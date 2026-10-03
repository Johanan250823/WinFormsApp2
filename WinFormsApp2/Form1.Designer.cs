namespace WinFormsApp2
{
    partial class Form1
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
            bntSuma = new Button();
            groupBox1 = new GroupBox();
            bntDivicion = new Button();
            bntMultiplicacion = new Button();
            bntResta = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bntSuma
            // 
            bntSuma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntSuma.Location = new Point(223, 156);
            bntSuma.Name = "bntSuma";
            bntSuma.Size = new Size(52, 40);
            bntSuma.TabIndex = 0;
            bntSuma.Text = "+";
            bntSuma.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(bntDivicion);
            groupBox1.Controls.Add(bntMultiplicacion);
            groupBox1.Controls.Add(bntResta);
            groupBox1.Controls.Add(bntSuma);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 415);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // bntDivicion
            // 
            bntDivicion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntDivicion.Location = new Point(223, 294);
            bntDivicion.Name = "bntDivicion";
            bntDivicion.Size = new Size(52, 40);
            bntDivicion.TabIndex = 3;
            bntDivicion.Text = "/";
            bntDivicion.UseVisualStyleBackColor = true;
            // 
            // bntMultiplicacion
            // 
            bntMultiplicacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntMultiplicacion.Location = new Point(223, 248);
            bntMultiplicacion.Name = "bntMultiplicacion";
            bntMultiplicacion.Size = new Size(52, 40);
            bntMultiplicacion.TabIndex = 2;
            bntMultiplicacion.Text = "x";
            bntMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // bntResta
            // 
            bntResta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntResta.Location = new Point(223, 202);
            bntResta.Name = "bntResta";
            bntResta.Size = new Size(52, 40);
            bntResta.TabIndex = 1;
            bntResta.Text = "-";
            bntResta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 412);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bntSuma;
        private GroupBox groupBox1;
        private Button bntDivicion;
        private Button bntMultiplicacion;
        private Button bntResta;
    }
}
