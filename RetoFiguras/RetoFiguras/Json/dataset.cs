using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFiguras.Json
{
    public class dataset
    {
        public List<Registro> Lista { get; set; }

        public dataset()
        {
            Lista = new List<Registro>();
        }
    }
}
