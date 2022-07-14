using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class CreateProductB : Creator
    {
        public CreateProductB(String name) : base(name)
        {
            this.name = name;
        }
        public override IProduct CreateProduct(String name)
        {
            Console.WriteLine(" - CreateProductB / CreateProduct()");
            ProductB product = new ProductB("camion", 2001);
            product.name = name;

            return product;
        }

    }
}
