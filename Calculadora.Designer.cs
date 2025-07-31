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
            txtnumero1 = new TextBox();
            lblnumero2 = new Label();
            txtnumero2 = new TextBox();
            btnsomar = new Button();
            btnsubtrair = new Button();
            btnmultiplicar = new Button();
            btndividir = new Button();
            lbltotal = new Label();
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
            // txtnumero1
            // 
            txtnumero1.Font = new Font("Segoe UI", 12F);
            txtnumero1.Location = new Point(12, 27);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 29);
            txtnumero1.TabIndex = 1;
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
            // txtnumero2
            // 
            txtnumero2.Font = new Font("Segoe UI", 12F);
            txtnumero2.Location = new Point(138, 27);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 29);
            txtnumero2.TabIndex = 3;
            // 
            // btnsomar
            // 
            btnsomar.Location = new Point(13, 71);
            btnsomar.Name = "btnsomar";
            btnsomar.Size = new Size(75, 23);
            btnsomar.TabIndex = 4;
            btnsomar.Text = "Somar";
            btnsomar.UseVisualStyleBackColor = true;
            // 
            // btnsubtrair
            // 
            btnsubtrair.Location = new Point(94, 71);
            btnsubtrair.Name = "btnsubtrair";
            btnsubtrair.Size = new Size(75, 23);
            btnsubtrair.TabIndex = 5;
            btnsubtrair.Text = "Subtrair";
            btnsubtrair.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(175, 71);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(75, 23);
            btnmultiplicar.TabIndex = 6;
            btnmultiplicar.Text = "Multiplicar";
            btnmultiplicar.UseVisualStyleBackColor = true;
            // 
            // btndividir
            // 
            btndividir.Location = new Point(256, 71);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(75, 23);
            btndividir.TabIndex = 7;
            btndividir.Text = "Dividir";
            btndividir.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(283, 28);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(23, 24);
            lbltotal.TabIndex = 8;
            lbltotal.Text = "0";
            lbltotal.Click += lbltotal_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 103);
            Controls.Add(lbltotal);
            Controls.Add(btndividir);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnsubtrair);
            Controls.Add(btnsomar);
            Controls.Add(txtnumero2);
            Controls.Add(lblnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(lblnumero);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private TextBox txtnumero1;
        private Label lblnumero2;
        private TextBox txtnumero2;
        private Button btnsomar;
        private Button btnsubtrair;
        private Button btnmultiplicar;
        private Button btndividir;
        private Label lbltotal;
    }
}
