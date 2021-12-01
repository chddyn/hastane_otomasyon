namespace WindowsFormsApp3
{
    partial class DoktorEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDoktorTel = new DevExpress.XtraEditors.TextEdit();
            this.txtDoktorAdres = new DevExpress.XtraEditors.TextEdit();
            this.txtDoktorSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtDoktorAdi = new DevExpress.XtraEditors.TextEdit();
            this.doktorSekreter = new DevExpress.XtraEditors.LookUpEdit();
            this.doktorUnvan = new DevExpress.XtraEditors.LookUpEdit();
            this.doktorBolum = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDoktorKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorSekreter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDoktorTel);
            this.groupBox1.Controls.Add(this.txtDoktorAdres);
            this.groupBox1.Controls.Add(this.txtDoktorSoyadi);
            this.groupBox1.Controls.Add(this.txtDoktorAdi);
            this.groupBox1.Controls.Add(this.doktorSekreter);
            this.groupBox1.Controls.Add(this.doktorUnvan);
            this.groupBox1.Controls.Add(this.doktorBolum);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Ekle";
            // 
            // txtDoktorTel
            // 
            this.txtDoktorTel.Location = new System.Drawing.Point(546, 61);
            this.txtDoktorTel.Name = "txtDoktorTel";
            this.txtDoktorTel.Size = new System.Drawing.Size(125, 22);
            this.txtDoktorTel.TabIndex = 3;
            // 
            // txtDoktorAdres
            // 
            this.txtDoktorAdres.Location = new System.Drawing.Point(546, 112);
            this.txtDoktorAdres.Name = "txtDoktorAdres";
            this.txtDoktorAdres.Size = new System.Drawing.Size(125, 22);
            this.txtDoktorAdres.TabIndex = 3;
            // 
            // txtDoktorSoyadi
            // 
            this.txtDoktorSoyadi.Location = new System.Drawing.Point(180, 115);
            this.txtDoktorSoyadi.Name = "txtDoktorSoyadi";
            this.txtDoktorSoyadi.Size = new System.Drawing.Size(125, 22);
            this.txtDoktorSoyadi.TabIndex = 3;
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(180, 43);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(125, 22);
            this.txtDoktorAdi.TabIndex = 3;
            // 
            // doktorSekreter
            // 
            this.doktorSekreter.Location = new System.Drawing.Point(525, 189);
            this.doktorSekreter.Name = "doktorSekreter";
            this.doktorSekreter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.doktorSekreter.Properties.DisplayMember = "sekreterAdi";
            this.doktorSekreter.Properties.ValueMember = "id";
            this.doktorSekreter.Size = new System.Drawing.Size(209, 22);
            this.doktorSekreter.TabIndex = 2;
            this.doktorSekreter.EditValueChanged += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // doktorUnvan
            // 
            this.doktorUnvan.Location = new System.Drawing.Point(261, 189);
            this.doktorUnvan.Name = "doktorUnvan";
            this.doktorUnvan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.doktorUnvan.Properties.DisplayMember = "unvanAdi";
            this.doktorUnvan.Properties.ValueMember = "id";
            this.doktorUnvan.Size = new System.Drawing.Size(217, 22);
            this.doktorUnvan.TabIndex = 2;
            this.doktorUnvan.EditValueChanged += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // doktorBolum
            // 
            this.doktorBolum.Location = new System.Drawing.Point(27, 189);
            this.doktorBolum.Name = "doktorBolum";
            this.doktorBolum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.doktorBolum.Properties.DisplayMember = "bolumAdi";
            this.doktorBolum.Properties.ValueMember = "id";
            this.doktorBolum.Size = new System.Drawing.Size(187, 22);
            this.doktorBolum.TabIndex = 2;
            this.doktorBolum.EditValueChanged += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(421, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Adres";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(421, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Telefon";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Soyad";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad";
            // 
            // btnDoktorKaydet
            // 
            this.btnDoktorKaydet.Location = new System.Drawing.Point(644, 301);
            this.btnDoktorKaydet.Name = "btnDoktorKaydet";
            this.btnDoktorKaydet.Size = new System.Drawing.Size(102, 40);
            this.btnDoktorKaydet.TabIndex = 1;
            this.btnDoktorKaydet.Text = "KAYDET";
            this.btnDoktorKaydet.Click += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 358);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 284);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // DoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 668);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnDoktorKaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoktorEkle";
            this.Text = "DoktorEkle";
            this.Load += new System.EventHandler(this.DoktorEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorSekreter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtDoktorTel;
        private DevExpress.XtraEditors.TextEdit txtDoktorAdres;
        private DevExpress.XtraEditors.TextEdit txtDoktorSoyadi;
        private DevExpress.XtraEditors.TextEdit txtDoktorAdi;
        private DevExpress.XtraEditors.LookUpEdit doktorSekreter;
        private DevExpress.XtraEditors.LookUpEdit doktorUnvan;
        private DevExpress.XtraEditors.LookUpEdit doktorBolum;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDoktorKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}