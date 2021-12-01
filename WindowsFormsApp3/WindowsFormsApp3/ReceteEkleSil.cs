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
    public partial class ReceteEkleSil : DevExpress.XtraEditors.XtraForm
    {
        public ReceteEkleSil()
        {
            InitializeComponent();
        }

        private void ReceteEkleSil_Load(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            hasta.Properties.DataSource = db.Tbl_Hastas;
            doktor.Properties.DataSource = db.Tbl_Doktors;
            sekreter.Properties.DataSource = db.Tbl_Sekreters;
            ilac.Properties.DataSource = db.Tbl_ilacs;

            gridControl1.DataSource = new dbDataContext().Tbl_Recetes;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}