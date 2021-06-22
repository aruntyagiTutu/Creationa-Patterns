using System;
using System.Linq;
using Pizza_Creation_With_Factory_Method;

namespace Pizza_Ingredient_Factory
{
    #region ["Abstract factory"]

    interface Pizza_Ingredient_Factory
    {
        public string CreateDough();
        public string CreateSauce();
        public string CreateCheese();
        public string[] CreateVegetables();

    }

    class IndianPizzaIngredientFactory : Pizza_Ingredient_Factory
    {
        public string CreateCheese()
        {
            return "Cow milk cheese";
        }

        public string CreateDough()
        {
            return "Mixed flour thin crust";
        }

        public string CreateSauce()
        {
            return "Tomato and tamrid sauce";
        }

        public string[] CreateVegetables()
        {
            return "Panner Olives etc".Split(" ");
        }
    }

    class SomeOtherIngredientFactory : Pizza_Ingredient_Factory
    {
        public string CreateCheese()
        {
            throw new NotImplementedException();
        }

        public string CreateDough()
        {
            throw new NotImplementedException();
        }

        public string CreateSauce()
        {
            throw new NotImplementedException();
        }

        public string[] CreateVegetables()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region ["Creator"]

    class NewIndianPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("Satvik"))
            {
                return new NewIndianPizza(new IndianPizzaIngredientFactory());
            }
            else if (type.Equals("Desi"))
            {
                return new FarmFullPizza();
            }
            return null;
        }
    }

    #endregion

    #region [Product]

    class NewIndianPizza : Pizza
    {
        Pizza_Ingredient_Factory factory;
        public NewIndianPizza(Pizza_Ingredient_Factory factory)
        {
            this.factory = factory;
        }

        public override void Prepare()
        {
            dough = factory.CreateDough();
            sauce = factory.CreateSauce();
            toppings = factory.CreateVegetables().ToList();

            // etc
        }
    }

    #endregion
}