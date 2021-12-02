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
    public partial class EczaciForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EczaciForm()
        {
            InitializeComponent();
        }

        private void EczaciForm_Load(object sender, EventArgs e)
        {
            eczaciAnasayfaForm form = new eczaciAnasayfaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmilacEkleSil forum = new FrmilacEkleSil();
            forum.MdiParent = this;
            forum.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmilacListesi form = new FrmilacListesi();
            form.MdiParent = this;
            form.Show();
        }
    }
}