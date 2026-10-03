namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            BTN_Cerrar = new Button();
            BTN_Min = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnNumero1 = new Button();
            btnNumero2 = new Button();
            btnNumero3 = new Button();
            bntSuma = new Button();
            bntResta = new Button();
            bntMultiplicacion = new Button();
            bntDivicion = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BTN_Cerrar
            // 
            BTN_Cerrar.BackColor = Color.Red;
            BTN_Cerrar.Location = new Point(402, 0);
            BTN_Cerrar.Name = "BTN_Cerrar";
            BTN_Cerrar.Size = new Size(30, 21);
            BTN_Cerrar.TabIndex = 3;
            BTN_Cerrar.Text = "X";
            BTN_Cerrar.UseVisualStyleBackColor = false;
            BTN_Cerrar.Click += BTN_Cerrar_Click;
            // 
            // BTN_Min
            // 
            BTN_Min.BackColor = Color.DodgerBlue;
            BTN_Min.Location = new Point(371, 0);
            BTN_Min.Name = "BTN_Min";
            BTN_Min.Size = new Size(30, 21);
            BTN_Min.TabIndex = 4;
            BTN_Min.Text = "-";
            BTN_Min.UseVisualStyleBackColor = false;
            BTN_Min.Click += BTN_Min_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 138);
            button1.Name = "button1";
            button1.Size = new Size(60, 34);
            button1.TabIndex = 5;
            button1.Text = "4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 138);
            button2.Name = "button2";
            button2.Size = new Size(58, 34);
            button2.TabIndex = 6;
            button2.Text = "5";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(204, 138);
            button3.Name = "button3";
            button3.Size = new Size(51, 34);
            button3.TabIndex = 7;
            button3.Text = "6";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnNumero1
            // 
            btnNumero1.Location = new Point(39, 192);
            btnNumero1.Name = "btnNumero1";
            btnNumero1.Size = new Size(60, 29);
            btnNumero1.TabIndex = 2;
            btnNumero1.Text = "1";
            btnNumero1.UseVisualStyleBackColor = true;
            // 
            // btnNumero2
            // 
            btnNumero2.Location = new Point(117, 192);
            btnNumero2.Name = "btnNumero2";
            btnNumero2.Size = new Size(58, 29);
            btnNumero2.TabIndex = 3;
            btnNumero2.Text = "2";
            btnNumero2.UseVisualStyleBackColor = true;
            // 
            // btnNumero3
            // 
            btnNumero3.Location = new Point(204, 192);
            btnNumero3.Name = "btnNumero3";
            btnNumero3.Size = new Size(51, 29);
            btnNumero3.TabIndex = 4;
            btnNumero3.Text = "3";
            btnNumero3.UseVisualStyleBackColor = true;
            // 
            // bntSuma
            // 
            bntSuma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntSuma.Location = new Point(17, 18);
            bntSuma.Name = "bntSuma";
            bntSuma.Size = new Size(52, 40);
            bntSuma.TabIndex = 8;
            bntSuma.Text = "+";
            bntSuma.UseVisualStyleBackColor = true;
            // 
            // bntResta
            // 
            bntResta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntResta.Location = new Point(17, 64);
            bntResta.Name = "bntResta";
            bntResta.Size = new Size(52, 40);
            bntResta.TabIndex = 9;
            bntResta.Text = "-";
            bntResta.UseVisualStyleBackColor = true;
            // 
            // bntMultiplicacion
            // 
            bntMultiplicacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntMultiplicacion.Location = new Point(17, 110);
            bntMultiplicacion.Name = "bntMultiplicacion";
            bntMultiplicacion.Size = new Size(52, 40);
            bntMultiplicacion.TabIndex = 10;
            bntMultiplicacion.Text = "x";
            bntMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // bntDivicion
            // 
            bntDivicion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntDivicion.Location = new Point(17, 156);
            bntDivicion.Name = "bntDivicion";
            bntDivicion.Size = new Size(52, 40);
            bntDivicion.TabIndex = 11;
            bntDivicion.Text = "/";
            bntDivicion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNumero1);
            groupBox1.Controls.Add(btnNumero2);
            groupBox1.Controls.Add(btnNumero3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(12, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 257);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(17, 202);
            button4.Name = "button4";
            button4.Size = new Size(52, 40);
            button4.TabIndex = 12;
            button4.Text = "=";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bntDivicion);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(bntSuma);
            groupBox2.Controls.Add(bntResta);
            groupBox2.Controls.Add(bntMultiplicacion);
            groupBox2.Location = new Point(314, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(87, 257);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(432, 550);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BTN_Min);
            Controls.Add(BTN_Cerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Cerrar;
        private Button BTN_Min;

        // Números 4, 5 y 6
        private Button button1;
        private Button button2;
        private Button button3;

        // Números 1, 2 y 3
        private Button btnNumero1;
        private Button btnNumero2;
        private Button btnNumero3;

        private GroupBox groupBox1;

        // Operaciones de Jefferson
        private Button bntSuma;
        private Button bntResta;
        private Button bntMultiplicacion;
        private Button bntDivicion;
        private Button button4;
        private GroupBox groupBox2;
    }
}