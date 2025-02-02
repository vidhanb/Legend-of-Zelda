﻿
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace HackAndSlash
{
    public class HeartItem : IItem
    {
        
        private Game1 game;
        private IPlayer player; //Player reference

        private ItemSprite heartSprite;
        public int spriteWidth, spriteHeight;
        public Vector2 position;

        private SpriteBatch spriteBatch;

        public static bool inInventory = false;

        public Rectangle[] collidableTiles;
        public ItemCollisionHandler Handler;
        private const float UNDERLAYER = 0.4f;
        private const int WIDTH = 90;
        private const int HEIGHT = 75;
        private const int OUT_OF_MAP = -200;


        // Constructor
        public HeartItem(Vector2 startPosition, SpriteBatch gameSpriteBatch, Game1 game)
        {
            this.game = game;
            this.player = this.game.Player; //Reference of player from Game1

            position = startPosition;
            heartSprite = (ItemSprite)SpriteFactory.Instance.CreateHeart();
            spriteWidth = heartSprite.Texture.Width / heartSprite.Columns;
            spriteHeight = heartSprite.Texture.Height / heartSprite.Rows;
            spriteBatch = gameSpriteBatch;
            collidableTiles = new Rectangle[1];
            collidableTiles[0] = new Rectangle((int)position.X, (int)position.Y, spriteWidth, spriteHeight);
            Handler = new ItemCollisionHandler(this.player);
        }

        public void Update()
        {
            // check for collision collision -> collect Item
            if (Handler.CheckForPlayerCollision(collidableTiles))
            {
                CollectItem();
            }
            heartSprite.Update();
        }

        public void Draw()
        {
            // Draw on ground
            Rectangle sourceRectangle = new Rectangle(0, 0, heartSprite.Texture.Width, heartSprite.Texture.Height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, WIDTH, HEIGHT);

            spriteBatch.Draw(heartSprite.Texture, destinationRectangle, sourceRectangle, Color.White,
                0f, Vector2.Zero, SpriteEffects.None, UNDERLAYER);
        }
        /// <summary>
        /// Increase the Maximum Health.
        /// </summary>
        public void CollectItem()
        {
            if (RupyItem.numUses >= 100)
            {
                RupyItem.numUses -= 100;
                this.game.Player.HealthUp();
                //Remove the item, make sure the player only collects once!
                ChangeToExpended();
                collidableTiles[0] = new Rectangle(0, 0, 0, 0);

                SoundFactory.Instance.TriforceObtainedEffect();
                SpriteFactory.Instance.SetZeldaGotHeart();
                DrawPlayer.Instance.Item = true; //Adjust the player sprite's position
                this.game.Player = new BuyItemPlayer(game.Player, game);
            }
        }

        public void UseItem(GlobalSettings.Direction currentPlayerDirection)
        {

        }

        public bool FogBreaker()
        {
            return inInventory;
        }
        public Vector2 GetPos()
        {
            return position;
        }

        // returns collidableTiles for enemy damage or player collection
        public Rectangle[] getCollidableTiles(bool isEnemy)
        {
            Rectangle[] RectanglesList = collidableTiles;
            return RectanglesList;
        }

        public void SetToolbarPosition(int index)
        {

        }

        public void SetMax()
        {

        }


        public void ChangeToCollectable()
        {

        }

        public void ChangeToUseable()
        {

        }

        public void ChangeToBeingUsed()
        {

        }

        public void ChangeToExpended()
        {
            position = new Vector2(OUT_OF_MAP, GlobalSettings.BASE_SCALAR);
        }
    }
}