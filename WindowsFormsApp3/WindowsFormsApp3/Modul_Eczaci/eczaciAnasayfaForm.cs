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
    public partial class eczaciAnasayfaForm : DevExpress.XtraEditors.XtraForm
    {
        public eczaciAnasayfaForm()
        {
            InitializeComponent();
        }

        private void eczaciAnasayfaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.Tbl_Recete' table. You can move, or remove it, as needed.
            this.tbl_ReceteTableAdapter.Fill(this.hastaneDataSet.Tbl_Recete);
            //gridControl1.DataSource = new dbDataContext().Tbl_Recetes;
           

        }
    }
}