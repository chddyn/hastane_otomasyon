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
    public partial class FrmilacListesi : DevExpress.XtraEditors.XtraForm
    {
        public FrmilacListesi()
        {
            InitializeComponent();
        }

        private void FrmilacListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet2.Tbl_ilac' table. You can move, or remove it, as needed.
            this.tbl_ilacTableAdapter.Fill(this.hastaneDataSet2.Tbl_ilac);

        }
    }
}