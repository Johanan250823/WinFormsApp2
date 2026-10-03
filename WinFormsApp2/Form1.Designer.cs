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
            button_demas = new Button();
            button_menos = new Button();
            button_multipli = new Button();
            SuspendLayout();
            // 
            // button_demas
            // 
            button_demas.BackColor = SystemColors.ActiveCaption;
            button_demas.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_demas.Location = new Point(158, 142);
            button_demas.Name = "button_demas";
            button_demas.Size = new Size(66, 48);
            button_demas.TabIndex = 0;
            button_demas.Text = "+";
            button_demas.UseVisualStyleBackColor = false;
            // 
            // button_menos
            // 
            button_menos.BackColor = SystemColors.ActiveCaption;
            button_menos.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_menos.Location = new Point(230, 142);
            button_menos.Name = "button_menos";
            button_menos.Size = new Size(66, 48);
            button_menos.TabIndex = 1;
            button_menos.Text = "-";
            button_menos.UseVisualStyleBackColor = false;
            // 
            // button_multipli
            // 
            button_multipli.BackColor = SystemColors.ActiveCaption;
            button_multipli.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_multipli.Location = new Point(302, 142);
            button_multipli.Name = "button_multipli";
            button_multipli.Size = new Size(66, 48);
            button_multipli.TabIndex = 2;
            button_multipli.Text = "*";
            button_multipli.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_multipli);
            Controls.Add(button_menos);
            Controls.Add(button_demas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_demas;
        private Button button_menos;
        private Button button_multipli;
    }
}
