namespace WindowsFormsApp3
{
    partial class SekreterAnasayfaForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hastaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columHastaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columHastaSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columHastaTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columHastaAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSetBindingSource)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hastaneDataSetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(964, 559);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hastaneDataSetBindingSource
            // 
            // 
            // hastaneDataSet
            // 
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columHastaAdi,
            this.columHastaSoyadi,
            this.columHastaTel,
            this.columHastaAdres});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // columHastaAdi
            // 
            this.columHastaAdi.Caption = "Hasta Adı";
            this.columHastaAdi.MinWidth = 25;
            this.columHastaAdi.Name = "columHastaAdi";
            this.columHastaAdi.Visible = true;
            this.columHastaAdi.VisibleIndex = 0;
            this.columHastaAdi.Width = 94;
            // 
            // columHastaSoyadi
            // 
            this.columHastaSoyadi.Caption = "Hasta Soyadı";
            this.columHastaSoyadi.MinWidth = 25;
            this.columHastaSoyadi.Name = "columHastaSoyadi";
            this.columHastaSoyadi.Visible = true;
            this.columHastaSoyadi.VisibleIndex = 1;
            this.columHastaSoyadi.Width = 94;
            // 
            // columHastaTel
            // 
            this.columHastaTel.Caption = "Hasta Telefon";
            this.columHastaTel.MinWidth = 25;
            this.columHastaTel.Name = "columHastaTel";
            this.columHastaTel.Visible = true;
            this.columHastaTel.VisibleIndex = 2;
            this.columHastaTel.Width = 94;
            // 
            // columHastaAdres
            // 
            this.columHastaAdres.Caption = "Hasta Adres";
            this.columHastaAdres.MinWidth = 25;
            this.columHastaAdres.Name = "columHastaAdres";
            this.columHastaAdres.Visible = true;
            this.columHastaAdres.VisibleIndex = 3;
            this.columHastaAdres.Width = 94;
            // 
            // SekreterAnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 559);
            this.Controls.Add(this.gridControl1);
            this.Name = "SekreterAnasayfaForm";
            this.Text = "Sekreter Ana Sayfa";
            this.Load += new System.EventHandler(this.SekreterAnasayfaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSetBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columHastaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn columHastaSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn columHastaTel;
        private DevExpress.XtraGrid.Columns.GridColumn columHastaAdres;
        private System.Windows.Forms.BindingSource hastaneDataSetBindingSource;
       
    }
}