using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class Report
    {
        private string html;

        public virtual string HTML
        {
            get { return html; }
            set { html = value; }
        }


        public Report()
        {
            html = "";
        }

        public void replace(string key, object o)
        {
            if (o == null) return;
            HTML = HTML.Replace("{{"+key+"}}", o.ToString());
        }
    }
}
