using System.Collections.Generic;

namespace Pizza_With_Pattern
{

    class Pizza
    {

        public string name;
        public string basetype;
        public bool cheeseburst;
        public List<string> addons;


        //...  others
    }

    // just a facade
    class PizzaBuilder
    {
        protected Pizza pizza = new Pizza();

        public PizzaTypeBuilder Type => new PizzaTypeBuilder(pizza);
        public PizzaAddonsBuilder Addons => new PizzaAddonsBuilder(pizza);


        public Pizza Build()
        {
            return pizza;
        }
        public static implicit operator Pizza(PizzaBuilder pb)
        {
            return pb.pizza;
        }
    }

    class PizzaTypeBuilder : PizzaBuilder
    {
        public PizzaTypeBuilder(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public PizzaTypeBuilder Name(string name)
        {
            pizza.name = name;
            return this;
        }

        public PizzaTypeBuilder Base(string basetype)
        {
            pizza.basetype = basetype;
            return this;
        }
        public PizzaTypeBuilder Cheeseburst()
        {
            pizza.cheeseburst = true;
            return this;
        }
    }

    class PizzaAddonsBuilder : PizzaBuilder
    {
        public PizzaAddonsBuilder(Pizza pizza)
        {
            this.pizza = pizza;
            this.pizza.addons = new List<string>();
        }

        public PizzaAddonsBuilder Add(string side)
        {
            pizza.addons.Add(side);
            return this;
        }

    }


    class Client
    {
        public static void Run()
        {
            PizzaBuilder builder = new PizzaBuilder();
            Pizza pizza = builder.Type
                .Name("Farm fresh")
                .Base("Multigrains")
                .Cheeseburst()
                .Addons.Add("capsicum")
                .Add("Olives");
        }
    }


}