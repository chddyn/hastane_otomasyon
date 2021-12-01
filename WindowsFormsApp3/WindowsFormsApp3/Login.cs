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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //dbDataContext db = new dbDataContext();
            
            //Tbl_User user = new Tbl_User();

            //if (user.username == txtUsername.Text && user.password == txtPassword.Text)
            //{
            //    XtraMessageBox.Show("Giriş Başarılı");

            //}
            //else
            //    XtraMessageBox.Show("hata");

            SekreterForm form = new SekreterForm();
            form.Show();
            this.Hide();

        }
    }
}