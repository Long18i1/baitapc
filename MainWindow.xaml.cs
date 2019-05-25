using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace BaiTapNop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FilldataGi();
        }
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da;
        DataSet ds;
        public void ConnectDB()
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-4H2CDN2\\SQLEXPRESS; Initial Catalog=BTC; Integrated Security=SSPI");
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FilldataGi()
        {
            try
            {
                ConnectDB();
                da = new SqlDataAdapter("select * from NopBT ", conn);
                ds = new DataSet();
                da.Fill(ds);
                dataGi.ItemsSource = ds.Tables[0].DefaultView;
                dataGi.DisplayMemberPath = "CustomerID";
                dataGi.SelectedValuePath = "ComparyName";
                conn.Close();
                da.Dispose();
                ds.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                ConnectDB();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into NopBT values(@CustomerID,@ComparyName,@ContactName,@ContactTitle,@Addiess,@City,@Region,@PostaCode,@Country,@Phone,@Fax)";
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = txtCustomerID.Text;
                cmd.Parameters.Add("@ComparyName", SqlDbType.VarChar).Value = txtComparyName.Text;
                cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = txtContactName.Text;
                cmd.Parameters.Add("@ContactTitle", SqlDbType.VarChar).Value = txtContactTitle.Text;
                cmd.Parameters.Add("@Addiess", SqlDbType.VarChar).Value = txtAddiess.Text;
                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = txtCity.Text;
                cmd.Parameters.Add("@Region", SqlDbType.VarChar).Value = txtRegion.Text;
                cmd.Parameters.Add("@PostaCode", SqlDbType.VarChar).Value = txtPostaCode.Text;
                cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = txtCountry.Text;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = txtPhone.Text;
                cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = txtFax.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0) MessageBox.Show("Success");
                else MessageBox.Show("Fail");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from NopBT where CustomerID = '" + txtCustomerID.Text + "'";
            int n = cmd.ExecuteNonQuery();
            if (n > 0) MessageBox.Show("Success");
            else MessageBox.Show("Fail");

        }

        private void BtnL_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            var load = new MainWindow();
            load.Show();
            this.Hide();
        }

        private void BtnU_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update NopBT Set ComparyName = '"+txtComparyName.Text+ "' Where CustomerID = '" + txtCustomerID.Text+ "' ";
            int n = cmd.ExecuteNonQuery();
            if (n > 0) MessageBox.Show("Success");
            else MessageBox.Show("Fail");
            conn.Close();
            cmd.Dispose();
        }
    }
}
