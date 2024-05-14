namespace Ejercicio4
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
            panel1 = new Panel();
            label1 = new Label();
            textBoxCodigoProducto = new TextBox();
            btnBuscarProducto = new Button();
            listBoxProducto = new ListBox();
            btnEliminarProducto = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxCodigoProducto);
            panel1.Controls.Add(btnBuscarProducto);
            panel1.Location = new Point(23, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 269);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 69);
            label1.Name = "label1";
            label1.Size = new Size(279, 20);
            label1.TabIndex = 3;
            label1.Text = "INTRODUCE EL CÓDIGO DEL PRODUCTO\r\n";
            // 
            // textBoxCodigoProducto
            // 
            textBoxCodigoProducto.Location = new Point(14, 103);
            textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            textBoxCodigoProducto.Size = new Size(219, 27);
            textBoxCodigoProducto.TabIndex = 1;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(14, 148);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(218, 45);
            btnBuscarProducto.TabIndex = 0;
            btnBuscarProducto.Text = "BUSCAR";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // listBoxProducto
            // 
            listBoxProducto.FormattingEnabled = true;
            listBoxProducto.Location = new Point(355, 56);
            listBoxProducto.Name = "listBoxProducto";
            listBoxProducto.Size = new Size(428, 164);
            listBoxProducto.TabIndex = 5;
            listBoxProducto.SelectedIndexChanged += btnEliminarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.IndianRed;
            btnEliminarProducto.Location = new Point(360, 255);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(428, 70);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(btnEliminarProducto);
            Controls.Add(panel1);
            Controls.Add(listBoxProducto);
            Name = "Form1";
            Text = "EJERCICIO 4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxCodigoProducto;
        private Button btnBuscarProducto;
        private ListBox listBoxProducto;
        private Button btnEliminarProducto;
    }
}
