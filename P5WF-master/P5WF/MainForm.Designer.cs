namespace P5WF
{
    partial class MainForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tileControl1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(773, 534);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControl1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceText.Options.UseFont = true;
            this.tileControl1.ColumnCount = 2;
            this.tileControl1.Groups.Add(this.tileGroup1);
            this.tileControl1.Location = new System.Drawing.Point(13, 121);
            this.tileControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tileControl1.MaxId = 8;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(36, 32, 36, 32);
            this.tileControl1.RowCount = 2;
            this.tileControl1.Size = new System.Drawing.Size(747, 373);
            this.tileControl1.TabIndex = 5;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem1);
            this.tileGroup1.Items.Add(this.tileItem2);
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Items.Add(this.tileItem4);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // tileItem1
            // 
            tileItemElement13.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement13.Appearance.Normal.Options.UseFont = true;
            tileItemElement13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement13.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement13.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement13.Text = "Form Bac Dao Tao";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem1.Elements.Add(tileItemElement13);
            this.tileItem1.Id = 4;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItem2
            // 
            tileItemElement14.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement14.Appearance.Normal.Options.UseFont = true;
            tileItemElement14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement14.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement14.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement14.Text = "Form Nganh Dao Tao";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem2.Elements.Add(tileItemElement14);
            this.tileItem2.Id = 5;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileItem3
            // 
            tileItemElement15.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement15.Appearance.Normal.Options.UseFont = true;
            tileItemElement15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement15.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement15.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement15.Text = "Form Quan Ly Sinh Vien";
            tileItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem3.Elements.Add(tileItemElement15);
            this.tileItem3.Id = 6;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // tileItem4
            // 
            tileItemElement16.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            tileItemElement16.Appearance.Normal.Options.UseFont = true;
            tileItemElement16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement16.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement16.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement16.Text = "Exit";
            tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem4.Elements.Add(tileItemElement16);
            this.tileItem4.Id = 7;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(253, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 52);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Main Form";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 534);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
    }
}
