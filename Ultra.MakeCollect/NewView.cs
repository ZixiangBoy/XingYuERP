using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetaPoco;
using Ultra.Surface.Common;
using Ultra.Surface.Form;
using Ultra.Web.Core.Common;
using DbEntity;

namespace Ultra.MakeCollect {
    public partial class NewView : DialogView {
        public NewView() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (!dxValidationProvider1.Validate())
                return;
            if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.New) {
                using (var db = new Database()) {
                    db.Save(new t_makecollect() {
                        Guid = Guid.NewGuid(),
                        Payment = spnPayment.Value,
                        PayMember = userGridEdit1.GetSelectedValue().ReceiverName,
                        RecvChanl = txtRecvChanl.Text,
                        RecvType = cmbRecvType.SelectedItem.ToString(),
                        PayTime = datePayTime.DateTime,
                        CreateDate = TimeSync.Default.CurrentSyncTime,
                        Creator = this.CurUser,
                        IsUsing = true,
                        Remark = string.Empty
                    });
                }
            } else if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var et = db.FirstOrDefault<t_makecollect>("where Guid=@0", GuidKey);
                    if (null != et) {
                        et.Payment = spnPayment.Value;
                        et.PayMember = userGridEdit1.GetSelectedValue().ReceiverName;
                        et.RecvChanl = txtRecvChanl.Text;
                        et.RecvType = cmbRecvType.SelectedItem.ToString();
                        et.PayTime = datePayTime.DateTime;
                        et.CreateDate = TimeSync.Default.CurrentSyncTime;
                        et.Remark = string.Empty;
                    }
                    db.Save(et);
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void NewView_Load(object sender, EventArgs e) {
            userGridEdit1.LoadData();
            if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var et = db.FirstOrDefault<t_makecollect>("where Guid=@0", GuidKey);
                    if (null != et) {
                        cmbRecvType.SelectedItem = et.RecvType.ToString();
                        txtRecvChanl.Text = et.RecvChanl;
                        spnPayment.Value = et.Payment;
                        datePayTime.DateTime = et.PayTime ?? DateTime.Now;
                        userGridEdit1.SetSelectedValue(userGridEdit1.LoadData().FirstOrDefault(k=>k.ReceiverName==et.PayMember));
                    }
                }
            }
        }
    }
}
