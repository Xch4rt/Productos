using Productos.Model;
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
    public partial class frmMdi : Form
    {
        public ProductoModel ProductoModel;
        public frmMdi()
        {
            InitializeComponent();
            ProductoModel = new ProductoModel();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 frmProducto = new Form1();
            frmViews views = new frmViews();
            views.ProductoModel = ProductoModel;
            views.MdiParent = this;
            views.Show();
            //frmProducto.MdiParent = this;
            //frmProducto.Show();
        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Modificaciones aqu
            /*
             *  UCform es el formulario con un flow layout para mostrar las cards
            */
            UCform ucfrview = new UCform();
            ucfrview.ProductoModel = ProductoModel;
            ucfrview.MdiParent = this;
            ucfrview.Show();

        }

        private void frmMdi_Load(object sender, EventArgs e)
        {

        }
    }
}
