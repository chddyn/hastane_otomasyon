namespace WindowsFormsApp3
{
    partial class DoktorAnasayfaForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnDoktorAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDoktorSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDoktorBolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDoktorUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1022, 544);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnDoktorAdi,
            this.columnDoktorSoyadi,
            this.columnDoktorBolum,
            this.columnDoktorUnvan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // columnDoktorAdi
            // 
            this.columnDoktorAdi.Caption = "Doktor Adı";
            this.columnDoktorAdi.FieldName = "doktorAdi";
            this.columnDoktorAdi.MinWidth = 25;
            this.columnDoktorAdi.Name = "columnDoktorAdi";
            this.columnDoktorAdi.Visible = true;
            this.columnDoktorAdi.VisibleIndex = 0;
            this.columnDoktorAdi.Width = 94;
            // 
            // columnDoktorSoyadi
            // 
            this.columnDoktorSoyadi.Caption = "Doktor Soyadı";
            this.columnDoktorSoyadi.FieldName = "doktorSoyadi";
            this.columnDoktorSoyadi.MinWidth = 25;
            this.columnDoktorSoyadi.Name = "columnDoktorSoyadi";
            this.columnDoktorSoyadi.Visible = true;
            this.columnDoktorSoyadi.VisibleIndex = 1;
            this.columnDoktorSoyadi.Width = 94;
            // 
            // columnDoktorBolum
            // 
            this.columnDoktorBolum.Caption = "Bölümü";
            this.columnDoktorBolum.FieldName = "doktorBolumid";
            this.columnDoktorBolum.MinWidth = 25;
            this.columnDoktorBolum.Name = "columnDoktorBolum";
            this.columnDoktorBolum.Visible = true;
            this.columnDoktorBolum.VisibleIndex = 2;
            this.columnDoktorBolum.Width = 94;
            // 
            // columnDoktorUnvan
            // 
            this.columnDoktorUnvan.Caption = "Ünvan";
            this.columnDoktorUnvan.FieldName = "doktorUnvanid";
            this.columnDoktorUnvan.MinWidth = 25;
            this.columnDoktorUnvan.Name = "columnDoktorUnvan";
            this.columnDoktorUnvan.Visible = true;
            this.columnDoktorUnvan.VisibleIndex = 3;
            this.columnDoktorUnvan.Width = 94;
            // 
            // DoktorAnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 544);
            this.Controls.Add(this.gridControl1);
            this.Name = "DoktorAnasayfaForm";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.DoktorAnasayfaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columnDoktorAdi;
        private DevExpress.XtraGrid.Columns.GridColumn columnDoktorSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn columnDoktorBolum;
        private DevExpress.XtraGrid.Columns.GridColumn columnDoktorUnvan;
    }
}