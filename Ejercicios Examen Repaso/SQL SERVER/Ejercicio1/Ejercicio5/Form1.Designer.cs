namespace Ejercicio5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCodigo = new TextBox();
            btnBuscarProducto = new Button();
            label1 = new Label();
            textBoxNombreProducto = new TextBox();
            textBoxPrecioProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnModificarPrecio = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(46, 36);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(177, 27);
            textBoxCodigo.TabIndex = 0;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(46, 69);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(177, 29);
            btnBuscarProducto.TabIndex = 1;
            btnBuscarProducto.Text = "BUSCAR";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 2;
            label1.Text = "Introduce el código del producto deseado: ";
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(23, 38);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(177, 27);
            textBoxNombreProducto.TabIndex = 3;
            // 
            // textBoxPrecioProducto
            // 
            textBoxPrecioProducto.Location = new Point(23, 103);
            textBoxPrecioProducto.Name = "textBoxPrecioProducto";
            textBoxPrecioProducto.Size = new Size(177, 27);
            textBoxPrecioProducto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 80);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 6;
            label3.Text = "Precio Producto: ";
            // 
            // btnModificarPrecio
            // 
            btnModificarPrecio.Location = new Point(23, 136);
            btnModificarPrecio.Name = "btnModificarPrecio";
            btnModificarPrecio.Size = new Size(177, 29);
            btnModificarPrecio.TabIndex = 7;
            btnModificarPrecio.Text = "Modificar el Precio";
            btnModificarPrecio.UseVisualStyleBackColor = true;
            btnModificarPrecio.Click += btnModificarPrecio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(btnModificarPrecio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxPrecioProducto);
            panel1.Controls.Add(textBoxNombreProducto);
            panel1.Location = new Point(282, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 194);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxCodigo);
            panel2.Controls.Add(btnBuscarProducto);
            panel2.Location = new Point(247, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 122);
            panel2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "EJERCICIO 5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxCodigo;
        private Button btnBuscarProducto;
        private Label label1;
        private TextBox textBoxNombreProducto;
        private TextBox textBoxPrecioProducto;
        private Label label2;
        private Label label3;
        private Button btnModificarPrecio;
        private Panel panel1;
        private Panel panel2;
    }
}
