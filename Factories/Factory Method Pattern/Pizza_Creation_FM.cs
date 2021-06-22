using System;
using System.Collections.Generic;

namespace Pizza_Creation_With_Factory_Method
{

    #region ["products"]
    abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;

        public List<string> toppings = new List<string>();
       public abstract void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("tossing with  " + dough + " dough");
            Console.WriteLine("adding " + sauce + " sauce");
            Console.WriteLine("Preparing " + name);

            foreach (var topping in toppings)
                Console.WriteLine("Adding " + topping + " on top");
        }

       public void Bake()
        {
            Console.WriteLine("Bake for 20 minutes");
        }

       public void Cut()
        {
            Console.WriteLine("Cut in 4 pieces");
        }

       public void Box()
        {
            Console.WriteLine("Place in box");
            Console.WriteLine("Place stooper in middle of pizza");
        }

        //// other getter ...
    }

    class FarmFullPizza: Pizza
    {
        public FarmFullPizza()
        {
            name = "Farm Full";
            dough = "Standard dough";
            sauce = "Indian spices dough";

            toppings.Add("dried green chilli");
            toppings.Add("dried ginger");
            toppings.Add("dried coriander leaves");
            toppings.Add("Veggies");
        }
    }

    class SatvikPizza: Pizza
    {
        public  SatvikPizza()
        {
            name = "Satvik";
            dough = "thin crust millets dough";
            sauce = "plum tomato sauce";

            toppings.Add("mushroom");
            toppings.Add("cheddar cheese");
        }
    }

    #endregion


    #region ["Creator or factories"]

    abstract class  PizzaStore
    {
        Pizza pizza;
        public Pizza OrderPizza(string type)
        {
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // this is our factory method
        protected abstract Pizza CreatePizza(string type);
    }

    class IndianPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if(type.Equals("Satvik"))
            {
                return new SatvikPizza();
            }
            else if(type.Equals("Desi"))
            {
                return new FarmFullPizza();
            }
            return null;
        }
    }


    #endregion


    #region ["Client"]

    class Client
    {
        void Run()
        {
            // store 

            PizzaStore indianStore = new IndianPizzaStore();
            
            // order pizza
            Pizza mypizza  = indianStore.OrderPizza("Desi");

            // enjoy your pizza

        }
    }

    #endregion

}