using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.poco
{
    public class Products
    {
        int id { get; set; }
        string nombre { get; set; }
        int nExistencia { get; set; }
        string marca { get; set; }
        string modelo { get; set; }
        decimal precio { get; set; }

        string desc { get; set; }
        string img { get; set; }
    }
}
