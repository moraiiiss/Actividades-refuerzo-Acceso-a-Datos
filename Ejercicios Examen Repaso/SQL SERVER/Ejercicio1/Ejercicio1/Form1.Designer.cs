namespace Ejercicio1
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
            btnAñadirFabricante = new Button();
            btnMostrarFabricantes = new Button();
            listBoxFabricantes = new ListBox();
            textBoxCodigoFabricante = new TextBox();
            textBoxNombreFabricante = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAñadirFabricante
            // 
            btnAñadirFabricante.Location = new Point(19, 177);
            btnAñadirFabricante.Name = "btnAñadirFabricante";
            btnAñadirFabricante.Size = new Size(189, 44);
            btnAñadirFabricante.TabIndex = 0;
            btnAñadirFabricante.Text = "AÑADIR FABRICANTE";
            btnAñadirFabricante.UseVisualStyleBackColor = true;
            btnAñadirFabricante.Click += btnAñadirFabricante_Click;
            // 
            // btnMostrarFabricantes
            // 
            btnMostrarFabricantes.Location = new Point(25, 181);
            btnMostrarFabricantes.Name = "btnMostrarFabricantes";
            btnMostrarFabricantes.Size = new Size(252, 44);
            btnMostrarFabricantes.TabIndex = 1;
            btnMostrarFabricantes.Text = "Mostrar Fabricantes";
            btnMostrarFabricantes.UseVisualStyleBackColor = true;
            btnMostrarFabricantes.Click += btnMostrarFabricantes_Click;
            // 
            // listBoxFabricantes
            // 
            listBoxFabricantes.FormattingEnabled = true;
            listBoxFabricantes.Location = new Point(25, 10);
            listBoxFabricantes.Name = "listBoxFabricantes";
            listBoxFabricantes.Size = new Size(252, 144);
            listBoxFabricantes.TabIndex = 2;
            // 
            // textBoxCodigoFabricante
            // 
            textBoxCodigoFabricante.Location = new Point(26, 43);
            textBoxCodigoFabricante.Name = "textBoxCodigoFabricante";
            textBoxCodigoFabricante.Size = new Size(182, 27);
            textBoxCodigoFabricante.TabIndex = 3;
            // 
            // textBoxNombreFabricante
            // 
            textBoxNombreFabricante.Location = new Point(26, 116);
            textBoxNombreFabricante.Name = "textBoxNombreFabricante";
            textBoxNombreFabricante.Size = new Size(182, 27);
            textBoxNombreFabricante.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 10);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "Codigo Fabricante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre Fabricante";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAñadirFabricante);
            panel1.Controls.Add(textBoxCodigoFabricante);
            panel1.Controls.Add(textBoxNombreFabricante);
            panel1.Location = new Point(90, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 243);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(listBoxFabricantes);
            panel2.Controls.Add(btnMostrarFabricantes);
            panel2.Location = new Point(403, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 243);
            panel2.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(403, 361);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(279, 29);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR DATOS";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(btnLimpiar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadirFabricante;
        private Button btnMostrarFabricantes;
        private ListBox listBoxFabricantes;
        private TextBox textBoxCodigoFabricante;
        private TextBox textBoxNombreFabricante;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button btnLimpiar;
    }
}
