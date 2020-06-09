using System.Data;
using System.Data.SqlClient;

namespace PointOfSale.Controllers
{
    class ClassParameters
    {

        public SqlCommand cmd;
        public SqlConnection con;
        public SqlDataAdapter adapter;
        public DataTable dt;
        public DataRow row;
        public DataSet ds;
        public Connection cn = new Connection();
    }
}
