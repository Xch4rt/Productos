using Productos.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Card : UserControl
    {
        public Products product { get; set; }
        public Card()
        {
            InitializeComponent();
            product = new Products();
        }

        private void Card_Load(object sender, EventArgs e)
        {
            // Se encarga de pasarle los parametros a la tarjeta
            pcbImage.Image = Image.FromFile(product.img);
            lblId.Text += 1;
            lblMarca.Text += product.marca;
            lblModel.Text += product.modelo;
            lblPrice.Text += product.precio;
            lblDecrip.Text += product.desc;
        }
    }
}
