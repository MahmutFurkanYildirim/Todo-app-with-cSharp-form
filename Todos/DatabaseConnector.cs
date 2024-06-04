using System.Data.SqlClient;
using System.Configuration;


namespace Todos
{
	public class DatabaseConnector
	{
		public SqlConnection Connect() 
		{
			// Bağlantı dizesini yapılandırmadan al
			string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;

			// SqlConnection nesnesini oluştur
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			return conn;
		}
	}
}
