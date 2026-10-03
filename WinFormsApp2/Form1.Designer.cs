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
            // button3 - 1
            // 
            button3.Location = new Point(25, 373);
            button3.Name = "button3";
            button3.Size = new Size(57, 32);
            button3.TabIndex = 5;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;

            // 
            // button4 - 2
            // 
            button4.Location = new Point(127, 373);
            button4.Name = "button4";
            button4.Size = new Size(57, 32);
            button4.TabIndex = 6;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;

            // 
            // button5 - 3
            // 
            button5.Location = new Point(234, 373);
            button5.Name = "button5";
            button5.Size = new Size(57, 32);
            button5.TabIndex = 7;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;

            // 
            // bntSuma
            // 
            bntSuma.Font = new Font(
                "Segoe UI",
                15.75F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

            bntSuma.Location = new Point(350, 156);
            bntSuma.Name = "bntSuma";
            bntSuma.Size = new Size(52, 40);
            bntSuma.TabIndex = 8;
            bntSuma.Text = "+";
            bntSuma.UseVisualStyleBackColor = true;

            // 
            // bntResta
            // 
            bntResta.Font = new Font(
                "Segoe UI",
                15.75F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

            bntResta.Location = new Point(350, 202);
            bntResta.Name = "bntResta";
            bntResta.Size = new Size(52, 40);
            bntResta.TabIndex = 9;
            bntResta.Text = "-";
            bntResta.UseVisualStyleBackColor = true;

            // 
            // bntMultiplicacion
            // 
            bntMultiplicacion.Font = new Font(
                "Segoe UI",
                15.75F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

            bntMultiplicacion.Location = new Point(350, 248);
            bntMultiplicacion.Name = "bntMultiplicacion";
            bntMultiplicacion.Size = new Size(52, 40);
            bntMultiplicacion.TabIndex = 10;
            bntMultiplicacion.Text = "x";
            bntMultiplicacion.UseVisualStyleBackColor = true;

            // 
            // bntDivicion
            // 
            bntDivicion.Font = new Font(
                "Segoe UI",
                15.75F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

            bntDivicion.Location = new Point(350, 294);
            bntDivicion.Name = "bntDivicion";
            bntDivicion.Size = new Size(52, 40);
            bntDivicion.TabIndex = 11;
            bntDivicion.Text = "/";
            bntDivicion.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Center;

            ClientSize = new Size(432, 481);

            // Tus controles
            Controls.Add(BTN_Cerrar);
            Controls.Add(BTN_Min);

            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);

            // Botones que conservamos de la otra rama
            Controls.Add(bntSuma);
            Controls.Add(bntResta);
            Controls.Add(bntMultiplicacion);
            Controls.Add(bntDivicion);

            FormBorderStyle = FormBorderStyle.None;
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
    }
}