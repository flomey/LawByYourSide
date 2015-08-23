using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace LawByYourSide
{
    public partial class pane : UserControl
    {
        public pane()
        {
            InitializeComponent();
        }

        private void pane_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void query_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(norm_input.Text))
                {
                    LawRetrieval xmlRetriever = new LawRetrieval();
                    xmlRetriever.loadXMLDoc(norm_input.Text);
                    output.Text = xmlRetriever.getNorm(norm_input.Text);
                    Dictionary<int, Norm> norms;

                    IEnumerable<XElement> allNormsXML = xmlRetriever.getAllNorms();
                    norms = this.getDictFromXMLLaw(allNormsXML);
                }
            }
            catch (COMException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private Dictionary<int, Norm> getDictFromXMLLaw(IEnumerable<XElement> normsXML)
        {
            Dictionary<int, Norm> res = new Dictionary<int, Norm>();
            int i = 0;
            foreach (XElement xEle in normsXML)
            {
                res.Add(i, new Norm
                {
                    number = "test",
                    title = "testTitle",
                    content = "testcontent"
                });
                i++;
            }
            return res;
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void tree_laws_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }

    public class Norm
    {
        public string number { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}
