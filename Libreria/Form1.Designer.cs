namespace Libreria
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 88);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Genero usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 130);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(84, 301);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(209, 301);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(86, 114);
            label5.Name = "label5";
            label5.Size = new Size(174, 17);
            label5.TabIndex = 9;
            label5.Text = "Resgistro de venta de libro";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 145);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "Titulo";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(266, 190);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(84, 3);
            label7.Name = "label7";
            label7.Size = new Size(116, 17);
            label7.TabIndex = 12;
            label7.Text = "Resgistro Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 181);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 13;
            label8.Text = "Tipo de genero";
            label8.Click += label8_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(358, 23);
            textBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(188, 173);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(131, 23);
            comboBox2.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(269, 224);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 16;
            label9.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 219);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 17;
            label10.Text = "Cantidad";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(315, 216);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(81, 23);
            textBox5.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registro de ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private Label label9;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}