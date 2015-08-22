using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultra.Surface.Form;
using Ultra.Surface.Lanuch;
using Ultra.Surface.Extend;
using Ultra.Surface.Common;
using Ultra.Web.Core.Common;
using DbEntity;
using System.Data.SqlClient;
using PetaPoco;

namespace Ultra.Inventory {
    public partial class InvtLogView : BaseForm, Ultra.Surface.Interfaces.ISurfacePermission {
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
                    new Ultra.Surface.Interfaces.PermitGridView(this.gvInvtLog,"库存变动记录查询"),
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
                    myBar.btnRefresh,
                    myBar.btnExport,
                };
            }
        }

        #endregion
        public InvtLogView() {
            InitializeComponent();
        }

        private void InvtLogView_Load(object sender, EventArgs e) {
            myBar.btnRefresh.ItemClick += btnRefresh_ItemClick;
            myBar.btnExport.ItemClick += btnExport_ItemClick;
        }

        void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gcInvtLog.GridExportXls();
        }

        void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using (var db = new Database()) {
                gcInvtLog.DataSource=db.Fetch<t_inventorylog>(" select * from t_inventorylog");
            }
        }
    }
}
