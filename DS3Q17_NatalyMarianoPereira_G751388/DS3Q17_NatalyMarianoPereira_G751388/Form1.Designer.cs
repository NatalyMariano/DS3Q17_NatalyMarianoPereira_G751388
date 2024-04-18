namespace DS3Q17_NatalyMarianoPereira_G751388
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
            label1 = new Label();
            txtRA = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtMensangem = new TextBox();
            btnLaboratorioInformatica = new Button();
            btnLaboratorioQuimica = new Button();
            btnLaboratorioMecanica = new Button();
            txtLaboratorio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 46);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe o RA";
            label1.Click += label1_Click;
            // 
            // txtRA
            // 
            txtRA.Location = new Point(47, 75);
            txtRA.Name = "txtRA";
            txtRA.Size = new Size(381, 23);
            txtRA.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(193, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 151);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // txtMensangem
            // 
            txtMensangem.Enabled = false;
            txtMensangem.Location = new Point(47, 151);
            txtMensangem.Name = "txtMensangem";
            txtMensangem.Size = new Size(381, 23);
            txtMensangem.TabIndex = 4;
            // 
            // btnLaboratorioInformatica
            // 
            btnLaboratorioInformatica.Enabled = false;
            btnLaboratorioInformatica.Location = new Point(47, 205);
            btnLaboratorioInformatica.Name = "btnLaboratorioInformatica";
            btnLaboratorioInformatica.Size = new Size(114, 23);
            btnLaboratorioInformatica.TabIndex = 5;
            btnLaboratorioInformatica.Text = "Informatica";
            btnLaboratorioInformatica.UseVisualStyleBackColor = true;
            btnLaboratorioInformatica.Click += LaboratorioInformatica_Click;
            // 
            // btnLaboratorioQuimica
            // 
            btnLaboratorioQuimica.Enabled = false;
            btnLaboratorioQuimica.Location = new Point(176, 205);
            btnLaboratorioQuimica.Name = "btnLaboratorioQuimica";
            btnLaboratorioQuimica.Size = new Size(114, 23);
            btnLaboratorioQuimica.TabIndex = 6;
            btnLaboratorioQuimica.Text = "Quimica";
            btnLaboratorioQuimica.UseVisualStyleBackColor = true;
            btnLaboratorioQuimica.Click += LaboratorioQuimica_Click;
            // 
            // btnLaboratorioMecanica
            // 
            btnLaboratorioMecanica.Enabled = false;
            btnLaboratorioMecanica.Location = new Point(314, 205);
            btnLaboratorioMecanica.Name = "btnLaboratorioMecanica";
            btnLaboratorioMecanica.Size = new Size(114, 23);
            btnLaboratorioMecanica.TabIndex = 7;
            btnLaboratorioMecanica.Text = "Mecanica";
            btnLaboratorioMecanica.UseVisualStyleBackColor = true;
            btnLaboratorioMecanica.Click += LaboratorioMecanica_Click;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Enabled = false;
            txtLaboratorio.Location = new Point(47, 261);
            txtLaboratorio.Multiline = true;
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(381, 93);
            txtLaboratorio.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 384);
            Controls.Add(txtLaboratorio);
            Controls.Add(btnLaboratorioMecanica);
            Controls.Add(btnLaboratorioQuimica);
            Controls.Add(btnLaboratorioInformatica);
            Controls.Add(txtMensangem);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtRA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRA;
        private Button button1;
        private Label label2;
        private TextBox txtMensangem;
        private Button btnLaboratorioInformatica;
        private Button btnLaboratorioQuimica;
        private Button btnLaboratorioMecanica;
        private TextBox txtLaboratorio;
    }
}
