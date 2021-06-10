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
    public partial class Form1 : Form
    {
        public ProductoModel ProductoModel{ get; set; }
        public DataGridView dgvDatos { get; set; }
        public frmViews frmViewss;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //productoModel = new ProductoModel();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string msj = "Todo ok";
            try
            {
                string nombre = isValid(txtNombre.Text) ? txtNombre.Text : msj="Nombre";
                string marca = isValid(txtMarca.Text) ? txtMarca.Text : msj="Marca";
                string modelo = isValid(txtModelo.Text) ? txtModelo.Text : msj="Modelo";
                decimal price = Convert.ToDecimal(txtPrecio.Text);
                string description = isValid(txtDescripcion.Text) ? txtDescripcion.Text : msj="Descripcion";
                string urlImage = isValid(txtImagen.Text) ? txtImagen.Text : msj="Imagen";
                int nExistencia = (int)npExistencia.Value;


                if (msj == "Todo ok" && !(nExistencia == 0))
                {
                    MessageBox.Show(msj);

                    Products pr = new Products()
                    {
                        nombre = nombre,
                        marca = marca,
                        modelo = modelo,
                        precio = price,
                        desc = description,
                        img = urlImage,
                        nExistencia = nExistencia
                    };
                    
                    //productoModel = new ProductoModel();
                    ProductoModel.Add(pr);//System.NullreferencException
                    dgvDatos.DataSource = ProductoModel.GetAll();
                    //MessageBox.Show($"Nombre: {pr.nombre}");
                    //frmViewss.dataGridViews1
                }
                else
                {
                    MessageBox.Show("Rellenar " + msj);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean isValid(string obj)
        {
            if (!string.IsNullOrEmpty(obj))
                return true;
            return false;
        }

        // ignorar abajo
        private void txtNExistencias_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
