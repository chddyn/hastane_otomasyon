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
    public partial class DoktorForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoktorEkle doktorEkle = new DoktorEkle();
            doktorEkle.MdiParent = this;
            doktorEkle.Show();



        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoktorAnasayfaForm form = new DoktorAnasayfaForm();
            form.MdiParent = this;
            form.Show();


        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            DoktorAnasayfaForm form = new DoktorAnasayfaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoktorHastaListesi form = new DoktorHastaListesi();
            form.MdiParent = this;
            form.Show();

            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            HastaEkleSil form = new HastaEkleSil();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            receteListesiForm form = new receteListesiForm();
            form.MdiParent= this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReceteEkleSil form =new ReceteEkleSil();
            form.MdiParent = this;
            form.Show();
        }
    }
}