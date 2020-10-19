namespace P5WF
{
    partial class BDTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDTForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bacdtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDBDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBacDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.IDBDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TenBacDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIDBDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTenBacDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacdtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenBacDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDBDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenBacDT)).BeginInit();
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barToolbarsListItem1});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar2.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Update";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Export";
            this.barButtonItem5.Hint = "Export";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(632, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 258);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(632, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 234);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(632, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 234);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Cancel";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Id = 6;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.layoutControl1);
            this.dataLayoutControl1.Controls.Add(this.IDBDTTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TenBacDTTextEdit);
            this.dataLayoutControl1.DataSource = this.bacdtBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(632, 234);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Location = new System.Drawing.Point(12, 60);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(608, 162);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bacdtBindingSource;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl.Location = new System.Drawing.Point(12, 12);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.MenuManager = this.barManager1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(584, 138);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // bacdtBindingSource
            // 
            this.bacdtBindingSource.DataSource = typeof(P5WF.bacdt);
            this.bacdtBindingSource.CurrentChanged += new System.EventHandler(this.bacdtBindingSource_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDBDT,
            this.colTenBacDT});
            this.gridView1.DetailHeight = 285;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colIDBDT
            // 
            this.colIDBDT.FieldName = "IDBDT";
            this.colIDBDT.MinWidth = 21;
            this.colIDBDT.Name = "colIDBDT";
            this.colIDBDT.Visible = true;
            this.colIDBDT.VisibleIndex = 0;
            this.colIDBDT.Width = 81;
            // 
            // colTenBacDT
            // 
            this.colTenBacDT.FieldName = "TenBacDT";
            this.colTenBacDT.MinWidth = 21;
            this.colTenBacDT.Name = "colTenBacDT";
            this.colTenBacDT.Visible = true;
            this.colTenBacDT.VisibleIndex = 1;
            this.colTenBacDT.Width = 81;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(608, 162);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(588, 142);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // IDBDTTextEdit
            // 
            this.IDBDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bacdtBindingSource, "IDBDT", true));
            this.IDBDTTextEdit.Location = new System.Drawing.Point(69, 12);
            this.IDBDTTextEdit.MenuManager = this.barManager1;
            this.IDBDTTextEdit.Name = "IDBDTTextEdit";
            this.IDBDTTextEdit.Size = new System.Drawing.Size(551, 20);
            this.IDBDTTextEdit.StyleController = this.dataLayoutControl1;
            this.IDBDTTextEdit.TabIndex = 4;
            // 
            // TenBacDTTextEdit
            // 
            this.TenBacDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bacdtBindingSource, "TenBacDT", true));
            this.TenBacDTTextEdit.Location = new System.Drawing.Point(69, 36);
            this.TenBacDTTextEdit.MenuManager = this.barManager1;
            this.TenBacDTTextEdit.Name = "TenBacDTTextEdit";
            this.TenBacDTTextEdit.Size = new System.Drawing.Size(551, 20);
            this.TenBacDTTextEdit.StyleController = this.dataLayoutControl1;
            this.TenBacDTTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(632, 234);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIDBDT,
            this.ItemForTenBacDT});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(612, 48);
            // 
            // ItemForIDBDT
            // 
            this.ItemForIDBDT.Control = this.IDBDTTextEdit;
            this.ItemForIDBDT.Location = new System.Drawing.Point(0, 0);
            this.ItemForIDBDT.Name = "ItemForIDBDT";
            this.ItemForIDBDT.Size = new System.Drawing.Size(612, 24);
            this.ItemForIDBDT.Text = "IDBDT";
            this.ItemForIDBDT.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForTenBacDT
            // 
            this.ItemForTenBacDT.Control = this.TenBacDTTextEdit;
            this.ItemForTenBacDT.Location = new System.Drawing.Point(0, 24);
            this.ItemForTenBacDT.Name = "ItemForTenBacDT";
            this.ItemForTenBacDT.Size = new System.Drawing.Size(612, 24);
            this.ItemForTenBacDT.Text = "Ten Bac DT";
            this.ItemForTenBacDT.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(612, 166);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // BDTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BDTForm";
            this.Text = "BDTForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacdtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenBacDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDBDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenBacDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit IDBDTTextEdit;
        private System.Windows.Forms.BindingSource bacdtBindingSource;
        private DevExpress.XtraEditors.TextEdit TenBacDTTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIDBDT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenBacDT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBDT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBacDT;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
    }
}
