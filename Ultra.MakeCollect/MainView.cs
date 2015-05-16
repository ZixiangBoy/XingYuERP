using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ultra.Surface.Form;
using Ultra.Surface.Lanuch;
using Ultra.Surface.Extend;
using Ultra.Surface.Common;
using Ultra.Web.Core.Common;
using DbEntity;
using System.Data.SqlClient;
using PetaPoco;
using DevExpress.XtraBars;

namespace Ultra.MakeCollect {
    public partial class MainView : BaseForm, Ultra.Surface.Interfaces.ISurfacePermission {
        #region ISurfacePermission 成员

        public List<Control> ButtonItems {
            get;
            set;
        }

        public List<BaseSurface> DialogForms {
            get;
            set;
        }

        public List<Ultra.Surface.Interfaces.PermitGridView> Grids {
            get {
                return new List<Ultra.Surface.Interfaces.PermitGridView> { 
                new Ultra.Surface.Interfaces.PermitGridView(this.gridView1,"收款信息")
            };
            }
        }

        public List<Control> MenuItems {
            get;
            set;
        }

        public List<DevExpress.XtraBars.BarButtonItem> ToolBarItems {
            get {
                return new List<DevExpress.XtraBars.BarButtonItem> { 
                    this.myBar.btnCreate,
                    myBar.btnModify,
                    this.myBar.btnRefresh,
                    this.myBar.btnExport,
                    myBar.btnSubmit,
                    myBar.btnInvalid
                };
            }
        }

        #endregion

        public MainView() {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e) {
            myBar.btnCreate.ItemClick += barBtnNew_ItemClick;
            myBar.btnRefresh.ItemClick += barBtnRefresh_ItemClick;
            myBar.btnExport.ItemClick += barBtnExport_ItemClick;
            myBar.btnSubmit.ItemClick += btnSubmit_ItemClick;
            myBar.btnInvalid.ItemClick += btnInvalid_ItemClick;
            myBar.btnModify.ItemClick += barBtnEdt_ItemClick;
        }

        void btnInvalid_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gridControlEx1.GetFocusedDataSource<t_makecollect>();
            if (null == et) return;
            using (var db = new Database()) {
                db.Update<t_makecollect>(" set IsInvalid=1 where guid=@0", et.Guid);
            }
            barBtnRefresh_ItemClick(null, null);
        }

        void btnSubmit_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gridControlEx1.GetFocusedDataSource<t_makecollect>();
            if (null == et) return;
            using (var db = new Database()) {
                try {
                    db.BeginTransaction();

                    db.Update<t_member>(" set CurBalance=CurBalance+@0 where receivername=@1", et.Payment, et.PayMember);

                    var mem = db.FirstOrDefault<t_member>(" where receivername=@0", et.PayMember);

                    db.Save(new t_balancelog() {
                        Guid = Guid.NewGuid(),
                        Amount = et.Payment,
                        Desc = et.RecvChanl + (et.Payment > 0 ? "+" : "-"),
                        RecvName = et.PayMember,
                        CurBalance = mem.CurBalance,
                        RecvBalance = mem.RecvBalance,
                        CreateDate = TimeSync.Default.CurrentSyncTime,
                        Creator = this.CurUser,
                        IsUsing = true,
                        Remark = string.Empty
                    });

                    db.Update<t_makecollect>(" set IsSubmit=1 where guid=@0", et.Guid);
                    db.CompleteTransaction();
                } catch (Exception) {
                    db.AbortTransaction();
                    throw;
                }
            }
            barBtnRefresh_ItemClick(null, null);
        }

        void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.gridControlEx1.GridExportXls();
        }

        void barBtnEdt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridControlEx1_RowCellDoubleClick(sender, null);
        }

        void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (tabMain.SelectedTabPage.Text) {
                case "未提交": 
                    using (var db = new Database()) {
                        this.gridControlEx1.DataSource = db.Fetch<t_makecollect>(" where isnull(issubmit,0)=0 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已提交":
                    using (var db = new Database()) {
                        this.gridControlEx2.DataSource = db.Fetch<t_makecollect>(" where isnull(issubmit,0)=1 and isnull(isinvalid,0)=0");
                    }
                    break;
                default:
                    break;
            }
        }

        void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var vw = new NewView();
            Lanucher.InitView(vw);
            vw.EditMode = Ultra.Web.Core.Enums.EnViewEditMode.New;
            if (vw.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                barBtnRefresh_ItemClick(sender, e);
            }
        }

        private void gridControlEx1_RowCellDoubleClick(object sender, MouseEventArgs e) {
            var et = gridControlEx1.GetFocusedDataSource<t_makecollect>();
            if (null == et) return;
            var vw = new NewView();
            Lanucher.InitView(vw);
            vw.EditMode = Ultra.Web.Core.Enums.EnViewEditMode.Edit;
            vw.GuidKey = et.Guid;
            if (vw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                barBtnRefresh_ItemClick(sender, null);
        }

        private void tabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
                    myBar.btnRefresh.Enabled =
                    myBar.btnExport.Enabled =
                    myBar.btnSubmit.Enabled =
                    myBar.btnInvalid.Enabled = true;
            switch (tabMain.SelectedTabPage.Text) {
                case "未提交":
                    
                    break;
                case "已提交":
                    myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
                    myBar.btnSubmit.Enabled =
                    myBar.btnInvalid.Enabled = false;
                    break;
                default:
                    break;
            }
            barBtnRefresh_ItemClick(null, null);
        }
    }
}
