using System;

namespace Lab5_4EnumStructCreatingMario
{
    class Program
    {
        // 2. Now, let’s turn this into a struct. This code is written 
        // ABOVE the Main() Code Block. Do not place it inside of it.
        public struct Mario 
        {
            // Size Enum (small or large)
            public enum Size 
            {
                small,
                large
            }

            // Number of lives
            public int numbOfLives;
            
            // Current Stage
            public string currentLevel;

            // Size (small or large)
            public Size sizeOfMario;
            
            // Can Shoot a fireball? (yes or no)
            public bool canShootFirstBalls;
            
            // Is jumping right now (yes or no) 
            public bool isJumping;

            // Number of gold coins
            public int numOfCoins;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab5_4EnumStructCreatingMario!");

            // In this lab, we will represent the video game character Mario as a 
            // struct as a way to start thinking about how complex data is created.

            // Scenario: You work for a company that allows users to play classic 
            // video games on their web site. You’ve been asked to re-create 
            // the classic character Mario for use on the website. Using a struct, 
            // create various data points that makeup Mario.

            // 1. We need to begin by thinking of all of things 
            // that Mario might need.  Let’s start making a list. 

            // 2. Here's the list we came up with. (See above.)

            // 3. Now in the Main() code block, let’s create Mario and give him 
            // some default values.

            Mario mario = new Mario();
            mario.numbOfLives = 3;
            mario.currentLevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFirstBalls = false;
            mario.isJumping = false;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            //enter your code here.
            mario.isJumping = true;

            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            //enter your code here.
            mario.isJumping = false;

            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            //enter your code here.
            mario.numbOfLives += 1;

            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            //enter your code here.
            mario.canShootFirstBalls = true;

            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            //enter your code here.
            mario.sizeOfMario = Mario.Size.large;

            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            //enter your code here.
            mario.numOfCoins = 10;

            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            //enter your code here.
            mario.currentLevel = "World 1-2";

        }
    }
}
