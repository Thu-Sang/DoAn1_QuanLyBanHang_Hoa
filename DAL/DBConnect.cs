using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=MSI;Initial Catalog=DoAn1_QuanLyBanHang_Hoa;Integrated Security=True;TrustServerCertificate=True");
    }
}
