namespace cantina_1._0
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lbltotal = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(95, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(153, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(568, 56);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 94);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(351, 74);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Adicionar \r\n\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(351, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = " Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(288, 327);
            button3.Name = "button3";
            button3.Size = new Size(202, 81);
            button3.TabIndex = 4;
            button3.Text = "Finalizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(364, 241);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(52, 25);
            lbltotal.TabIndex = 5;
            lbltotal.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 6;
            label1.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(605, 28);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 7;
            label2.Text = "Carrinho";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbltotal);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
