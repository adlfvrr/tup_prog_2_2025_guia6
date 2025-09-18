namespace ej
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
            btnAgregar = new Button();
            btnEliminar = new Button();
            lsbPersonas = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbPersonas);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listado de personas";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(414, 39);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 48);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(414, 120);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 48);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lsbPersonas
            // 
            lsbPersonas.FormattingEnabled = true;
            lsbPersonas.ItemHeight = 15;
            lsbPersonas.Location = new Point(6, 22);
            lsbPersonas.Name = "lsbPersonas";
            lsbPersonas.Size = new Size(402, 229);
            lsbPersonas.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 297);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Ejercicio";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lsbPersonas;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}
