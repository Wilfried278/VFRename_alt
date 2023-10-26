using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VFRename
{
  /// <summary>
  /// Dateien die bearbeitet werden sollen,werden mit dieser Klasse geladen
  /// </summary>
  public class CQuellDateinamen
  {
    private List<FileInfo> quellDateien = new List<FileInfo>(100);
    private List<string> extensions;
    private string pfad;

    public CQuellDateinamen(CFormOptionen fOptionen)
    {
      VideoDateipfad = fOptionen.DateiPfad;
      Extensions = fOptionen.DateiErweiterungen;

      QuellVideoDateien = DateinamenErmitteln();
    }

    public string VideoDateipfad { get => pfad; set => pfad = value; }
    public List<string> Extensions { get => extensions; set => extensions = value; }
    public List<FileInfo> QuellVideoDateien { get => quellDateien; private set => quellDateien = value; }

    private List<FileInfo> DateinamenErmitteln()
    {
      List<FileInfo> fileInfoBlöcke = new List<FileInfo>(100);

      //  Alle Dateierweiterung durchlaufebn und die Dateien im angegebenen Pfad suchen
      //  die Fileinformationen dieser infrage kommenden Dateien in Liste speichern
      //
      foreach (string ext in Extensions)
      {
        //  Suchmaske zusammenbauen
        //
        string suchMaske = "*." + ext;
        //
        //  Informationen des angegebenen Verzeichnisses laden
        //
        DirectoryInfo di = new DirectoryInfo(VideoDateipfad);
        //
        //  Dateien die er Extension entsprechen einlesen
        //
        FileInfo[] fileEntries = di.GetFiles(suchMaske);
        //
        // Fileinformationen in Liste speichern
        //
        fileInfoBlöcke.AddRange(fileEntries);
      }
      return fileInfoBlöcke;
    }


  }
}
