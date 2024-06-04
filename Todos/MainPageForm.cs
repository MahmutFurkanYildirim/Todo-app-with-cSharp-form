using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Todos
{
	public partial class MainPageForm : Form
	{
		public MainPageForm()
		{
			InitializeComponent();
		}

		DatabaseConnector connector = new DatabaseConnector();

		public enum Priority
		{
			High,
			Medium,
			Low
		}

		public enum Category
		{
			Work,
			Personal,
			Hobby,
			Optional
		}

		public enum Status
		{
			Complete,
			Incomplete
		}


		private void MainPage_Load(object sender, EventArgs e)
		{
			// ComboBox'lara enum değerlerini ekleyin
			foreach (var priority in Enum.GetValues(typeof(Priority)))
			{
				priority_cmbx.Items.Add(priority);
			}

			foreach (var category in Enum.GetValues(typeof(Category)))
            {
				category_cmbx.Items.Add(category);
            }


        }

		private void Save_button_Click(object sender, EventArgs e)
		{
			Status defaultStatus = Status.Incomplete;

			SqlCommand command = new SqlCommand("insert into Todo (Description,Status,Priority,Due_date,Category) values (@desc,@status,@priority,@date,@category)",connector.Connect());
			command.Parameters.AddWithValue("@desc",enter_text.Text);
			command.Parameters.AddWithValue("@status", defaultStatus.ToString());
			command.Parameters.AddWithValue("@priority", priority_cmbx.Text);
			command.Parameters.AddWithValue("@date", DateTime.Parse(due_date.Text));
			command.Parameters.AddWithValue("@category",category_cmbx.Text);
			command.ExecuteNonQuery();
			connector.Connect().Close();
			MessageBox.Show("Todo Added", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

		}
	}
}
