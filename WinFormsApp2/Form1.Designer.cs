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
<<<<<<< HEAD
            BTN_Cerrar = new Button();
            BTN_Min = new Button();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();

            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();

=======
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
>>>>>>> Fabricio
            groupBox1.SuspendLayout();
            SuspendLayout();

            // 
<<<<<<< HEAD
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
=======
>>>>>>> Fabricio
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(25, 183);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(380, 270);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
<<<<<<< HEAD
            groupBox1.Text = "groupBox1";

            // 
            // button1
            // 
            button1.Location = new Point(20, 85);
            button1.Name = "button1";
            button1.Size = new Size(110, 33);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;

            // 
            // button2
            // 
            button2.Location = new Point(151, 85);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(110, 33);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;

            // 
            // button3
            // 
            button3.Location = new Point(18, 206);
            button3.Name = "button3";
            button3.Size = new Size(80, 29);
            button3.TabIndex = 2;
            button3.Text = "Oblitas";
            button3.UseVisualStyleBackColor = true;

            // 
            // button4
            // 
            button4.Location = new Point(130, 206);
            button4.Name = "button4";
            button4.Size = new Size(76, 29);
            button4.TabIndex = 3;
            button4.Text = "Rengifo";
            button4.UseVisualStyleBackColor = true;

=======
>>>>>>> Fabricio
            // 
            // button5
            // 
            button5.Location = new Point(239, 206);
            button5.Name = "button5";
            button5.Size = new Size(79, 29);
            button5.TabIndex = 4;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;

            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(25, 57);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(380, 117);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";

            // 
            // button4
            // 
            button4.Location = new Point(130, 206);
            button4.Name = "button4";
            button4.Size = new Size(76, 29);
            button4.TabIndex = 3;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(18, 206);
            button3.Name = "button3";
            button3.Size = new Size(80, 29);
            button3.TabIndex = 2;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(432, 481);

            Controls.Add(groupBox2);
=======
            ClientSize = new Size(494, 600);
>>>>>>> Fabricio
            Controls.Add(groupBox1);
            Controls.Add(BTN_Min);
            Controls.Add(BTN_Cerrar);

            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";

            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
<<<<<<< HEAD

        private Button BTN_Cerrar;
        private Button BTN_Min;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button button1;
        private Button button2;
=======
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
>>>>>>> Fabricio
        private Button button3;
        private Button button4;
        private Button button5;
    }
}