namespace WindowsFormsApp3
{
    partial class HastaEkleSil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaEkleSil));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHastaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtHastaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtHastaTel = new DevExpress.XtraEditors.TextEdit();
            this.txtHastaSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtHastaAdresi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtHastaAdresi);
            this.groupControl1.Controls.Add(this.txtHastaSoyadi);
            this.groupControl1.Controls.Add(this.txtHastaTel);
            this.groupControl1.Controls.Add(this.txtHastaAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(714, 252);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hasta Ekle";
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaEkle.ImageOptions.Image")));
            this.btnHastaEkle.Location = new System.Drawing.Point(114, 258);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(128, 42);
            this.btnHastaEkle.TabIndex = 1;
            this.btnHastaEkle.Text = "EKLE";
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(114, 68);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(183, 22);
            this.txtHastaAdi.TabIndex = 0;
            // 
            // txtHastaTel
            // 
            this.txtHastaTel.Location = new System.Drawing.Point(481, 74);
            this.txtHastaTel.Name = "txtHastaTel";
            this.txtHastaTel.Size = new System.Drawing.Size(186, 22);
            this.txtHastaTel.TabIndex = 0;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(114, 156);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(183, 22);
            this.txtHastaSoyadi.TabIndex = 0;
            // 
            // txtHastaAdresi
            // 
            this.txtHastaAdresi.Location = new System.Drawing.Point(481, 153);
            this.txtHastaAdresi.Name = "txtHastaAdresi";
            this.txtHastaAdresi.Size = new System.Drawing.Size(186, 22);
            this.txtHastaAdresi.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Adı ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 159);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Soyadı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(382, 162);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Adres";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(382, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Telefon";
            // 
            // HastaEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 554);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.groupControl1);
            this.Name = "HastaEkleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaEkleSil";
            this.Load += new System.EventHandler(this.HastaEkleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHastaEkle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHastaAdresi;
        private DevExpress.XtraEditors.TextEdit txtHastaSoyadi;
        private DevExpress.XtraEditors.TextEdit txtHastaTel;
        private DevExpress.XtraEditors.TextEdit txtHastaAdi;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}