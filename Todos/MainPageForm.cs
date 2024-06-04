using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todos
{
	public partial class MainPageForm : Form
	{
		public MainPageForm()
		{
			InitializeComponent();
		}

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
	}
}
