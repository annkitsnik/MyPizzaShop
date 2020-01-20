using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    class Warehouse
    {
        List<Article> InStock;

        //constructor
        public Warehouse()
        {
            InStock = new List<Article>();
            Article americana = new Article(1, "Americana: sauce, cheese, salami, pineapple", Category.PIZZA, 5);//1
            InStock.Add(americana);
            Article margherita = new Article(2, "Margherita: sauce, cheese", Category.PIZZA, 3);//2
            InStock.Add(margherita);
            Article romana = new Article(3, "Romana: sauce, cheese, bacon, pineapple", Category.PIZZA, 5);//3
            InStock.Add(romana);
            Article pepperone = new Article(4, "Pepperone: sauce, cheese, onion, peperoni", Category.PIZZA, 4);//4
            InStock.Add(pepperone);
            Article siciliana = new Article(5, "Siciliana: sauce, cheese, ham, onion", Category.PIZZA, 5);//5
            InStock.Add(siciliana);
            Article olives = new Article(6, "olives", Category.EXTRA, 0.50);//1
            InStock.Add(olives);
            Article onion = new Article(7, "onion", Category.EXTRA, 0.50);//2
            InStock.Add(onion);
            Article pineapple = new Article(8, "pineapple", Category.EXTRA, 0.5);//3
            InStock.Add(pineapple);
            Article tomatoSauce = new Article(9, "tomato sauce", Category.EXTRA, 0.50);//4
            InStock.Add(tomatoSauce);
            Article cheese = new Article(10, "cheese", Category.EXTRA, 0.50);//5
            InStock.Add(cheese);
            Article basicDough = new Article(11, "basic dough", Category.DOUGH, 0);
            InStock.Add(basicDough);
            Article superDough = new Article(12, "super dough", Category.DOUGH, 1);
            InStock.Add(superDough);
           
        }

        public void PrintInStock()
        {
            foreach (Article article in InStock)
            {
                Console.WriteLine($"ID: {article.Id}");
                Console.WriteLine($"Product: {article.Name}");
                Console.WriteLine($"Category: {article.Category}");
                Console.WriteLine($"Price: {article.Price}");
                Console.WriteLine();
            }
        }

        //Get an article object from the list
        public Article GetFromStock(int id)
        {
            return InStock[id-1];
        }


        
    }
}
