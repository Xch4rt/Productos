using Productos.Model;
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
    // Formulario que se encarga de ir mostrando las cards
    public partial class UCform : Form
    {
        public ProductoModel ProductoModel { get; set; }
        private Card ucCard;

        public UCform()
        {
            InitializeComponent();
        }

        private void UCform_Load(object sender, EventArgs e)
        {
            if (ProductoModel.GetAll() == null)
                return;
            

            Products[] rr = ProductoModel.GetAll();

            for (int i = 0; i < rr.Length; i++)// con un for le seteo y es dinamico jiji
            {
                ucCard = new Card();
                ucCard.product = rr[i];
                this.flLayout.Controls.Add(ucCard);
            }
        }
    }
}
