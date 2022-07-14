using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class CreateProductA : Creator
    {
        public CreateProductA(String name): base(name)
        {
            this.name = name;
        }

        public override IProduct CreateProduct(String name)
        {
            Console.WriteLine(" - CreateProductA / CreateProduct()");

            ProductA product = new ProductA("Varco");
            product.name= name;

            return product;
        }
    }
}
