namespace ejercicio1
{
    partial class FormPrincipal
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
            tbValor = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            button2 = new Button();
            label2 = new Label();
            btnBuscar = new Button();
            btnListarOrdenado = new Button();
            lbResultado = new Label();
            tbBuscar = new TextBox();
            tbResultado = new TextBox();
            SuspendLayout();
            // 
            // tbValor
            // 
            tbValor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbValor.Location = new Point(120, 30);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 0;
            tbValor.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 39);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(237, 30);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(237, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 46);
            button2.TabIndex = 6;
            button2.Text = "Calcular Promedio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 110);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Promedio";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(174, 163);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(237, 207);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(75, 45);
            btnListarOrdenado.TabIndex = 10;
            btnListarOrdenado.Text = "Lista Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BorderStyle = BorderStyle.Fixed3D;
            lbResultado.Location = new Point(131, 110);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(71, 17);
            lbResultado.TabIndex = 11;
            lbResultado.Text = "lbResultado";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(55, 164);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(100, 23);
            tbBuscar.TabIndex = 12;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(40, 207);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(191, 74);
            tbResultado.TabIndex = 13;
            tbResultado.TextChanged += tbResultado_TextChanged;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 380);
            Controls.Add(tbResultado);
            Controls.Add(tbBuscar);
            Controls.Add(lbResultado);
            Controls.Add(btnListarOrdenado);
            Controls.Add(btnBuscar);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(tbValor);
            Cursor = Cursors.PanSW;
            Name = "FormPrincipal";
            Text = "Busqueda y Ordenamiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbValor;
        private Label label1;
        private Button btnRegistrar;
        private Button button2;
        private Label label2;
        private Button btnBuscar;
        private Button btnListarOrdenado;
        private Label lbResultado;
        private TextBox tbBuscar;
        private TextBox tbResultado;
    }
}
