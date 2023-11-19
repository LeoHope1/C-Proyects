namespace WinFormsApp1
{
    partial class Creditos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Belcast;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(311, 21);
            label1.Name = "label1";
            label1.Size = new Size(111, 27);
            label1.TabIndex = 1;
            label1.Text = "créditos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(271, 75);
            label2.Name = "label2";
            label2.Size = new Size(213, 23);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE DEL ALUMNO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(311, 153);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 3;
            label3.Text = "MATRÍCULA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(295, 222);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 4;
            label4.Text = "ESPECIALIDAD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(287, 98);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 5;
            label5.Text = "Leonardo Ramírez";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(324, 176);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 6;
            label6.Text = "203298";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(344, 245);
            label7.Name = "label7";
            label7.Size = new Size(40, 25);
            label7.TabIndex = 7;
            label7.Text = "FM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(295, 314);
            label8.Name = "label8";
            label8.Size = new Size(156, 25);
            label8.TabIndex = 8;
            label8.Text = "17 de Nov 2023";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(327, 291);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 9;
            label9.Text = "FECHA:";
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 381);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Creditos";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}