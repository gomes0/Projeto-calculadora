namespace Calculadora
{
    partial class Calculadora
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
            lblnumero = new Label();
            txtNumero1 = new TextBox();
            lblnumero2 = new Label();
            txtNumero2 = new TextBox();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(12, 9);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(60, 15);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Font = new Font("Segoe UI", 12F);
            txtNumero1.Location = new Point(12, 27);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 29);
            txtNumero1.TabIndex = 1;
            // 
            // lblnumero2
            // 
            lblnumero2.AutoSize = true;
            lblnumero2.Location = new Point(138, 9);
            lblnumero2.Name = "lblnumero2";
            lblnumero2.Size = new Size(60, 15);
            lblnumero2.TabIndex = 2;
            lblnumero2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Font = new Font("Segoe UI", 12F);
            txtNumero2.Location = new Point(138, 27);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 29);
            txtNumero2.TabIndex = 3;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(13, 71);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(94, 71);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 5;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(175, 71);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(256, 71);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(283, 28);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(23, 24);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "0";
            lblResultado.Click += lbltotal_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 103);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(txtNumero2);
            Controls.Add(lblnumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblnumero);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private TextBox txtNumero1;
        private Label lblnumero2;
        private TextBox txtNumero2;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblResultado;
    }
}
