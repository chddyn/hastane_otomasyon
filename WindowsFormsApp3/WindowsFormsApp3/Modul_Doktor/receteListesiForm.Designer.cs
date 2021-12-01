namespace WindowsFormsApp3
{
    partial class receteListesiForm
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
            this.columnHastaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDoktorid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnSekreterid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnilacid = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(1194, 536);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnHastaid,
            this.columnDoktorid,
            this.columnSekreterid,
            this.columnilacid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // columnHastaid
            // 
            this.columnHastaid.Caption = "Hasta";
            this.columnHastaid.FieldName = "hastaid";
            this.columnHastaid.MinWidth = 25;
            this.columnHastaid.Name = "columnHastaid";
            this.columnHastaid.Visible = true;
            this.columnHastaid.VisibleIndex = 0;
            this.columnHastaid.Width = 94;
            // 
            // columnDoktorid
            // 
            this.columnDoktorid.Caption = "Doktor";
            this.columnDoktorid.FieldName = "doktorid";
            this.columnDoktorid.MinWidth = 25;
            this.columnDoktorid.Name = "columnDoktorid";
            this.columnDoktorid.Visible = true;
            this.columnDoktorid.VisibleIndex = 1;
            this.columnDoktorid.Width = 94;
            // 
            // columnSekreterid
            // 
            this.columnSekreterid.Caption = "Sekreter";
            this.columnSekreterid.FieldName = "sekreterid";
            this.columnSekreterid.MinWidth = 25;
            this.columnSekreterid.Name = "columnSekreterid";
            this.columnSekreterid.Visible = true;
            this.columnSekreterid.VisibleIndex = 2;
            this.columnSekreterid.Width = 94;
            // 
            // columnilacid
            // 
            this.columnilacid.Caption = "İlaç";
            this.columnilacid.FieldName = "ilacid";
            this.columnilacid.MinWidth = 25;
            this.columnilacid.Name = "columnilacid";
            this.columnilacid.Visible = true;
            this.columnilacid.VisibleIndex = 3;
            this.columnilacid.Width = 94;
            // 
            // receteListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 536);
            this.Controls.Add(this.gridControl1);
            this.Name = "receteListesiForm";
            this.Text = "receteListesiForm";
            this.Load += new System.EventHandler(this.receteListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columnHastaid;
        private DevExpress.XtraGrid.Columns.GridColumn columnDoktorid;
        private DevExpress.XtraGrid.Columns.GridColumn columnSekreterid;
        private DevExpress.XtraGrid.Columns.GridColumn columnilacid;
    }
}