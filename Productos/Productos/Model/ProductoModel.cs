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
        public Products[] prs;

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
            
            //Console.WriteLine(productos);
        }
        public Products[] GetAll()
        {
            return productos;
        }
        public Products[] GetInfo()
        {
            prs[0] = productos[0];
            /*prs[1] = productos[1];
            prs[2] = productos[2];
            prs[3] = productos[3];
            prs[4] = productos[4];*/
            return prs;
        }


        public void remove(int index)
        {
            if (index < 0)
                return;

            if (productos == null)
                return;

            if (index >= productos.Length)
                throw new IndexOutOfRangeException($"El index {index} esta fuera de rango");

            if (index == 0 && productos.Length == 1)
            {
                productos = null;
                return;
            }

            Products[] temp = new Products[productos.Length - 1];

            if (index == 0)
            {
                Array.Copy(productos, index + 1, temp, 0, temp.Length);
                productos = temp;
                return;
            }

            if (index == productos.Length - 1)
            {
                Array.Copy(productos, 0, temp, 0, temp.Length);
                productos = temp;
                return;
            }

            Array.Copy(productos, 0, temp, 0, index);
            Array.Copy(productos, index + 1, temp, index, temp.Length - index);
            productos = temp;
        }

    }

    


}
