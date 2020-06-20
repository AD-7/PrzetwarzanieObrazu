using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioFiltering
{
    public partial class GetFileName : Form
    {
        public GetFileName()
        {
            InitializeComponent();
        }
        public string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            fileName = edFilename.Text + ".wav";
            this.Close();
        }
    }
}
