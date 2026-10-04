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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            bntSuma = new Button();
            bntResta = new Button();
            bntMultiplicacion = new Button();
            bntDivicion = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();

            // BTN_Cerrar
            BTN_Cerrar.BackColor = Color.Red;
            BTN_Cerrar.Location = new Point(459, 0);
            BTN_Cerrar.Margin = new Padding(3, 4, 3, 4);
            BTN_Cerrar.Name = "BTN_Cerrar";
            BTN_Cerrar.Size = new Size(34, 28);
            BTN_Cerrar.TabIndex = 3;
            BTN_Cerrar.Text = "X";
            BTN_Cerrar.UseVisualStyleBackColor = false;
            BTN_Cerrar.Click += BTN_Cerrar_Click;

            // BTN_Min
            BTN_Min.BackColor = Color.DodgerBlue;
            BTN_Min.Location = new Point(424, 0);
            BTN_Min.Margin = new Padding(3, 4, 3, 4);
            BTN_Min.Name = "BTN_Min";
            BTN_Min.Size = new Size(34, 28);
            BTN_Min.TabIndex = 4;
            BTN_Min.Text = "-";
            BTN_Min.UseVisualStyleBackColor = false;
            BTN_Min.Click += BTN_Min_Click;

            // button3
            button3.Location = new Point(29, 208);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(65, 43);
            button3.TabIndex = 5;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;

            // button4
            button4.Location = new Point(145, 208);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(65, 43);
            button4.TabIndex = 6;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;

            // button5
            button5.Location = new Point(267, 208);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(65, 43);
            button5.TabIndex = 7;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;

            // bntSuma
            bntSuma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntSuma.Location = new Point(400, 208);
            bntSuma.Margin = new Padding(3, 4, 3, 4);
            bntSuma.Name = "bntSuma";
            bntSuma.Size = new Size(59, 53);
            bntSuma.TabIndex = 8;
            bntSuma.Text = "+";
            bntSuma.UseVisualStyleBackColor = true;

            // bntResta
            bntResta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntResta.Location = new Point(400, 269);
            bntResta.Margin = new Padding(3, 4, 3, 4);
            bntResta.Name = "bntResta";
            bntResta.Size = new Size(59, 53);
            bntResta.TabIndex = 9;
            bntResta.Text = "-";
            bntResta.UseVisualStyleBackColor = true;

            // bntMultiplicacion
            bntMultiplicacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntMultiplicacion.Location = new Point(400, 331);
            bntMultiplicacion.Margin = new Padding(3, 4, 3, 4);
            bntMultiplicacion.Name = "bntMultiplicacion";
            bntMultiplicacion.Size = new Size(59, 53);
            bntMultiplicacion.TabIndex = 10;
            bntMultiplicacion.Text = "x";
            bntMultiplicacion.UseVisualStyleBackColor = true;

            // bntDivicion
            bntDivicion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntDivicion.Location = new Point(400, 392);
            bntDivicion.Margin = new Padding(3, 4, 3, 4);
            bntDivicion.Name = "bntDivicion";
            bntDivicion.Size = new Size(59, 53);
            bntDivicion.TabIndex = 11;
            bntDivicion.Text = "/";
            bntDivicion.UseVisualStyleBackColor = true;

            // button7
            button7.Location = new Point(29, 401);
            button7.Name = "button7";
            button7.Size = new Size(65, 44);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;

            // button8
            button8.Location = new Point(145, 401);
            button8.Name = "button8";
            button8.Size = new Size(65, 44);
            button8.TabIndex = 13;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;

            // button9
            button9.Location = new Point(267, 401);
            button9.Name = "button9";
            button9.Size = new Size(65, 44);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(494, 641);

            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(BTN_Cerrar);
            Controls.Add(BTN_Min);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(bntSuma);
            Controls.Add(bntResta);
            Controls.Add(bntMultiplicacion);
            Controls.Add(bntDivicion);

            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Cerrar;
        private Button BTN_Min;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button bntSuma;
        private Button bntResta;
        private Button bntMultiplicacion;
        private Button bntDivicion;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}