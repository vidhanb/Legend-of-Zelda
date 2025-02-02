﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackAndSlash
{
    // This class is used to record all the meta-info of the pictures 
    class ImageDatabase
    {
        public ImageFile playerMoveUp;
        public ImageFile playerMoveDown;
        public ImageFile playerMoveLeft;
        public ImageFile playerMoveRight;

        public ImageFile zeldaDown;
        public ImageFile zeldaUp;
        public ImageFile zeldaLeft;
        public ImageFile zeldaRight;

        public ImageFile zeldaAttackDown;
        public ImageFile zeldaAttackUp;
        public ImageFile zeldaAttackLeft;
        public ImageFile zeldaAttackRight;

        public ImageFile zeldaUseItemDown;
        public ImageFile zeldaUseItemUp;
        public ImageFile zeldaUseItemLeft;
        public ImageFile zeldaUseItemRight;

        public ImageFile zeldaDying;
        public ImageFile zeldaWon;

        public ImageFile fullHeart;
        public ImageFile halfHeart;
        public ImageFile emptyHeart;

        public ImageFile snakeMoveLeft;
        public ImageFile snakeMoveRight;
        public ImageFile snakeDie;
        public ImageFile snakeIdle;

        public ImageFile bugMoveUp;
        public ImageFile bugMoveDown;
        public ImageFile bugMoveRight;
        public ImageFile bugMoveLeft;
        public ImageFile bugIdle;
        public ImageFile bugDie;

        public ImageFile moblinMoveUp;
        public ImageFile moblinMoveDown;
        public ImageFile moblinMoveRight;
        public ImageFile moblinMoveLeft;
        public ImageFile moblinBomb;

        public ImageFile goriyaMoveDown;
        public ImageFile goriyaMoveUp;
        public ImageFile goriyaMoveLeft;
        public ImageFile goriyaMoveRight;
        public ImageFile goriyaBoomerang;

        public ImageFile boss;
        public ImageFile bossDie;


        public ImageFile fireWall;
        public ImageFile bomb;
        public ImageFile explosion;
        public ImageFile throwingKnifeUp;
        public ImageFile throwingKnifeDown;
        public ImageFile throwingKnifeLeft;
        public ImageFile throwingKnifeRight;
        public ImageFile SwordUp;
        public ImageFile SwordDown;
        public ImageFile SwordLeft;
        public ImageFile SwordRight;
        public ImageFile food;
        public ImageFile triforce;
        public ImageFile rupy;

        public ImageFile BG;

        public ImageFile BlockMovable;
        public ImageFile BlockAllMight;
        public ImageFile BlockDemo;
        public ImageFile BlockBlank1;
        public ImageFile LevelEagleBorder;
        public ImageFile LevelEagleDoors;
        public ImageFile LevelBloodBorder;
        public ImageFile LevelBloodDoors;
        public ImageFile[] LevelEagleDoorNormOpen;
        public ImageFile[] LevelEagleHole;

        public ImageFile FOGMask; 

        public ImageFile PauseOverlay;
        public ImageFile SwordSelector;
        public ImageFile InventoryText;
        public ImageFile ItemSelector;
        public ImageFile VolumeSlider;

        public ImageFile nightmareModeText;

        public ImageFile GameOverOverlay;
        public ImageFile TitleScreenOverlay;
        public ImageFile GameWonOverlay;
        public ImageFile SoundMenuOverlay;

        public ImageFile TextCharacters;
        public ImageFile OldMan;
        public ImageFile RedBall;
        public ImageFile Font_OldManText1;
        public ImageFile Font_OldManText2;
        public ImageFile CheatText;

        public ImageFile OldWoman;
        public ImageFile Heart;
        public ImageFile Refill;
        public ImageFile Shield;
        public ImageFile ShieldItem;

        public ImageFile ZeldaGotShield;
        public ImageFile ZeldaGotRefill;
        public ImageFile ZeldaGotHeart;
        public ImageFile Price;
        public ImageFile Bar;

        public ImageFile Font_Shield;
        public ImageFile Font_Life;

        public ImageDatabase()
        {
            // Initilize images with path/name, column and row
            Bar = new ImageFile("images/Bar", 1, 1);
            Price = new ImageFile("Merchant/Price", 1, 1);
            OldWoman = new ImageFile("Merchant/Oldwoman", 1, 1);
            Heart = new ImageFile("Merchant/Heart", 1, 1);
            Refill = new ImageFile("Merchant/Refill", 1, 1);
            Shield = new ImageFile("Merchant/Shield", 1, 1);
            ShieldItem = new ImageFile("Merchant/ShieldItem", 1, 1);
            ZeldaGotHeart = new ImageFile("Merchant/ZeldaGotHeart", 1, 1);
            ZeldaGotRefill = new ImageFile("Merchant/ZeldaGotRefill", 1, 1);
            ZeldaGotShield = new ImageFile("Merchant/ZeldaGotShield", 1, 1);

            RedBall = new ImageFile("images/RedBall", 1, 1);
            OldMan = new ImageFile("images/Oldman", 1, 1);

            Font_OldManText1 = new ImageFile("images/font/Font_OldMan1", 1, 1);
            Font_OldManText2 = new ImageFile("images/font/Font_OldMan2", 1, 1);

            Font_Life = new ImageFile("images/font/Font_life", 1, 1);
            Font_Shield = new ImageFile("images/font/Font_Shield", 1, 1);

            playerMoveUp = new ImageFile("images/sucUp", 1, 7);
            playerMoveDown = new ImageFile("images/sucDown", 1, 7);
            playerMoveLeft = new ImageFile("images/sucLeft", 1, 7);
            playerMoveRight = new ImageFile("images/sucOva", 1, 7);

            zeldaDown = new ImageFile("images/ZeldaDown", 2, 1);
            zeldaUp = new ImageFile("images/ZeldaUp", 2, 1);
            zeldaLeft = new ImageFile("images/ZeldaLeft", 2, 1);
            zeldaRight = new ImageFile("images/ZeldaRight", 2, 1);

            zeldaAttackDown = new ImageFile("images/ZeldaAttackDown", 3, 1);
            zeldaAttackUp = new ImageFile("images/ZeldaAttackUp", 3, 1);
            zeldaAttackRight = new ImageFile("images/ZeldaAttackRight", 3, 1);
            zeldaAttackLeft = new ImageFile("images/ZeldaAttackLeft", 3, 1);

            zeldaUseItemDown = new ImageFile("images/ZeldaUseItemDown", 1, 1);
            zeldaUseItemUp = new ImageFile("images/ZeldaUseItemUp", 1, 1);
            zeldaUseItemLeft = new ImageFile("images/ZeldaUseItemLeft", 1, 1);
            zeldaUseItemRight = new ImageFile("images/ZeldaUseItemRight", 1, 1);

            zeldaDying = new ImageFile("images/ZeldaDying", 2, 1);
            zeldaWon = new ImageFile("images/LinkTriforce", 1, 1);

            fullHeart = new ImageFile("images/fullHeart", 1, 1);
            halfHeart = new ImageFile("images/halfHeart", 1, 1);
            emptyHeart = new ImageFile("images/emptyHeart", 1, 1);

            snakeMoveLeft = new ImageFile("images/SnakeLeftMoving", 1, 10);
            snakeMoveRight = new ImageFile("images/SnakeEnemyRight", 1, 10);
            snakeDie = new ImageFile("images/SnakeDie", 1, 10);
            snakeIdle = new ImageFile("images/SnakeIdle", 1, 10);

            bugMoveUp = new ImageFile("images/BugEnemyMoveUp", 1, 6);
            bugMoveDown = new ImageFile("images/BugEnemyMoveDown", 1, 6);
            bugMoveLeft = new ImageFile("images/BugEnemyLeft", 1, 6);
            bugMoveRight = new ImageFile("images/BugEnemyRight", 1, 6);
            bugIdle = new ImageFile("images/BugEnemyIdle", 1, 6);
            bugDie = new ImageFile("images/BugIdle", 1, 6);

            moblinMoveUp = new ImageFile("images/MoblinUp", 1, 2);
            moblinMoveDown = new ImageFile("images/MoblinDown", 1, 2);
            moblinMoveLeft = new ImageFile("images/MoblinLeft", 1, 2);
            moblinMoveRight = new ImageFile("images/MoblinRight", 1, 2);
            moblinBomb = new ImageFile("images/MoblinBomb", 1, 1);

            goriyaMoveDown = new ImageFile("images/GoriyaDown",1,1);
            goriyaMoveUp = new ImageFile("images/GoriyaUp",1,1);
            goriyaMoveLeft = new ImageFile("images/GoriyaLeft",1,1);
            goriyaMoveRight = new ImageFile("images/GoriyaRight",1,1);
            goriyaBoomerang = new ImageFile("images/GoriyaBoomerang", 1, 3);

            boss = new ImageFile("images/Boss", 1, 4);
            bossDie = new ImageFile("images/bossDie", 1, 1);


            fireWall = new ImageFile("images/firewall3", 1, 2);
            bomb = new ImageFile("images/Bomb", 1, 1);
            explosion = new ImageFile("images/explosion", 1, 3);
            throwingKnifeUp = new ImageFile("images/ThrowingKnifeUp", 1, 1);
            throwingKnifeDown = new ImageFile("images/ThrowingKnifeDown", 1, 1);
            throwingKnifeLeft = new ImageFile("images/ThrowingKnifeLeft", 1, 1);
            throwingKnifeRight = new ImageFile("images/ThrowingKnifeRight", 1, 1);
            SwordUp = new ImageFile("images/FlyingSwordUp", 1, 1);
            SwordDown = new ImageFile("images/FlyingSwordDown", 1, 1);
            SwordLeft = new ImageFile("images/FlyingSwordLeft", 1, 1);
            SwordRight = new ImageFile("images/FlyingSwordRight", 1, 1);
            food = new ImageFile("images/Food", 1, 1);
            triforce = new ImageFile("images/Triforce", 1, 1);
            rupy = new ImageFile("images/Rupy", 1, 1);

            BG = new ImageFile("images/BG", 1, 1);

            BlockMovable = new ImageFile("images/MoveableBlood", 1, 1);

            // For level blocks, they must be the same size as BASE_SCALAR
            BlockDemo = new ImageFile("images/BlockDemo", 1, 1);
            BlockBlank1 = new ImageFile("images/BlockBlank1", 1, 1);
            BlockAllMight = new ImageFile("images/levels/blockAllMight", 1, 1);
            LevelEagleBorder = new ImageFile("images/LevelEagleBorder", 1, 1);
            LevelEagleDoors = new ImageFile("images/levels/eagleDoors", 5, 4);
            LevelBloodBorder = new ImageFile("images/levels/BloodWall", 1, 1);
            LevelBloodDoors = new ImageFile("images/levels/bloodDoors", 5, 4);
            LevelEagleDoorNormOpen = new ImageFile[] {
                new ImageFile("images/levels/eagleDoorVerticalUp", 1, 1),
                new ImageFile("images/levels/eagleDoorVerticalDown", 1, 1),
                new ImageFile("images/levels/eagleDoorHorizontalLeft", 1, 1),
                new ImageFile("images/levels/eagleDoorHorizontalRight", 1, 1)};
            LevelEagleHole = new ImageFile[]{
                new ImageFile("images/levels/eagleHoleVerticalUp", 1, 1),
                new ImageFile("images/levels/eagleHoleVerticalDown", 1, 1),
                new ImageFile("images/levels/eagleHoleHorizontalLeft", 1, 1),
                new ImageFile("images/levels/eagleHoleHorizontalRight", 1, 1)};
            FOGMask = new ImageFile("images/Mask", 1, 1);

            //UI
            PauseOverlay = new ImageFile("images/UI/GamePauseOverlay", 1, 1);
            SwordSelector = new ImageFile("images/UI/SwordSelector", 1, 1);
            GameOverOverlay = new ImageFile("images/UI/GameOverOverlay", 1, 1);
            InventoryText = new ImageFile("images/Font/Font_Inventory", 1, 1);
            CheatText = new ImageFile("images/Font/Cheat", 1, 1);
            ItemSelector = new ImageFile("images/UI/ItemSelector", 1, 1);
            TitleScreenOverlay = new ImageFile("images/UI/TitleScreens", 2, 2);
            GameWonOverlay = new ImageFile("images/UI/GameWonOverlay", 1, 1);
            SoundMenuOverlay = new ImageFile("images/UI/SoundMenuOverlay", 1, 1);
            VolumeSlider = new ImageFile("images/UI/VolumeSlider1", 1, 1);

            TextCharacters = new ImageFile("images/TextCharacters", 4, 13);
            nightmareModeText = new ImageFile("images/nightmareModeText", 1, 1);
        }
    }

    public class MapDatabase
    {
        // Means "Level Demo Map 1"
        public const string demoLevelM1 = @"Content/info/levelDemoM1.json";

        public const string eagleM1 = @"Content/info/eagleM1.json";
        public const string eagleM2 = @"Content/info/eagleM2.json";
        public const string eagleM3 = @"Content/info/eagleM3.json";
        public const string eagleM4 = @"Content/info/eagleM4.json";
        public const string eagleM5 = @"Content/info/eagleM5.json";
        public const string eagleM6 = @"Content/info/eagleM6.json";
        public const string eagleM7 = @"Content/info/eagleM7.json";
        public const string eagleM8 = @"Content/info/eagleM8.json";
        public const string eagleM9 = @"Content/info/eagleM9.json";
        public const string eagleM10 = @"Content/info/eagleM10.json";
        public const string eagleM11 = @"Content/info/eagleM11.json";
        public const string eagleM12 = @"Content/info/eagleM12.json";
        public const string eagleM13 = @"Content/info/eagleM13.json";
        public const string eagleM14 = @"Content/info/eagleM14.json";
        public const string eagleM15 = @"Content/info/eagleM15.json";
        public const string eagleM16 = @"Content/info/eagleM16.json";
        public const string eagleM17 = @"Content/info/eagleM17.json";

        public static string[,] eagle = new string[6,6] { 
                {null, @"Content/info/eagleM1.json", @"Content/info/eagleM2.json", null, null, null},
                {null, null, @"Content/info/eagleM3.json", null, @"Content/info/eagleM4.json", @"Content/info/eagleM5.json"},
                {@"Content/info/eagleM6.json", @"Content/info/eagleM7.json", @"Content/info/eagleM8.json", @"Content/info/eagleM9.json", @"Content/info/eagleM10.json", null},
                {null, @"Content/info/eagleM11.json", @"Content/info/eagleM12.json", @"Content/info/eagleM13.json", null, null},
                {null, null, @"Content/info/eagleM14.json", null, null, null},
                {null, @"Content/info/eagleM15.json", @"Content/info/eagleM16.json", @"Content/info/eagleM17.json", null, null},
            };

  
    }

    public class SaveDatabase
    {
        // Correctly saves data to the AppData folder (just like a real game!)
        // Amarth: I changed the name to NewSaveFile since it's having error reading 
        public static string saveFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NewSaveFile.json");
    }
}
