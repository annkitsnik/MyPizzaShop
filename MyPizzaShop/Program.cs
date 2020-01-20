using MyPizzaShop;
using System;
using System.Collections.Generic;
using System.Text;


namespace Pizza
{
    class Program
    {
        //you have got a menu of pizza types.
        //a user can choose from 2 type of pizza dought.
        //a user can add some additional ingredients of their order.
        // a user can choose a custom pizza with four ingredients.
        // a user can order more than one pizza.
        // after the user confirms their order, the total is displayed.

        static void Main(string[] args)
        {
            
            Warehouse currentlyInStock = new Warehouse();
            //Create a Shopping Cart object
            Shoppingcart shoppingCart = new Shoppingcart();
            //Display the warehouse content
            currentlyInStock.PrintInStock();

            AddItemsToShoppingCart(currentlyInStock, shoppingCart);
            while (true)
            {
                Console.WriteLine("Add/Add your extra/Choose your dough/Remove/Confirm");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    AddItemsToShoppingCart(currentlyInStock, shoppingCart);
                }
                else if (userInput == "add your extra")
                {
                    Console.WriteLine("Enter the id of the extra(id:5-10) to add to the pizza.");
                    int productID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of extras to add to the shopping cart: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Article articleToAdd = currentlyInStock.GetFromStock(productID);
                    shoppingCart.AddToShoppingCart(articleToAdd, quantity);
                    shoppingCart.PrintShoppingCart();
                }
                else if (userInput == "choose your dough")
                {
                    Console.WriteLine("Now choose your pizza dough: basic(id 11), super(id 12):");
                    int productID = int.Parse(Console.ReadLine());
                    Article articleToAdd = currentlyInStock.GetFromStock(productID);
                    shoppingCart.AddToShoppingCart(articleToAdd, 1);
                    shoppingCart.PrintShoppingCart();
                }
                else if (userInput == "remove")
                {
                    Console.WriteLine("Enter the id of the pizza to remove from the shopping cart: ");
                    int itemIdToremove = int.Parse(Console.ReadLine());
                    shoppingCart.RemoveFromShoppingCart(itemIdToremove);
                }
                else if (userInput == "confirm")
                {
                    shoppingCart.PrintTotal();
                    Console.WriteLine($"Total: {shoppingCart.Total} euros. Thank you for generous tips!");
                    break;
                }
            }

        }
        public static void AddItemsToShoppingCart(Warehouse currentlyInStock, Shoppingcart shoppingCart)
        {
            Console.WriteLine("Enter the id of the pizza(id 1-5) to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Article articleToAdd = currentlyInStock.GetFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            shoppingCart.PrintShoppingCart();
        }
    }
}