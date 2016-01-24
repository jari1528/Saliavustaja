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
            System.Windows.Forms.ListViewItem listViewItem41 = new System.Windows.Forms.ListViewItem(new string[] {
            "Katkarapu-ceasar -salaatti",
            "14,90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem42 = new System.Windows.Forms.ListViewItem(new string[] {
            "Maalaissalaatti kananmunalla ja pekoniruseteilla",
            "13,90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem43 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tulinen nyhtokaurahampurilainen",
            "13,90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem44 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kermainen kolmen pähkinän pasta",
            "16,50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem(new string[] {
            "Miilunpolttajan pasta",
            "12,80"}, -1);
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem(new string[] {
            "Grillattuja pikkuahvenia, perunalumi",
            "21,20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem(new string[] {
            "Haukimureke, fenkolipeti",
            "17,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mustajuuri-chevrepihvit, hiiliperunat",
            "15,50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem(new string[] {
            "Peuran sisäfile, metsäsienirisotto",
            "29,40"}, -1);
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem(new string[] {
            "Rosvopaisti lampaan potkasta, haudutetut juurekset",
            "26,60"}, -1);
            this.UusiTilausButton = new System.Windows.Forms.Button();
            this.TilausSummaLabel = new System.Windows.Forms.Label();
            this.TilausVeroLabel = new System.Windows.Forms.Label();
            this.TilausVerotonLabel = new System.Windows.Forms.Label();
            this.KokonaishintaLabel = new System.Windows.Forms.Label();
            this.VeronOsuusLabel = new System.Windows.Forms.Label();
            this.VerotonHintaLabel = new System.Windows.Forms.Label();
            this.LisaaTilausButton = new System.Windows.Forms.Button();
            this.PeruTilausButton = new System.Windows.Forms.Button();
            this.PoistaRiviButton = new System.Windows.Forms.Button();
            this.LisaaRiviButton = new System.Windows.Forms.Button();
            this.TilausRivitLtk = new System.Windows.Forms.DataGridView();
            this.tuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuokalistaLtk = new System.Windows.Forms.ListView();
            this.columnHeaderAhinta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ValitsePoytaValikko = new System.Windows.Forms.ComboBox();
            this.TilauksetLabel = new System.Windows.Forms.Label();
            this.TilauksetLtk = new System.Windows.Forms.DataGridView();
            this.tilausnro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poyta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tilausaika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loppusumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            columnHeaderTuote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.TilausRivitLtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TilauksetLtk)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeaderTuote
            // 
            columnHeaderTuote.Text = "Tuote";
            columnHeaderTuote.Width = 274;
            // 
            // UusiTilausButton
            // 
            this.UusiTilausButton.BackColor = System.Drawing.SystemColors.Control;
            this.UusiTilausButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UusiTilausButton.BackgroundImage")));
            this.UusiTilausButton.Location = new System.Drawing.Point(28, 176);
            this.UusiTilausButton.Margin = new System.Windows.Forms.Padding(2);
            this.UusiTilausButton.Name = "UusiTilausButton";
            this.UusiTilausButton.Size = new System.Drawing.Size(75, 41);
            this.UusiTilausButton.TabIndex = 30;
            this.UusiTilausButton.Text = "Uusi tilaus";
            this.UusiTilausButton.UseVisualStyleBackColor = false;
            this.UusiTilausButton.Click += new System.EventHandler(this.UusiTilausButton_Click);
            // 
            // TilausSummaLabel
            // 
            this.TilausSummaLabel.AutoSize = true;
            this.TilausSummaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilausSummaLabel.Location = new System.Drawing.Point(318, 579);
            this.TilausSummaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TilausSummaLabel.Name = "TilausSummaLabel";
            this.TilausSummaLabel.Size = new System.Drawing.Size(49, 17);
            this.TilausSummaLabel.TabIndex = 29;
            this.TilausSummaLabel.Text = "00,00";
            // 
            // TilausVeroLabel
            // 
            this.TilausVeroLabel.AutoSize = true;
            this.TilausVeroLabel.Location = new System.Drawing.Point(326, 557);
            this.TilausVeroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TilausVeroLabel.Name = "TilausVeroLabel";
            this.TilausVeroLabel.Size = new System.Drawing.Size(34, 13);
            this.TilausVeroLabel.TabIndex = 28;
            this.TilausVeroLabel.Text = "00,00";
            // 
            // TilausVerotonLabel
            // 
            this.TilausVerotonLabel.AutoSize = true;
            this.TilausVerotonLabel.Location = new System.Drawing.Point(326, 537);
            this.TilausVerotonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TilausVerotonLabel.Name = "TilausVerotonLabel";
            this.TilausVerotonLabel.Size = new System.Drawing.Size(34, 13);
            this.TilausVerotonLabel.TabIndex = 27;
            this.TilausVerotonLabel.Text = "00,00";
            // 
            // KokonaishintaLabel
            // 
            this.KokonaishintaLabel.AutoSize = true;
            this.KokonaishintaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KokonaishintaLabel.Location = new System.Drawing.Point(31, 579);
            this.KokonaishintaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KokonaishintaLabel.Name = "KokonaishintaLabel";
            this.KokonaishintaLabel.Size = new System.Drawing.Size(183, 17);
            this.KokonaishintaLabel.TabIndex = 26;
            this.KokonaishintaLabel.Text = "Tilauksen kokonaishinta";
            // 
            // VeronOsuusLabel
            // 
            this.VeronOsuusLabel.AutoSize = true;
            this.VeronOsuusLabel.Location = new System.Drawing.Point(31, 557);
            this.VeronOsuusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VeronOsuusLabel.Name = "VeronOsuusLabel";
            this.VeronOsuusLabel.Size = new System.Drawing.Size(66, 13);
            this.VeronOsuusLabel.TabIndex = 25;
            this.VeronOsuusLabel.Text = "Veron osuus";
            // 
            // VerotonHintaLabel
            // 
            this.VerotonHintaLabel.AutoSize = true;
            this.VerotonHintaLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.VerotonHintaLabel.Location = new System.Drawing.Point(31, 537);
            this.VerotonHintaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VerotonHintaLabel.Name = "VerotonHintaLabel";
            this.VerotonHintaLabel.Size = new System.Drawing.Size(70, 13);
            this.VerotonHintaLabel.TabIndex = 24;
            this.VerotonHintaLabel.Text = "Veroton hinta";
            // 
            // LisaaTilausButton
            // 
            this.LisaaTilausButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LisaaTilausButton.BackgroundImage")));
            this.LisaaTilausButton.Location = new System.Drawing.Point(764, 545);
            this.LisaaTilausButton.Margin = new System.Windows.Forms.Padding(2);
            this.LisaaTilausButton.Name = "LisaaTilausButton";
            this.LisaaTilausButton.Size = new System.Drawing.Size(75, 41);
            this.LisaaTilausButton.TabIndex = 23;
            this.LisaaTilausButton.Text = "Lisää tilaus";
            this.LisaaTilausButton.UseVisualStyleBackColor = true;
            this.LisaaTilausButton.Click += new System.EventHandler(this.LisaaTilausButton_Click);
            // 
            // PeruTilausButton
            // 
            this.PeruTilausButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PeruTilausButton.BackgroundImage")));
            this.PeruTilausButton.Location = new System.Drawing.Point(676, 545);
            this.PeruTilausButton.Margin = new System.Windows.Forms.Padding(2);
            this.PeruTilausButton.Name = "PeruTilausButton";
            this.PeruTilausButton.Size = new System.Drawing.Size(75, 41);
            this.PeruTilausButton.TabIndex = 22;
            this.PeruTilausButton.Text = "Peru tilaus";
            this.PeruTilausButton.UseVisualStyleBackColor = true;
            this.PeruTilausButton.Click += new System.EventHandler(this.PeruTilausButton_Click);
            // 
            // PoistaRiviButton
            // 
            this.PoistaRiviButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PoistaRiviButton.BackgroundImage")));
            this.PoistaRiviButton.Location = new System.Drawing.Point(383, 432);
            this.PoistaRiviButton.Margin = new System.Windows.Forms.Padding(2);
            this.PoistaRiviButton.Name = "PoistaRiviButton";
            this.PoistaRiviButton.Size = new System.Drawing.Size(75, 41);
            this.PoistaRiviButton.TabIndex = 21;
            this.PoistaRiviButton.Text = "<< Poista";
            this.PoistaRiviButton.UseVisualStyleBackColor = true;
            this.PoistaRiviButton.Click += new System.EventHandler(this.PoistaRiviButton_Click);
            // 
            // LisaaRiviButton
            // 
            this.LisaaRiviButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LisaaRiviButton.BackgroundImage")));
            this.LisaaRiviButton.Location = new System.Drawing.Point(383, 372);
            this.LisaaRiviButton.Margin = new System.Windows.Forms.Padding(2);
            this.LisaaRiviButton.Name = "LisaaRiviButton";
            this.LisaaRiviButton.Size = new System.Drawing.Size(75, 41);
            this.LisaaRiviButton.TabIndex = 20;
            this.LisaaRiviButton.Text = "Lisää >>";
            this.LisaaRiviButton.UseVisualStyleBackColor = true;
            this.LisaaRiviButton.Click += new System.EventHandler(this.LisaaRiviButton_Click);
            // 
            // TilausRivitLtk
            // 
            this.TilausRivitLtk.AllowUserToAddRows = false;
            this.TilausRivitLtk.AllowUserToDeleteRows = false;
            this.TilausRivitLtk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TilausRivitLtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TilausRivitLtk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tuote,
            this.ahinta,
            this.maara});
            this.TilausRivitLtk.Location = new System.Drawing.Point(474, 260);
            this.TilausRivitLtk.Margin = new System.Windows.Forms.Padding(2);
            this.TilausRivitLtk.MultiSelect = false;
            this.TilausRivitLtk.Name = "TilausRivitLtk";
            this.TilausRivitLtk.RowHeadersVisible = false;
            this.TilausRivitLtk.RowTemplate.Height = 24;
            this.TilausRivitLtk.Size = new System.Drawing.Size(384, 255);
            this.TilausRivitLtk.TabIndex = 19;
            this.TilausRivitLtk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TilausRivitLtk_CellContentClick);
            this.TilausRivitLtk.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TilausRivitLtk_CellValueChanged);
            this.TilausRivitLtk.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TilausRivitLtk_RowsAdded);
            this.TilausRivitLtk.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.TilausRivitLtk_RowsRemoved);
            // 
            // tuote
            // 
            this.tuote.HeaderText = "Tuote";
            this.tuote.Name = "tuote";
            this.tuote.ReadOnly = true;
            this.tuote.Width = 250;
            // 
            // ahinta
            // 
            this.ahinta.HeaderText = "A-Hinta";
            this.ahinta.Name = "ahinta";
            this.ahinta.ReadOnly = true;
            this.ahinta.Width = 66;
            // 
            // maara
            // 
            this.maara.HeaderText = "Määrä";
            this.maara.Name = "maara";
            this.maara.Width = 64;
            // 
            // RuokalistaLtk
            // 
            this.RuokalistaLtk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeaderTuote,
            this.columnHeaderAhinta});
            this.RuokalistaLtk.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem41,
            listViewItem42,
            listViewItem43,
            listViewItem44,
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48,
            listViewItem49,
            listViewItem50});
            this.RuokalistaLtk.Location = new System.Drawing.Point(28, 292);
            this.RuokalistaLtk.Margin = new System.Windows.Forms.Padding(2);
            this.RuokalistaLtk.MultiSelect = false;
            this.RuokalistaLtk.Name = "RuokalistaLtk";
            this.RuokalistaLtk.Size = new System.Drawing.Size(333, 223);
            this.RuokalistaLtk.TabIndex = 18;
            this.RuokalistaLtk.UseCompatibleStateImageBehavior = false;
            this.RuokalistaLtk.View = System.Windows.Forms.View.Details;
            this.RuokalistaLtk.SelectedIndexChanged += new System.EventHandler(this.RuokalistaLaatikko_SelectedIndexChanged);
            // 
            // columnHeaderAhinta
            // 
            this.columnHeaderAhinta.Text = "A-Hinta";
            this.columnHeaderAhinta.Width = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valitse pöytä";
            // 
            // ValitsePoytaValikko
            // 
            this.ValitsePoytaValikko.FormattingEnabled = true;
            this.ValitsePoytaValikko.Items.AddRange(new object[] {
            "Pöytä 1",
            "Pöytä 2",
            "Pöytä 3",
            "Pöytä 4",
            "Pöytä 5",
            "Kabinetti 1",
            "Kabinetti 2",
            "Parveke "});
            this.ValitsePoytaValikko.Location = new System.Drawing.Point(28, 260);
            this.ValitsePoytaValikko.Margin = new System.Windows.Forms.Padding(2);
            this.ValitsePoytaValikko.Name = "ValitsePoytaValikko";
            this.ValitsePoytaValikko.Size = new System.Drawing.Size(333, 21);
            this.ValitsePoytaValikko.TabIndex = 16;
            this.ValitsePoytaValikko.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TilauksetLabel
            // 
            this.TilauksetLabel.AutoSize = true;
            this.TilauksetLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TilauksetLabel.Location = new System.Drawing.Point(239, 20);
            this.TilauksetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TilauksetLabel.Name = "TilauksetLabel";
            this.TilauksetLabel.Size = new System.Drawing.Size(50, 13);
            this.TilauksetLabel.TabIndex = 31;
            this.TilauksetLabel.Text = "Tilaukset";
            // 
            // TilauksetLtk
            // 
            this.TilauksetLtk.AllowUserToAddRows = false;
            this.TilauksetLtk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TilauksetLtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TilauksetLtk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tilausnro,
            this.poyta,
            this.tilausaika,
            this.loppusumma});
            this.TilauksetLtk.Location = new System.Drawing.Point(296, 20);
            this.TilauksetLtk.MultiSelect = false;
            this.TilauksetLtk.Name = "TilauksetLtk";
            this.TilauksetLtk.RowHeadersVisible = false;
            this.TilauksetLtk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TilauksetLtk.Size = new System.Drawing.Size(562, 215);
            this.TilauksetLtk.TabIndex = 32;
            // 
            // tilausnro
            // 
            this.tilausnro.HeaderText = "Tilausnro";
            this.tilausnro.Name = "tilausnro";
            this.tilausnro.ReadOnly = true;
            this.tilausnro.Width = 70;
            // 
            // poyta
            // 
            this.poyta.HeaderText = "Pöytä";
            this.poyta.Name = "poyta";
            this.poyta.ReadOnly = true;
            this.poyta.Width = 170;
            // 
            // tilausaika
            // 
            this.tilausaika.HeaderText = "Tilausaika";
            this.tilausaika.Name = "tilausaika";
            this.tilausaika.ReadOnly = true;
            this.tilausaika.Width = 170;
            // 
            // loppusumma
            // 
            this.loppusumma.HeaderText = "Loppusumma";
            this.loppusumma.Name = "loppusumma";
            this.loppusumma.ReadOnly = true;
            // 
            // Saliavustaja
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 619);
            this.Controls.Add(this.TilauksetLtk);
            this.Controls.Add(this.TilauksetLabel);
            this.Controls.Add(this.UusiTilausButton);
            this.Controls.Add(this.TilausSummaLabel);
            this.Controls.Add(this.TilausVeroLabel);
            this.Controls.Add(this.TilausVerotonLabel);
            this.Controls.Add(this.KokonaishintaLabel);
            this.Controls.Add(this.VeronOsuusLabel);
            this.Controls.Add(this.VerotonHintaLabel);
            this.Controls.Add(this.LisaaTilausButton);
            this.Controls.Add(this.PeruTilausButton);
            this.Controls.Add(this.PoistaRiviButton);
            this.Controls.Add(this.LisaaRiviButton);
            this.Controls.Add(this.TilausRivitLtk);
            this.Controls.Add(this.RuokalistaLtk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValitsePoytaValikko);
            this.MinimumSize = new System.Drawing.Size(904, 657);
            this.Name = "Saliavustaja";
            this.Text = "Saliavustaja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Saliavustaja_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Saliavustaja_FormClosed);
            this.Load += new System.EventHandler(this.Saliavustaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TilausRivitLtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TilauksetLtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UusiTilausButton;
        private System.Windows.Forms.Label TilausSummaLabel;
        private System.Windows.Forms.Label TilausVeroLabel;
        private System.Windows.Forms.Label TilausVerotonLabel;
        private System.Windows.Forms.Label KokonaishintaLabel;
        private System.Windows.Forms.Label VeronOsuusLabel;
        private System.Windows.Forms.Label VerotonHintaLabel;
        private System.Windows.Forms.Button LisaaTilausButton;
        private System.Windows.Forms.Button PeruTilausButton;
        private System.Windows.Forms.Button PoistaRiviButton;
        private System.Windows.Forms.Button LisaaRiviButton;
        private System.Windows.Forms.DataGridView TilausRivitLtk;
        private System.Windows.Forms.ListView RuokalistaLtk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ValitsePoytaValikko;
        private System.Windows.Forms.Label TilauksetLabel;
        private System.Windows.Forms.ColumnHeader columnHeaderAhinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn maara;
        private System.Windows.Forms.DataGridView TilauksetLtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn tilausnro;
        private System.Windows.Forms.DataGridViewTextBoxColumn poyta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tilausaika;
        private System.Windows.Forms.DataGridViewTextBoxColumn loppusumma;
    }
}

