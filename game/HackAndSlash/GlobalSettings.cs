﻿

namespace HackAndSlash
{
    // Left for some future global (throught out the game kind) variables 
    

    class GlobalSettings
    {
        public const int WINDOW_WIDTH = 600;
        public const int WINDOW_HEIGHT = 400;

        public const int MAX_DISPLAY_DIV = 6;

        public const int STEP_SIZE_X = 5;
        public const int STEP_SIZE_Y = 5;

        public const long DELAY_TIME = 100; // In ms
    }

    class ImageFile
    {
        public string pathName { get; set; }
        public int R { get; set; }
        public int C { get; set; }

        public ImageFile(string PN, int C, int R)
        {
            this.pathName = PN;
            this.C = C;
            this.R = R;
            
        }
    }

    class ImageDatabase
    {
        public ImageFile playerMoveUp;
        public ImageFile playerMoveDown;
        public ImageFile playerMoveLeft;
        public ImageFile playerMoveRight;

        public ImageFile zelda;
        public ImageFile zeldaDown;
        public ImageFile zeldaUp;
        public ImageFile zeldaLeft;
        public ImageFile zeldaRight;

        public ImageFile zeldaAttackDown;
        public ImageFile zeldaAttackUp;
        public ImageFile zeldaAttackLeft;
        public ImageFile zeldaAttackRight;


        public ImageFile snakeMoveLeft;
        public ImageFile snakeAttackLeft;
        public ImageFile snakeDie;
        public ImageFile snakeIdle;

        public ImageFile bugMoveUp;
        public ImageFile bugMoveDown;
        public ImageFile bugIdle;
        public ImageFile bugDie;

        public ImageFile fireWall;
        public ImageFile bomb;
        public ImageFile explosion;

        public ImageFile BG;

        public ImageFile ChipBlock;
        public ImageFile SmoothBlock;

        public ImageDatabase()
        {
            // Initilize images with path/name, column and row 

            playerMoveUp = new ImageFile("images/sucUp", 1, 7);
            playerMoveDown = new ImageFile("images/sucDown", 1, 7);
            playerMoveLeft = new ImageFile("images/sucLeft", 1, 7);
            playerMoveRight = new ImageFile("images/sucOva", 1, 7);

            zelda = new ImageFile("images/Zelda", 0, 0);

            zeldaDown = new ImageFile("images/ZeldaDown", 2, 1);
            zeldaUp = new ImageFile("images/ZeldaUp", 2, 1);
            zeldaLeft = new ImageFile("images/ZeldaLeft", 2, 1);
            zeldaRight = new ImageFile("images/ZeldaRight", 2, 1);

            zeldaAttackDown = new ImageFile("images/ZeldaAttackDown", 3, 1);
            zeldaAttackUp = new ImageFile("images/ZeldaAttackUp", 3, 1);
            zeldaAttackRight = new ImageFile("images/ZeldaAttackRight", 3, 1);
            zeldaAttackLeft = new ImageFile("images/ZeldaAttackLeft", 3, 1);

            



            snakeMoveLeft = new ImageFile("images/SnakeMoving", 1, 10); 
            snakeAttackLeft = new ImageFile("images/SnakeAttack", 1, 10); 
            snakeDie = new ImageFile("images/SnakeDie", 1, 10); 
            snakeIdle = new ImageFile("images/SnakeIdle", 1, 10);

            bugMoveUp = new ImageFile("images/BugMoveUp", 1, 6);
            bugMoveDown = new ImageFile("images/BugMoveDown", 1, 6);
            bugIdle = new ImageFile("images/BugIdle", 1, 6);
            bugDie = new ImageFile("images/BugDie", 1, 6);

            fireWall = new ImageFile("images/firewall", 1, 2);
            bomb = new ImageFile("images/Bomb", 1, 1);
            explosion = new ImageFile("images/explosion", 1, 3);
            BG = new ImageFile("images/BG", 1, 1);

            ChipBlock = new ImageFile("images/ChipBlock", 1, 1);
            SmoothBlock = new ImageFile("images/SmoothBlock", 1, 1);
        }
    }
}
