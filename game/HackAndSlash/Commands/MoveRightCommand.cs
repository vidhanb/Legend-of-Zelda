﻿using HackAndSlash;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackAndSlash
{
    public class MoveRightCommand : ICommand
    {
        private Game1 game;
        public MoveRightCommand(Game1 game)
        {
            this.game = game;
        }
        public void execute()
        {
            //game.SpriteHolder = new (method for right facing player sprite)
        }
    }
}
