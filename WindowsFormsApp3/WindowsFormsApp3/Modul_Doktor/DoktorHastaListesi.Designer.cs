namespace WindowsFormsApp3
{
    partial class DoktorHastaListesi
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
            this.columnHastaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnHastaSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnHastaTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnHastaAdres = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(1282, 525);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnHastaAdi,
            this.columnHastaSoyadi,
            this.columnHastaTel,
            this.columnHastaAdres});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // columnHastaAdi
            // 
            this.columnHastaAdi.Caption = "Hasta Adı";
            this.columnHastaAdi.FieldName = "hastaAdi";
            this.columnHastaAdi.MinWidth = 25;
            this.columnHastaAdi.Name = "columnHastaAdi";
            this.columnHastaAdi.Visible = true;
            this.columnHastaAdi.VisibleIndex = 0;
            this.columnHastaAdi.Width = 94;
            // 
            // columnHastaSoyadi
            // 
            this.columnHastaSoyadi.Caption = "Hasta Soyadı";
            this.columnHastaSoyadi.FieldName = "hastaSoyadi";
            this.columnHastaSoyadi.MinWidth = 25;
            this.columnHastaSoyadi.Name = "columnHastaSoyadi";
            this.columnHastaSoyadi.Visible = true;
            this.columnHastaSoyadi.VisibleIndex = 1;
            this.columnHastaSoyadi.Width = 94;
            // 
            // columnHastaTel
            // 
            this.columnHastaTel.Caption = "Hasta Telefon";
            this.columnHastaTel.FieldName = "hastaTel";
            this.columnHastaTel.MinWidth = 25;
            this.columnHastaTel.Name = "columnHastaTel";
            this.columnHastaTel.Visible = true;
            this.columnHastaTel.VisibleIndex = 2;
            this.columnHastaTel.Width = 94;
            // 
            // columnHastaAdres
            // 
            this.columnHastaAdres.Caption = "HastaAdres";
            this.columnHastaAdres.FieldName = "hastaAdres";
            this.columnHastaAdres.MinWidth = 25;
            this.columnHastaAdres.Name = "columnHastaAdres";
            this.columnHastaAdres.Visible = true;
            this.columnHastaAdres.VisibleIndex = 3;
            this.columnHastaAdres.Width = 94;
            // 
            // DoktorHastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 525);
            this.Controls.Add(this.gridControl1);
            this.Name = "DoktorHastaListesi";
            this.Text = "DoktorHastaListesi";
            this.Load += new System.EventHandler(this.DoktorHastaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columnHastaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn columnHastaSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn columnHastaTel;
        private DevExpress.XtraGrid.Columns.GridColumn columnHastaAdres;
    }
}