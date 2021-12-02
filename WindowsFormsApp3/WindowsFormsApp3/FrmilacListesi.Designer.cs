namespace WindowsFormsApp3
{
    partial class FrmilacListesi
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hastaneDataSet2 = new WindowsFormsApp3.hastaneDataSet2();
            this.tblilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ilacTableAdapter = new WindowsFormsApp3.hastaneDataSet2TableAdapters.Tbl_ilacTableAdapter();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colilacAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblilacBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1058, 687);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colilacAdi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // hastaneDataSet2
            // 
            this.hastaneDataSet2.DataSetName = "hastaneDataSet2";
            this.hastaneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblilacBindingSource
            // 
            this.tblilacBindingSource.DataMember = "Tbl_ilac";
            this.tblilacBindingSource.DataSource = this.hastaneDataSet2;
            // 
            // tbl_ilacTableAdapter
            // 
            this.tbl_ilacTableAdapter.ClearBeforeFill = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 94;
            // 
            // colilacAdi
            // 
            this.colilacAdi.FieldName = "ilacAdi";
            this.colilacAdi.MinWidth = 25;
            this.colilacAdi.Name = "colilacAdi";
            this.colilacAdi.Visible = true;
            this.colilacAdi.VisibleIndex = 1;
            this.colilacAdi.Width = 94;
            // 
            // FrmilacListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 687);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmilacListesi";
            this.Text = "FrmilacListesi";
            this.Load += new System.EventHandler(this.FrmilacListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private hastaneDataSet2 hastaneDataSet2;
        private System.Windows.Forms.BindingSource tblilacBindingSource;
        private hastaneDataSet2TableAdapters.Tbl_ilacTableAdapter tbl_ilacTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colilacAdi;
    }
}