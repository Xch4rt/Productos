using Productos.poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Model
{
    public class ProductoModel
    {
        public Products[] productos;

        public ProductoModel(){ }

        public void Add(Products pr)
        {
            if (productos == null)
            {
                productos = new Products[1];
                productos[0] = pr;
                return;
            }
            Products[] tmp = new Products[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);

            tmp[tmp.Length - 1] = pr;
            productos = tmp;
        }

        public Products[] GetAll()
        {
            return productos;
        }
    }

    


}
