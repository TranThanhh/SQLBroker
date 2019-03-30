using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace SQLDePendency
{
    public partial class FrmNV : DevExpress.XtraEditors.XtraForm
    {
        private int changeCount = 0;
        private const string tableName = "Nhanvien";
        private const string statusMessage = "Đã có {0} thay đổi.";

        // The following objects are reused
        // for the lifetime of the application.
        private SqlConnection connection = null/* TODO Change to default(_) if this is not a reference type */;
        private SqlCommand command = null/* TODO Change to default(_) if this is not a reference type */;
        private DataSet dataToWatch = null;
        public FrmNV()
        {
            InitializeComponent();
        }

        private void nHANVIEN1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FrmNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.NHANVIEN1' table. You can move, or remove it, as needed.
            this.nHANVIEN1TableAdapter.Fill(this.ds.NHANVIEN1);
            grbThemNV.Visible = false;
            if (CanRequestNotifications() == true)
                BatDau();
            else
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "", MessageBoxButtons.OK);

        }
         


        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grbThemNV.Visible = true;
            bdsNV.AddNew();
            txtMANV.Focus();
            gcNV.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grbThemNV.Visible = false;
            gcNV.Enabled = true;
            bdsNV.EndEdit();// y.c form kết thúc qtrình điều chỉnh
            bdsNV.ResetCurrentItem();//lấy data đang sửa đẩy vào lưới
            this.nHANVIEN1TableAdapter.Update(this.ds.NHANVIEN1);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private string GetConnectionString()
        {
            return "Data Source=MOON;Initial Catalog=QL_VATTU;User ID=sa;Password=sa;";
        }
        private bool CanRequestNotifications()
        {
            // In order to use the callback feature of the
            // SqlDependency, the application must have
            // the SqlClientPermission permission.
            try
            {
                SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);

                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private string GetSQL()
        {
            return "select MaNV, HO, TEN, PHAI, DIACHI from dbo.Nhanvien1";
        }
        private void BatDau()
        {
            changeCount = 0;
            // Remove any existing dependency connection, then create a new one.
            SqlDependency.Stop(GetConnectionString());
            try
            {
                SqlDependency.Start(GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (connection == null)
            {
                connection = new SqlConnection(GetConnectionString());
                connection.Open();
            }
            if (command == null)
                // GetSQL is a local procedure that returns
                // a paramaterized SQL string. You might want
                // to use a stored procedure in your application.
                command = new SqlCommand(GetSQL(), connection);

            if (dataToWatch == null)
                dataToWatch = new DataSet();
            GetData();
        }
        private void GetData()
        {
            // Empty the dataset so that there is only
            // one batch worth of data displayed.
            dataToWatch.Clear();

            // Make sure the command object does not already have
            // a notification object associated with it.

            command.Notification = null;

            // Create and bind the SqlDependency object
            // to the command object.

            SqlDependency dependency = new SqlDependency(command);
            dependency.OnChange += dependency_OnChange;

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dataToWatch, tableName);

                this.gcNV.DataSource = dataToWatch;
                this.gcNV.DataMember = tableName;
            }
        }
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {

            // This event will occur on a thread pool thread.
            // It is illegal to update the UI from a worker thread
            // The following code checks to see if it is safe update the UI.
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // If InvokeRequired returns True, the code is executing on a worker thread.
            if (i.InvokeRequired)
            {
                // Create a delegate to perform the thread switch
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                object[] args = new[] { sender, e };

                // Marshal the data from the worker thread
                // to the UI thread.
                i.BeginInvoke(tempDelegate, args);

                return;
            }

            // Remove the handler since it's only good
            // for a single notification
            SqlDependency dependency = (SqlDependency)sender;

            dependency.OnChange -= dependency_OnChange;

            // At this point, the code is executing on the
            // UI thread, so it is safe to update the UI.
            changeCount += 1;
            /*
            this.Label1.Text = string.Format(statusMessage, changeCount);

            // Add information from the event arguments to the list box
            // for debugging purposes only.
            {
                var withBlock = this.ListBox1.Items;
                withBlock.Clear();
                withBlock.Add("Info:   " + e.Info.ToString());
                withBlock.Add("Source: " + e.Source.ToString());
                withBlock.Add("Type:   " + e.Type.ToString());
            }
            */
            // Reload the dataset that's bound to the grid.
            GetData();
        }
    }
}