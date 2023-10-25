using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFRename
{
    public class CDateinamenReport
    {
        private  List<CDateinamen> dateiliste = null;
        public CDateinamenReport()
        {
            dateiliste = new List<CDateinamen>(100);

        }

        public int Add(CDateinamen dateinamen)
        {
            dateiliste.Add(dateinamen);
            return dateiliste.Count();
        }

        public List<CDateinamen>  GibCDteinamenListe()
        {
            return dateiliste;
        }

    }

    /// <summary>
    /// Diese Klasse repräsentiert die Quelldateinamen und die für den Rename
    /// daraus resultierenden Zieldateinamen
    /// </summary>
    public class CDateinamen
    {
        public string Quelledateiname { get; private set; }
        public string Zieldateiname { get; private set; }

        public CDateinamen(string quelldateianame, string zieldateiname)
        {
            Quelledateiname = quelldateianame;
            Zieldateiname = zieldateiname;
        }
    }
}