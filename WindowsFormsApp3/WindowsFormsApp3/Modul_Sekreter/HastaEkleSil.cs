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
    public partial class HastaEkleSil : DevExpress.XtraEditors.XtraForm
    {
        public HastaEkleSil()
        {
            InitializeComponent();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            Tbl_Hasta hasta = new Tbl_Hasta();
            hasta.hastaAdi = txtHastaAdi.Text;
            hasta.hastaSoyadi = txtHastaSoyadi.Text;
            hasta.hastaTel = txtHastaTel.Text;
            hasta.hastaAdres = txtHastaAdresi.Text;

            db.Tbl_Hastas.InsertOnSubmit(hasta);
            db.SubmitChanges();

        }

        private void HastaEkleSil_Load(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            Tbl_Hasta hasta = new Tbl_Hasta();
            
           
            
            
            
        }
    }
}