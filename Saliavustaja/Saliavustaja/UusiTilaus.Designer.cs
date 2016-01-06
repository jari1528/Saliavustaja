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
            this.BonusasiakasBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LisaaAteriaButton = new System.Windows.Forms.Button();
            this.PoistaAteriaButton = new System.Windows.Forms.Button();
            this.PeruTilausButton = new System.Windows.Forms.Button();
            this.LisaaTilausButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "testipöytä1",
            "testipöytä2"});
            this.comboBox1.Location = new System.Drawing.Point(44, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse pöytä";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RuokalistaLaatikko
            // 
            this.RuokalistaLaatikko.Location = new System.Drawing.Point(43, 91);
            this.RuokalistaLaatikko.Name = "RuokalistaLaatikko";
            this.RuokalistaLaatikko.Size = new System.Drawing.Size(444, 479);
            this.RuokalistaLaatikko.TabIndex = 2;
            this.RuokalistaLaatikko.UseCompatibleStateImageBehavior = false;
            // 
            // BonusasiakasBox
            // 
            this.BonusasiakasBox.AutoSize = true;
            this.BonusasiakasBox.Location = new System.Drawing.Point(864, 47);
            this.BonusasiakasBox.Name = "BonusasiakasBox";
            this.BonusasiakasBox.Size = new System.Drawing.Size(182, 21);
            this.BonusasiakasBox.TabIndex = 3;
            this.BonusasiakasBox.Text = "Bonus-asiakas, 15% ale";
            this.BonusasiakasBox.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(644, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 479);
            this.dataGridView1.TabIndex = 4;
            // 
            // LisaaAteriaButton
            // 
            this.LisaaAteriaButton.Location = new System.Drawing.Point(511, 240);
            this.LisaaAteriaButton.Name = "LisaaAteriaButton";
            this.LisaaAteriaButton.Size = new System.Drawing.Size(111, 49);
            this.LisaaAteriaButton.TabIndex = 5;
            this.LisaaAteriaButton.Text = "Lisää >>";
            this.LisaaAteriaButton.UseVisualStyleBackColor = true;
            // 
            // PoistaAteriaButton
            // 
            this.PoistaAteriaButton.Location = new System.Drawing.Point(511, 295);
            this.PoistaAteriaButton.Name = "PoistaAteriaButton";
            this.PoistaAteriaButton.Size = new System.Drawing.Size(111, 49);
            this.PoistaAteriaButton.TabIndex = 6;
            this.PoistaAteriaButton.Text = "<< Poista";
            this.PoistaAteriaButton.UseVisualStyleBackColor = true;
            this.PoistaAteriaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeruTilausButton
            // 
            this.PeruTilausButton.Location = new System.Drawing.Point(767, 608);
            this.PeruTilausButton.Name = "PeruTilausButton";
            this.PeruTilausButton.Size = new System.Drawing.Size(141, 46);
            this.PeruTilausButton.TabIndex = 7;
            this.PeruTilausButton.Text = "Peru tilaus";
            this.PeruTilausButton.UseVisualStyleBackColor = true;
            // 
            // LisaaTilausButton
            // 
            this.LisaaTilausButton.Location = new System.Drawing.Point(924, 608);
            this.LisaaTilausButton.Name = "LisaaTilausButton";
            this.LisaaTilausButton.Size = new System.Drawing.Size(133, 46);
            this.LisaaTilausButton.TabIndex = 8;
            this.LisaaTilausButton.Text = "Lisää tilaus";
            this.LisaaTilausButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // UusiTilaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LisaaTilausButton);
            this.Controls.Add(this.PeruTilausButton);
            this.Controls.Add(this.PoistaAteriaButton);
            this.Controls.Add(this.LisaaAteriaButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BonusasiakasBox);
            this.Controls.Add(this.RuokalistaLaatikko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "UusiTilaus";
            this.Text = "Tilaus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView RuokalistaLaatikko;
        private System.Windows.Forms.CheckBox BonusasiakasBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LisaaAteriaButton;
        private System.Windows.Forms.Button PoistaAteriaButton;
        private System.Windows.Forms.Button PeruTilausButton;
        private System.Windows.Forms.Button LisaaTilausButton;
        private System.Windows.Forms.Label label2;
    }
}