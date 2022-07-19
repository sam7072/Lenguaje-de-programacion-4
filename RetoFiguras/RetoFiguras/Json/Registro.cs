using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFiguras.Json
{
    public class Registro
    {
        public String Tipo { get; set; }
        public String Texto { get; set; }
        public String Props { get; set; }

        public Registro(String Tipo, String Texto, String Props)
        {
            this.Tipo = Tipo;
            this.Texto = Texto;
            this.Props = Props;
        }
    }
}
