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
            this.TilausListaLtk = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.TilauksenRivitLtk = new System.Windows.Forms.DataGridView();
            this.RuokalistaLtk = new System.Windows.Forms.ListView();
            this.columnHeaderAhinta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TilauksetLabel = new System.Windows.Forms.Label();
            columnHeaderTuote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.TilauksenRivitLtk)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeaderTuote
            // 
            columnHeaderTuote.Text = "Tuote";
            columnHeaderTuote.Width = 274;
            // 
            // TilausListaLtk
            // 
            this.TilausListaLtk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TilausListaLtk.Location = new System.Drawing.Point(297, 21);
            this.TilausListaLtk.Margin = new System.Windows.Forms.Padding(2);
            this.TilausListaLtk.MultiSelect = false;
            this.TilausListaLtk.Name = "TilausListaLtk";
            this.TilausListaLtk.Size = new System.Drawing.Size(562, 215);
            this.TilausListaLtk.TabIndex = 1;
            this.TilausListaLtk.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tilaus nro";
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
            // 
            // PoistaRiviButton
            // 
            this.PoistaRiviButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PoistaRiviButton.BackgroundImage")));
            this.PoistaRiviButton.Location = new System.Drawing.Point(395, 427);
            this.PoistaRiviButton.Margin = new System.Windows.Forms.Padding(2);
            this.PoistaRiviButton.Name = "PoistaRiviButton";
            this.PoistaRiviButton.Size = new System.Drawing.Size(75, 41);
            this.PoistaRiviButton.TabIndex = 21;
            this.PoistaRiviButton.Text = "<< Poista";
            this.PoistaRiviButton.UseVisualStyleBackColor = true;
            // 
            // LisaaRiviButton
            // 
            this.LisaaRiviButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LisaaRiviButton.BackgroundImage")));
            this.LisaaRiviButton.Location = new System.Drawing.Point(395, 372);
            this.LisaaRiviButton.Margin = new System.Windows.Forms.Padding(2);
            this.LisaaRiviButton.Name = "LisaaRiviButton";
            this.LisaaRiviButton.Size = new System.Drawing.Size(75, 41);
            this.LisaaRiviButton.TabIndex = 20;
            this.LisaaRiviButton.Text = "Lisää >>";
            this.LisaaRiviButton.UseVisualStyleBackColor = true;
            // 
            // TilauksenRivitLtk
            // 
            this.TilauksenRivitLtk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TilauksenRivitLtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TilauksenRivitLtk.Location = new System.Drawing.Point(493, 260);
            this.TilauksenRivitLtk.Margin = new System.Windows.Forms.Padding(2);
            this.TilauksenRivitLtk.MultiSelect = false;
            this.TilauksenRivitLtk.Name = "TilauksenRivitLtk";
            this.TilauksenRivitLtk.RowTemplate.Height = 24;
            this.TilauksenRivitLtk.Size = new System.Drawing.Size(365, 255);
            this.TilauksenRivitLtk.TabIndex = 19;
            // 
            // RuokalistaLtk
            // 
            this.RuokalistaLtk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeaderTuote,
            this.columnHeaderAhinta});
            this.RuokalistaLtk.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
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
            this.comboBox1.Location = new System.Drawing.Point(28, 260);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // Saliavustaja
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 619);
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
            this.Controls.Add(this.TilauksenRivitLtk);
            this.Controls.Add(this.RuokalistaLtk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TilausListaLtk);
            this.MinimumSize = new System.Drawing.Size(904, 657);
            this.Name = "Saliavustaja";
            this.Text = "Saliavustaja v0.02";
            ((System.ComponentModel.ISupportInitialize)(this.TilauksenRivitLtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TilausListaLtk;
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
        private System.Windows.Forms.DataGridView TilauksenRivitLtk;
        private System.Windows.Forms.ListView RuokalistaLtk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label TilauksetLabel;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeaderAhinta;
    }
}

