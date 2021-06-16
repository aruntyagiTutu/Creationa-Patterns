using System;
using System.Collections.Generic;

namespace Pizza_No_Pattern
{
    class Pizza
    {

        public string name;
        public string basetype;
        public bool cheeseburst;
        public List<string> addons;


        //...  others

        // crowded constructors

        public Pizza(string name)
        {
            this.name = name;
            this.addons = new List<string>();
        }

        public Pizza(string name, string basetype)
        {
            this.name = name;
            this.basetype = basetype;
            this.addons = new List<string>();
        }

        public Pizza(string name, string basetype, bool isCheeseBurst = false)
        {
            this.name = name;
            this.basetype = basetype;
            this.cheeseburst = isCheeseBurst;
            this.addons = new List<string>();
        }

        public Pizza(string name, string basetype, List<string> addons, bool isCheeseBurst = false)
        {
            this.name = name;
            this.basetype = basetype;
            this.cheeseburst = isCheeseBurst;
            this.addons = addons;
        }
    }

    class Client
    {
        public static void Run()
        {
            // can use any constructor, but highly vulnerable to errors
            var pizza = new Pizza("", "");
        }
    }
}