namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            Name = new TextBox();
            StudentID = new TextBox();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Promedio = new Label();
            txtresult = new Label();
            veredicto = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1 = new Panel();
            PicImagen = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImagen).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(354, 398);
            button2.Name = "button2";
            button2.Size = new Size(124, 39);
            button2.TabIndex = 5;
            button2.Text = "PROMEDIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(103, 349);
            button1.Name = "button1";
            button1.Size = new Size(46, 44);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(602, 398);
            button3.Name = "button3";
            button3.Size = new Size(71, 39);
            button3.TabIndex = 6;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(485, 398);
            button4.Name = "button4";
            button4.Size = new Size(98, 39);
            button4.TabIndex = 7;
            button4.Text = "CRÉDITOS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Name
            // 
            Name.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Name.Location = new Point(496, 81);
            Name.Name = "Name";
            Name.Size = new Size(100, 24);
            Name.TabIndex = 8;
            // 
            // StudentID
            // 
            StudentID.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            StudentID.Location = new Point(496, 124);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(100, 24);
            StudentID.TabIndex = 9;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtNum1.Location = new Point(476, 260);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(30, 24);
            txtNum1.TabIndex = 10;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtNum2.Location = new Point(524, 260);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(32, 24);
            txtNum2.TabIndex = 11;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            txtNum2.TextChanged += textBox4_TextChanged;
            // 
            // txtNum3
            // 
            txtNum3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtNum3.Location = new Point(573, 260);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(29, 24);
            txtNum3.TabIndex = 12;
            txtNum3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(378, 81);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 13;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(370, 128);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 14;
            label2.Text = "MATRICULA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(316, 234);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 15;
            label3.Text = "calificaciones:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(470, 233);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 16;
            label4.Text = "1ER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(516, 233);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 17;
            label5.Text = "2DO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(565, 233);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 18;
            label6.Text = "3ER";
            // 
            // Promedio
            // 
            Promedio.AutoSize = true;
            Promedio.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Promedio.Location = new Point(316, 349);
            Promedio.Name = "Promedio";
            Promedio.Size = new Size(102, 20);
            Promedio.TabIndex = 19;
            Promedio.Text = "PROMEDIO:";
            // 
            // txtresult
            // 
            txtresult.AutoSize = true;
            txtresult.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtresult.Location = new Point(424, 349);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(18, 20);
            txtresult.TabIndex = 20;
            txtresult.Text = "0";
            // 
            // veredicto
            // 
            veredicto.AutoSize = true;
            veredicto.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            veredicto.Location = new Point(523, 349);
            veredicto.Name = "veredicto";
            veredicto.Size = new Size(79, 20);
            veredicto.TabIndex = 22;
            veredicto.Text = "----------";
            veredicto.Click += label10_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(PicImagen);
            panel1.Location = new Point(9, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 320);
            panel1.TabIndex = 23;
            // 
            // PicImagen
            // 
            PicImagen.BackgroundImageLayout = ImageLayout.Stretch;
            PicImagen.Location = new Point(3, 3);
            PicImagen.Name = "PicImagen";
            PicImagen.Size = new Size(238, 314);
            PicImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            PicImagen.TabIndex = 0;
            PicImagen.TabStop = false;
            PicImagen.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(67, 398);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 24;
            label7.Text = "SUBIR IMAGEN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 459);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(veredicto);
            Controls.Add(txtresult);
            Controls.Add(Promedio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(StudentID);
            Controls.Add(Name);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            this.Text = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox Name;
        private TextBox StudentID;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label Promedio;
        private Label txtresult;
        private Label veredicto;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel1;
        private PictureBox PicImagen;
        private Label label7;
    }
}