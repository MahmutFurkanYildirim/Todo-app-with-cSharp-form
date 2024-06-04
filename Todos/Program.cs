using System;
using System.Windows.Forms;

namespace Todos
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainPageForm());
			//Application.Run(new UpdateTodoForm());
		}
	}
}
