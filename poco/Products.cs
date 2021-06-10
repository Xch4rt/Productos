using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.poco
{
    public class Products
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int nExistencia { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal precio { get; set; }

        public string desc { get; set; }
        public string img { get; set; }
    }
}
