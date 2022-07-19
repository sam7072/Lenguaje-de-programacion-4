using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RetoFiguras.Json
{
    public class GestorJson
    {
        public static dataset Leer(String filename)
        {
            String json = File.ReadAllText("C:\\Users\\zam-house\\source\\repos\\RetoFiguras\\RetoFiguras\\Json\\" + filename);
            return JsonSerializer.Deserialize<dataset>(json);
        }
    }
}
