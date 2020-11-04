namespace MetrónomoDigital
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hSBGolpes = new System.Windows.Forms.HScrollBar();
            this.lblValorActual = new System.Windows.Forms.Label();
            this.lblValorMinimo = new System.Windows.Forms.Label();
            this.lblValorMaximo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.osApagado = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.osEncendido = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hSBGolpes
            // 
            this.hSBGolpes.Location = new System.Drawing.Point(219, 66);
            this.hSBGolpes.Maximum = 280;
            this.hSBGolpes.Minimum = 40;
            this.hSBGolpes.Name = "hSBGolpes";
            this.hSBGolpes.ScaleScrollBarForDpiChange = false;
            this.hSBGolpes.Size = new System.Drawing.Size(339, 21);
            this.hSBGolpes.TabIndex = 2;
            this.hSBGolpes.Value = 160;
            this.hSBGolpes.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSBGolpes_Scroll);
            // 
            // lblValorActual
            // 
            this.lblValorActual.AutoSize = true;
            this.lblValorActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorActual.Location = new System.Drawing.Point(376, 34);
            this.lblValorActual.Name = "lblValorActual";
            this.lblValorActual.Size = new System.Drawing.Size(37, 21);
            this.lblValorActual.TabIndex = 1;
            this.lblValorActual.Text = "150";
            // 
            // lblValorMinimo
            // 
            this.lblValorMinimo.AutoSize = true;
            this.lblValorMinimo.Location = new System.Drawing.Point(222, 87);
            this.lblValorMinimo.Name = "lblValorMinimo";
            this.lblValorMinimo.Size = new System.Drawing.Size(22, 17);
            this.lblValorMinimo.TabIndex = 3;
            this.lblValorMinimo.Text = "40";
            // 
            // lblValorMaximo
            // 
            this.lblValorMaximo.AutoSize = true;
            this.lblValorMaximo.Location = new System.Drawing.Point(529, 87);
            this.lblValorMaximo.Name = "lblValorMaximo";
            this.lblValorMaximo.Size = new System.Drawing.Size(29, 17);
            this.lblValorMaximo.TabIndex = 4;
            this.lblValorMaximo.Text = "280";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(335, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(118, 17);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Golpes por minuto";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.osApagado,
            this.osEncendido});
            this.shapeContainer1.Size = new System.Drawing.Size(567, 228);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // osApagado
            // 
            this.osApagado.FillColor = System.Drawing.Color.Red;
            this.osApagado.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.osApagado.Location = new System.Drawing.Point(413, 155);
            this.osApagado.Name = "osApagado";
            this.osApagado.Size = new System.Drawing.Size(22, 22);
            // 
            // osEncendido
            // 
            this.osEncendido.FillColor = System.Drawing.Color.Green;
            this.osEncendido.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.osEncendido.Location = new System.Drawing.Point(251, 155);
            this.osEncendido.Name = "osEncendido";
            this.osEncendido.Size = new System.Drawing.Size(22, 22);
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(282, 153);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(75, 28);
            this.btnEncender.TabIndex = 7;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Enabled = false;
            this.btnApagar.Location = new System.Drawing.Point(444, 153);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 28);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.White;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(44, 27);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(24, 30);
            this.lblContador.TabIndex = 8;
            this.lblContador.Text = "0";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(567, 228);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblValorMaximo);
            this.Controls.Add(this.lblValorMinimo);
            this.Controls.Add(this.lblValorActual);
            this.Controls.Add(this.hSBGolpes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Metrónomo Digital (2020)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HScrollBar hSBGolpes;
        private System.Windows.Forms.Label lblValorActual;
        private System.Windows.Forms.Label lblValorMinimo;
        private System.Windows.Forms.Label lblValorMaximo;
        private System.Windows.Forms.Label lblDescripcion;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape osApagado;
        private Microsoft.VisualBasic.PowerPacks.OvalShape osEncendido;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblContador;
    }
}

