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

namespace WindowsFormsApp3
{
    public partial class DoktorAnasayfaForm : DevExpress.XtraEditors.XtraForm
    {
        public DoktorAnasayfaForm()
        {
            InitializeComponent();
        }

       

        private void DoktorAnasayfaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = new dbDataContext().Tbl_Doktors;
        }
    }
}