namespace EF_Diyet_UI
{
    partial class frm_DiyetListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DiyetListe));
            comboBox1 = new ComboBox();
            gbKahvaltı = new GroupBox();
            btnCikarKahvalti = new Button();
            lstSecilenKahvaltı = new ListBox();
            btnKahvalti = new Button();
            btnDetayKahvalti = new Button();
            lstTumKahvalti = new ListBox();
            gbOgle = new GroupBox();
            btnCikarOgle = new Button();
            btnOgle = new Button();
            btnDetayOgle = new Button();
            lstSecilenOgle = new ListBox();
            lstTumOgle = new ListBox();
            gbAksam = new GroupBox();
            btnCikarAksam = new Button();
            btnAksam = new Button();
            btnDetayAksam = new Button();
            lstSecilenAksam = new ListBox();
            lstTumAksam = new ListBox();
            gbAperatif = new GroupBox();
            btnCikarAperatif = new Button();
            btnAperatif = new Button();
            btnDetayAperatif = new Button();
            lstSecilenAperatif = new ListBox();
            lstTumAperatif = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtAra = new TextBox();
            label3 = new Label();
            lblKahvalti = new Label();
            label5 = new Label();
            lblOgle = new Label();
            label7 = new Label();
            lblAksam = new Label();
            label9 = new Label();
            lblAperatif = new Label();
            label11 = new Label();
            menuStrip1 = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            gbKahvaltı.SuspendLayout();
            gbOgle.SuspendLayout();
            gbAksam.SuspendLayout();
            gbAperatif.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // gbKahvaltı
            // 
            gbKahvaltı.BackColor = Color.Transparent;
            gbKahvaltı.Controls.Add(btnCikarKahvalti);
            gbKahvaltı.Controls.Add(lstSecilenKahvaltı);
            gbKahvaltı.Controls.Add(btnKahvalti);
            gbKahvaltı.Controls.Add(btnDetayKahvalti);
            gbKahvaltı.Controls.Add(lstTumKahvalti);
            gbKahvaltı.Location = new Point(34, 65);
            gbKahvaltı.Name = "gbKahvaltı";
            gbKahvaltı.Size = new Size(370, 264);
            gbKahvaltı.TabIndex = 5;
            gbKahvaltı.TabStop = false;
            gbKahvaltı.Text = "Kahvalti";
            gbKahvaltı.Visible = false;
            // 
            // btnCikarKahvalti
            // 
            btnCikarKahvalti.Location = new Point(133, 140);
            btnCikarKahvalti.Name = "btnCikarKahvalti";
            btnCikarKahvalti.Size = new Size(55, 23);
            btnCikarKahvalti.TabIndex = 4;
            btnCikarKahvalti.Text = "<---";
            btnCikarKahvalti.UseVisualStyleBackColor = true;
            btnCikarKahvalti.Click += btnCikarKahvalti_Click;
            // 
            // lstSecilenKahvaltı
            // 
            lstSecilenKahvaltı.FormattingEnabled = true;
            lstSecilenKahvaltı.ItemHeight = 15;
            lstSecilenKahvaltı.Location = new Point(215, 22);
            lstSecilenKahvaltı.Name = "lstSecilenKahvaltı";
            lstSecilenKahvaltı.Size = new Size(149, 199);
            lstSecilenKahvaltı.TabIndex = 3;
            // 
            // btnKahvalti
            // 
            btnKahvalti.Location = new Point(133, 86);
            btnKahvalti.Name = "btnKahvalti";
            btnKahvalti.Size = new Size(66, 23);
            btnKahvalti.TabIndex = 2;
            btnKahvalti.Text = "--->";
            btnKahvalti.UseVisualStyleBackColor = true;
            btnKahvalti.Click += btnKahvalti_Click;
            // 
            // btnDetayKahvalti
            // 
            btnDetayKahvalti.Location = new Point(6, 232);
            btnDetayKahvalti.Name = "btnDetayKahvalti";
            btnDetayKahvalti.Size = new Size(75, 23);
            btnDetayKahvalti.TabIndex = 1;
            btnDetayKahvalti.Text = "Detaylandır";
            btnDetayKahvalti.UseVisualStyleBackColor = true;
            // 
            // lstTumKahvalti
            // 
            lstTumKahvalti.FormattingEnabled = true;
            lstTumKahvalti.ItemHeight = 15;
            lstTumKahvalti.Location = new Point(6, 22);
            lstTumKahvalti.Name = "lstTumKahvalti";
            lstTumKahvalti.Size = new Size(121, 199);
            lstTumKahvalti.TabIndex = 0;
            // 
            // gbOgle
            // 
            gbOgle.BackColor = Color.Transparent;
            gbOgle.Controls.Add(btnCikarOgle);
            gbOgle.Controls.Add(btnOgle);
            gbOgle.Controls.Add(btnDetayOgle);
            gbOgle.Controls.Add(lstSecilenOgle);
            gbOgle.Controls.Add(lstTumOgle);
            gbOgle.Location = new Point(27, 56);
            gbOgle.Name = "gbOgle";
            gbOgle.Size = new Size(370, 264);
            gbOgle.TabIndex = 6;
            gbOgle.TabStop = false;
            gbOgle.Text = "Ogle";
            gbOgle.Visible = false;
            // 
            // btnCikarOgle
            // 
            btnCikarOgle.Location = new Point(144, 140);
            btnCikarOgle.Name = "btnCikarOgle";
            btnCikarOgle.Size = new Size(55, 23);
            btnCikarOgle.TabIndex = 3;
            btnCikarOgle.Text = "<---";
            btnCikarOgle.UseVisualStyleBackColor = true;
            btnCikarOgle.Click += btnCikarOgle_Click;
            // 
            // btnOgle
            // 
            btnOgle.Location = new Point(144, 76);
            btnOgle.Name = "btnOgle";
            btnOgle.Size = new Size(55, 23);
            btnOgle.TabIndex = 2;
            btnOgle.Text = "--->";
            btnOgle.UseVisualStyleBackColor = true;
            btnOgle.Click += btnOgle_Click;
            // 
            // btnDetayOgle
            // 
            btnDetayOgle.Location = new Point(6, 222);
            btnDetayOgle.Name = "btnDetayOgle";
            btnDetayOgle.Size = new Size(75, 23);
            btnDetayOgle.TabIndex = 1;
            btnDetayOgle.Text = "Detaylandır";
            btnDetayOgle.UseVisualStyleBackColor = true;
            // 
            // lstSecilenOgle
            // 
            lstSecilenOgle.FormattingEnabled = true;
            lstSecilenOgle.ItemHeight = 15;
            lstSecilenOgle.Location = new Point(215, 22);
            lstSecilenOgle.Name = "lstSecilenOgle";
            lstSecilenOgle.Size = new Size(149, 199);
            lstSecilenOgle.TabIndex = 0;
            // 
            // lstTumOgle
            // 
            lstTumOgle.FormattingEnabled = true;
            lstTumOgle.ItemHeight = 15;
            lstTumOgle.Location = new Point(6, 22);
            lstTumOgle.Name = "lstTumOgle";
            lstTumOgle.Size = new Size(121, 199);
            lstTumOgle.TabIndex = 0;
            // 
            // gbAksam
            // 
            gbAksam.BackColor = Color.Transparent;
            gbAksam.Controls.Add(btnCikarAksam);
            gbAksam.Controls.Add(btnAksam);
            gbAksam.Controls.Add(btnDetayAksam);
            gbAksam.Controls.Add(lstSecilenAksam);
            gbAksam.Controls.Add(lstTumAksam);
            gbAksam.Location = new Point(28, 59);
            gbAksam.Name = "gbAksam";
            gbAksam.Size = new Size(370, 264);
            gbAksam.TabIndex = 7;
            gbAksam.TabStop = false;
            gbAksam.Text = "Aksam";
            gbAksam.Visible = false;
            // 
            // btnCikarAksam
            // 
            btnCikarAksam.Location = new Point(133, 124);
            btnCikarAksam.Name = "btnCikarAksam";
            btnCikarAksam.Size = new Size(55, 23);
            btnCikarAksam.TabIndex = 3;
            btnCikarAksam.Text = "<---";
            btnCikarAksam.UseVisualStyleBackColor = true;
            btnCikarAksam.Click += btnCikarAksam_Click;
            // 
            // btnAksam
            // 
            btnAksam.Location = new Point(133, 48);
            btnAksam.Name = "btnAksam";
            btnAksam.Size = new Size(55, 23);
            btnAksam.TabIndex = 2;
            btnAksam.Text = "--->";
            btnAksam.UseVisualStyleBackColor = true;
            btnAksam.Click += btnAksam_Click;
            // 
            // btnDetayAksam
            // 
            btnDetayAksam.Location = new Point(6, 227);
            btnDetayAksam.Name = "btnDetayAksam";
            btnDetayAksam.Size = new Size(75, 23);
            btnDetayAksam.TabIndex = 1;
            btnDetayAksam.Text = "Detaylandır";
            btnDetayAksam.UseVisualStyleBackColor = true;
            // 
            // lstSecilenAksam
            // 
            lstSecilenAksam.FormattingEnabled = true;
            lstSecilenAksam.ItemHeight = 15;
            lstSecilenAksam.Location = new Point(196, 22);
            lstSecilenAksam.Name = "lstSecilenAksam";
            lstSecilenAksam.Size = new Size(149, 199);
            lstSecilenAksam.TabIndex = 0;
            // 
            // lstTumAksam
            // 
            lstTumAksam.FormattingEnabled = true;
            lstTumAksam.ItemHeight = 15;
            lstTumAksam.Location = new Point(6, 22);
            lstTumAksam.Name = "lstTumAksam";
            lstTumAksam.Size = new Size(121, 199);
            lstTumAksam.TabIndex = 0;
            // 
            // gbAperatif
            // 
            gbAperatif.BackColor = Color.Transparent;
            gbAperatif.Controls.Add(btnCikarAperatif);
            gbAperatif.Controls.Add(btnAperatif);
            gbAperatif.Controls.Add(btnDetayAperatif);
            gbAperatif.Controls.Add(lstSecilenAperatif);
            gbAperatif.Controls.Add(lstTumAperatif);
            gbAperatif.Location = new Point(21, 70);
            gbAperatif.Name = "gbAperatif";
            gbAperatif.Size = new Size(370, 264);
            gbAperatif.TabIndex = 8;
            gbAperatif.TabStop = false;
            gbAperatif.Text = "Aperatif";
            gbAperatif.Visible = false;
            // 
            // btnCikarAperatif
            // 
            btnCikarAperatif.Location = new Point(144, 114);
            btnCikarAperatif.Name = "btnCikarAperatif";
            btnCikarAperatif.Size = new Size(55, 23);
            btnCikarAperatif.TabIndex = 2;
            btnCikarAperatif.Text = "<---";
            btnCikarAperatif.UseVisualStyleBackColor = true;
            btnCikarAperatif.Click += btnCikarAperatif_Click;
            // 
            // btnAperatif
            // 
            btnAperatif.Location = new Point(144, 56);
            btnAperatif.Name = "btnAperatif";
            btnAperatif.Size = new Size(55, 23);
            btnAperatif.TabIndex = 2;
            btnAperatif.Text = "--->";
            btnAperatif.UseVisualStyleBackColor = true;
            btnAperatif.Click += btnAperatif_Click;
            // 
            // btnDetayAperatif
            // 
            btnDetayAperatif.Location = new Point(6, 227);
            btnDetayAperatif.Name = "btnDetayAperatif";
            btnDetayAperatif.Size = new Size(75, 23);
            btnDetayAperatif.TabIndex = 1;
            btnDetayAperatif.Text = "Detaylandır";
            btnDetayAperatif.UseVisualStyleBackColor = true;
            // 
            // lstSecilenAperatif
            // 
            lstSecilenAperatif.FormattingEnabled = true;
            lstSecilenAperatif.ItemHeight = 15;
            lstSecilenAperatif.Location = new Point(215, 26);
            lstSecilenAperatif.Name = "lstSecilenAperatif";
            lstSecilenAperatif.Size = new Size(149, 199);
            lstSecilenAperatif.TabIndex = 0;
            // 
            // lstTumAperatif
            // 
            lstTumAperatif.FormattingEnabled = true;
            lstTumAperatif.ItemHeight = 15;
            lstTumAperatif.Location = new Point(6, 22);
            lstTumAperatif.Name = "lstTumAperatif";
            lstTumAperatif.Size = new Size(121, 199);
            lstTumAperatif.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 348);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 9;
            label1.Text = "Toplam Kalori(kcal):";
            // 
            // label2
            // 
            label2.Location = new Point(628, 340);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 10;
            label2.Text = "0";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(98, 340);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(306, 23);
            txtAra.TabIndex = 11;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 340);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Besin Ara:";
            // 
            // lblKahvalti
            // 
            lblKahvalti.Location = new Point(628, 65);
            lblKahvalti.Name = "lblKahvalti";
            lblKahvalti.Size = new Size(134, 23);
            lblKahvalti.TabIndex = 14;
            lblKahvalti.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 65);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 13;
            label5.Text = "Kahvaltı Kalori:";
            // 
            // lblOgle
            // 
            lblOgle.Location = new Point(628, 124);
            lblOgle.Name = "lblOgle";
            lblOgle.Size = new Size(134, 23);
            lblOgle.TabIndex = 16;
            lblOgle.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 132);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 15;
            label7.Text = "Öğle Yemeği  Kalori:";
            // 
            // lblAksam
            // 
            lblAksam.Location = new Point(628, 188);
            lblAksam.Name = "lblAksam";
            lblAksam.Size = new Size(134, 23);
            lblAksam.TabIndex = 18;
            lblAksam.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(488, 196);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 17;
            label9.Text = "Akşam Kalori:";
            // 
            // lblAperatif
            // 
            lblAperatif.Location = new Point(628, 254);
            lblAperatif.Name = "lblAperatif";
            lblAperatif.Size = new Size(134, 23);
            lblAperatif.TabIndex = 20;
            lblAperatif.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(488, 262);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 19;
            label11.Text = "Aperatif Kalori:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            anaMenüToolStripMenuItem.Size = new Size(74, 20);
            anaMenüToolStripMenuItem.Text = "Ana Menü";
            anaMenüToolStripMenuItem.Click += anaMenüToolStripMenuItem_Click_1;
            // 
            // frm_DiyetListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 536);
            Controls.Add(lblAperatif);
            Controls.Add(label11);
            Controls.Add(lblAksam);
            Controls.Add(label9);
            Controls.Add(gbOgle);
            Controls.Add(lblOgle);
            Controls.Add(label7);
            Controls.Add(lblKahvalti);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbAperatif);
            Controls.Add(gbAksam);
            Controls.Add(gbKahvaltı);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_DiyetListe";
            Text = "frm_DiyetListe";
            Load += frm_DiyetListe_Load;
            gbKahvaltı.ResumeLayout(false);
            gbOgle.ResumeLayout(false);
            gbAksam.ResumeLayout(false);
            gbAperatif.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private GroupBox gbKahvaltı;
        private ListBox lstTumKahvalti;
        private Button btnKahvalti;
        private Button btnDetayKahvalti;
        private GroupBox gbOgle;
        private Button btnOgle;
        private Button btnDetayOgle;
        private ListBox lstSecilenOgle;
        private ListBox lstTumOgle;
        private GroupBox gbAksam;
        private Button btnAksam;
        private Button btnDetayAksam;
        private ListBox lstSecilenAksam;
        private ListBox lstTumAksam;
        private GroupBox gbAperatif;
        private Button btnAperatif;
        private Button btnDetayAperatif;
        private ListBox lstSecilenAperatif;
        private ListBox lstTumAperatif;
        private ListBox lstSecilenKahvaltı;
        private Label label1;
        private Label label2;
        private TextBox txtAra;
        private Label label3;
        private Button btnCikarAperatif;
        private Button btnCikarKahvalti;
        private Button btnCikarOgle;
        private Button btnCikarAksam;
        private Label lblKahvalti;
        private Label label5;
        private Label lblOgle;
        private Label label7;
        private Label lblAksam;
        private Label label9;
        private Label lblAperatif;
        private Label label11;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
    }
}