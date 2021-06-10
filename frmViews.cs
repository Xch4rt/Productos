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
    public partial class frmViews : Form
    {
        public ProductoModel ProductoModel { get; set; }

        public frmViews()
        {
            
            InitializeComponent();
            

        }

        private void frmViews_Load(object sender, EventArgs e)
        {
            if (ProductoModel.GetAll() == null)
            {
                return;
            }

            dgvDatos.DataSource = ProductoModel.GetAll();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.dgvDatos = dgvDatos;
            form1.ProductoModel = ProductoModel;
            form1.Show();

            dgvDatos.DataSource = ProductoModel.GetAll();


        }
    }
}
