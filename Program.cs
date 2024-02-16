using System;
using static System.Console;

//CL02
// CL01
//Michael Kerr 10/12/21
/* Here is my attempt to make a text based adventure game*/

namespace DankestDungeon
{
    class Program
    {
        static void Main(string[] args)

        {
            //CL28/29
            gameTitle();
        }

        static void winner()
        {
            //CL03 & CL19
            for (int i = 1; i <= 3; i++)
            {
                WriteLine("Hip Hip Hooray");
            }
            {
                WriteLine("You have won!");
                WriteLine("Thank you for playing!");
            }
        }
        // HELP
        static void helpGuide()
        {
            string help;
            WriteLine("1. Restart Game");
            WriteLine("2. End Game");
            WriteLine("Pressing '0' During 'Choices' goes back.");
            help = ReadLine();
            switch (help)
            {
                case "1":
                    {
                        gameTitle();
                        break;
                    }

                case "2":
                    {
                        gameOver();
                        break;
                    }
                default:
                    {
                        Console.Write("Invalid input");
                        Console.Write("Please press 'Enter' to try again.");
                        Console.ReadLine();
                        helpGuide();
                        break;
                    }

            }

        }

        static void gameOver()
        {
            //CL18
            string inputString;
            char response;
            Console.WriteLine("Game over...");
            Write("Do you want to retry? Y or N...");
            inputString = ReadLine();
            response = Convert.ToChar(inputString);
            while (response == 'Y')
            {
                gameTitle();
            }
            WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }

        public static void gameTitle()
        {
            //CL01/03/06
            bool yesVariable = true;
            if (yesVariable)
            {
                DisplayWithBorder2("Welcome to the Dankest Dungeon");
                DisplayWithBorder2("Press 'Enter'... if you dare. ");
                Console.ReadLine();
                Console.Clear();
                first();
            }
            else
            {
                gameOver();
            }
        }
        static void DisplayWithBorder2(string word) //CL36
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = word.Length + EXTRA_STARS;
            int x;
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine();
            WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine("\n\n");
        }

