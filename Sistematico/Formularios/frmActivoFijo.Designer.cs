namespace Sistematico.Formularios
{
    partial class frmActivoFijo
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.bntMostrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(544, 262);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bntMostrar);
            this.flowLayoutPanel1.Controls.Add(this.btnCrear);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 291);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(544, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(335, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 30);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // bntMostrar
            // 
            this.bntMostrar.Location = new System.Drawing.Point(441, 3);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(100, 30);
            this.bntMostrar.TabIndex = 1;
            this.bntMostrar.Text = "Mostrar";
            this.bntMostrar.UseVisualStyleBackColor = true;
            // 
            // frmActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 341);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmActivoFijo";
            this.Text = "frmActivoFijo";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bntMostrar;
        private System.Windows.Forms.Button btnCrear;
    }
}