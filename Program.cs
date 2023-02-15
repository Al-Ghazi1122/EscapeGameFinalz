using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Quiz;

namespace EscapeGame
{
    class Program1
    {
        //These are global variables private means they can only be accessed from the Program Clas
        //create Room Objects
        private static StoreRoom startingStoreRoom = new StoreRoom();
        private static StoreRoom emptyStoreRoom = new StoreRoom("Store 2", "This is an empty store", "on", "open");
        private static Kitchen theKitchen = new Kitchen("The Kitchen", "This is a kitchen. It has two storerooms and a locked door leading to the livingroom");
        private static LivingRoom thelivingRoom = new LivingRoom("The Living Room", "This is the Livingroom");
        //Create Item Objects
        private static Key blueKey = new Key("Blue Key", "This key can be used to unlock a door", "blue");
        private static Key redkey = new Key("Red key");

        static void PlayGame(PlayerClass player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Escape Game");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome, " + player.UserName +
                " You are staring with a score of : " + player.getScore().ToString());
            Console.WriteLine("");
            Console.WriteLine("<< Insert Introduction/narrative here >>");
            Console.WriteLine("<< Insert player instructions here 33");
            Console.WriteLine("");
            Console.WriteLine(player.getPlayerDetails());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to begin...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void StartStoreRoom(ref PlayerClass player)
        {
            string userInput = "";
            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Escape Game: The unknown beginning");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(startingStoreRoom.getRoomDetails());
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Would you like to:");
                    Console.WriteLine(" [1] Run forward?");
                    Console.WriteLine(" [2] feel the walls for a light switch?");
                    userInput = Console.ReadLine();
                    if (userInput[0] == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        player.updateScore(-10);
                        Console.WriteLine("You run foward and bang you head, knocking yourself out...");
                        Console.WriteLine("...you wake up some time later");
                        Console.WriteLine("Your score is now:" + player.getScore());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }
                } while (userInput[0] != '2');
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You found a switch on the wall - press enter to turn in on");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("press enter to turn on the switch");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(startingStoreRoom.setLightStatus());
                Console.WriteLine(startingStoreRoom.getRoomDetails());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to:");
                Console.WriteLine(" [1] look at the door?");
                Console.WriteLine(" [2] open the door");
                userInput = Console.ReadLine();
                if (userInput[0] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    player.updateScore(-10);
                    Console.WriteLine("While looking at the door you get bored and fall asleep...");
                    Console.WriteLine("...you wake up some time later");
                    Console.WriteLine("Your score is now:" + player.getScore());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    Console.WriteLine(startingStoreRoom.setLightStatus());
                }
            } while (userInput[0] != '2');
            AreaComplete(ref player);
        }

        static void StartKitchen(ref PlayerClass player)
        {
            string userInput = "";
            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Escape Game: The Kitchen");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(theKitchen.getRoomDetails());
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to walk forward");
                    userInput = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("As you walk forward a sensor activates...");
                    Console.WriteLine(theKitchen.setLightStatus());
                    Console.WriteLine("You can see a table that appears to have a small object on it");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Would you like to:");
                    Console.WriteLine(" [1] repeat the room details?");
                    Console.WriteLine(" [2] walk around the room?");
                    Console.WriteLine(" [3] walk over to the table and inspect the small object");
                    Console.WriteLine(" [4] investigate what is isnide the other store room");
                    userInput = Console.ReadLine();

                    if (userInput[0] == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(theKitchen.getRoomDetails());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }
                    else if (userInput[0] == '2')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(theKitchen.getRoomDetails());
                        Console.WriteLine("You spend some time walking around the room");
                        Console.WriteLine("...eventually you stop and realise you are back where you started");
                        player.updateScore(-10);
                        theKitchen.setLightStatus();
                        Console.WriteLine("Your score is now:" + player.getScore());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }
                    else if (userInput[0] == '4')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You enter the store room");
                        Console.WriteLine("... as the store room is empty you turn around to go back into the kitchen");
                        Console.WriteLine(theKitchen.setLightStatus());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }
                } while (userInput[0] != '3');
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You walk up to the table and inspect the object");
                Console.WriteLine("...");
                Console.WriteLine(blueKey.getItemDetails());
                Console.WriteLine("...");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to:");
                Console.WriteLine(" [1] repeat all of the room details so far?");
                Console.WriteLine(" [2] discard the item");
                Console.WriteLine(" [3] take the item and walk over to the locked door");
                userInput = Console.ReadLine();
                if (userInput[0] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(theKitchen.getRoomDetails());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                }
                else if (userInput[0] == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(theKitchen.getRoomDetails());
                    Console.WriteLine("the key has been lost!");
                    Console.WriteLine("... you are unable to escape the room.");
                    Console.WriteLine("The room will be reset");
                    player.updateScore(-50);
                    Console.WriteLine("Your score is now:" + player.getScore());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("press enter to continue");
                    theKitchen.setLightStatus();
                    Console.ReadLine();
                }
            } while (userInput[0] != '3');
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You walk over to the door. It has a blue lock");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to use the key in the lock");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(theKitchen.setLivingRoomDoorStatus(true));

            AreaComplete(ref player);
        }// Start Living Room
        static void StartLivingRoom(ref PlayerClass player)
        {
            string userInput = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Escape Game: The Living Room");
            Console.ForegroundColor = ConsoleColor.Cyan;

            AreaComplete(ref player);
        }
        static void AreaComplete(ref PlayerClass playerObject)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            playerObject.updateScore(10);
            Console.WriteLine("The door opens and you walk out of the room");
            Console.WriteLine("...well done you have successfully escaped from this room");
            Console.WriteLine("Your score is now:" + playerObject.getScore());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        static void gameComplete(ref PlayerClass player)
        {
            Console.WriteLine("Well done you have completed the game:");
            Console.WriteLine(player.getPlayerDetails());
            Console.WriteLine("Press enter");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Escape Game");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            //Set up new user
            string userName, password;
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();
            Console.WriteLine("Please choose a password");

            password = Console.ReadLine();

            if (password == "YO!")
            {
                Console.WriteLine("You may enter the game");
            }
            else
            {
                Console.WriteLine("Incorrect Password lad");
            }
            Console.Clear();

            //Player Class Object 
            PlayerClass player = new PlayerClass("user", "password");
            UpdateScore(ref player, 10);
            Console.WriteLine(player.getPlayerDetails());
            Console.ReadLine();

            PlayGame(player);
            StartStoreRoom(ref player);
            StartKitchen(ref player);
            StartLivingRoom(ref player);
            gameComplete(ref player);
        }

        static void UpdateScore(ref PlayerClass player, decimal score)
        {
            player.updateScore(score);
        }
    }
}
//End of Program Code
