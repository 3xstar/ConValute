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
            lblXrp = new Label();
            lblEthereum = new Label();
            lblSolana = new Label();
            lblBitcoin = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            tbxConvertQuantity = new TextBox();
            cbxValute1 = new ComboBox();
            cbxValute2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            lblResult = new Label();
            label4 = new Label();
            label6 = new Label();
            btnConvert = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblOp = new Label();
            lblDoge = new Label();
            lblAvax = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblSui = new Label();
            pictureBox3 = new PictureBox();
            lblStatus = new Label();
            lblError = new Label();
            pictureBox7 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // lblXrp
            // 
            lblXrp.AutoSize = true;
            lblXrp.Dock = DockStyle.Fill;
            lblXrp.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblXrp.ForeColor = Color.White;
            lblXrp.Location = new Point(132, 418);
            lblXrp.Name = "lblXrp";
            lblXrp.Size = new Size(259, 125);
            lblXrp.TabIndex = 22;
            lblXrp.Text = "xrp";
            lblXrp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEthereum
            // 
            lblEthereum.AutoSize = true;
            lblEthereum.Dock = DockStyle.Fill;
            lblEthereum.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblEthereum.ForeColor = Color.White;
            lblEthereum.Location = new Point(132, 290);
            lblEthereum.Name = "lblEthereum";
            lblEthereum.Size = new Size(259, 128);
            lblEthereum.TabIndex = 21;
            lblEthereum.Text = "ethereum";
            lblEthereum.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSolana
            // 
            lblSolana.AutoSize = true;
            lblSolana.Dock = DockStyle.Fill;
            lblSolana.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblSolana.ForeColor = Color.White;
            lblSolana.Location = new Point(132, 166);
            lblSolana.Name = "lblSolana";
            lblSolana.Size = new Size(259, 124);
            lblSolana.TabIndex = 20;
            lblSolana.Text = "solana";
            lblSolana.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBitcoin
            // 
            lblBitcoin.AutoSize = true;
            lblBitcoin.Dock = DockStyle.Fill;
            lblBitcoin.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblBitcoin.ForeColor = Color.White;
            lblBitcoin.Location = new Point(132, 41);
            lblBitcoin.Name = "lblBitcoin";
            lblBitcoin.Size = new Size(259, 125);
            lblBitcoin.TabIndex = 19;
            lblBitcoin.Text = "bitcoin";
            lblBitcoin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Variable Display", 16F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 546);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 194);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Convertation";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8549213F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7979279F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.419689F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.150259F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.792746F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8549213F));
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(tbxConvertQuantity, 0, 1);
            tableLayoutPanel2.Controls.Add(cbxValute1, 1, 1);
            tableLayoutPanel2.Controls.Add(cbxValute2, 3, 1);
            tableLayoutPanel2.Controls.Add(label3, 4, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(lblResult, 5, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 32);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.38418F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 83.61582F));
            tableLayoutPanel2.Size = new Size(772, 159);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 26);
            label5.TabIndex = 7;
            label5.Text = "from Currency";
            // 
            // tbxConvertQuantity
            // 
            tbxConvertQuantity.Dock = DockStyle.Fill;
            tbxConvertQuantity.Location = new Point(3, 29);
            tbxConvertQuantity.Multiline = true;
            tbxConvertQuantity.Name = "tbxConvertQuantity";
            tbxConvertQuantity.Size = new Size(155, 127);
            tbxConvertQuantity.TabIndex = 0;
            // 
            // cbxValute1
            // 
            cbxValute1.Dock = DockStyle.Fill;
            cbxValute1.FormattingEnabled = true;
            cbxValute1.Items.AddRange(new object[] { "BITCOIN", "SOLANA", "ETHEREUM", "XRP", "SUI", "AVAX", "DOGE", "OP" });
            cbxValute1.Location = new Point(164, 29);
            cbxValute1.Name = "cbxValute1";
            cbxValute1.Size = new Size(170, 36);
            cbxValute1.TabIndex = 1;
            // 
            // cbxValute2
            // 
            cbxValute2.Dock = DockStyle.Fill;
            cbxValute2.FormattingEnabled = true;
            cbxValute2.Items.AddRange(new object[] { "BITCOIN", "SOLANA", "ETHEREUM", "XRP", "SUI", "AVAX", "DOGE", "OP" });
            cbxValute2.Location = new Point(405, 29);
            cbxValute2.Name = "cbxValute2";
            cbxValute2.Size = new Size(165, 36);
            cbxValute2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(576, 0);
            label3.Name = "label3";
            tableLayoutPanel2.SetRowSpan(label3, 2);
            label3.Size = new Size(31, 159);
            label3.TabIndex = 4;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.Location = new Point(340, 0);
            label2.Name = "label2";
            tableLayoutPanel2.SetRowSpan(label2, 2);
            label2.Size = new Size(59, 159);
            label2.TabIndex = 3;
            label2.Text = "IN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Dock = DockStyle.Fill;
            lblResult.Location = new Point(613, 0);
            lblResult.Name = "lblResult";
            tableLayoutPanel2.SetRowSpan(lblResult, 2);
            lblResult.Size = new Size(156, 159);
            lblResult.TabIndex = 5;
            lblResult.Text = "the result of the conversion";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 26);
            label4.TabIndex = 6;
            label4.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 26);
            label6.TabIndex = 8;
            label6.Text = "to Currency";
            // 
            // btnConvert
            // 
            tableLayoutPanel1.SetColumnSpan(btnConvert, 2);
            btnConvert.Dock = DockStyle.Fill;
            btnConvert.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Location = new Point(3, 795);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(388, 63);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert\U0001fa99";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.xrp;
            pictureBox4.Location = new Point(3, 421);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(123, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.ethereum;
            pictureBox2.Location = new Point(3, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.bitcoin;
            pictureBox1.Location = new Point(3, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            tableLayoutPanel1.SetColumnSpan(label1, 4);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Sitka Small Semibold", 25F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(778, 41);
            label1.TabIndex = 0;
            label1.Text = "ConValute";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.4540825F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.80102F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.5612249F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.05612F));
            tableLayoutPanel1.Controls.Add(lblOp, 3, 4);
            tableLayoutPanel1.Controls.Add(lblDoge, 3, 3);
            tableLayoutPanel1.Controls.Add(lblAvax, 3, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 4);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 5);
            tableLayoutPanel1.Controls.Add(lblBitcoin, 1, 1);
            tableLayoutPanel1.Controls.Add(lblSolana, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEthereum, 1, 3);
            tableLayoutPanel1.Controls.Add(lblXrp, 1, 4);
            tableLayoutPanel1.Controls.Add(pictureBox5, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox6, 2, 2);
            tableLayoutPanel1.Controls.Add(pictureBox8, 2, 4);
            tableLayoutPanel1.Controls.Add(lblSui, 3, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(btnConvert, 0, 7);
            tableLayoutPanel1.Controls.Add(lblStatus, 2, 7);
            tableLayoutPanel1.Controls.Add(lblError, 0, 6);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox7, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 16F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.176768F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7828283F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6565657F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1616154F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7828283F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.2525253F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21118F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(784, 861);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOp
            // 
            lblOp.AutoSize = true;
            lblOp.Dock = DockStyle.Fill;
            lblOp.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblOp.ForeColor = Color.White;
            lblOp.Location = new Point(519, 418);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(262, 125);
            lblOp.TabIndex = 31;
            lblOp.Text = "op";
            lblOp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDoge
            // 
            lblDoge.AutoSize = true;
            lblDoge.Dock = DockStyle.Fill;
            lblDoge.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblDoge.ForeColor = Color.White;
            lblDoge.Location = new Point(519, 290);
            lblDoge.Name = "lblDoge";
            lblDoge.Size = new Size(262, 128);
            lblDoge.TabIndex = 30;
            lblDoge.Text = "doge";
            lblDoge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAvax
            // 
            lblAvax.AutoSize = true;
            lblAvax.Dock = DockStyle.Fill;
            lblAvax.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblAvax.ForeColor = Color.White;
            lblAvax.Location = new Point(519, 166);
            lblAvax.Name = "lblAvax";
            lblAvax.Size = new Size(262, 124);
            lblAvax.TabIndex = 29;
            lblAvax.Text = "avax";
            lblAvax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.sui;
            pictureBox5.Location = new Point(397, 44);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(116, 119);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Properties.Resources.apax;
            pictureBox6.Location = new Point(397, 169);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(116, 118);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Image = Properties.Resources.op;
            pictureBox8.Location = new Point(397, 421);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(116, 119);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            // 
            // lblSui
            // 
            lblSui.AutoSize = true;
            lblSui.Dock = DockStyle.Fill;
            lblSui.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            lblSui.ForeColor = Color.White;
            lblSui.Location = new Point(519, 41);
            lblSui.Name = "lblSui";
            lblSui.Size = new Size(262, 125);
            lblSui.TabIndex = 28;
            lblSui.Text = "sui";
            lblSui.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.solana;
            pictureBox3.Location = new Point(3, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(123, 118);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblStatus, 2);
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(397, 792);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(384, 69);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Black;
            tableLayoutPanel1.SetColumnSpan(lblError, 4);
            lblError.Dock = DockStyle.Fill;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblError.ForeColor = Color.FromArgb(192, 0, 0);
            lblError.Location = new Point(3, 743);
            lblError.Name = "lblError";
            lblError.Size = new Size(778, 49);
            lblError.TabIndex = 33;
            lblError.Text = "error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Image = Properties.Resources.doge1;
            pictureBox7.Location = new Point(397, 293);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(116, 122);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 34;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 861);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblXrp;
        private Label lblEthereum;
        private Label lblSolana;
        private Label lblBitcoin;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button btnConvert;
        private TextBox textBox2;
        private TextBox tbxConvert1;
        private Label lblStatus;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private Label lblSui;
        private Label lblOp;
        private Label lblDoge;
        private Label lblAvax;
        private PictureBox pictureBox3;
        private TextBox tbxConvert2;
        private Label lblError;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbxConvertQuantity;
        private ComboBox cbxValute1;
        private ComboBox cbxValute2;
        private Label label2;
        private Label lblResult;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox7;
    }
}
