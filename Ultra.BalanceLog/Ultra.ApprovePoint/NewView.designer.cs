using DevExpress.XtraEditors;
namespace Ultra.ApprovePoint
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spnPointFee = new DevExpress.XtraEditors.SpinEdit();
            this.fromMember = new Ultra.Controls.MemberGridEdit();
            this.userGridEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtToMember = new DevExpress.XtraEditors.TextEdit();
            this.txtToMemberNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPointFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToMemberNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(303, 162);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.txtToMemberNo);
            this.pnlFill.Controls.Add(this.txtToMember);
            this.pnlFill.Controls.Add(this.fromMember);
            this.pnlFill.Controls.Add(this.spnPointFee);
            this.pnlFill.Controls.Add(this.labelControl4);
            this.pnlFill.Controls.Add(this.labelControl3);
            this.pnlFill.Controls.Add(this.labelControl2);
            this.pnlFill.Controls.Add(this.labelControl1);
            this.pnlFill.Size = new System.Drawing.Size(303, 116);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Location = new System.Drawing.Point(0, 116);
            this.pnlBottom.Size = new System.Drawing.Size(303, 46);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(216, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(123, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定(&E)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "积分来源";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "给谁";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "消耗积分数额";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "给谁的编号";
            // 
            // spnPointFee
            // 
            this.spnPointFee.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPointFee.Location = new System.Drawing.Point(84, 32);
            this.spnPointFee.Name = "spnPointFee";
            this.spnPointFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPointFee.Size = new System.Drawing.Size(209, 20);
            this.spnPointFee.TabIndex = 29;
            // 
            // fromMember
            // 
            this.fromMember.ClearButtonText = "清除所选";
            this.fromMember.ColumnCaption = "顾客";
            this.fromMember.DisplayMember = "ReceiverName";
            this.fromMember.EditValue = "";
            this.fromMember.Location = new System.Drawing.Point(84, 7);
            this.fromMember.Name = "fromMember";
            this.fromMember.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "清除所选", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "清除所选", null, null, true)});
            this.fromMember.Properties.DisplayMember = "ReceiverName";
            this.fromMember.Properties.NullText = "";
            this.fromMember.Properties.ValueMember = "Guid";
            this.fromMember.Properties.View = this.userGridEdit1View;
            this.fromMember.SelectedValue = null;
            this.fromMember.Size = new System.Drawing.Size(209, 20);
            this.fromMember.TabIndex = 31;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.fromMember, conditionValidationRule2);
            this.fromMember.ValueMember = "Guid";
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
            // txtToMember
            // 
            this.txtToMember.Location = new System.Drawing.Point(83, 58);
            this.txtToMember.Name = "txtToMember";
            this.txtToMember.Size = new System.Drawing.Size(208, 20);
            this.txtToMember.TabIndex = 32;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtToMember, conditionValidationRule1);
            // 
            // txtToMemberNo
            // 
            this.txtToMemberNo.Location = new System.Drawing.Point(84, 86);
            this.txtToMemberNo.Name = "txtToMemberNo";
            this.txtToMemberNo.Size = new System.Drawing.Size(207, 20);
            this.txtToMemberNo.TabIndex = 33;
            // 
            // NewView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(303, 162);
            this.Name = "NewView";
            this.ShowIcon = false;
            this.Text = "上报积分";
            this.Load += new System.EventHandler(this.NewView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPointFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToMemberNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private TextEdit txtPayUser;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private SpinEdit spnPointFee;
        private LabelControl labelControl4;
        private Controls.MemberGridEdit fromMember;
        private DevExpress.XtraGrid.Views.Grid.GridView userGridEdit1View;
        private TextEdit txtToMemberNo;
        private TextEdit txtToMember;
    }
}