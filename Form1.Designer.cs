namespace VFRename
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Beenden = new System.Windows.Forms.Button();
            this.EDT_Pfad = new System.Windows.Forms.TextBox();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.GBXFotoDateierweiterungen = new System.Windows.Forms.GroupBox();
            this.CHK_JPG = new System.Windows.Forms.CheckBox();
            this.CHK_TIF = new System.Windows.Forms.CheckBox();
            this.CHK_GIF = new System.Windows.Forms.CheckBox();
            this.GBXVideoDateierweiterungen = new System.Windows.Forms.GroupBox();
            this.CHK_MTS = new System.Windows.Forms.CheckBox();
            this.CHK_MP4 = new System.Windows.Forms.CheckBox();
            this.CHK_VOB = new System.Windows.Forms.CheckBox();
            this.CHK_AVI = new System.Windows.Forms.CheckBox();
            this.CHK_MOV = new System.Windows.Forms.CheckBox();
            this.CHK_Pfad = new System.Windows.Forms.Button();
            this.BTN_Rename = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RBTN_Änderungsdatum = new System.Windows.Forms.RadioButton();
            this.RBTN_Erstelldatum = new System.Windows.Forms.RadioButton();
            this.CHK_UhrzeitAnhängen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDT_Präfix = new System.Windows.Forms.TextBox();
            this.RBTN_OrigNamePostfix = new System.Windows.Forms.RadioButton();
            this.RBTN_OrigNamePräfix = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBX_Originaldateinamen = new System.Windows.Forms.GroupBox();
            this.CHK_OriginalDateinemenVerwenden = new System.Windows.Forms.CheckBox();
            this.LBX_DateienVorhanden = new System.Windows.Forms.ListBox();
            this.BTN_Vorschau = new System.Windows.Forms.Button();
            this.LVW_RenameErgebnis = new System.Windows.Forms.ListView();
            this.colUrsprung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColZielname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Datenpfad = new System.Windows.Forms.Button();
            this.LBL_Datenpfad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupbox1.SuspendLayout();
            this.GBXFotoDateierweiterungen.SuspendLayout();
            this.GBXVideoDateierweiterungen.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GBX_Originaldateinamen.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Beenden
            // 
            this.BTN_Beenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Beenden.Location = new System.Drawing.Point(652, 12);
            this.BTN_Beenden.Name = "BTN_Beenden";
            this.BTN_Beenden.Size = new System.Drawing.Size(75, 23);
            this.BTN_Beenden.TabIndex = 0;
            this.BTN_Beenden.Text = "Beenden";
            this.BTN_Beenden.UseVisualStyleBackColor = true;
            this.BTN_Beenden.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // EDT_Pfad
            // 
            this.EDT_Pfad.Location = new System.Drawing.Point(24, 34);
            this.EDT_Pfad.Name = "EDT_Pfad";
            this.EDT_Pfad.ReadOnly = true;
            this.EDT_Pfad.Size = new System.Drawing.Size(524, 20);
            this.EDT_Pfad.TabIndex = 2;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.GBXFotoDateierweiterungen);
            this.groupbox1.Controls.Add(this.GBXVideoDateierweiterungen);
            this.groupbox1.Controls.Add(this.CHK_Pfad);
            this.groupbox1.Controls.Add(this.EDT_Pfad);
            this.groupbox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(616, 213);
            this.groupbox1.TabIndex = 3;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Dateioptionen";
            // 
            // GBXFotoDateierweiterungen
            // 
            this.GBXFotoDateierweiterungen.Controls.Add(this.CHK_JPG);
            this.GBXFotoDateierweiterungen.Controls.Add(this.CHK_TIF);
            this.GBXFotoDateierweiterungen.Controls.Add(this.CHK_GIF);
            this.GBXFotoDateierweiterungen.Location = new System.Drawing.Point(24, 134);
            this.GBXFotoDateierweiterungen.Name = "GBXFotoDateierweiterungen";
            this.GBXFotoDateierweiterungen.Size = new System.Drawing.Size(524, 59);
            this.GBXFotoDateierweiterungen.TabIndex = 9;
            this.GBXFotoDateierweiterungen.TabStop = false;
            this.GBXFotoDateierweiterungen.Text = "Fotodateien";
            // 
            // CHK_JPG
            // 
            this.CHK_JPG.AutoSize = true;
            this.CHK_JPG.Location = new System.Drawing.Point(18, 28);
            this.CHK_JPG.Name = "CHK_JPG";
            this.CHK_JPG.Size = new System.Drawing.Size(46, 17);
            this.CHK_JPG.TabIndex = 3;
            this.CHK_JPG.Tag = "JPG";
            this.CHK_JPG.Text = "JPG";
            this.CHK_JPG.UseVisualStyleBackColor = true;
            // 
            // CHK_TIF
            // 
            this.CHK_TIF.AutoSize = true;
            this.CHK_TIF.Location = new System.Drawing.Point(164, 28);
            this.CHK_TIF.Name = "CHK_TIF";
            this.CHK_TIF.Size = new System.Drawing.Size(42, 17);
            this.CHK_TIF.TabIndex = 4;
            this.CHK_TIF.Tag = "TIF";
            this.CHK_TIF.Text = "TIF";
            this.CHK_TIF.UseVisualStyleBackColor = true;
            // 
            // CHK_GIF
            // 
            this.CHK_GIF.AutoSize = true;
            this.CHK_GIF.Location = new System.Drawing.Point(91, 28);
            this.CHK_GIF.Name = "CHK_GIF";
            this.CHK_GIF.Size = new System.Drawing.Size(43, 17);
            this.CHK_GIF.TabIndex = 6;
            this.CHK_GIF.Tag = "GIF";
            this.CHK_GIF.Text = "GIF";
            this.CHK_GIF.UseVisualStyleBackColor = true;
            // 
            // GBXVideoDateierweiterungen
            // 
            this.GBXVideoDateierweiterungen.Controls.Add(this.CHK_MTS);
            this.GBXVideoDateierweiterungen.Controls.Add(this.CHK_MP4);
            this.GBXVideoDateierweiterungen.Controls.Add(this.CHK_VOB);
            this.GBXVideoDateierweiterungen.Controls.Add(this.CHK_AVI);
            this.GBXVideoDateierweiterungen.Controls.Add(this.CHK_MOV);
            this.GBXVideoDateierweiterungen.Location = new System.Drawing.Point(24, 69);
            this.GBXVideoDateierweiterungen.Name = "GBXVideoDateierweiterungen";
            this.GBXVideoDateierweiterungen.Size = new System.Drawing.Size(524, 59);
            this.GBXVideoDateierweiterungen.TabIndex = 4;
            this.GBXVideoDateierweiterungen.TabStop = false;
            this.GBXVideoDateierweiterungen.Text = "Videodateien";
            // 
            // CHK_MTS
            // 
            this.CHK_MTS.AutoSize = true;
            this.CHK_MTS.Location = new System.Drawing.Point(18, 28);
            this.CHK_MTS.Name = "CHK_MTS";
            this.CHK_MTS.Size = new System.Drawing.Size(49, 17);
            this.CHK_MTS.TabIndex = 3;
            this.CHK_MTS.Tag = "MTS";
            this.CHK_MTS.Text = "MTS";
            this.CHK_MTS.UseVisualStyleBackColor = true;
            // 
            // CHK_MP4
            // 
            this.CHK_MP4.AutoSize = true;
            this.CHK_MP4.Location = new System.Drawing.Point(235, 28);
            this.CHK_MP4.Name = "CHK_MP4";
            this.CHK_MP4.Size = new System.Drawing.Size(48, 17);
            this.CHK_MP4.TabIndex = 7;
            this.CHK_MP4.Tag = "MP4";
            this.CHK_MP4.Text = "MP4";
            this.CHK_MP4.UseVisualStyleBackColor = true;
            // 
            // CHK_VOB
            // 
            this.CHK_VOB.AutoSize = true;
            this.CHK_VOB.Location = new System.Drawing.Point(164, 28);
            this.CHK_VOB.Name = "CHK_VOB";
            this.CHK_VOB.Size = new System.Drawing.Size(48, 17);
            this.CHK_VOB.TabIndex = 4;
            this.CHK_VOB.Tag = "VOB";
            this.CHK_VOB.Text = "VOB";
            this.CHK_VOB.UseVisualStyleBackColor = true;
            // 
            // CHK_AVI
            // 
            this.CHK_AVI.AutoSize = true;
            this.CHK_AVI.Location = new System.Drawing.Point(91, 28);
            this.CHK_AVI.Name = "CHK_AVI";
            this.CHK_AVI.Size = new System.Drawing.Size(43, 17);
            this.CHK_AVI.TabIndex = 6;
            this.CHK_AVI.Tag = "AVI";
            this.CHK_AVI.Text = "AVI";
            this.CHK_AVI.UseVisualStyleBackColor = true;
            // 
            // CHK_MOV
            // 
            this.CHK_MOV.AutoSize = true;
            this.CHK_MOV.Location = new System.Drawing.Point(309, 28);
            this.CHK_MOV.Name = "CHK_MOV";
            this.CHK_MOV.Size = new System.Drawing.Size(50, 17);
            this.CHK_MOV.TabIndex = 5;
            this.CHK_MOV.Tag = "MOV";
            this.CHK_MOV.Text = "MOV";
            this.CHK_MOV.UseVisualStyleBackColor = true;
            // 
            // CHK_Pfad
            // 
            this.CHK_Pfad.Location = new System.Drawing.Point(554, 32);
            this.CHK_Pfad.Name = "CHK_Pfad";
            this.CHK_Pfad.Size = new System.Drawing.Size(26, 23);
            this.CHK_Pfad.TabIndex = 8;
            this.CHK_Pfad.Text = "...";
            this.CHK_Pfad.UseVisualStyleBackColor = true;
            this.CHK_Pfad.Click += new System.EventHandler(this.BTN_Pfad_Click);
            // 
            // BTN_Rename
            // 
            this.BTN_Rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Rename.Location = new System.Drawing.Point(553, 270);
            this.BTN_Rename.Name = "BTN_Rename";
            this.BTN_Rename.Size = new System.Drawing.Size(75, 23);
            this.BTN_Rename.TabIndex = 9;
            this.BTN_Rename.Text = "Rename";
            this.BTN_Rename.UseVisualStyleBackColor = true;
            this.BTN_Rename.Click += new System.EventHandler(this.BTN_Rename_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RBTN_Änderungsdatum);
            this.groupBox3.Controls.Add(this.RBTN_Erstelldatum);
            this.groupBox3.Controls.Add(this.CHK_UhrzeitAnhängen);
            this.groupBox3.Location = new System.Drawing.Point(345, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 144);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datum und Uhrzeit";
            // 
            // RBTN_Änderungsdatum
            // 
            this.RBTN_Änderungsdatum.AutoSize = true;
            this.RBTN_Änderungsdatum.Location = new System.Drawing.Point(25, 53);
            this.RBTN_Änderungsdatum.Name = "RBTN_Änderungsdatum";
            this.RBTN_Änderungsdatum.Size = new System.Drawing.Size(156, 17);
            this.RBTN_Änderungsdatum.TabIndex = 9;
            this.RBTN_Änderungsdatum.TabStop = true;
            this.RBTN_Änderungsdatum.Text = "Änderungsdatum anhängen";
            this.RBTN_Änderungsdatum.UseVisualStyleBackColor = true;
            // 
            // RBTN_Erstelldatum
            // 
            this.RBTN_Erstelldatum.AutoSize = true;
            this.RBTN_Erstelldatum.Location = new System.Drawing.Point(25, 30);
            this.RBTN_Erstelldatum.Name = "RBTN_Erstelldatum";
            this.RBTN_Erstelldatum.Size = new System.Drawing.Size(133, 17);
            this.RBTN_Erstelldatum.TabIndex = 9;
            this.RBTN_Erstelldatum.TabStop = true;
            this.RBTN_Erstelldatum.Text = "Erstelldatum anhängen";
            this.RBTN_Erstelldatum.UseVisualStyleBackColor = true;
            // 
            // CHK_UhrzeitAnhängen
            // 
            this.CHK_UhrzeitAnhängen.AutoSize = true;
            this.CHK_UhrzeitAnhängen.Location = new System.Drawing.Point(25, 88);
            this.CHK_UhrzeitAnhängen.Name = "CHK_UhrzeitAnhängen";
            this.CHK_UhrzeitAnhängen.Size = new System.Drawing.Size(110, 17);
            this.CHK_UhrzeitAnhängen.TabIndex = 8;
            this.CHK_UhrzeitAnhängen.Text = "Uhrzeit anhängen";
            this.CHK_UhrzeitAnhängen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dateipräfix";
            // 
            // EDT_Präfix
            // 
            this.EDT_Präfix.Location = new System.Drawing.Point(69, 25);
            this.EDT_Präfix.Name = "EDT_Präfix";
            this.EDT_Präfix.Size = new System.Drawing.Size(230, 20);
            this.EDT_Präfix.TabIndex = 0;
            // 
            // RBTN_OrigNamePostfix
            // 
            this.RBTN_OrigNamePostfix.AutoSize = true;
            this.RBTN_OrigNamePostfix.Location = new System.Drawing.Point(6, 50);
            this.RBTN_OrigNamePostfix.Name = "RBTN_OrigNamePostfix";
            this.RBTN_OrigNamePostfix.Size = new System.Drawing.Size(163, 17);
            this.RBTN_OrigNamePostfix.TabIndex = 11;
            this.RBTN_OrigNamePostfix.TabStop = true;
            this.RBTN_OrigNamePostfix.Text = "Orginaldateinamen als Postfix";
            this.RBTN_OrigNamePostfix.UseVisualStyleBackColor = true;
            // 
            // RBTN_OrigNamePräfix
            // 
            this.RBTN_OrigNamePräfix.AutoSize = true;
            this.RBTN_OrigNamePräfix.Location = new System.Drawing.Point(6, 27);
            this.RBTN_OrigNamePräfix.Name = "RBTN_OrigNamePräfix";
            this.RBTN_OrigNamePräfix.Size = new System.Drawing.Size(158, 17);
            this.RBTN_OrigNamePräfix.TabIndex = 12;
            this.RBTN_OrigNamePräfix.TabStop = true;
            this.RBTN_OrigNamePräfix.Text = "Orginaldateinamen als Präfix";
            this.RBTN_OrigNamePräfix.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GBX_Originaldateinamen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EDT_Präfix);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 144);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dateinamen";
            // 
            // GBX_Originaldateinamen
            // 
            this.GBX_Originaldateinamen.Controls.Add(this.CHK_OriginalDateinemenVerwenden);
            this.GBX_Originaldateinamen.Controls.Add(this.RBTN_OrigNamePostfix);
            this.GBX_Originaldateinamen.Controls.Add(this.RBTN_OrigNamePräfix);
            this.GBX_Originaldateinamen.Location = new System.Drawing.Point(69, 60);
            this.GBX_Originaldateinamen.Name = "GBX_Originaldateinamen";
            this.GBX_Originaldateinamen.Size = new System.Drawing.Size(230, 78);
            this.GBX_Originaldateinamen.TabIndex = 11;
            this.GBX_Originaldateinamen.TabStop = false;
            this.GBX_Originaldateinamen.Text = "groupBox4";
            // 
            // CHK_OriginalDateinemenVerwenden
            // 
            this.CHK_OriginalDateinemenVerwenden.AutoSize = true;
            this.CHK_OriginalDateinemenVerwenden.Location = new System.Drawing.Point(6, 0);
            this.CHK_OriginalDateinemenVerwenden.Name = "CHK_OriginalDateinemenVerwenden";
            this.CHK_OriginalDateinemenVerwenden.Size = new System.Drawing.Size(188, 17);
            this.CHK_OriginalDateinemenVerwenden.TabIndex = 12;
            this.CHK_OriginalDateinemenVerwenden.Text = "Originaldateinamen mit verwenden";
            this.CHK_OriginalDateinemenVerwenden.UseVisualStyleBackColor = true;
            this.CHK_OriginalDateinemenVerwenden.CheckedChanged += new System.EventHandler(this.CHK_OriginalDateinemenVerwenden_CheckedChanged);
            // 
            // LBX_DateienVorhanden
            // 
            this.LBX_DateienVorhanden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_DateienVorhanden.FormattingEnabled = true;
            this.LBX_DateienVorhanden.Location = new System.Drawing.Point(16, 402);
            this.LBX_DateienVorhanden.Name = "LBX_DateienVorhanden";
            this.LBX_DateienVorhanden.Size = new System.Drawing.Size(711, 147);
            this.LBX_DateienVorhanden.TabIndex = 11;
            // 
            // BTN_Vorschau
            // 
            this.BTN_Vorschau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Vorschau.Location = new System.Drawing.Point(553, 241);
            this.BTN_Vorschau.Name = "BTN_Vorschau";
            this.BTN_Vorschau.Size = new System.Drawing.Size(75, 23);
            this.BTN_Vorschau.TabIndex = 12;
            this.BTN_Vorschau.Text = "Vorschau";
            this.BTN_Vorschau.UseVisualStyleBackColor = true;
            this.BTN_Vorschau.Click += new System.EventHandler(this.BTN_Vorschau_Click);
            // 
            // LVW_RenameErgebnis
            // 
            this.LVW_RenameErgebnis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUrsprung,
            this.ColZielname});
            this.LVW_RenameErgebnis.GridLines = true;
            this.LVW_RenameErgebnis.HideSelection = false;
            this.LVW_RenameErgebnis.Location = new System.Drawing.Point(16, 583);
            this.LVW_RenameErgebnis.Name = "LVW_RenameErgebnis";
            this.LVW_RenameErgebnis.Size = new System.Drawing.Size(711, 143);
            this.LVW_RenameErgebnis.TabIndex = 13;
            this.LVW_RenameErgebnis.UseCompatibleStateImageBehavior = false;
            this.LVW_RenameErgebnis.View = System.Windows.Forms.View.Details;
            // 
            // colUrsprung
            // 
            this.colUrsprung.Text = "Ursprungsdateiname";
            this.colUrsprung.Width = 351;
            // 
            // ColZielname
            // 
            this.ColZielname.Text = "Zieldateiname";
            this.ColZielname.Width = 350;
            // 
            // BTN_Datenpfad
            // 
            this.BTN_Datenpfad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Datenpfad.Location = new System.Drawing.Point(553, 352);
            this.BTN_Datenpfad.Name = "BTN_Datenpfad";
            this.BTN_Datenpfad.Size = new System.Drawing.Size(75, 23);
            this.BTN_Datenpfad.TabIndex = 14;
            this.BTN_Datenpfad.Text = "Datenpfad";
            this.BTN_Datenpfad.UseVisualStyleBackColor = true;
            this.BTN_Datenpfad.Click += new System.EventHandler(this.BTN_Datenpfad_Click);
            // 
            // LBL_Datenpfad
            // 
            this.LBL_Datenpfad.AutoSize = true;
            this.LBL_Datenpfad.Location = new System.Drawing.Point(13, 386);
            this.LBL_Datenpfad.Name = "LBL_Datenpfad";
            this.LBL_Datenpfad.Size = new System.Drawing.Size(139, 13);
            this.LBL_Datenpfad.TabIndex = 15;
            this.LBL_Datenpfad.Text = "Vorhandene Datein im Plad ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ergebbnis der Konvertierung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_Datenpfad);
            this.Controls.Add(this.BTN_Datenpfad);
            this.Controls.Add(this.LVW_RenameErgebnis);
            this.Controls.Add(this.BTN_Vorschau);
            this.Controls.Add(this.LBX_DateienVorhanden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_Rename);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BTN_Beenden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.GBXFotoDateierweiterungen.ResumeLayout(false);
            this.GBXFotoDateierweiterungen.PerformLayout();
            this.GBXVideoDateierweiterungen.ResumeLayout(false);
            this.GBXVideoDateierweiterungen.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GBX_Originaldateinamen.ResumeLayout(false);
            this.GBX_Originaldateinamen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BTN_Beenden;
    private System.Windows.Forms.TextBox EDT_Pfad;
    private System.Windows.Forms.GroupBox groupbox1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.CheckBox CHK_UhrzeitAnhängen;
    private System.Windows.Forms.TextBox EDT_Präfix;
    private System.Windows.Forms.GroupBox GBXVideoDateierweiterungen;
    private System.Windows.Forms.CheckBox CHK_MTS;
    private System.Windows.Forms.CheckBox CHK_MP4;
    private System.Windows.Forms.CheckBox CHK_VOB;
    private System.Windows.Forms.CheckBox CHK_AVI;
    private System.Windows.Forms.CheckBox CHK_MOV;
    private System.Windows.Forms.Button CHK_Pfad;
    private System.Windows.Forms.Button BTN_Rename;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton RBTN_Änderungsdatum;
    private System.Windows.Forms.RadioButton RBTN_Erstelldatum;
    private System.Windows.Forms.RadioButton RBTN_OrigNamePostfix;
    private System.Windows.Forms.RadioButton RBTN_OrigNamePräfix;
    private System.Windows.Forms.GroupBox GBXFotoDateierweiterungen;
    private System.Windows.Forms.CheckBox CHK_JPG;
    private System.Windows.Forms.CheckBox CHK_TIF;
    private System.Windows.Forms.CheckBox CHK_GIF;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox GBX_Originaldateinamen;
    private System.Windows.Forms.CheckBox CHK_OriginalDateinemenVerwenden;
    private System.Windows.Forms.ListBox LBX_DateienVorhanden;
    private System.Windows.Forms.Button BTN_Vorschau;
        private System.Windows.Forms.ListView LVW_RenameErgebnis;
        private System.Windows.Forms.ColumnHeader colUrsprung;
        private System.Windows.Forms.ColumnHeader ColZielname;
        private System.Windows.Forms.Button BTN_Datenpfad;
        private System.Windows.Forms.Label LBL_Datenpfad;
        private System.Windows.Forms.Label label3;
    }
}

