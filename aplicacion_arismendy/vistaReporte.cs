using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion_arismendy
{
    public partial class vistaReporte : Form
    {
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        public vistaReporte()
        {
            InitializeComponent();
            this.crv = this.crystalReportViewer1;
        }

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRV {
            set { this.crv = value;  }
            get { return this.crv; }
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
