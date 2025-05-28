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
            listBalcao = new ListBox();
            listPronto = new ListBox();
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
            listBalcao.Location = new Point(27, 165);
            listBalcao.Name = "listBalcao";
            listBalcao.Size = new Size(249, 184);
            listBalcao.TabIndex = 1;
            listBalcao.SelectedIndexChanged += listBalcao_SelectedIndexChanged;
            // 
            // listPronto
            // 
            listPronto.FormattingEnabled = true;
            listPronto.ItemHeight = 15;
            listPronto.Location = new Point(416, 165);
            listPronto.Name = "listPronto";
            listPronto.Size = new Size(249, 184);
            listPronto.TabIndex = 2;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(listPronto);
            Controls.Add(listBalcao);
            Controls.Add(pictureBox1);
            Name = "Balcao";
            Text = "balcao";
            Load += balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBalcao;
        private ListBox listPronto;
    }
}