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
        private void LoadProducts()
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.dgvDatos = dgvDatos;
            form1.ProductoModel = ProductoModel;
            form1.Show();

            dgvDatos.DataSource = ProductoModel.GetAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0 || dgvDatos.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("No se han seleccionado datos");
                return;
            }

            int index = dgvDatos.CurrentCell.RowIndex;// obtenemos el index de la fila
            ProductoModel.remove(index); //funcion remove hecha en el model
            dgvDatos.DataSource = ProductoModel.GetAll();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
                return;

            List<Products> filtro = new List<Products>();// Uso LIst para trabajar mas rapido utilizando el metodo Add
            string Clave = txtFiltro.Text.ToUpper();//Obtenemos lo que haya en el txt
            foreach (Products pro in ProductoModel.GetAll())
            {
                if (pro.nombre.ToUpper().Contains(Clave) || pro.marca.ToUpper().Contains(Clave) || pro.modelo.ToUpper().Contains(Clave) || (pro.precio + "").ToUpper().Contains(Clave) || (pro.nExistencia + "").ToUpper().Contains(Clave))
                    // si existe OR existe lo otro, mostrar en tabla, utilizando ToUpper para evitar percances y compararlas en mayusq
                    filtro.Add(pro);

            }

            if (filtro.Count > 0)
                dgvDatos.DataSource = filtro;
            else
                dgvDatos.DataSource = ProductoModel.GetAll();
        }
    }
}
