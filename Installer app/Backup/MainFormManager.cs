using System;
using System.Windows.Forms;

namespace ApplicationContextDemo
{
	public class MainFormManager : ApplicationContext
	{
		protected bool exitAppOnClose;

		public Form CurrentForm
		{
			get {return MainForm;}
			set
			{
				if (MainForm != null)
				{
					// close the current form, but don't exit the application
					exitAppOnClose=false;
					MainForm.Close();
					exitAppOnClose=true;
				}
				// switch to the new form
				MainForm=value;
				MainForm.Show();
			}
		}

		public MainFormManager()
		{
			exitAppOnClose=true;
		}

		// when a form is closed, bring up the first form in the array,
		// or close the application.
		protected override void OnMainFormClosed(object sender, EventArgs e)
		{
			if (exitAppOnClose)
			{
				base.OnMainFormClosed(sender, e);
			}
		}
	}
}
