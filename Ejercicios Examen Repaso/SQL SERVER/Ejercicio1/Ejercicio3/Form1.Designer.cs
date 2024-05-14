namespace Ejercicio3
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
            listBoxProducto = new ListBox();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(23, 112);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(218, 45);
            btnBuscarProducto.TabIndex = 0;
            btnBuscarProducto.Text = "BUSCAR";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // textBoxCodigoProducto
            // 
            textBoxCodigoProducto.Location = new Point(23, 67);
            textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            textBoxCodigoProducto.Size = new Size(219, 27);
            textBoxCodigoProducto.TabIndex = 1;
            // 
            // listBoxProducto
            // 
            listBoxProducto.FormattingEnabled = true;
            listBoxProducto.Location = new Point(360, 58);
            listBoxProducto.Name = "listBoxProducto";
            listBoxProducto.Size = new Size(428, 164);
            listBoxProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(279, 20);
            label1.TabIndex = 3;
            label1.Text = "INTRODUCE EL CÓDIGO DEL PRODUCTO\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxCodigoProducto);
            panel1.Controls.Add(btnBuscarProducto);
            panel1.Location = new Point(23, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 199);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 314);
            Controls.Add(panel1);
            Controls.Add(listBoxProducto);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarProducto;
        private TextBox textBoxCodigoProducto;
        private ListBox listBoxProducto;
        private Label label1;
        private Panel panel1;
    }
}
