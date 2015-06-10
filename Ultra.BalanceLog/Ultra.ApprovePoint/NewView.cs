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

namespace Ultra.ApprovePoint {
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
                    db.Save(new t_approvepoint() {
                        Guid = Guid.NewGuid(),
                        PointFee = spnPointFee.Value,
                        FromMember = fromMember.GetSelectedValue().ReceiverName,
                        ToMember = txtToMember.Text,
                        ToMemberNo = txtToMemberNo.Text,
                        CreateDate = TimeSync.Default.CurrentSyncTime,
                        Creator = this.CurUser,
                        IsUsing = true,
                        Remark = string.Empty
                    });
                }
            } else if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var et = db.FirstOrDefault<t_approvepoint>("where Guid=@0", GuidKey);
                    if (null != et) {
                        et.PointFee = spnPointFee.Value;
                        et.FromMember = fromMember.GetSelectedValue().ReceiverName;
                        et.ToMember = txtToMember.Text;
                        et.ToMemberNo = txtToMemberNo.Text;
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
            fromMember.LoadData();
            if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    try {
                        var et = db.FirstOrDefault<t_approvepoint>("where Guid=@0", GuidKey);
                        if (null != et) {
                            txtToMemberNo.Text = et.ToMemberNo;
                            spnPointFee.Value = et.PointFee;
                            txtToMember.Text = et.ToMember;
                            fromMember.SetSelectedValue(db.FirstOrDefault<t_member>(" where receivername=@0", et.FromMember));
                        }
                    } catch (Exception ex) {
                        throw ex;
                    }
                }
            }
        }

    }
}
