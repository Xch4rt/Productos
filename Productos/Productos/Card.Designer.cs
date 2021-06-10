
namespace Productos
{
    partial class Card
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDecrip = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(3, 3);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(328, 151);
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 200);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(32, 232);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(32, 257);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(42, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Modelo";
            // 
            // lblDecrip
            // 
            this.lblDecrip.AutoSize = true;
            this.lblDecrip.Location = new System.Drawing.Point(35, 323);
            this.lblDecrip.Name = "lblDecrip";
            this.lblDecrip.Size = new System.Drawing.Size(63, 13);
            this.lblDecrip.TabIndex = 4;
            this.lblDecrip.Text = "Descripcion";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(35, 284);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Precio";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDecrip);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pcbImage);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(334, 428);
            this.Load += new System.EventHandler(this.Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDecrip;
        private System.Windows.Forms.Label lblPrice;
    }
}
