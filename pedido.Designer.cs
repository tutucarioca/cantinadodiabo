namespace cantina_1._0
{
    partial class pedido
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lbltotal = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            numericQuant = new NumericUpDown();
            listBox3 = new ListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuant).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(225, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 154);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(555, 56);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(199, 154);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(458, 87);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Adicionar \r\n\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 255, 0);
            button2.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(458, 130);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = " Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Agrandir Narrow", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(552, 364);
            button3.Name = "button3";
            button3.Size = new Size(202, 48);
            button3.TabIndex = 4;
            button3.Text = "Finalizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = Color.FromArgb(230, 255, 0);
            lbltotal.CausesValidation = false;
            lbltotal.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(469, 230);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(49, 25);
            lbltotal.TabIndex = 5;
            lbltotal.Text = "Total";
            lbltotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(278, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 6;
            label1.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(605, 28);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 7;
            label2.Text = "Pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(61, 418);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(61, 389);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_14_085343;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 109);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // numericQuant
            // 
            numericQuant.Location = new Point(479, 187);
            numericQuant.Name = "numericQuant";
            numericQuant.Size = new Size(39, 23);
            numericQuant.TabIndex = 11;
            numericQuant.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(235, 56);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(199, 154);
            listBox3.TabIndex = 12;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(52, 281);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 13;
            label3.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(203, 281);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 16;
            label4.Text = "Método";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(184, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Agrandir Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(458, 168);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 20;
            label6.Text = "Quantidade";
            label6.Click += label6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(621, 338);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 20);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Viagem";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(230, 255, 0);
            button4.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(319, 389);
            button4.Name = "button4";
            button4.Size = new Size(181, 49);
            button4.TabIndex = 22;
            button4.Text = "Mandar para o balcão";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(numericQuant);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbltotal);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(pictureBox1);
            Name = "pedido";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lbltotal;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox1;
        private NumericUpDown numericQuant;
        private ListBox listBox3;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private CheckBox checkBox1;
        private Button button4;
    }
}
