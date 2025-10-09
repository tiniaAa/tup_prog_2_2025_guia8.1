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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lbxEmpleados = new ListBox();
            btnVerListado = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(280, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(3, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbxEmpleados);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 413);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listado de empleados ";
            // 
            // lbxEmpleados
            // 
            lbxEmpleados.FormattingEnabled = true;
            lbxEmpleados.ItemHeight = 15;
            lbxEmpleados.Location = new Point(6, 22);
            lbxEmpleados.Name = "lbxEmpleados";
            lbxEmpleados.Size = new Size(205, 379);
            lbxEmpleados.TabIndex = 0;
            lbxEmpleados.SelectedIndexChanged += lbxEmpleados_SelectedIndexChanged;
            // 
            // btnVerListado
            // 
            btnVerListado.Location = new Point(280, 56);
            btnVerListado.Name = "btnVerListado";
            btnVerListado.Size = new Size(110, 76);
            btnVerListado.TabIndex = 1;
            btnVerListado.Text = "(1) Ver Listado ";
            btnVerListado.UseVisualStyleBackColor = true;
            btnVerListado.Click += btnVerListado_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 138);
            button2.Name = "button2";
            button2.Size = new Size(110, 76);
            button2.TabIndex = 2;
            button2.Text = "(2) Importar Empleados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(280, 223);
            button3.Name = "button3";
            button3.Size = new Size(110, 76);
            button3.TabIndex = 3;
            button3.Text = "(3) Exportar Empleados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(280, 305);
            button4.Name = "button4";
            button4.Size = new Size(110, 76);
            button4.TabIndex = 4;
            button4.Text = "(5) Generar Recibos ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 439);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnVerListado);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListBox lbxEmpleados;
        private Button btnVerListado;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
