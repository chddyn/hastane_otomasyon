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
    public partial class FrmilacEkleSil : DevExpress.XtraEditors.XtraForm
    {
        public FrmilacEkleSil()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            Tbl_ilac ilac = new Tbl_ilac();
            ilac.ilacAdi = txtilacadi.Text;
            db.Tbl_ilacs.InsertOnSubmit(ilac);
            db.SubmitChanges();
        }

        private void FrmilacEkleSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet1.Tbl_ilac' table. You can move, or remove it, as needed.
            this.tbl_ilacTableAdapter.Fill(this.hastaneDataSet1.Tbl_ilac);

        }

        private void gridView1_Click(object sender, EventArgs e)
        {


            txtilacadi.Text = gridView1.GetFocusedRowCellValue(colilacAdi).ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            
            
           

            var ilacsil = txtilacadi.Text.Trim();
            Tbl_ilac ilac = db.Tbl_ilacs.First(ilacs => ilacs.ilacAdi == ilacsil);
            db.Tbl_ilacs.DeleteOnSubmit(ilac);
            db.SubmitChanges();
        }
    }
}