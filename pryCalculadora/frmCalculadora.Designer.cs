namespace pryCalculadora
{
    partial class frmCalculadora
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
            txtN1 = new TextBox();
            label1 = new Label();
            txtN2 = new TextBox();
            txtResultado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            SuspendLayout();
            // 
            // txtN1
            // 
            txtN1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtN1.Location = new Point(220, 52);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(254, 26);
            txtN1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.Location = new Point(124, 55);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 1;
            label1.Text = "Número 1:";
            // 
            // txtN2
            // 
            txtN2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtN2.Location = new Point(220, 108);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(254, 26);
            txtN2.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtResultado.Location = new Point(220, 237);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(254, 26);
            txtResultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label2.Location = new Point(124, 240);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 4;
            label2.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(124, 111);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 5;
            label3.Text = "Número 2:";
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSumar.Location = new Point(243, 162);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 40);
            btnSumar.TabIndex = 6;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnRestar.Location = new Point(359, 162);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(80, 44);
            btnRestar.TabIndex = 7;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 324);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(txtN2);
            Controls.Add(label1);
            Controls.Add(txtN1);
            Name = "frmCalculadora";
            Text = "Calculadora de Operaciones básicas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN1;
        private Label label1;
        private TextBox txtN2;
        private TextBox txtResultado;
        private Label label2;
        private Label label3;
        private Button btnSumar;
        private Button btnRestar;
    }
}
