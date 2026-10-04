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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            bntSuma = new Button();
            bntResta = new Button();
            bntMultiplicacion = new Button();
            bntDivicion = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BTN_Cerrar
            // 
            BTN_Cerrar.BackColor = Color.Red;
            BTN_Cerrar.Location = new Point(389, 0);
            BTN_Cerrar.Margin = new Padding(3, 4, 3, 4);
            BTN_Cerrar.Name = "BTN_Cerrar";
            BTN_Cerrar.Size = new Size(34, 28);
            BTN_Cerrar.TabIndex = 3;
            BTN_Cerrar.Text = "X";
            BTN_Cerrar.UseVisualStyleBackColor = false;
            BTN_Cerrar.Click += BTN_Cerrar_Click;
            // 
            // BTN_Min
            // 
            BTN_Min.BackColor = Color.DodgerBlue;
            BTN_Min.Location = new Point(354, 0);
            BTN_Min.Margin = new Padding(3, 4, 3, 4);
            BTN_Min.Name = "BTN_Min";
            BTN_Min.Size = new Size(34, 28);
            BTN_Min.TabIndex = 4;
            BTN_Min.Text = "-";
            BTN_Min.UseVisualStyleBackColor = false;
            BTN_Min.Click += BTN_Min_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 109);
            button1.Name = "button1";
            button1.Size = new Size(64, 33);
            button1.TabIndex = 5;
            button1.Text = "4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 109);
            button2.Name = "button2";
            button2.Size = new Size(62, 33);
            button2.TabIndex = 6;
            button2.Text = "5";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(196, 109);
            button3.Name = "button3";
            button3.Size = new Size(55, 33);
            button3.TabIndex = 7;
            button3.Text = "6";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnNumero1
            // 
            btnNumero1.Location = new Point(31, 163);
            btnNumero1.Name = "btnNumero1";
            btnNumero1.Size = new Size(64, 33);
            btnNumero1.TabIndex = 2;
            btnNumero1.Text = "1";
            btnNumero1.UseVisualStyleBackColor = true;
            // 
            // btnNumero2
            // 
            btnNumero2.Location = new Point(112, 163);
            btnNumero2.Name = "btnNumero2";
            btnNumero2.Size = new Size(62, 33);
            btnNumero2.TabIndex = 3;
            btnNumero2.Text = "2";
            btnNumero2.UseVisualStyleBackColor = true;
            // 
            // btnNumero3
            // 
            btnNumero3.Location = new Point(196, 163);
            btnNumero3.Name = "btnNumero3";
            btnNumero3.Size = new Size(55, 33);
            btnNumero3.TabIndex = 4;
            btnNumero3.Text = "3";
            btnNumero3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(31, 55);
            button7.Name = "button7";
            button7.Size = new Size(64, 33);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(112, 55);
            button8.Name = "button8";
            button8.Size = new Size(62, 33);
            button8.TabIndex = 13;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(196, 55);
            button9.Name = "button9";
            button9.Size = new Size(55, 33);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnNumero1);
            groupBox1.Controls.Add(btnNumero2);
            groupBox1.Controls.Add(btnNumero3);
            groupBox1.Location = new Point(10, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 257);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bntSuma);
            groupBox2.Controls.Add(bntResta);
            groupBox2.Controls.Add(bntMultiplicacion);
            groupBox2.Controls.Add(bntDivicion);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(312, 197);
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
            ClientSize = new Size(423, 481);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BTN_Min);
            Controls.Add(BTN_Cerrar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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

        // 4, 5 y 6
        private Button button1;
        private Button button2;
        private Button button3;

        // 1, 2 y 3
        private Button btnNumero1;
        private Button btnNumero2;
        private Button btnNumero3;

        // 7, 8 y 9
        private Button button7;
        private Button button8;
        private Button button9;

        // Operaciones
        private Button bntSuma;
        private Button bntResta;
        private Button bntMultiplicacion;
        private Button bntDivicion;

        // =
        private Button button4;

        // Contenedores
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}