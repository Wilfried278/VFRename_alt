using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VFRename
{
    public partial class Form1 : Form
    {
        private CFormOptionen formOptionen = null;
        public Form1()
        {
            InitializeComponent();
            InitSteuerelemente();
        }
        /// <summary>
        /// Initialisieren der Steuerelemente der GUI
        /// </summary>
        private void InitSteuerelemente()
        {
            // neue Instanz für die Programnmoptionen initialisieren
            //
            formOptionen = new CFormOptionen();
            //
            //  Standardeisnetllungen herstellen
            //
            CheckBoxesVideoFilesEnabled(true);
            CheckBoxesImageFilesEnabled(true);
            RenameButtonEnabled(false);
            //
            //
            EDT_Präfix.Text = "Privatstunde";
            //
            // als Standard sollen das Erstelledaum der Datei und die Uhrzeit angehangen werden
            //
            RBTN_Erstelldatum.Checked = true;
            CHK_UhrzeitAnhängen.Checked = true;
            //
            //  Checkbox einmal umschlaten damit Rdatiobuttons enabled = false werden
            //
            CHK_OriginalDateinemenVerwenden.Checked = true;
            CHK_OriginalDateinemenVerwenden.Checked = false;

            formOptionen.DateiPfad = Properties.Settings.Default.letzerPfad;
        }

        /// <summary>
        /// Aktivieren/Deaktivieren der Checkboxen für Videofiles
        /// </summary>
        /// <param name="status"></param>
        private void CheckBoxesVideoFilesEnabled(bool status)
        {
            CHK_AVI.Checked = status;
            CHK_MOV.Checked = status;
            CHK_MTS.Checked = status;
            CHK_VOB.Checked = status;
            CHK_MP4.Checked = status;
        }

        /// <summary>
        /// Aktivieren/Deaktivieren der Checkboxen für Fotodateien
        /// </summary>
        /// <param name="status"></param>
        private void CheckBoxesImageFilesEnabled(bool status)
        {
            CHK_JPG.Checked = status;
            CHK_GIF.Checked = status;
            CHK_TIF.Checked = status;
        }


        /// <summary>
        /// Dateien des angegebenen Pfad ermitteln und bei erfolgreichem LÖaden der Dateinamen
        /// den Button um Renamen und zur Vorschau aktivieren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Pfad_Click(object sender, EventArgs e)
        {
            SteuerelementAktivieren(true);

            
            LVW_RenameErgebnis.Items.Clear();
            LBX_DateienVorhanden.Items.Clear();

            FolderBrowserDialog fb = new FolderBrowserDialog();
            // fb.SelectedPath = "C:\\";

            fb.SelectedPath = Properties.Settings.Default.letzerPfad;
            //
            //  Dialog zur Auswahl des Verzeichnisses starten
            //
            DialogResult result = fb.ShowDialog();
            if (result == DialogResult.OK)
            {
                formOptionen.DateiPfad = fb.SelectedPath;
                EDT_Pfad.Text = formOptionen.DateiPfad;
            }
            else
            {
                return; // der Dialog wurde mit Cancel geschlossen
            }
            BTN_Rename.Enabled = true;
            Properties.Settings.Default.letzerPfad = formOptionen.DateiPfad;
            Properties.Settings.Default.Save();
            LBL_Datenpfad.Text = "Vorhandene Dateien in " + formOptionen.DateiPfad;
            //
            //  Vesuch des Ladens der Dateinamen und bei erfolgreichem Laden
            //  die Schaltflächen zum Renamen und zur Vorschau aktivietrn
            //
            bool geladen = LadenDateinamen();
            if (geladen == true)
            {
                RenameButtonEnabled(true);
            }

        }
        /// <summary>
        /// Buttons BTN_Vorschau und BTN_Vorschau Enabled/Diabled
        /// </summary>
        /// <param name="status"></param>
        private void RenameButtonEnabled(bool status)
        {
            BTN_Vorschau.Enabled = status;
            BTN_Rename.Enabled = status;
        }

        /// <summary>
        /// Laden der Dateiinformationen. Wurden keine Dateien ermittel, (Anzahl = 0) wird false zurückgeliefert
        /// </summary>
        private bool LadenDateinamen()
        {

            List<string> dateierweiterungen = LadeExtensions();
            formOptionen.DateiErweiterungen = dateierweiterungen;
            //
            //  Quelldateien ermitteln auf Grund der Angaben der gewüscnhten Extension und des Pfades aus den formOptionen
            //
            CQuellDateinamen quelldateien = new CQuellDateinamen(formOptionen);

            formOptionen.Quelldateinamen = quelldateien.QuellVideoDateien;

            LBX_DateienVorhanden.Items.Clear();
            foreach (FileInfo finfo in quelldateien.QuellVideoDateien)
                LBX_DateienVorhanden.Items.Add(finfo.FullName);

            return quelldateien.QuellVideoDateien.Count < 1 ? false : true;
        }





        /// <summary>
        /// Laden der Tags (enstspricht den Dateiextensions der Videodateierweiterungen) 
        /// der angeklickten Checkboxen. Diese Tags werden in einer Liste zurückgegeben 
        /// </summary>
        private List<string> LadeExtensions()
        {
            List<string> extensions = new List<string>(10);

            foreach (Control c in GBXVideoDateierweiterungen.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox myChkBox = (CheckBox)c;
                    if (myChkBox.Checked == true)
                        extensions.Add((string)myChkBox.Tag);
                }
            }

            foreach (Control c in GBXFotoDateierweiterungen.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox myChkBox = (CheckBox)c;
                    if (myChkBox.Checked == true)
                        extensions.Add((string)myChkBox.Tag);
                }
            }
            return extensions;
        }

        private void CHK_OriginalDateinemenVerwenden_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_OriginalDateinemenVerwenden.Checked == true)
            {
                CHK_OriginalDateinemenVerwenden.Checked = true;

                RBTN_OrigNamePostfix.Checked = true;
                RBTN_OrigNamePräfix.Enabled = true;
                RBTN_OrigNamePostfix.Enabled = true;
                RBTN_OrigNamePostfix.Checked = true;
            }
            else
            {
                CHK_OriginalDateinemenVerwenden.Checked = false;
                RBTN_OrigNamePräfix.Enabled = false;
                RBTN_OrigNamePostfix.Enabled = false;
                RBTN_OrigNamePostfix.Checked = false;
            }
        }

        private void BTN_Rename_Click(object sender, EventArgs e)
        {
            bool simulation = false;
            StartRenameFiles(simulation);
        }

        private void StartRenameFiles(bool simulation)
        {
            if (simulation == false)
            {
                SteuerelementAktivieren(simulation);
            }


            // Einstellungen der GUI sichern
            //
            SichernFormOptionen();
            //
            //  Zieldateinanamen bestimmen und in Abhängigkeit von 'simulation'
            //  nur die Quelle-/Zieldateinamen zurückliefern oder den Rename 
            //  durchführen
            //
            CZieldateinamen ziel = new CZieldateinamen(formOptionen, simulation);
            List<CDateinamen> dateinamen = ziel.Gibdateinamen();

            int colWidth = LVW_RenameErgebnis.Width / 2;
            LVW_RenameErgebnis.Columns[0].Width = colWidth;
            LVW_RenameErgebnis.Columns[1].Width = colWidth;


            LVW_RenameErgebnis.Items.Clear();
            foreach (CDateinamen d  in dateinamen)
            {
                ListViewItem lvw = new ListViewItem(d.Quelledateiname);
                lvw.SubItems.Add(d.Zieldateiname);
                LVW_RenameErgebnis.Items.Add(lvw);
            }

            foreach(ColumnHeader col in LVW_RenameErgebnis.Columns) 
                col.Width = -1;
        }

        private void SteuerelementAktivieren(bool aktiv)
        {
            EDT_Präfix.Enabled = aktiv;
            BTN_Rename.Enabled = aktiv;
            BTN_Vorschau.Enabled = aktiv;
        }

        /// <summary>
        /// Sichern der Einstellung zum Umbenennen der Dateien in den FormOptionen
        /// </summary>
        private void SichernFormOptionen()
        {
            // Soll der Dateiname weitervverwendet werden, dann ermitteln ob es als Post- oder Präfix verwendet werden soll
            //
            if (CHK_OriginalDateinemenVerwenden.Checked == true)
            {
                formOptionen.OriginalDateinamenMitVerwenden = CHK_OriginalDateinemenVerwenden.Checked;
                formOptionen.DateinameAlsPostfix = RBTN_OrigNamePostfix.Checked;
                formOptionen.DateinameAlsPräfix = RBTN_OrigNamePräfix.Checked;
            }
            else
            {
                formOptionen.OriginalDateinamenMitVerwenden = CHK_OriginalDateinemenVerwenden.Checked;
                formOptionen.DateinameAlsPostfix = false;
                formOptionen.DateinameAlsPräfix = false;
            }

            formOptionen.Dateipräfix = EDT_Präfix.Text;
            formOptionen.ErstelldatumVerwenden = RBTN_Erstelldatum.Checked;
            formOptionen.ÄnderungsdatumVerwenden = RBTN_Änderungsdatum.Checked;
            formOptionen.UhrzeitAnhängen = CHK_UhrzeitAnhängen.Checked;
        }

        private void BTN_Vorschau_Click(object sender, EventArgs e)
        {
            bool simulation = true;
            StartRenameFiles(simulation);
        }
        /// <summary>
        /// Abbruch der Anwendung, bisher war diese Methiode leer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Abbruch_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Datenpfad_Click(object sender, EventArgs e)
        {
            string letzerpfad = Properties.Settings.Default.letzerPfad;

            if (Directory.Exists(letzerpfad))
                Process.Start("explorer.exe", letzerpfad);
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
