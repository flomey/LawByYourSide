using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LawByYourSide
{
    public partial class LawRetrieval : Component
    {
        private XDocument xdoc;
        public LawRetrieval()
        {
            InitializeComponent();
        }

        public LawRetrieval(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void loadXMLDoc(String url)
        {
            this.xdoc = XDocument.Load(@"E:\desktop\BJNR001950896.xml");
        }
        public string getNorm(string norm_to_retrieve)
        {
            string res="";
            var law = from norm in this.xdoc.Descendants("norm")
                      where (string)norm.Element("metadaten").Element("enbez") == "§ " + norm_to_retrieve
                      select norm;
            foreach (XElement xEle in law)
            {
                res += xEle;
            }
            return res;
        }

        public IEnumerable<XElement> getAllNorms()
        {
            IEnumerable<XElement> res = from norm in this.xdoc.Descendants("norm") select norm;

            return res;
        }
    }

}
