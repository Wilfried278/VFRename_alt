﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;


namespace VFRename
{
    /// <summary>
    /// Ermitellt zu den FileInfoBlöcken die mit den  FormOptionen übergeben werden
    /// die Zieldateinamen
    /// </summary>
    public class CZieldateinamen
    {
        /// <summary>
        /// Quell- und Zieldateinamen des Renames
        /// </summary>
        CDateinamenReport report = null;

        //  alte Version
        //
        List<string> listBoxInfo;
        //
        //  Simulatuion eingeschaltet für Vorschau?
        //
        bool Simulation { get; set; }
        //
        // die Programmeinstekllungen und die Daten
        //
        CFormOptionen formOptionen;
        /// <summary>
        /// Konstruktion des Klasse
        /// </summary>
        /// <param name="formOptionen">Eingabedaten und Optionen</param>
        /// <param name="simulation">Vorschau true/false</param>
        public CZieldateinamen(CFormOptionen formOptionen, bool simulation = false)
        {
            report = new CDateinamenReport(); 
            FormOptionen = formOptionen;
            Simulation = simulation;

            ListBoxInfo = new List<string>();
            RenameFiles();
        }


        public CFormOptionen FormOptionen { get => formOptionen; set => formOptionen = value; }
        public List<string> ListBoxInfo { get => listBoxInfo; private set => listBoxInfo = value; }

        private void RenameFiles()
        {
            StreamWriter logfile = CreateStreamWriter("VFRename_FileName.vbs");

            DateTime heute = DateTime.Now;
            logfile.Write("' * Datum : ");
            logfile.WriteLine(heute.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
            logfile.WriteLine("' * Diese Script kann den Renaem von Videodateien rückgängig machen!");
            logfile.WriteLine("' * Das Script wurde automatisch durch das C# Programm VFRename erzeugt");
            logfile.WriteLine("'");
            logfile.WriteLine("On Error Resume next");
            logfile.WriteLine("Dim Fso");
            logfile.WriteLine("Set Fso = WScript.CreateObject(\"Scripting.FileSystemObject\")");
            logfile.WriteLine("result = msgbox (\"Rename rückgägig machen ? \", vbYesNo,  \"Rename\")");
            logfile.WriteLine("if (result = vbyes) then ");
            //
            //  alle Quelldateien un Reanem statement bilden
            //
            foreach (FileInfo fileInfo in FormOptionen.Quelldateinamen)
            {
                DateTime erzeugt = fileInfo.CreationTime;
                DateTime geändert = fileInfo.LastWriteTime;
                DateTime datum;

                if (formOptionen.ErstelldatumVerwenden == true)
                    datum = erzeugt;
                else
                    datum = geändert;

                string zieldateiname = ErzeugeZieldateiname(fileInfo, datum);

                WriteLogfile(logfile, fileInfo, zieldateiname);
                RenameFiles(fileInfo, zieldateiname);
            }
            //
            //  Errorjhandlicg schreiben
            //
            logfile.WriteLine("end if");
            logfile.WriteLine("if Err.Number <> 0 Then");
            logfile.WriteLine("\tMsgBox Err.Description, vbOkOnly, \"Fehler bei Rename!\"");
            logfile.WriteLine("end if");


            logfile.Close();
        }

        
        private void WriteLogfile(StreamWriter logfile, FileInfo file, string zieldateiname)
        {
            /*
            Dim Fso
            Set Fso = WScript.CreateObject("Scripting.FileSystemObject")
            Fso.MoveFile "A.txt", "B.txt"
            */

            logfile.Write("\tFso.MoveFile");

            logfile.Write(" \"");
            logfile.Write(zieldateiname);
            logfile.Write("\",");
            //logfile.Write(file.FullName);

            logfile.Write(" \"");
            logfile.Write(file.FullName); 
            logfile.Write("\"");
            logfile.WriteLine();

            string textListbox = file.FullName + " -> " + zieldateiname;
            ListBoxInfo.Add(textListbox);
        }

        private void RenameFiles(FileInfo file, string zieldateiname)
        {
            string dateiname = Path.GetFileName(zieldateiname);
            report.Add(new CDateinamen(file.Name, dateiname));

            if (Simulation == true)
            {
                return;
            }

            file.MoveTo(zieldateiname);
        }

        private StreamWriter CreateStreamWriter(string logfileName)
        {
            string pfad = FormOptionen.Quelldateinamen[0].DirectoryName;
            string logdatei = Path.Combine(pfad, logfileName);

            
            StreamWriter sw = new StreamWriter(logdatei, false, Encoding.Default);
            sw.Write("' * VFRename_FileName: ");
            sw.WriteLine(logfileName);
            return sw;

        }

        /// <summary>
        /// Aus einem FileInfo-Block die Daten der aktuellen Datei entnehmen und mit diesen Daten
        /// den neuen Dateinamen entsprechend den Vorgaben aus den globalen FormOptionen zusammenbauen 
        /// </summary>
        /// <param name="dateiInfo"></param>
        /// <param name="datum"></param>
        /// <returns></returns>
        private string ErzeugeZieldateiname(FileInfo dateiInfo, DateTime datum)
        {
           string trainerPostfix = bestimmeTrainerNachWochentag(datum);


            string zieldateiname = FormOptionen.DateiPfad + "\\";

            if (FormOptionen.OriginalDateinamenMitVerwenden == true)
            {
                if (FormOptionen.DateinameAlsPräfix == true)
                    zieldateiname += Path.GetFileNameWithoutExtension(dateiInfo.Name) + "_";
            }

            zieldateiname += FormOptionen.Dateipräfix;

            zieldateiname += "_" + trainerPostfix;

            if (FormOptionen.OriginalDateinamenMitVerwenden == true)
            {
                if (FormOptionen.DateinameAlsPostfix == true)
                    zieldateiname += "_" + Path.GetFileNameWithoutExtension(dateiInfo.Name);
            }

            zieldateiname += "_" + CreateDatumstempel(datum);

            if (FormOptionen.UhrzeitAnhängen == true)
                zieldateiname += "_" + CreateUhrzeittempel(datum);

            zieldateiname += dateiInfo.Extension;

            return zieldateiname;
        }


        /// <summary>
        /// Anhang des Wochentage wird der Suffix für den Dateinamen bestimmt
        /// </summary>
        /// <param name="datum"></param>
        /// <returns></returns>
        private string bestimmeTrainerNachWochentag(DateTime datum)
        {
            // Tag 0 = Sonntag 
            // Tag 1 = Montag       (Privatstunde Fee, selten Heiko)
            // Tag 4 = Donnertag    (Privatstunde Heiko, selten Fee)
            // Tag 5 = CT           (Competition Training)
            // Tag 6 = Samstag      (Privatstunde Heiko)
            int wochentag = (int) datum.DayOfWeek;
            //
            // Privatstunden bei Heiko Sonntags, Donnerstags oder Samstags
            //
            if (wochentag == 0 || wochentag == 4)
            {
                return "Heiko";
            }
            else if (wochentag == 1)
            {
                return "Fee";
            }
            else if (wochentag == 5)
                return "CT";
            else
                return "unbekannt";   
        }

        private string CreateUhrzeittempel(DateTime datum)
        {
            string uhrzeitStempel = datum.ToString("HHmmss");
            return uhrzeitStempel;
        }

        private string CreateDatumstempel(DateTime datum)
        {
            string datumStempel = datum.ToString("yyyyMMdd");
            return datumStempel;
        }

        internal List<CDateinamen> Gibdateinamen()
        {
            List<CDateinamen> kopie = report.GibCDteinamenListe();
            return kopie;
        }
    }

}
