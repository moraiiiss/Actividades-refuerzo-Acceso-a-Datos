namespace Ejercicio2
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
            listBoxProductos = new ListBox();
            btnListarProductos = new Button();
            panel1 = new Panel();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxProductos
            // 
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.Location = new Point(3, 20);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(548, 184);
            listBoxProductos.TabIndex = 0;
            // 
            // btnListarProductos
            // 
            btnListarProductos.BackColor = SystemColors.Desktop;
            btnListarProductos.Location = new Point(64, 235);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(213, 57);
            btnListarProductos.TabIndex = 1;
            btnListarProductos.Text = "Ver Productos";
            btnListarProductos.UseVisualStyleBackColor = false;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnListarProductos);
            panel1.Controls.Add(listBoxProductos);
            panel1.Location = new Point(119, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 328);
            panel1.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Info;
            btnLimpiar.Location = new Point(306, 235);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(213, 57);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar datos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProductos;
        private Button btnListarProductos;
        private Panel panel1;
        private Button btnLimpiar;
    }
}
