
namespace Productos
{
    partial class UCform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flLayout
            // 
            this.flLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flLayout.Location = new System.Drawing.Point(0, 0);
            this.flLayout.Name = "flLayout";
            this.flLayout.Size = new System.Drawing.Size(800, 450);
            this.flLayout.TabIndex = 0;
            // 
            // UCform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flLayout);
            this.Name = "UCform";
            this.Text = "UCform";
            this.Load += new System.EventHandler(this.UCform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flLayout;
    }
}