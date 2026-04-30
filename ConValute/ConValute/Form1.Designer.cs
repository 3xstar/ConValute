namespace ConValute
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblXrp = new Label();
            lblBitcoin = new Label();
            lblSolana = new Label();
            lblEtherium = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lblEtherium, 2, 3);
            tableLayoutPanel1.Controls.Add(lblSolana, 2, 2);
            tableLayoutPanel1.Controls.Add(lblBitcoin, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(button1, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(lblXrp, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 16F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.8823514F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6991863F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1184673F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.81533F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0023232F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4018583F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.88235331F));
            tableLayoutPanel1.Size = new Size(484, 861);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            tableLayoutPanel1.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Emoji", 25F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(478, 50);
            label1.TabIndex = 0;
            label1.Text = "ConValute";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.bitcoin;
            pictureBox1.Location = new Point(3, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.ethereum;
            pictureBox2.Location = new Point(3, 370);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.solana;
            pictureBox3.Location = new Point(3, 214);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.xrp;
            pictureBox4.Location = new Point(3, 532);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(155, 149);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(comboBox2, 3, 0);
            tableLayoutPanel2.Controls.Add(label6, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 687);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(478, 118);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(89, 38);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(288, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(89, 38);
            comboBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 45F);
            label6.Location = new Point(193, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 118);
            label6.TabIndex = 2;
            label6.Text = "in";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 3);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 811);
            button1.Name = "button1";
            button1.Size = new Size(478, 47);
            button1.TabIndex = 6;
            button1.Text = "Convertation\r\n";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label2.Location = new Point(164, 50);
            label2.Name = "label2";
            label2.Size = new Size(155, 161);
            label2.TabIndex = 7;
            label2.Text = "BITCOIN =";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold);
            label3.Location = new Point(164, 211);
            label3.Name = "label3";
            label3.Size = new Size(155, 156);
            label3.TabIndex = 8;
            label3.Text = "SOLANA =";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label4.Location = new Point(164, 367);
            label4.Name = "label4";
            label4.Size = new Size(155, 162);
            label4.TabIndex = 9;
            label4.Text = "ETHERIUM =";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Bold);
            label5.Location = new Point(164, 529);
            label5.Name = "label5";
            label5.Size = new Size(155, 155);
            label5.TabIndex = 10;
            label5.Text = "XRP =";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblXrp
            // 
            lblXrp.AutoSize = true;
            lblXrp.Dock = DockStyle.Fill;
            lblXrp.Location = new Point(325, 529);
            lblXrp.Name = "lblXrp";
            lblXrp.Size = new Size(156, 155);
            lblXrp.TabIndex = 14;
            lblXrp.Text = "label10";
            lblXrp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBitcoin
            // 
            lblBitcoin.AutoSize = true;
            lblBitcoin.Dock = DockStyle.Fill;
            lblBitcoin.Location = new Point(325, 50);
            lblBitcoin.Name = "lblBitcoin";
            lblBitcoin.Size = new Size(156, 161);
            lblBitcoin.TabIndex = 15;
            lblBitcoin.Text = "label10";
            lblBitcoin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSolana
            // 
            lblSolana.AutoSize = true;
            lblSolana.Dock = DockStyle.Fill;
            lblSolana.Location = new Point(325, 211);
            lblSolana.Name = "lblSolana";
            lblSolana.Size = new Size(156, 156);
            lblSolana.TabIndex = 16;
            lblSolana.Text = "label10";
            lblSolana.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEtherium
            // 
            lblEtherium.AutoSize = true;
            lblEtherium.Dock = DockStyle.Fill;
            lblEtherium.Location = new Point(325, 367);
            lblEtherium.Name = "lblEtherium";
            lblEtherium.Size = new Size(156, 162);
            lblEtherium.TabIndex = 17;
            lblEtherium.Text = "label10";
            lblEtherium.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 861);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblXrp;
        private Label lblEtherium;
        private Label lblSolana;
        private Label lblBitcoin;
    }
}
