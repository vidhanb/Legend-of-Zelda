﻿

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace HackAndSlash
{

    public class UseItemPlayer : IPlayer
    {
        private IPlayer DecoratedPlayer;
        private Game1 game;
        private int timer;
        private const int TIME = 285; //added delay

        public UseItemPlayer(IPlayer decoratedPlayer, Game1 game)
        {
            timer = TIME; //Added delay.
            this.DecoratedPlayer = decoratedPlayer;
            this.game = game;
            DrawPlayer.Instance.Frame = 0;
            DrawItemCD.Instance.setCD(); //CD of using an item
        }
        public int GetMaxHealth()
        {
            return DecoratedPlayer.GetMaxHealth();
        }
        public int GetCurrentHealth()
        {
            return DecoratedPlayer.GetCurrentHealth();
        }
        public Vector2 GetPos()
        {
            return this.DecoratedPlayer.GetPos();
        }

        public void SetPos(Vector2 pos)
        {
            this.DecoratedPlayer.SetPos(pos);
        }

        public void unlockMovement()
        {
            this.DecoratedPlayer.unlockMovement();
        }
        public bool isShield()
        {
            return this.DecoratedPlayer.isShield();
        }

        public void ShieldUp()
        {
            this.DecoratedPlayer.ShieldUp();
        }

        public void HealthUp()
        {
            this.DecoratedPlayer.HealthUp();
        }

        public void Update()
        {
            timer--;
            if (timer == 0)
            {
                DecoratedPlayer.Move();
                RemoveDecorator(); //Set it back to orignal state
            }
            DecoratedPlayer.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            DecoratedPlayer.Draw(spriteBatch, location, color);
        }

        public void RemoveDecorator()
        {
            game.Player = DecoratedPlayer; //set it back to movement state.
            DrawPlayer.Instance.Attack = false;
        }

        public void Move()
        {
            DecoratedPlayer.Move();
        }

        public void Attack()
        {
            DecoratedPlayer.Attack();
        }

        public void Damaged()
        {
            DecoratedPlayer.Damaged();
        }

        public void Healed()
        {
            DecoratedPlayer.Healed();
        }

        public GlobalSettings.Direction GetDir()
        {
            return DecoratedPlayer.GetDir();
        }

        public void ChangeDirection(GlobalSettings.Direction dir)
        {
            DecoratedPlayer.ChangeDirection(dir);
        }
        public void UseItem()
        {
            //Does not UseItem
        }
    }

}
