﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HackAndSlash
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Map currentMap; 
        private MapGenerator generator;

        //Player
        private IPlayer PlayerMain;
        public IPlayer Player
        {
            get
            {
                return PlayerMain;
            }
            set
            {
                PlayerMain = value;
            }
        }

        // Sprites  
        public IItem ItemHolder { get; set; }
        

        public SnakeEnemy snakefirst;
        public BugEnemy bugfirst;
        public MoblinEnemy moblinfirst;

        public FirewallItem firewallFirst;
        public BombItem bombFirst;
        public ThrowingKnifeItem throwingKnifeFirst;

        // Object lists
        List<Object> controllerList;
        public List<IBlock> blockList { get; set; }
        public List<ILevel> levelList { get; set; }
        public List<IEnemy> enemyList { get; set;  }

        /* ============================================================
         * ======================== Methods ===========================
         * ============================================================ */
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
        }

        public void reset() {
            blockList = generator.GetBlockList(spriteBatch);
            //enemyList = generator.GetEnemyList(spriteBatch);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            //level = new Level(GraphicsDevice, spriteBatch);

            controllerList = new List<Object>();
            controllerList.Add(new KeyboardController(this));
            controllerList.Add(new MouseController(this));
            controllerList.Add(new GamepadController(this));

            // Setup window size 
            graphics.PreferredBackBufferWidth = GlobalSettings.WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = GlobalSettings.WINDOW_HEIGHT;

            graphics.ApplyChanges();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            currentMap = new JsonParser(MapDatabase.demoLevelM1).getCurrentMapInfo();
            generator = new MapGenerator(currentMap);

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Get sprite from spriteFactory
            SpriteFactory.Instance.LoadAllTextures(Content);

            // SpriteHolder = SpriteFactory.Instance.CreateRightPlayer();

            //Enemy
            snakefirst = new SnakeEnemy(new Vector2(128,200), GraphicsDevice, spriteBatch, this);
            bugfirst = new BugEnemy(new Vector2(700,128), GraphicsDevice, spriteBatch, this);
            moblinfirst = new MoblinEnemy(new Vector2(500, 200), GraphicsDevice, spriteBatch, this);

            enemyList = new List<IEnemy>()
            {
                snakefirst,bugfirst,moblinfirst
            };
         
            //Player
            PlayerMain = new Player(this);//Player object

            // Items
            firewallFirst = new FirewallItem(new Vector2(200, 200), spriteBatch, this);
            bombFirst = new BombItem(new Vector2(200, 200), spriteBatch, this);
            throwingKnifeFirst = new ThrowingKnifeItem(new Vector2(200, 200), spriteBatch, this);
            ItemHolder = firewallFirst;

            //firewallFirst.LoadContent(); 

            // A list of level maps for further transition cutscene 
            levelList = new List<ILevel>()
            {
                new Level(GraphicsDevice, spriteBatch, currentMap.Arrangement, currentMap.DefaultBlock,
                currentMap.OpenDoors, currentMap.HiddenDoors, currentMap.LockedDoors) 
            };

            //Create list of blocks
            blockList = generator.GetBlockList(spriteBatch);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            PlayerMain.Update();
            
            snakefirst.Update(gameTime);
            bugfirst.Update(gameTime);
            moblinfirst.Update(gameTime);

            ItemHolder.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, SamplerState.PointClamp);

            foreach (ILevel levelMap in levelList) levelMap.Draw();
            foreach (IBlock block in blockList) block.Draw();
            PlayerMain.Draw(spriteBatch, Player.GetPos(), Color.White);
            ItemHolder.Draw();
            snakefirst.Draw();
            moblinfirst.Draw();
            bugfirst.Draw();

            spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
