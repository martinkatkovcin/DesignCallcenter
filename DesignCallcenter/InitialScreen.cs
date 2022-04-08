using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignCallcenter
{
    public partial class Initial : DevExpress.XtraEditors.XtraUserControl
    {
        public Initial()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            XtraForm2 form = new XtraForm2();
            form.ShowDialog();
        }
    }
}