        public static void first()
        {
            //CL04 
            string choice;
            Console.WriteLine("You're walking through the woods when you stumble upon a cellar door at your feet");
            Console.WriteLine(" ");
            Console.WriteLine("What do you do? ");
            Console.WriteLine("1. Investigate. ");
            Console.WriteLine("2. Carry on. ");
            Console.WriteLine("3. Phone a friend. ");
            Console.WriteLine("Help");
            Console.Write("Choice: ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "invest":
                case "investigate":
                    {
                        Console.WriteLine("You see a mossy oaken cellar door,");
                        Console.WriteLine("reinforced by rusted metal cladding.");
                        Console.WriteLine("On the right side you see a old combination lock.");
                        Console.WriteLine("On the bottom you can input four numbers ranging from 0-9");
                        Console.WriteLine("");
                        Console.WriteLine("What do you do? ");
                        Console.WriteLine("");
                        Console.WriteLine("Press 'Enter' to choose");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    }
                case "2":
                case "carry":
                case "carry on":
                    {
                        Console.WriteLine("You shrug your shoulders.");
                        Console.WriteLine("Simple cellar doors do not impress you.");
                        Console.WriteLine("You continue your hike and never think twice about it.");
                        Console.WriteLine("Press 'Enter'.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "3":
                case "phone":
                case "phone a friend.":
                    {
                        Console.WriteLine("You pull your cell phone out of your pocket.");
                        Console.WriteLine("As you look down at your screen you see you have no signal.");
                        Console.WriteLine("Out of frustration you throw your phone at a tree.");
                        Console.WriteLine("It shatters along with your happiness...");
                        Console.WriteLine("Press 'Enter'.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "0":
                case "Return":
                    {
                        Console.WriteLine("Press 'Enter'to return. ");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                    }
                //HELP
                case "help":
                case "Help":
                    {
                        helpGuide();
                        break;
                    }
                default:
                    {
                        Console.Write("Invalid input");
                        Console.Write("Please press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }


        static void second()
        {
            string choice2;
            Console.WriteLine("1. Look around for the combination number clues.");
            Console.WriteLine("2. Leave because brain games are hard.");
            Console.WriteLine("3. Brute force your way in by trying a combination.");
            Console.WriteLine("Type 'Help' for a list of commands");
            Console.Write("Choice: ");
            choice2 = Console.ReadLine();
            Console.Clear();

            switch (choice2)
            {
                case "1":
                case "look":
                case "look around":
                    {
                        Console.WriteLine("You see a carving on a nearby tree.");
                        Console.WriteLine("A heart with the numbers");
                        Console.WriteLine("6969");
                        Console.WriteLine("carved in the center.");
                        Console.WriteLine("");
                        Console.WriteLine("What do you do? ");
                        Console.WriteLine("");
                        Console.WriteLine("Press 'Enter' to choose");
                        Console.ReadLine();
                        third();
                        break;
                    }

                case "2":
                case "leave":
                case "leave because":
                    {
                        Console.WriteLine("Your brain aches at the thought");
                        Console.WriteLine("of trying to solve a puzzle");
                        Console.WriteLine("let alone anything.");
                        Console.WriteLine("Loser...");
                        Console.WriteLine("Press 'Enter' to choose");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "3":
                case "brute":
                case "brute force":
                    {
                        Console.WriteLine("You smash the lock with a nearby stone.");
                        Console.WriteLine("It bounces off and hit you in the face.");
                        Console.WriteLine("You are knocked unconscious.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "0":
                case "Return":
                    {
                        Console.WriteLine("Press 'Enter'to return. ");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                    }
                case "help":
                case "Help":
                    {
                        helpGuide();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Please press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }


        static void third()
        {
            string choice3;
            Console.WriteLine("You can see the numbers 6969 on the tree.");
            Console.WriteLine("1. Enter the numbers into the combination lock.");
            Console.WriteLine("2. Brush it off as holliganism.");
            Console.WriteLine("3. Go back to the cellar door.");
            Console.WriteLine("Type 'Help' for a list of commands");
            Console.Write("Choice: ");
            choice3 = Console.ReadLine();
            Console.Clear();

            // CL16
            switch (choice3)
            {
                case "1":
                case "enter":
                case "enter the numbers":
                    {
                        Console.WriteLine("You walk back to the old cellar door.");
                        Console.WriteLine("You get down on your knees and hold the padlock in your hand.");
                        Console.WriteLine("You proceed to enter the combination: ");
                        Console.WriteLine("Please enter 4 digit pin");
                        fourth();
                        break;
                    }
                case "2":
                case "brush":
                case "brush it":
                    {
                        Console.WriteLine("You think to yourself.");
                        Console.WriteLine("'Kids these days with their numbers and tree carvings...");
                        Console.WriteLine("...disgraceful'");
                        Console.WriteLine("Press 'Enter'.");
                        Console.ReadLine();
                        third();
                        break;
                    }
                case "3":
                case "go":
                case "go back":
                    {
                        Console.WriteLine("Press 'Enter'.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "0":
                case "Return":
                    {
                        Console.WriteLine("Press 'Enter'to return. ");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                    }
                case "help":
                case "Help":
                    {
                        helpGuide();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Please press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }


        static void fourth()
        /* CL04 & CL05 & CL12 & CL13*/
        {
            const int correct = 6969;
            string numberString;
            int pass;
            numberString = Console.ReadLine();
            pass = Convert.ToInt32(numberString);
            if (pass == correct)
            {
                Console.WriteLine("{0} entered, the padlock opens!", pass);
                fifth();
            }
            else
            {
                Console.WriteLine("{0} entered, the lock remains closed.", pass);
                third();
            }
        }

        static void fifth()
        {
            Console.WriteLine("You walk down the cellar stairs.");
            Console.WriteLine("It is lit by a single candle and you cant see more than a 5 foot radius.");
            Console.WriteLine("A figure appears out of thin air");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It appears to be a ghost of the one and only Shrek!");
            Console.WriteLine("The ghost of shrek says.. ");
            Console.WriteLine("You must guess two things in my head or your lights go out!");
            Console.WriteLine("Shrek's ghost blows out the candle shrouding the room in darkness.");
            Console.WriteLine("His eyes begin to glow green...");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Guess a number between 1 and 10.");
            Console.WriteLine("If the number is higher than the number in my head you can pass...");
            Console.WriteLine("However...");
            Console.WriteLine("If the number is lower you shall get shreked.");
            Console.WriteLine("Also, you must guess my favortie color.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            {
                //CL09 & CL08
                const int rightNum = 6;
                string rightCol = "green";
                string inputString;
                int numAnswer;
                string colAnswer;
                WriteLine("Enter Number:");
                WriteLine("Maybe the combination lock pin is a good guess (6969)");
                inputString = ReadLine();
                numAnswer = Convert.ToInt32(inputString);
                WriteLine("Enter Color:");
                WriteLine("The color of his eyes might be a good guess (green)");
                colAnswer = ReadLine();
                //CL14
                if (numAnswer >= rightNum && colAnswer == rightCol)
                {
                    Console.WriteLine("You Shall Pass!");
                }

                WriteLine("Press 'Enter to Continue:");
                ReadLine();
                sixth();
            }
        }


        static void sixth()
        {
            {
                WriteLine("You are teleported through a cloud of green fog.");
                WriteLine("And appear in a room with a giant wolf named chi-chi.");
                WriteLine("Press 'Enter' to continue:");
                ReadLine();
                Clear();
            }
            {
                // CL11
                int gf1 = 50;

                long lgf1 = gf1;

                float fgf1 = lgf1;

                int gf2 = 150;

                long lgf2 = gf2;

                float fgf2 = lgf2;

                //CL10
                WriteLine("Here is the gold you started your journey with {0}.", fgf1);
                int resultgold = gf1 + gf2;
                WriteLine("After giving you this 150 gold you walk away with a whopping {0}", resultgold);
                WriteLine("Press 'Enter' to continue:");
                ReadLine();
                Clear();
                seven();
            }
        }

        static void seven()
        {
            int i = 2;

            while (true)
            {
                WriteLine("You get teleported back to your bedroom.");
                WriteLine("You awaken from a dream of two closed hands.");
                WriteLine(" ");
                WriteLine("A left hand and a right hand.");
                WriteLine("You were asked to choose one to open");
                WriteLine("Which hand did you choose?", i);


                i++;
                //CL15
                if (i > 1 || i < 3)
                    break;

            }


            //CL17
            for (int x = 0; x != 1; x++)
            {
                string final;
                WriteLine("1. Left Hand.");
                WriteLine("2. Right Hand.");
                Console.WriteLine("Type 'Help' for a list of commands");
                Console.Write("Choice: ");
                final = Console.ReadLine();
                Console.Clear();


                // CL16
                switch (final)
                {
                    case "1":
                    case "left":
                    case "left hand":
                        {
                            WriteLine("You chose the left hand.");
                            WriteLine("The hand opens and before you");
                            WriteLine("can see whats inside.");
                            WriteLine("You wake up, and dont remember anything");
                            gameOver();
                            break;
                        }
                    case "2":
                    case "right":
                    case "right hand":
                        {
                            WriteLine("You chose the right");
                            WriteLine("The right hand opens and you can see you whole life");
                            WriteLine("in the palm of this hand");
                            WriteLine("You awaken with tonights memories intact!");
                            WriteLine("Press 'Enter' to continue");
                            ReadLine();
                            Clear();


                            eight();
                            break;
                        }
                    case "help":
                    case "Help":
                        {
                            helpGuide();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("Please press 'Enter' to try again.");
                            Console.ReadLine();
                            first();
                            break;
                        }
                }
            }
        }






        static void eight()
        {
            //New Location 1
            WriteLine("That was one hell of a fever dream..");
            WriteLine("But it felt so real!");
            WriteLine("Press 'Enter' to Continue..:");
            Console.ReadLine();
            WriteLine("You proceed to get out of bed and head downstairs.");
            WriteLine("My pockets feel full.. I should check them.");
            //CL21
            string[] inventory = { "Pocket Lint", "A coin with Shrek on it", "A normal penny"};
            string finalItem = "A gum wrapper";
            Array.Resize(ref inventory, inventory.Length + 1);
            inventory[inventory.Length - 1] = finalItem;
            




            string inventroyCheck;
            WriteLine("1. Check Pockets");
            WriteLine("2. Ignore gut feeling");
            Console.WriteLine("Type 'Help' for a list of commands");
            Console.Write("Choice: ");
            inventroyCheck = Console.ReadLine();
            Console.Clear();


            switch (inventroyCheck)
            {
                case "1":
                case "check":
                case "check pockets":
                    {
                        WriteLine("You check your pockets.");
                        WriteLine("You see...");
                        //CL23, CL27.
                        foreach (string value in inventory)
                            WriteLine(value);
                        WriteLine("Press 'Enter' to Continue...");
                        ReadLine();
                        Clear();
                        WriteLine("No way! Could this be the Shrek coin from my dream?!");
                        nine();
                        Clear();
                        break;
                    }
                case "2":
                case "ignore":
                case "ignore gut":
                    {
                        WriteLine("You ignore your gut feeling.");
                        WriteLine("After all this you should know better.");
                        WriteLine("in the palm of this hand");
                        WriteLine("You Continue your day and slowly forget anything weird happened last night.");
                        WriteLine("Press 'Enter' to continue");
                        ReadLine();
                        Clear();


                        gameOver();
                        break;
                    }
                case "help":
                case "Help":
                    {
                        helpGuide();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Please press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }

            static void nine()
            //CL24 New location 2 and interaction
            {
                WriteLine("I should add this coin to my collection!");
                WriteLine("I wonder how many different coin types I have.");
                WriteLine("Let me head to my coin room and look!");
                WriteLine("Press 'Enter' to continue..");
                ReadLine();
                Clear();
                WriteLine("You arrive in your coin room.");
                WriteLine("Press a Button on your coin machine");
                WriteLine("to see how many you have!");
                WriteLine("1. Pennies");
                WriteLine("2. Nickles");
                WriteLine("3. Dimes");
                WriteLine("4. Quarters");
                WriteLine("5. Gold");
                {

                    int[] validValues = { 1, 2, 3, 4, 5 };
                    double[] coin = { 100, 75, 50, 25, 1 };
                    int coinChoice;
                    double coinQuantity = 0;
                    bool isValidCoin = false;
                    Write("Enter coin number: ");
                    coinChoice = Convert.ToInt32(ReadLine());
                    //CL26
                    for (int x = 0; x < validValues.Length; ++x)
                    {
                        if (coinChoice == validValues[x])
                        {
                            isValidCoin = true;
                            coinQuantity = coin[x];
                        }
                    }
                    if (isValidCoin)
                        WriteLine("Quatity of selected coin is {0}", coinQuantity);
                    else
                        WriteLine("Dang I wish I had that coin, try another.");
                    WriteLine("Press 'Enter' to continue...");
                    ReadLine();
                    Clear();
                    ten();
                }

            }

            static void ten()
            //New location 3 
            {

                WriteLine("I should use these coins to buy a new game!");
                WriteLine("Lets go to the gaming room to go on steam");
                WriteLine("and see whats on sale!");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                WriteLine("You arrive in the gaming room and open up steam.");
                WriteLine("But your forgot your password.");
                WriteLine("What do you do?");
                WriteLine("Press 'Enter' to continue..");
                ReadLine();
                Clear();
                string choiceNew;
                WriteLine("1. Brute force the password.");
                WriteLine("2. Check your phone for a saved password. ");
                WriteLine("3. Kick the tower.");
                WriteLine("Type 'Help' for a list of commands");
                Write("Choice: ");
                choiceNew = ReadLine();
                Clear();



                switch (choiceNew)
                {
                    case "1":
                    case "brute":
                    case "brute force":
                        {
                            WriteLine("You try as many combinations as possible");
                            WriteLine("but cannot seem to enter anything right.");
                            WriteLine("You exceed the maximum attemps and are locked out. ");
                            gameOver();
                            break;
                        }
                    case "2":
                    case "check":
                    case "check your phone":
                        {
                            WriteLine("You get out your phone and enter 0420 to get in.");
                            WriteLine("You look though the keychain and do not see the password.");
                            WriteLine("Maybe 0420 is the password?");
                            WriteLine("Press 'Enter'.");
                            ReadLine();
                            eleven();
                            break;
                        }
                    case "3":
                    case "kick":
                    case "kick the tower":
                        {
                            WriteLine("You kick the tower.");
                            WriteLine("Your psu was not properly certified");
                            WriteLine("and your computer explodes.");
                            WriteLine("Press 'Enter' to continue.");
                            ReadLine();
                            gameOver();
                            break;
                        }
                    case "0":
                    case "Return":
                        {
                            WriteLine("Press 'Enter'to return. ");
                            ReadLine();
                            Clear();
                            ten();
                            break;
                        }
                    case "help":
                    case "Help":
                        {
                            helpGuide();
                            break;
                        }
                    default:
                        {
                            WriteLine("Invalid input");
                            WriteLine("Please press 'Enter' to try again.");
                            ReadLine();
                            ten();
                            break;
                        }
                }
            }
            static void eleven()
            {
                WriteLine("Remember maybe 0420 is the password.");
                WriteLine("You approach the console ready to enter password.");
                WriteLine("Please enter pin..");
                const int correct = 0420;
                string numberString;
                int passTwo;
                numberString = ReadLine();
                passTwo = Convert.ToInt32(numberString);
                if (passTwo == correct)
                {
                    Console.WriteLine("{0} is entered into the launcher!", passTwo);
                    WriteLine("Steam opens!");
                    WriteLine("Press 'Enter' to continue.");
                    ReadLine();
                    twelve();
                }
                else
                {
                    Console.WriteLine("{0} is entered into the launcher!", passTwo);
                    WriteLine("Steam remains locked...");
                    WriteLine("Press 'Enter' to continue.");
                    ReadLine();
                    eleven();
                }
            }

            static void twelve()
            {
                WriteLine("You open the store and see a game you want is on sale.");
                WriteLine("Bet! Paca Plus is on sale.. but the tax isn't calculating... ");
                WriteLine("Weird...");
                WriteLine("Guess I'll have to calculate it myself.");
                WriteLine("Press 'Enter' to continue..");
                ReadLine();
                Clear();
                WriteLine("So the game is on sale for 15 before tax.");
                WriteLine("Let's figure the tax out ourselves..");
                WriteLine("Yay!..");
                WriteLine("Press 'Enter' to continue.");
                ReadLine();
                Clear();
                WriteLine("So if tax is 6 percent and Steam takes 2 percent..");
                WriteLine("Then...");
                double myPrice = 15;
                DisplaySalesTax(myPrice);
            }

            static void DisplaySalesTax(double saleAmount)
            {
                double tax;
                const double Rate = 0.08;
                tax = saleAmount * Rate;
                WriteLine("The tax on {0} is {1}", saleAmount.ToString("C"), tax.ToString("C"));
                WriteLine("Thus if the tax is $1.20 and the price was $15 ");
                WriteLine("Then the game would cost $16.20!");
                WriteLine("I can definitely afford that!");
                WriteLine("Press 'Enter' to continue.");
                ReadLine();
                Clear();
                thirteen();
            }

            static void thirteen()
            {
                WriteLine("Imagine if I got paid to play games...");
                WriteLine("Let's calculate that!");
                WriteLine("Press 'Enter' to continue..");
                ReadLine();
                double myHours = 80;
                double myRate = 7.35;
                double grossPay;
                grossPay = CalcPay(myHours, myRate);
                WriteLine("I played {0} hours at {1} per hour", myHours, myRate);
                WriteLine("I would have made {0}", grossPay.ToString("C"));
                WriteLine("Press 'Enter' to continue..");
                ReadLine();
                Clear();
                fourteen();
            }

            static double CalcPay(double hours, double rate)
            {
                double gross;
                gross = hours * rate;
                return gross;
            }

            static void fourteen()
            {
                WriteLine("Let's see what I would have made on my favorite game.");
                double[] playTime = { 80.5, 15.5, 3.40, };
                WageOnTime(playTime);
                WriteLine("I would have made {0} at 7.35 an hour!", playTime[1]);
                WriteLine("Crazy... maybe in a perfect world.");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                fifteen();
            }

            static void WageOnTime(double[] amount)
            {
                const double INCREASE = 7.35;
                WriteLine("I have played for {0} hours.", amount[1]);
                amount[1] = amount[1] * INCREASE;
            }

            static void fifteen()
            {
                WriteLine("You go crazy at what could be and spill your drink on the keyboard.");
                WriteLine("You quickly dry it off!");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                WriteLine("I should check that my inputs are correct");
                int first, second;
                InputMethod(out first, out second);
                WriteLine("Your inputs were {0}", first);
                WriteLine("and {0}", second);
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                WriteLine("All looks good to me!");
                WriteLine("Thank god!");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                sixteen();
            }

            static void InputMethod(out int one, out int two)
            {
                string s1, s2;
                WriteLine("Enter first number input ");
                s1 = ReadLine();
                WriteLine("Enter second number input ");
                s2 = ReadLine();
                one = Convert.ToInt32(s1);
                two = Convert.ToInt32(s2);
            }

            static void sixteen()
            {
                WriteLine("You go to the desktop and see an old program you made in the past.");
                WriteLine("It was made for an assignment for a college project years ago.");
                WriteLine("You open it.");
                WriteLine("It is a program to demonstrate returning a reference from a method. ");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                int itemToFind;
                int x;
                int[] items = { 987, 741, 963, 321, 258 };
                WriteLine("Before replacement: ");
                for (x = 0; x < items.Length; ++x)
                    WriteLine("   " + items[x]);
                WriteLine("\n   Enter the value to find >>");
                itemToFind = Convert.ToInt32(ReadLine());
                ref int soldItem = ref FindItem(itemToFind, items);
                soldItem = 0;
                WriteLine("After replacement:");
                for (x = 0; x < items.Length; ++x)
                    WriteLine("   " + items[x]);
                WriteLine("");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                seventeen();
            }

            static ref int FindItem(int findValue, int[] elements)
            {
                int x;
                int position = -1;
                for (x = 0; x < elements.Length; ++x)
                {
                    if (findValue == elements[x])
                        position = x;
                }
                return ref elements[position];
            }

            static void seventeen()
            {
                WriteLine("Wow that was thrilling....");
                WriteLine("and very meta...");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                WriteLine("Wait am I in a machine?!");
                WriteLine("A program myself?!");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                WriteLine("You start fuming with existentialism");
                WriteLine("Your head smokes and aches terribly");
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                end();
            }

            static void end()
            {
                DisplayWithBorder("The End");
                DisplayWithBorder("To Be Continued?");
                WriteLine("Press 'Enter' to view stats");
                ReadLine();
                Clear();
                Stats();
            }

            static void DisplayWithBorder(string word)
            {
                const int EXTRA_STARS = 4;
                const string SYMBOL = "*";
                int size = word.Length + EXTRA_STARS;
                int x;
                for (x = 0; x < size; ++x)
                    Write(SYMBOL);
                WriteLine();
                WriteLine(SYMBOL + " " + word + " " + SYMBOL);
                for (x = 0; x < size; ++x)
                    Write(SYMBOL);
                WriteLine("\n\n");
            }

            static void Stats()
            {
                int x = 0;
                WriteLine("You began with {0} Shrek encounters", x);
                DisplayReferenceParameter(ref x);
                WriteLine("Thus you finished with {0} Shrek encounters", x);
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                WriteLine("Final Inventory:");
                WriteLine(" ");
                string[] inventory = { "Pocket Lint", "A coin with Shrek on it", "A normal penny" };
                string finalItem = "A gum wrapper";
                Array.Resize(ref inventory, inventory.Length + 1);
                inventory[inventory.Length - 1] = finalItem;
                foreach (var e in inventory)
                {
                    WriteLine(e);
                }
                WriteLine("Press 'Enter' to continue");
                ReadLine();
                Clear();
                winner();
            }

            static void DisplayReferenceParameter(ref int number)
            {
                number = 1;
                WriteLine("You encountered {0} Shrek on your journey", number);
            }
        }
    }
}