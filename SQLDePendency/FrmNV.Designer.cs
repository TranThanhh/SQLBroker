namespace SQLDePendency
{
    partial class FrmNV
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
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNV));
            this.ds = new SQLDePendency.ds();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIEN1TableAdapter = new SQLDePendency.dsTableAdapters.NHANVIEN1TableAdapter();
            this.tableAdapterManager = new SQLDePendency.dsTableAdapters.TableAdapterManager();
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grbThemNV = new System.Windows.Forms.GroupBox();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pHAITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            maNVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.grbThemNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHAITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(32, 27);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(56, 17);
            maNVLabel.TabIndex = 0;
            maNVLabel.Text = "Ma NV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(287, 29);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(553, 27);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(40, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(452, 81);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(47, 17);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "PHAI:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(32, 83);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(64, 17);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN1";
            this.bdsNV.DataSource = this.ds;
            // 
            // nHANVIEN1TableAdapter
            // 
            this.nHANVIEN1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NHANVIEN1TableAdapter = this.nHANVIEN1TableAdapter;
            this.tableAdapterManager.UpdateOrder = SQLDePendency.dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcNV.Location = new System.Drawing.Point(0, 47);
            this.gcNV.MainView = this.gridView1;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(803, 280);
            this.gcNV.TabIndex = 1;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI});
            this.gridView1.GridControl = this.gcNV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.OptionsColumn.AllowEdit = false;
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSave,
            this.btnThoat});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick_1);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(803, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 423);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(803, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 376);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(803, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 376);
            // 
            // grbThemNV
            // 
            this.grbThemNV.Controls.Add(dIACHILabel);
            this.grbThemNV.Controls.Add(this.dIACHITextEdit);
            this.grbThemNV.Controls.Add(pHAILabel);
            this.grbThemNV.Controls.Add(this.pHAITextEdit);
            this.grbThemNV.Controls.Add(tENLabel);
            this.grbThemNV.Controls.Add(this.tENTextEdit);
            this.grbThemNV.Controls.Add(hOLabel);
            this.grbThemNV.Controls.Add(this.hOTextEdit);
            this.grbThemNV.Controls.Add(maNVLabel);
            this.grbThemNV.Controls.Add(this.txtMANV);
            this.grbThemNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThemNV.Location = new System.Drawing.Point(0, 327);
            this.grbThemNV.Name = "grbThemNV";
            this.grbThemNV.Size = new System.Drawing.Size(803, 96);
            this.grbThemNV.TabIndex = 6;
            this.grbThemNV.TabStop = false;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(147, 80);
            this.dIACHITextEdit.MenuManager = this.barManager1;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(204, 20);
            this.dIACHITextEdit.TabIndex = 9;
            // 
            // pHAITextEdit
            // 
            this.pHAITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "PHAI", true));
            this.pHAITextEdit.Location = new System.Drawing.Point(556, 80);
            this.pHAITextEdit.MenuManager = this.barManager1;
            this.pHAITextEdit.Name = "pHAITextEdit";
            this.pHAITextEdit.Size = new System.Drawing.Size(100, 20);
            this.pHAITextEdit.TabIndex = 7;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(656, 26);
            this.tENTextEdit.MenuManager = this.barManager1;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENTextEdit.TabIndex = 5;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(372, 24);
            this.hOTextEdit.MenuManager = this.barManager1;
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hOTextEdit.TabIndex = 3;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MaNV", true));
            this.txtMANV.Location = new System.Drawing.Point(147, 24);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 1;
            // 
            // FrmNV
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 446);
            this.Controls.Add(this.grbThemNV);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNV";
            this.Text = "FrmNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.grbThemNV.ResumeLayout(false);
            this.grbThemNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHAITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds ds;
        private System.Windows.Forms.BindingSource bdsNV;
        private dsTableAdapters.NHANVIEN1TableAdapter nHANVIEN1TableAdapter;
        private dsTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private System.Windows.Forms.GroupBox grbThemNV;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit pHAITextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
    }
}