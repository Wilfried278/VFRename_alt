using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VFRename
{
  public class CFormOptionen
  {
    private string dateiPfad;
    private string dateipräfix;
    private bool originalDateinamenMitVerwenden;
    private bool dateinameAlsPräfix;
    private bool dateinameAlsPotfix;
    private bool erstelldatumVerwenden;
    private bool änderungsdatumVerwenden;
    private bool uhrzeitAnhängen;
    private List<string> dateiErweiterungen=null;
    private List<FileInfo> quelldateinamen = null;
    public CFormOptionen()
    {

    }

    public string Dateipräfix { get => dateipräfix; set => dateipräfix = value; }
    public bool OriginalDateinamenMitVerwenden { get => originalDateinamenMitVerwenden; set => originalDateinamenMitVerwenden = value; }
    public bool DateinameAlsPräfix { get => dateinameAlsPräfix; set => dateinameAlsPräfix = value; }
    public bool DateinameAlsPostfix { get => dateinameAlsPotfix; set => dateinameAlsPotfix = value; }
    public bool ErstelldatumVerwenden { get => erstelldatumVerwenden; set => erstelldatumVerwenden = value; }
    public bool ÄnderungsdatumVerwenden { get => änderungsdatumVerwenden; set => änderungsdatumVerwenden = value; }
    public bool UhrzeitAnhängen { get => uhrzeitAnhängen; set => uhrzeitAnhängen = value; }
    public List<string> DateiErweiterungen { get => dateiErweiterungen; set => dateiErweiterungen = value; }
    public string DateiPfad { get => dateiPfad; set => dateiPfad = value; }
    public List<FileInfo> Quelldateinamen { get => quelldateinamen; set => quelldateinamen = value; }
  }
}
