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
            groupBox1 = new GroupBox();
            btnNumero1 = new Button();
            btnNumero2 = new Button();
            btnNumero3 = new Button();
            groupBox1.SuspendLayout();
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
            button1.Location = new Point(19, 124);
            button1.Name = "button1";
            button1.Size = new Size(60, 34);
            button1.TabIndex = 5;
            button1.Text = "4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(97, 124);
            button2.Name = "button2";
            button2.Size = new Size(58, 34);
            button2.TabIndex = 6;
            button2.Text = "5";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(184, 124);
            button3.Name = "button3";
            button3.Size = new Size(51, 34);
            button3.TabIndex = 7;
            button3.Text = "6";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNumero1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnNumero2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnNumero3);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 257);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnNumero1
            // 
            btnNumero1.Location = new Point(19, 178);
            btnNumero1.Name = "btnNumero1";
            btnNumero1.Size = new Size(60, 29);
            btnNumero1.TabIndex = 2;
            btnNumero1.Text = "1";
            btnNumero1.UseVisualStyleBackColor = true;
            // 
            // btnNumero2
            // 
            btnNumero2.Location = new Point(97, 178);
            btnNumero2.Name = "btnNumero2";
            btnNumero2.Size = new Size(58, 29);
            btnNumero2.TabIndex = 3;
            btnNumero2.Text = "2";
            btnNumero2.UseVisualStyleBackColor = true;
            // 
            // btnNumero3
            // 
            btnNumero3.Location = new Point(184, 178);
            btnNumero3.Name = "btnNumero3";
            btnNumero3.Size = new Size(51, 29);
            btnNumero3.TabIndex = 4;
            btnNumero3.Text = "3";
            btnNumero3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(432, 481);
            Controls.Add(groupBox1);
            Controls.Add(BTN_Min);
            Controls.Add(BTN_Cerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Button btnNumero1;
        private Button btnNumero2;
        private Button btnNumero3;
    }
}