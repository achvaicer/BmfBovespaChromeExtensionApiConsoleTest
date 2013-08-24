using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmfBovespaChromeExtensionApiConsoleTest.Model
{
    public class Cotacao
    {
        public string abertura { get; set; }
        public string codigo { get; set; }
        public string data { get; set; }
        public string ibovespa { get; set; }
        public string maxima { get; set; }
        public string media { get; set; }
        public string minima { get; set; }
        public string nome { get; set; }
        public string oscilacao { get; set; }
        public string ultima { get; set; }
        public Dictionary<string, HorarioCotacao> grafico { get; set; }
    }
}
