﻿namespace Saliavustaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TilauksetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TilausLista
            // 
            this.TilausLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TilausLista.Location = new System.Drawing.Point(226, 37);
            this.TilausLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TilausLista.Name = "TilausLista";
            this.TilausLista.Size = new System.Drawing.Size(562, 215);
            this.TilausLista.TabIndex = 1;
            this.TilausLista.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tilaus nro";
            // 
            // UusiTilausButton
            // 
            this.UusiTilausButton.Location = new System.Drawing.Point(32, 210);
            this.UusiTilausButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UusiTilausButton.Name = "UusiTilausButton";
            this.UusiTilausButton.Size = new System.Drawing.Size(83, 40);
            this.UusiTilausButton.TabIndex = 30;
            this.UusiTilausButton.Text = "Uusi tilaus";
            this.UusiTilausButton.UseVisualStyleBackColor = true;
            // 
            // TilausSummaLabel
            // 
            this.TilausSummaLabel.AutoSize = true;
            this.TilausSummaLabel.Location = new System.Drawing.Point(327, 609);
            this.TilausSummaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TilausSummaLabel.Name = "TilausSummaLabel";
            this.TilausSummaLabel.Size = new System.Drawing.Size(34, 13);
            this.TilausSummaLabel.TabIndex = 29;
            this.TilausSummaLabel.Text = "00,00";
            // 
            // VeroSummaLabel
            // 
            this.VeroSummaLabel.AutoSize = true;
            this.VeroSummaLabel.Location = new System.Drawing.Point(327, 587);
            this.VeroSummaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VeroSummaLabel.Name = "VeroSummaLabel";
            this.VeroSummaLabel.Size = new System.Drawing.Size(34, 13);
            this.VeroSummaLabel.TabIndex = 28;
            this.VeroSummaLabel.Text = "00,00";
            // 
            // VerotonSummaLabel
            // 
            this.VerotonSummaLabel.AutoSize = true;
            this.VerotonSummaLabel.Location = new System.Drawing.Point(327, 566);
            this.VerotonSummaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VerotonSummaLabel.Name = "VerotonSummaLabel";
            this.VerotonSummaLabel.Size = new System.Drawing.Size(34, 13);
            this.VerotonSummaLabel.TabIndex = 27;
            this.VerotonSummaLabel.Text = "00,00";
            // 
            // KokonaishintaLabel
            // 
            this.KokonaishintaLabel.AutoSize = true;
            this.KokonaishintaLabel.Location = new System.Drawing.Point(31, 609);
            this.KokonaishintaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KokonaishintaLabel.Name = "KokonaishintaLabel";
            this.KokonaishintaLabel.Size = new System.Drawing.Size(122, 13);
            this.KokonaishintaLabel.TabIndex = 26;
            this.KokonaishintaLabel.Text = "Tilauksen kokonaishinta";
            // 
            // VeronOsuusLabel
            // 
            this.VeronOsuusLabel.AutoSize = true;
            this.VeronOsuusLabel.Location = new System.Drawing.Point(31, 587);
            this.VeronOsuusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VeronOsuusLabel.Name = "VeronOsuusLabel";
            this.VeronOsuusLabel.Size = new System.Drawing.Size(66, 13);
            this.VeronOsuusLabel.TabIndex = 25;
            this.VeronOsuusLabel.Text = "Veron osuus";
            // 
            // VerotonHintaLabel
            // 
            this.VerotonHintaLabel.AutoSize = true;
            this.VerotonHintaLabel.Location = new System.Drawing.Point(31, 566);
            this.VerotonHintaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VerotonHintaLabel.Name = "VerotonHintaLabel";
            this.VerotonHintaLabel.Size = new System.Drawing.Size(70, 13);
            this.VerotonHintaLabel.TabIndex = 24;
            this.VerotonHintaLabel.Text = "Veroton hinta";
            // 
            // LisaaTilausButton
            // 
            this.LisaaTilausButton.Location = new System.Drawing.Point(688, 581);
            this.LisaaTilausButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LisaaTilausButton.Name = "LisaaTilausButton";
            this.LisaaTilausButton.Size = new System.Drawing.Size(100, 37);
            this.LisaaTilausButton.TabIndex = 23;
            this.LisaaTilausButton.Text = "Lisää tilaus";
            this.LisaaTilausButton.UseVisualStyleBackColor = true;
            // 
            // PeruTilausButton
            // 
            this.PeruTilausButton.Location = new System.Drawing.Point(571, 581);
            this.PeruTilausButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PeruTilausButton.Name = "PeruTilausButton";
            this.PeruTilausButton.Size = new System.Drawing.Size(106, 37);
            this.PeruTilausButton.TabIndex = 22;
            this.PeruTilausButton.Text = "Peru tilaus";
            this.PeruTilausButton.UseVisualStyleBackColor = true;
            // 
            // PoistaAteriaButton
            // 
            this.PoistaAteriaButton.Location = new System.Drawing.Point(379, 447);
            this.PoistaAteriaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PoistaAteriaButton.Name = "PoistaAteriaButton";
            this.PoistaAteriaButton.Size = new System.Drawing.Size(83, 40);
            this.PoistaAteriaButton.TabIndex = 21;
            this.PoistaAteriaButton.Text = "<< Poista";
            this.PoistaAteriaButton.UseVisualStyleBackColor = true;
            // 
            // LisaaAteriaButton
            // 
            this.LisaaAteriaButton.Location = new System.Drawing.Point(379, 402);
            this.LisaaAteriaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LisaaAteriaButton.Name = "LisaaAteriaButton";
            this.LisaaAteriaButton.Size = new System.Drawing.Size(83, 40);
            this.LisaaAteriaButton.TabIndex = 20;
            this.LisaaAteriaButton.Text = "Lisää >>";
            this.LisaaAteriaButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 325);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 225);
            this.dataGridView1.TabIndex = 19;
            // 
            // RuokalistaLaatikko
            // 
            this.RuokalistaLaatikko.Location = new System.Drawing.Point(28, 325);
            this.RuokalistaLaatikko.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RuokalistaLaatikko.Name = "RuokalistaLaatikko";
            this.RuokalistaLaatikko.Size = new System.Drawing.Size(334, 226);
            this.RuokalistaLaatikko.TabIndex = 18;
            this.RuokalistaLaatikko.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 267);
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
            "testipöytä1",
            "testipöytä2"});
            this.comboBox1.Location = new System.Drawing.Point(28, 289);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TilauksetLabel
            // 
            this.TilauksetLabel.AutoSize = true;
            this.TilauksetLabel.Location = new System.Drawing.Point(165, 36);
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
            this.ClientSize = new System.Drawing.Size(818, 639);
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
    }
}

