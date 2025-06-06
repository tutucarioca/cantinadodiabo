namespace cantina_1._0
{
    partial class Balcao
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
            listBalcao = new System.Windows.Forms.ListBox();
            listPronto = new System.Windows.Forms.ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_14_085343;
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // listBalcao
            // 
            listBalcao.FormattingEnabled = true;
            listBalcao.ItemHeight = 15;
            listBalcao.Location = new Point(30, 174);
            listBalcao.Name = "listBalcao";
            listBalcao.Size = new Size(249, 184);
            listBalcao.TabIndex = 1;
            listBalcao.SelectedIndexChanged += listBalcao_SelectedIndexChanged;
            // 
            // listPronto
            // 
            listPronto.FormattingEnabled = true;
            listPronto.ItemHeight = 15;
            listPronto.Location = new Point(444, 174);
            listPronto.Name = "listPronto";
            listPronto.Size = new Size(249, 184);
            listPronto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(101, 146);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 3;
            label1.Text = "Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(522, 146);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Entregues";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(272, 394);
            button1.Name = "button1";
            button1.Size = new Size(229, 44);
            button1.TabIndex = 5;
            button1.Text = "Entregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listPronto);
            Controls.Add(listBalcao);
            Controls.Add(pictureBox1);
            Name = "Balcao";
            Text = "balcao";
            Load += balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBalcao;
        private System.Windows.Forms.ListBox listPronto;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}