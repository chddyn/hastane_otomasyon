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
    public partial class DoktorEkle : DevExpress.XtraEditors.XtraForm
    {
        public DoktorEkle()
        {
            InitializeComponent();

            Temizle();
        }

        public void Temizle()
        {
            txtDoktorAdi.Text = "";
            txtDoktorSoyadi.Text = "";
            txtDoktorTel.Text = "";
            txtDoktorAdres.Text = "";

            gridControl1.DataSource = new dbDataContext().Tbl_Doktors;
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            doktorBolum.Properties.DataSource = db.Tbl_Bolums;
         

            doktorUnvan.Properties.DataSource = db.Tbl_Unvans;
          

            doktorSekreter.Properties.DataSource = db.Tbl_Sekreters;
          
        }

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {

            dbDataContext db = new dbDataContext();
            Tbl_Doktor dr = new Tbl_Doktor();
            dr.doktorAdi = txtDoktorAdi.Text;
            dr.doktorSoyadi= txtDoktorSoyadi.Text;
            dr.doktorTel = txtDoktorTel.Text;
            dr.doktorBolumid = int.Parse(doktorBolum.EditValue.ToString());
            //dr.doktorUnvanid = int.Parse(doktorUnvan.EditValue.ToString());
            //dr.doktorSekreterid = int.Parse(doktorSekreter.EditValue.ToString());
           
            db.Tbl_Doktors.InsertOnSubmit(dr);
            db.SubmitChanges();
            Temizle();
        }
    }
}