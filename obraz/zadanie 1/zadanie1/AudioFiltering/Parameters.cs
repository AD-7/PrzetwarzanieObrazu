using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioFiltering
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();
            edWindowType.SelectedIndex = 2;
        }

        public int _frameSize;
        public float _frameHopSize;
        public bool _ifCausal;
        public int _filterSize;
        public float _filterCutOff;
        public int _WindowType;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveParams_Click(object sender, EventArgs e)
        {
            _ifCausal = chkCasual.Checked;
           if(!int.TryParse(edFrameSize.Text, out _frameSize))
            {
                throw new ArgumentOutOfRangeException("Nie można rzutować na int");
            }

            if (!int.TryParse(edFilterSize.Text, out _filterSize))
            {
                throw new ArgumentOutOfRangeException("Nie można rzutować na int");
            }
            if (!float.TryParse(edCutOffFilter.Text, out _filterCutOff))
            {
                throw new ArgumentOutOfRangeException("Nie można rzutować na float");
            }

            if (!float.TryParse(edHopSize.Text, out _frameHopSize))
            {
                throw new ArgumentOutOfRangeException("Nie można rzutować na float");
            }
            _WindowType = edWindowType.SelectedIndex;
            this.Close();
        }
    }
}
