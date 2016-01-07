namespace Saliavustaja
{
    partial class UusiTilaus
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RuokalistaLaatikko = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LisaaAteriaButton = new System.Windows.Forms.Button();
            this.PoistaAteriaButton = new System.Windows.Forms.Button();
            this.PeruTilausButton = new System.Windows.Forms.Button();
            this.LisaaTilausButton = new System.Windows.Forms.Button();
            this.VerotonHintaLabel = new System.Windows.Forms.Label();
            this.VeronOsuusLabel = new System.Windows.Forms.Label();
            this.KokonaishintaLabel = new System.Windows.Forms.Label();
            this.VerotonSummaLabel = new System.Windows.Forms.Label();
            this.VeroSummaLabel = new System.Windows.Forms.Label();
            this.TilausSummaLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "testipöytä1",
            "testipöytä2"});
            this.comboBox1.Location = new System.Drawing.Point(48, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse pöytä";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RuokalistaLaatikko
            // 
            this.RuokalistaLaatikko.Location = new System.Drawing.Point(47, 403);
            this.RuokalistaLaatikko.Name = "RuokalistaLaatikko";
            this.RuokalistaLaatikko.Size = new System.Drawing.Size(444, 277);
            this.RuokalistaLaatikko.TabIndex = 2;
            this.RuokalistaLaatikko.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(643, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 277);
            this.dataGridView1.TabIndex = 4;
            // 
            // LisaaAteriaButton
            // 
            this.LisaaAteriaButton.Location = new System.Drawing.Point(515, 498);
            this.LisaaAteriaButton.Name = "LisaaAteriaButton";
            this.LisaaAteriaButton.Size = new System.Drawing.Size(111, 49);
            this.LisaaAteriaButton.TabIndex = 5;
            this.LisaaAteriaButton.Text = "Lisää >>";
            this.LisaaAteriaButton.UseVisualStyleBackColor = true;
            // 
            // PoistaAteriaButton
            // 
            this.PoistaAteriaButton.Location = new System.Drawing.Point(515, 553);
            this.PoistaAteriaButton.Name = "PoistaAteriaButton";
            this.PoistaAteriaButton.Size = new System.Drawing.Size(111, 49);
            this.PoistaAteriaButton.TabIndex = 6;
            this.PoistaAteriaButton.Text = "<< Poista";
            this.PoistaAteriaButton.UseVisualStyleBackColor = true;
            this.PoistaAteriaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeruTilausButton
            // 
            this.PeruTilausButton.Location = new System.Drawing.Point(771, 718);
            this.PeruTilausButton.Name = "PeruTilausButton";
            this.PeruTilausButton.Size = new System.Drawing.Size(141, 46);
            this.PeruTilausButton.TabIndex = 7;
            this.PeruTilausButton.Text = "Peru tilaus";
            this.PeruTilausButton.UseVisualStyleBackColor = true;
            // 
            // LisaaTilausButton
            // 
            this.LisaaTilausButton.Location = new System.Drawing.Point(928, 718);
            this.LisaaTilausButton.Name = "LisaaTilausButton";
            this.LisaaTilausButton.Size = new System.Drawing.Size(133, 46);
            this.LisaaTilausButton.TabIndex = 8;
            this.LisaaTilausButton.Text = "Lisää tilaus";
            this.LisaaTilausButton.UseVisualStyleBackColor = true;
            // 
            // VerotonHintaLabel
            // 
            this.VerotonHintaLabel.AutoSize = true;
            this.VerotonHintaLabel.Location = new System.Drawing.Point(51, 700);
            this.VerotonHintaLabel.Name = "VerotonHintaLabel";
            this.VerotonHintaLabel.Size = new System.Drawing.Size(93, 17);
            this.VerotonHintaLabel.TabIndex = 9;
            this.VerotonHintaLabel.Text = "Veroton hinta";
            // 
            // VeronOsuusLabel
            // 
            this.VeronOsuusLabel.AutoSize = true;
            this.VeronOsuusLabel.Location = new System.Drawing.Point(51, 726);
            this.VeronOsuusLabel.Name = "VeronOsuusLabel";
            this.VeronOsuusLabel.Size = new System.Drawing.Size(88, 17);
            this.VeronOsuusLabel.TabIndex = 10;
            this.VeronOsuusLabel.Text = "Veron osuus";
            this.VeronOsuusLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // KokonaishintaLabel
            // 
            this.KokonaishintaLabel.AutoSize = true;
            this.KokonaishintaLabel.Location = new System.Drawing.Point(51, 752);
            this.KokonaishintaLabel.Name = "KokonaishintaLabel";
            this.KokonaishintaLabel.Size = new System.Drawing.Size(160, 17);
            this.KokonaishintaLabel.TabIndex = 11;
            this.KokonaishintaLabel.Text = "Tilauksen kokonaishinta";
            // 
            // VerotonSummaLabel
            // 
            this.VerotonSummaLabel.AutoSize = true;
            this.VerotonSummaLabel.Location = new System.Drawing.Point(446, 700);
            this.VerotonSummaLabel.Name = "VerotonSummaLabel";
            this.VerotonSummaLabel.Size = new System.Drawing.Size(44, 17);
            this.VerotonSummaLabel.TabIndex = 12;
            this.VerotonSummaLabel.Text = "00,00";
            // 
            // VeroSummaLabel
            // 
            this.VeroSummaLabel.AutoSize = true;
            this.VeroSummaLabel.Location = new System.Drawing.Point(446, 726);
            this.VeroSummaLabel.Name = "VeroSummaLabel";
            this.VeroSummaLabel.Size = new System.Drawing.Size(44, 17);
            this.VeroSummaLabel.TabIndex = 13;
            this.VeroSummaLabel.Text = "00,00";
            // 
            // TilausSummaLabel
            // 
            this.TilausSummaLabel.AutoSize = true;
            this.TilausSummaLabel.Location = new System.Drawing.Point(446, 752);
            this.TilausSummaLabel.Name = "TilausSummaLabel";
            this.TilausSummaLabel.Size = new System.Drawing.Size(44, 17);
            this.TilausSummaLabel.TabIndex = 14;
            this.TilausSummaLabel.Text = "00,00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UusiTilaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 776);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TilausSummaLabel);
            this.Controls.Add(this.VeroSummaLabel);
            this.Controls.Add(this.VerotonSummaLabel);
            this.Controls.Add(this.KokonaishintaLabel);
            this.Controls.Add(this.VeronOsuusLabel);
            this.Controls.Add(this.VerotonHintaLabel);
            this.Controls.Add(this.LisaaTilausButton);
            this.Controls.Add(this.PeruTilausButton);
            this.Controls.Add(this.PoistaAteriaButton);
            this.Controls.Add(this.LisaaAteriaButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RuokalistaLaatikko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "UusiTilaus";
            this.Text = "Tilaus";
            this.Load += new System.EventHandler(this.UusiTilaus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView RuokalistaLaatikko;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LisaaAteriaButton;
        private System.Windows.Forms.Button PoistaAteriaButton;
        private System.Windows.Forms.Button PeruTilausButton;
        private System.Windows.Forms.Button LisaaTilausButton;
        private System.Windows.Forms.Label VerotonHintaLabel;
        private System.Windows.Forms.Label VeronOsuusLabel;
        private System.Windows.Forms.Label KokonaishintaLabel;
        private System.Windows.Forms.Label VerotonSummaLabel;
        private System.Windows.Forms.Label VeroSummaLabel;
        private System.Windows.Forms.Label TilausSummaLabel;
        private System.Windows.Forms.Button button1;
    }
}