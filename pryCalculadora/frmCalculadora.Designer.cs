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
            btnPorcentaje = new TextBox();
            SuspendLayout();
            // 
            // txtN1
            // 
            txtN1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtN1.Location = new Point(251, 69);
            txtN1.Margin = new Padding(3, 4, 3, 4);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(290, 31);
            txtN1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.Location = new Point(142, 73);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 1;
            label1.Text = "Número 1:";
            // 
            // txtN2
            // 
            txtN2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtN2.Location = new Point(251, 144);
            txtN2.Margin = new Padding(3, 4, 3, 4);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(290, 31);
            txtN2.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtResultado.Location = new Point(251, 316);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(290, 31);
            txtResultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label2.Location = new Point(142, 320);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 4;
            label2.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(142, 148);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 5;
            label3.Text = "Número 2:";
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSumar.Location = new Point(142, 219);
            btnSumar.Margin = new Padding(3, 4, 3, 4);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(107, 53);
            btnSumar.TabIndex = 6;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(267, 219);
            btnRestar.Margin = new Padding(3, 4, 3, 4);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(91, 59);
            btnRestar.TabIndex = 7;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPorcentaje.Location = new Point(378, 231);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(125, 31);
            btnPorcentaje.TabIndex = 8;
            btnPorcentaje.Text = "Porcentaje";
            btnPorcentaje.TextChanged += btnPorcentaje_TextChanged;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 432);
            Controls.Add(btnPorcentaje);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(txtN2);
            Controls.Add(label1);
            Controls.Add(txtN1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox btnPorcentaje;
    }
}
