namespace P5WF
{
    partial class NDTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NDTForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nganhdtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.MaNganhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IDBDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TenNganhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaNganh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIDBDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTenNganh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhdtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNganhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNganhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDBDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnAdd,
            this.btnDelete,
            this.btnUpdate,
            this.barButtonItem4});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(69, 158);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar2.Offset = 5;
            this.bar2.Text = "Tools";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Caption = "Add";
            this.BtnAdd.Id = 0;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.LargeImage")));
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Export(Excel)";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(765, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(765, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(765, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.layoutControl1);
            this.dataLayoutControl1.Controls.Add(this.MaNganhTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IDBDTTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TenNganhTextEdit);
            this.dataLayoutControl1.DataSource = this.nganhdtBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(765, 377);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Location = new System.Drawing.Point(12, 90);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(741, 275);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nganhdtBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(717, 251);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nganhdtBindingSource
            // 
            this.nganhdtBindingSource.DataSource = typeof(P5WF.nganhdt);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNganh,
            this.colIDBDT,
            this.colTenNganh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNganh
            // 
            this.colMaNganh.FieldName = "MaNganh";
            this.colMaNganh.MinWidth = 25;
            this.colMaNganh.Name = "colMaNganh";
            this.colMaNganh.Visible = true;
            this.colMaNganh.VisibleIndex = 0;
            this.colMaNganh.Width = 94;
            // 
            // colIDBDT
            // 
            this.colIDBDT.FieldName = "IDBDT";
            this.colIDBDT.MinWidth = 25;
            this.colIDBDT.Name = "colIDBDT";
            this.colIDBDT.Visible = true;
            this.colIDBDT.VisibleIndex = 1;
            this.colIDBDT.Width = 94;
            // 
            // colTenNganh
            // 
            this.colTenNganh.FieldName = "TenNganh";
            this.colTenNganh.MinWidth = 25;
            this.colTenNganh.Name = "colTenNganh";
            this.colTenNganh.Visible = true;
            this.colTenNganh.VisibleIndex = 2;
            this.colTenNganh.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(741, 275);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(721, 255);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // MaNganhTextEdit
            // 
            this.MaNganhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nganhdtBindingSource, "MaNganh", true));
            this.MaNganhTextEdit.Location = new System.Drawing.Point(77, 12);
            this.MaNganhTextEdit.MenuManager = this.barManager1;
            this.MaNganhTextEdit.Name = "MaNganhTextEdit";
            this.MaNganhTextEdit.Size = new System.Drawing.Size(676, 22);
            this.MaNganhTextEdit.StyleController = this.dataLayoutControl1;
            this.MaNganhTextEdit.TabIndex = 4;
            // 
            // IDBDTTextEdit
            // 
            this.IDBDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nganhdtBindingSource, "IDBDT", true));
            this.IDBDTTextEdit.Location = new System.Drawing.Point(77, 38);
            this.IDBDTTextEdit.MenuManager = this.barManager1;
            this.IDBDTTextEdit.Name = "IDBDTTextEdit";
            this.IDBDTTextEdit.Size = new System.Drawing.Size(676, 22);
            this.IDBDTTextEdit.StyleController = this.dataLayoutControl1;
            this.IDBDTTextEdit.TabIndex = 5;
            // 
            // TenNganhTextEdit
            // 
            this.TenNganhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nganhdtBindingSource, "TenNganh", true));
            this.TenNganhTextEdit.Location = new System.Drawing.Point(77, 64);
            this.TenNganhTextEdit.MenuManager = this.barManager1;
            this.TenNganhTextEdit.Name = "TenNganhTextEdit";
            this.TenNganhTextEdit.Size = new System.Drawing.Size(676, 22);
            this.TenNganhTextEdit.StyleController = this.dataLayoutControl1;
            this.TenNganhTextEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(765, 377);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaNganh,
            this.ItemForIDBDT,
            this.ItemForTenNganh});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(745, 78);
            // 
            // ItemForMaNganh
            // 
            this.ItemForMaNganh.Control = this.MaNganhTextEdit;
            this.ItemForMaNganh.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaNganh.Name = "ItemForMaNganh";
            this.ItemForMaNganh.Size = new System.Drawing.Size(745, 26);
            this.ItemForMaNganh.Text = "Ma Nganh";
            this.ItemForMaNganh.TextSize = new System.Drawing.Size(62, 16);
            // 
            // ItemForIDBDT
            // 
            this.ItemForIDBDT.Control = this.IDBDTTextEdit;
            this.ItemForIDBDT.Location = new System.Drawing.Point(0, 26);
            this.ItemForIDBDT.Name = "ItemForIDBDT";
            this.ItemForIDBDT.Size = new System.Drawing.Size(745, 26);
            this.ItemForIDBDT.Text = "IDBDT";
            this.ItemForIDBDT.TextSize = new System.Drawing.Size(62, 16);
            // 
            // ItemForTenNganh
            // 
            this.ItemForTenNganh.Control = this.TenNganhTextEdit;
            this.ItemForTenNganh.Location = new System.Drawing.Point(0, 52);
            this.ItemForTenNganh.Name = "ItemForTenNganh";
            this.ItemForTenNganh.Size = new System.Drawing.Size(745, 26);
            this.ItemForTenNganh.Text = "Ten Nganh";
            this.ItemForTenNganh.TextSize = new System.Drawing.Size(62, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(745, 279);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // NDTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 427);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "NDTForm";
            this.Text = "NDTForm";
            this.Load += new System.EventHandler(this.NDTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhdtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNganhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNganhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDBDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource nganhdtBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBDT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganh;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit MaNganhTextEdit;
        private DevExpress.XtraEditors.TextEdit IDBDTTextEdit;
        private DevExpress.XtraEditors.TextEdit TenNganhTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaNganh;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIDBDT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenNganh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}