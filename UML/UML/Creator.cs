using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public abstract class Creator
    {
        public String name { get; set; }


        public Creator(String name)
        {
            this.name = name;
        }

        public void SomeOperation()
        {


            Console.WriteLine("Se ejecuta : SomeOperation() ");
            //depemdemcia de clase creator e imterfaz
            IProduct product = CreateProduct(name);
            product.doStuff();
        }

        public abstract IProduct CreateProduct(String name);
    }
}
