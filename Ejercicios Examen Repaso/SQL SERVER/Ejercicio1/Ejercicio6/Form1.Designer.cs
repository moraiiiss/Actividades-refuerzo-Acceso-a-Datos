namespace Ejercicio6
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
            btnBuscarProducto = new Button();
            textBoxCodigoProducto = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            listBoxProductoBuscado = new ListBox();
            btnBorrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(17, 72);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(176, 46);
            btnBuscarProducto.TabIndex = 0;
            btnBuscarProducto.Text = "BUSCAR";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // textBoxCodigoProducto
            // 
            textBoxCodigoProducto.Location = new Point(17, 39);
            textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            textBoxCodigoProducto.Size = new Size(176, 27);
            textBoxCodigoProducto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Código Producto: ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxCodigoProducto);
            panel1.Controls.Add(btnBuscarProducto);
            panel1.Location = new Point(54, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 131);
            panel1.TabIndex = 3;
            // 
            // listBoxProductoBuscado
            // 
            listBoxProductoBuscado.FormattingEnabled = true;
            listBoxProductoBuscado.Location = new Point(406, 79);
            listBoxProductoBuscado.Name = "listBoxProductoBuscado";
            listBoxProductoBuscado.Size = new Size(299, 264);
            listBoxProductoBuscado.TabIndex = 4;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(408, 366);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(297, 54);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(listBoxProductoBuscado);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarProducto;
        private TextBox textBoxCodigoProducto;
        private Label label1;
        private Panel panel1;
        private ListBox listBoxProductoBuscado;
        private Button btnBorrar;
    }
}
