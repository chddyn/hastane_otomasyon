using DevExpress.XtraBars;
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
    public partial class SekreterForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        int sekreteranasayfa = 1;
        int hastalistesi = 0;
        int hastaeklesil = 0;
        int sekreterguncelle = 0;
        public SekreterForm()
        {
            InitializeComponent();
            SekreterAnasayfaForm anasayfaForm = new SekreterAnasayfaForm();
            anasayfaForm.MdiParent = this;
            anasayfaForm.Show();
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (sekreteranasayfa == 0)
            {
                SekreterAnasayfaForm anasayfaForm = new SekreterAnasayfaForm();
                anasayfaForm.MdiParent = this;
                anasayfaForm.Show();
                sekreteranasayfa = 1;
                
            }
            else
                MessageBox.Show("Form zaten açık");
            
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
           

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (hastaeklesil == 0)
            {
                HastaEkleSil hastaEkleSil = new HastaEkleSil();
                hastaEkleSil.MdiParent = this;
                hastaEkleSil.Show();

                hastaeklesil = 1;

            }
            else
                MessageBox.Show("Form zaten açık");
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (sekreterguncelle == 0)
            {
                SekreterGuncelle sekreterGuncelle = new SekreterGuncelle();
                sekreterGuncelle.MdiParent = this;
                sekreterGuncelle.Show();
                sekreterguncelle = 1;
            }
            else
                MessageBox.Show("Form zaten açık");
        }

        private void SekreterForm_Load(object sender, EventArgs e)
        {

        }
    }
}