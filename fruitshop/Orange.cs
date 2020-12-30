using System;
using System.Collections.Generic;
using System.Text;

namespace fruitshop
{

    public class Orange : Fruit
    {
        public string Squeeze(){
            Console.WriteLine("Squeeze");
            return "Ok";
        }
    }
}