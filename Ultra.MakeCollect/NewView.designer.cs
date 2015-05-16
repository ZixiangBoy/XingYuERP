using DevExpress.XtraEditors;
namespace Ultra.MakeCollect
{
    partial class NewView
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtRecvChanl = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spnPayment = new DevExpress.XtraEditors.SpinEdit();
            this.cmbRecvType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.userGridEdit1 = new Ultra.Controls.MemberGridEdit();
            this.userGridEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.datePayTime = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecvChanl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRecvType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(310, 189);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.datePayTime);
            this.pnlFill.Controls.Add(this.labelControl5);
            this.pnlFill.Controls.Add(this.userGridEdit1);
            this.pnlFill.Controls.Add(this.cmbRecvType);
            this.pnlFill.Controls.Add(this.spnPayment);
            this.pnlFill.Controls.Add(this.labelControl4);
            this.pnlFill.Controls.Add(this.labelControl3);
            this.pnlFill.Controls.Add(this.labelControl2);
            this.pnlFill.Controls.Add(this.labelControl1);
            this.pnlFill.Controls.Add(this.txtRecvChanl);
            this.pnlFill.Size = new System.Drawing.Size(310, 143);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Location = new System.Drawing.Point(0, 143);
            this.pnlBottom.Size = new System.Drawing.Size(310, 46);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(223, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(130, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定(&E)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRecvChanl
            // 
            this.txtRecvChanl.Location = new System.Drawing.Point(67, 33);
            this.txtRecvChanl.Name = "txtRecvChanl";
            this.txtRecvChanl.Size = new System.Drawing.Size(220, 20);
            this.txtRecvChanl.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "打款人";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "收款渠道";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "金额";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "收款形式";
            // 
            // spnPayment
            // 
            this.spnPayment.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPayment.Location = new System.Drawing.Point(67, 59);
            this.spnPayment.Name = "spnPayment";
            this.spnPayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPayment.Size = new System.Drawing.Size(220, 20);
            this.spnPayment.TabIndex = 29;
            // 
            // cmbRecvType
            // 
            this.cmbRecvType.Location = new System.Drawing.Point(67, 86);
            this.cmbRecvType.Name = "cmbRecvType";
            this.cmbRecvType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRecvType.Properties.Items.AddRange(new object[] {
            "报单款",
            "二次拿货款"});
            this.cmbRecvType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbRecvType.Size = new System.Drawing.Size(220, 20);
            this.cmbRecvType.TabIndex = 30;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.cmbRecvType, conditionValidationRule3);
            // 
            // userGridEdit1
            // 
            this.userGridEdit1.ClearButtonText = "清除所选";
            this.userGridEdit1.ColumnCaption = "顾客";
            this.userGridEdit1.DisplayMember = "ReceiverName";
            this.userGridEdit1.EditValue = "";
            this.userGridEdit1.Location = new System.Drawing.Point(67, 7);
            this.userGridEdit1.Name = "userGridEdit1";
            this.userGridEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "清除所选", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "清除所选", null, null, true)});
            this.userGridEdit1.Properties.DisplayMember = "ReceiverName";
            this.userGridEdit1.Properties.NullText = "";
            this.userGridEdit1.Properties.ValueMember = "Guid";
            this.userGridEdit1.Properties.View = this.userGridEdit1View;
            this.userGridEdit1.SelectedValue = null;
            this.userGridEdit1.Size = new System.Drawing.Size(220, 20);
            this.userGridEdit1.TabIndex = 31;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.userGridEdit1, conditionValidationRule2);
            this.userGridEdit1.ValueMember = "Guid";
            // 
            // userGridEdit1View
            // 
            this.userGridEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.userGridEdit1View.Appearance.FocusedRow.Options.UseBackColor = true;
            this.userGridEdit1View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.userGridEdit1View.Appearance.SelectedRow.Options.UseBackColor = true;
            this.userGridEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.userGridEdit1View.Name = "userGridEdit1View";
            this.userGridEdit1View.OptionsBehavior.AutoPopulateColumns = false;
            this.userGridEdit1View.OptionsBehavior.Editable = false;
            this.userGridEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.userGridEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "时间";
            // 
            // datePayTime
            // 
            this.datePayTime.EditValue = null;
            this.datePayTime.Location = new System.Drawing.Point(67, 113);
            this.datePayTime.Name = "datePayTime";
            this.datePayTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePayTime.Properties.DisplayFormat.FormatString = "g";
            this.datePayTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayTime.Properties.EditFormat.FormatString = "g";
            this.datePayTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayTime.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.datePayTime.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            this.datePayTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datePayTime.Properties.VistaTimeProperties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.datePayTime.Properties.VistaTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayTime.Properties.VistaTimeProperties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.datePayTime.Properties.VistaTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayTime.Size = new System.Drawing.Size(220, 20);
            this.datePayTime.TabIndex = 33;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.datePayTime, conditionValidationRule1);
            // 
            // NewView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(310, 189);
            this.Name = "NewView";
            this.ShowIcon = false;
            this.Text = "收款";
            this.Load += new System.EventHandler(this.NewView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRecvChanl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRecvType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private TextEdit txtRecvChanl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private SpinEdit spnPayment;
        private LabelControl labelControl4;
        private ComboBoxEdit cmbRecvType;
        private Controls.MemberGridEdit userGridEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView userGridEdit1View;
        private DateEdit datePayTime;
        private LabelControl labelControl5;
    }
}