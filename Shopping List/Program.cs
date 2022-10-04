using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Shopping_List
{
    internal class Program
    {
        private static void Main()
        { 
            // Sets up the begining what is displayed to the user
            Console.WriteLine("Welcome to Western Tables! These are the items I have today");
            Console.WriteLine($"{"Item",15}{"Price",17} ");
            Console.WriteLine("=================================");

            List<string> orderedItems = new List<string>();

            while (true)
            {

                // adds to the dictionary what items I have
                Dictionary<string, decimal> ShoppingList = new Dictionary<string, decimal>();
                ShoppingList.Add("Watermelon", 3.85m);
                ShoppingList.Add("Apples", 2.51m);
                ShoppingList.Add("Chocolate Bar", 4.25m);
                ShoppingList.Add("Chicken", 7.99m);
                ShoppingList.Add("Cider", 4.55m);
                ShoppingList.Add("Pizza", 6.57m);
                ShoppingList.Add("Bread", 4.99m);
                ShoppingList.Add("Eggs", 3.62m);
                ShoppingList.Add("Toes", 0.99m);
                ShoppingList.Add("Water", 9.99m);
                ShoppingList.Add("Voodoo Mtn Dew", 9.22m);

                // displays the list of products
                foreach (KeyValuePair<string, decimal> kvp in ShoppingList)
                {
                    Console.WriteLine($"{kvp.Key,15} {kvp.Value,15}");
                }
                Console.WriteLine(" What would you like to buy today?");

                // Makes a list that will be added to when someone adds their item
                

                // This string is for the users input, it will determine whether or no if what they are asking for is on the list
                string userinput = Console.ReadLine();

                // this bool is setting up to determine if it is in the list, it will input true if it is
                bool haveitem = ShoppingList.ContainsKey(userinput);


                // this foreach isnt really important, it would be better to incorporate this into seperate methods
                foreach (KeyValuePair<string, decimal> kvp in ShoppingList)
                {
                    //checks if the item that the user input is in the dictionary
                    haveitem = ShoppingList.ContainsKey(userinput);
                    if (haveitem == true)
                    {
                        // if they have the item it adds it to the list and prints out the price and item
                        orderedItems.Add(userinput);
                        Console.WriteLine($"Awesome, you have added {userinput} to your list! That adds {ShoppingList[userinput]} to the cart!");
                        break;
                    }
                    else
                    {
                        // if they dont have it, it breaks the loop and does
                        Console.WriteLine($"Uhh it looks like we dont have {userinput}");
                        break;
                    }
                }

                // loops it to see if they want to buy something else
                Console.WriteLine("Would you like to buy something else? Y/N");
                string cont = Console.ReadLine().ToLower();
                if (cont == "y")
                { 
                continue;
                }
                else
                {
                    // displays the order stats
                    Console.WriteLine(string.Join(", ", orderedItems));
                    Console.WriteLine("Awesome! Thanks for your order");
                    Console.WriteLine("Heres what you got:");
                    Console.WriteLine($"{"Items", 15}{"Price",15}");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine();
                    decimal total = 0m;

                    // it is displaying each individual item, and then adding it onto the total
                    foreach (string choice in orderedItems)
                    {
                        Console.WriteLine($"{choice,15} {ShoppingList[choice],15}");
                        total +=  ShoppingList[choice];
                    }

                    // prints the total and ends the program
                    Console.WriteLine($"{total,32}");
                    Console.WriteLine(" Have a great day!");
                    break;
                } 
            }
        }
    }
}
    
