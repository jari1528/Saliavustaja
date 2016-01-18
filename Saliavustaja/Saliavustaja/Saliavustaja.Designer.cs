namespace Saliavustaja
{
    partial class Saliavustaja
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
            System.Windows.Forms.ColumnHeader columnHeaderTuote;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saliavustaja));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Katkarapu-ceasar -salaatti",
            "14.90",
            "15,70",
            "13.00",
            "13.90",
            "12.90",
            "22.90",
            "17.00",
            "17.40",
            "29.00",
            "27.60"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Maalaissalaatti kananmunalla ja pekoniruseteilla",
            "13.90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tulinen nyhtokaurahampurilainen",
            "13.90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kermainen kolmen pähkinän pasta",
            "16.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Miilunpolttajan pasta",
            "12.80"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Grillattuja pikkuahvenia, perunalumi",
            "21.20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Haukimureke, fenkolipeti",
            "17.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mustajuuri-chevrepihvit, hiiliperunat",
            "15.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Peuran sisäfile, metsäsienirisotto",
            "29.40"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Rosvopaisti lampaan potkasta, haudutetut juurekset",
            "26.60"}, -1);
            this.TilausLista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UusiTilausButton = new System.Windows.Forms.Button();
            this.TilausSummaLabel = new System.Windows.Forms.Label();
            this.VeroSummaLabel = new System.Windows.Forms.Label();
            this.VerotonSummaLabel = new System.Windows.Forms.Label();
            this.KokonaishintaLabel = new System.Windows.Forms.Label();
            this.VeronOsuusLabel = new System.Windows.Forms.Label();
            this.VerotonHintaLabel = new System.Windows.Forms.Label();
            this.LisaaTilausButton = new System.Windows.Forms.Button();
            this.PeruTilausButton = new System.Windows.Forms.Button();
            this.PoistaAteriaButton = new System.Windows.Forms.Button();
            this.LisaaAteriaButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RuokalistaLaatikko = new System.Windows.Forms.ListView();
            this.columnHeaderAhinta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TilauksetLabel = new System.Windows.Forms.Label();
            columnHeaderTuote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeaderTuote
            // 
            columnHeaderTuote.Text = "Tuote";
            columnHeaderTuote.Width = 344;
            // 
            // TilausLista
            // 
            this.TilausLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TilausLista.Location = new System.Drawing.Point(396, 26);
            this.TilausLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TilausLista.Name = "TilausLista";
            this.TilausLista.Size = new System.Drawing.Size(748, 264);
            this.TilausLista.TabIndex = 1;
            this.TilausLista.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tilaus nro";
            // 
            // UusiTilausButton
            // 
            this.UusiTilausButton.BackColor = System.Drawing.SystemColors.Control;
            this.UusiTilausButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UusiTilausButton.BackgroundImage")));
            this.UusiTilausButton.Location = new System.Drawing.Point(37, 217);
            this.UusiTilausButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UusiTilausButton.Name = "UusiTilausButton";
            this.UusiTilausButton.Size = new System.Drawing.Size(100, 50);
            this.UusiTilausButton.TabIndex = 30;
            this.UusiTilausButton.Text = "Uusi tilaus";
            this.UusiTilausButton.UseVisualStyleBackColor = false;
            // 
            // TilausSummaLabel
            // 
            this.TilausSummaLabel.AutoSize = true;
            this.TilausSummaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilausSummaLabel.Location = new System.Drawing.Point(424, 713);
            this.TilausSummaLabel.Name = "TilausSummaLabel";
            this.TilausSummaLabel.Size = new System.Drawing.Size(54, 20);
            this.TilausSummaLabel.TabIndex = 29;
            this.TilausSummaLabel.Text = "00,00";
            // 
            // VeroSummaLabel
            // 
            this.VeroSummaLabel.AutoSize = true;
            this.VeroSummaLabel.Location = new System.Drawing.Point(434, 686);
            this.VeroSummaLabel.Name = "VeroSummaLabel";
            this.VeroSummaLabel.Size = new System.Drawing.Size(44, 17);
            this.VeroSummaLabel.TabIndex = 28;
            this.VeroSummaLabel.Text = "00,00";
            // 
            // VerotonSummaLabel
            // 
            this.VerotonSummaLabel.AutoSize = true;
            this.VerotonSummaLabel.Location = new System.Drawing.Point(434, 661);
            this.VerotonSummaLabel.Name = "VerotonSummaLabel";
            this.VerotonSummaLabel.Size = new System.Drawing.Size(44, 17);
            this.VerotonSummaLabel.TabIndex = 27;
            this.VerotonSummaLabel.Text = "00,00";
            // 
            // KokonaishintaLabel
            // 
            this.KokonaishintaLabel.AutoSize = true;
            this.KokonaishintaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KokonaishintaLabel.Location = new System.Drawing.Point(41, 713);
            this.KokonaishintaLabel.Name = "KokonaishintaLabel";
            this.KokonaishintaLabel.Size = new System.Drawing.Size(209, 20);
            this.KokonaishintaLabel.TabIndex = 26;
            this.KokonaishintaLabel.Text = "Tilauksen kokonaishinta";
            // 
            // VeronOsuusLabel
            // 
            this.VeronOsuusLabel.AutoSize = true;
            this.VeronOsuusLabel.Location = new System.Drawing.Point(41, 686);
            this.VeronOsuusLabel.Name = "VeronOsuusLabel";
            this.VeronOsuusLabel.Size = new System.Drawing.Size(88, 17);
            this.VeronOsuusLabel.TabIndex = 25;
            this.VeronOsuusLabel.Text = "Veron osuus";
            // 
            // VerotonHintaLabel
            // 
            this.VerotonHintaLabel.AutoSize = true;
            this.VerotonHintaLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.VerotonHintaLabel.Location = new System.Drawing.Point(41, 661);
            this.VerotonHintaLabel.Name = "VerotonHintaLabel";
            this.VerotonHintaLabel.Size = new System.Drawing.Size(93, 17);
            this.VerotonHintaLabel.TabIndex = 24;
            this.VerotonHintaLabel.Text = "Veroton hinta";
            // 
            // LisaaTilausButton
            // 
            this.LisaaTilausButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LisaaTilausButton.BackgroundImage")));
            this.LisaaTilausButton.Location = new System.Drawing.Point(1019, 671);
            this.LisaaTilausButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LisaaTilausButton.Name = "LisaaTilausButton";
            this.LisaaTilausButton.Size = new System.Drawing.Size(100, 50);
            this.LisaaTilausButton.TabIndex = 23;
            this.LisaaTilausButton.Text = "Lisää tilaus";
            this.LisaaTilausButton.UseVisualStyleBackColor = true;
            // 
            // PeruTilausButton
            // 
            this.PeruTilausButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PeruTilausButton.BackgroundImage")));
            this.PeruTilausButton.Location = new System.Drawing.Point(901, 671);
            this.PeruTilausButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeruTilausButton.Name = "PeruTilausButton";
            this.PeruTilausButton.Size = new System.Drawing.Size(100, 50);
            this.PeruTilausButton.TabIndex = 22;
            this.PeruTilausButton.Text = "Peru tilaus";
            this.PeruTilausButton.UseVisualStyleBackColor = true;
            // 
            // PoistaAteriaButton
            // 
            this.PoistaAteriaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PoistaAteriaButton.BackgroundImage")));
            this.PoistaAteriaButton.Location = new System.Drawing.Point(505, 525);
            this.PoistaAteriaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PoistaAteriaButton.Name = "PoistaAteriaButton";
            this.PoistaAteriaButton.Size = new System.Drawing.Size(100, 50);
            this.PoistaAteriaButton.TabIndex = 21;
            this.PoistaAteriaButton.Text = "<< Poista";
            this.PoistaAteriaButton.UseVisualStyleBackColor = true;
            // 
            // LisaaAteriaButton
            // 
            this.LisaaAteriaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LisaaAteriaButton.BackgroundImage")));
            this.LisaaAteriaButton.Location = new System.Drawing.Point(505, 463);
            this.LisaaAteriaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LisaaAteriaButton.Name = "LisaaAteriaButton";
            this.LisaaAteriaButton.Size = new System.Drawing.Size(100, 50);
            this.LisaaAteriaButton.TabIndex = 20;
            this.LisaaAteriaButton.Text = "Lisää >>";
            this.LisaaAteriaButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(657, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 321);
            this.dataGridView1.TabIndex = 19;
            // 
            // RuokalistaLaatikko
            // 
            this.RuokalistaLaatikko.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeaderTuote,
            this.columnHeaderAhinta});
            this.RuokalistaLaatikko.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.RuokalistaLaatikko.Location = new System.Drawing.Point(36, 364);
            this.RuokalistaLaatikko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RuokalistaLaatikko.MultiSelect = false;
            this.RuokalistaLaatikko.Name = "RuokalistaLaatikko";
            this.RuokalistaLaatikko.Size = new System.Drawing.Size(444, 277);
            this.RuokalistaLaatikko.TabIndex = 18;
            this.RuokalistaLaatikko.UseCompatibleStateImageBehavior = false;
            this.RuokalistaLaatikko.View = System.Windows.Forms.View.Details;
            this.RuokalistaLaatikko.SelectedIndexChanged += new System.EventHandler(this.RuokalistaLaatikko_SelectedIndexChanged);
            // 
            // columnHeaderAhinta
            // 
            this.columnHeaderAhinta.Text = "A-Hinta";
            this.columnHeaderAhinta.Width = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valitse pöytä";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pöytä 1",
            "Pöytä 2",
            "Pöytä 3",
            "Pöytä 4",
            "Pöytä 5",
            "Kabinetti 1",
            "Kabinetti 2",
            "Parveke "});
            this.comboBox1.Location = new System.Drawing.Point(37, 320);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TilauksetLabel
            // 
            this.TilauksetLabel.AutoSize = true;
            this.TilauksetLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TilauksetLabel.Location = new System.Drawing.Point(319, 24);
            this.TilauksetLabel.Name = "TilauksetLabel";
            this.TilauksetLabel.Size = new System.Drawing.Size(65, 17);
            this.TilauksetLabel.TabIndex = 31;
            this.TilauksetLabel.Text = "Tilaukset";
            // 
            // Saliavustaja
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 755);
            this.Controls.Add(this.TilauksetLabel);
            this.Controls.Add(this.UusiTilausButton);
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
            this.Controls.Add(this.TilausLista);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Saliavustaja";
            this.Text = "Saliavustaja v0.02";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TilausLista;
        private System.Windows.Forms.Button UusiTilausButton;
        private System.Windows.Forms.Label TilausSummaLabel;
        private System.Windows.Forms.Label VeroSummaLabel;
        private System.Windows.Forms.Label VerotonSummaLabel;
        private System.Windows.Forms.Label KokonaishintaLabel;
        private System.Windows.Forms.Label VeronOsuusLabel;
        private System.Windows.Forms.Label VerotonHintaLabel;
        private System.Windows.Forms.Button LisaaTilausButton;
        private System.Windows.Forms.Button PeruTilausButton;
        private System.Windows.Forms.Button PoistaAteriaButton;
        private System.Windows.Forms.Button LisaaAteriaButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView RuokalistaLaatikko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label TilauksetLabel;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeaderAhinta;
    }
}

