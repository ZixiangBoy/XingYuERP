namespace Ultra.Inventory {
    partial class InvtLogView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabDetail = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gcInvtLog = new Ultra.Surface.Controls.GridControlEx();
            this.gvInvtLog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvtLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvtLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDetail
            // 
            this.tabDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetail.Location = new System.Drawing.Point(0, 60);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedTabPage = this.xtraTabPage4;
            this.tabDetail.Size = new System.Drawing.Size(955, 442);
            this.tabDetail.TabIndex = 9;
            this.tabDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.gcInvtLog);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(949, 413);
            this.xtraTabPage4.Text = "库存变动记录";
            // 
            // gcInvtLog
            // 
            this.gcInvtLog.ColorFieldName = null;
            this.gcInvtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvtLog.Location = new System.Drawing.Point(0, 0);
            this.gcInvtLog.MainView = this.gvInvtLog;
            this.gcInvtLog.Name = "gcInvtLog";
            this.gcInvtLog.ShowIndicator = true;
            this.gcInvtLog.ShowRowNumber = true;
            this.gcInvtLog.Size = new System.Drawing.Size(949, 413);
            this.gcInvtLog.TabIndex = 5;
            this.gcInvtLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvtLog});
            // 
            // gvInvtLog
            // 
            this.gvInvtLog.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvInvtLog.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInvtLog.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvInvtLog.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInvtLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn1,
            this.gridColumn23,
            this.gridColumn19,
            this.gridColumn2,
            this.gridColumn20});
            this.gvInvtLog.GridControl = this.gcInvtLog;
            this.gvInvtLog.Name = "gvInvtLog";
            this.gvInvtLog.OptionsBehavior.Editable = false;
            this.gvInvtLog.OptionsView.ColumnAutoWidth = false;
            this.gvInvtLog.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInvtLog.OptionsView.EnableAppearanceOddRow = true;
            this.gvInvtLog.OptionsView.ShowAutoFilterRow = true;
            this.gvInvtLog.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "货物名称";
            this.gridColumn16.FieldName = "ItemName";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "货物编码";
            this.gridColumn17.FieldName = "ItemNo";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "单价";
            this.gridColumn18.FieldName = "Price";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 2;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "原库存数";
            this.gridColumn23.FieldName = "OldQty";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 4;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "变动后库存数";
            this.gridColumn19.FieldName = "NowQty";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 5;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "创建时间";
            this.gridColumn20.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn20.FieldName = "CreateDate";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "积分";
            this.gridColumn1.FieldName = "PointFee";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "变动情况";
            this.gridColumn2.FieldName = "ActionName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // InvtLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 502);
            this.Controls.Add(this.tabDetail);
            this.Name = "InvtLogView";
            this.Text = "InvtLogView";
            this.Load += new System.EventHandler(this.InvtLogView_Load);
            this.Controls.SetChildIndex(this.myBar, 0);
            this.Controls.SetChildIndex(this.tabDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvtLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvtLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabDetail;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Surface.Controls.GridControlEx gcInvtLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvtLog;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}