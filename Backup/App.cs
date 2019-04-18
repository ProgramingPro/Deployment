using System;
using System.Windows.Forms;

namespace ApplicationContextDemo
{
	public class App
	{
		private static MainFormManager mainFormManager;

		public static MainFormManager MainFormManager
		{
			get {return mainFormManager;}
		}

		public App()
		{
			mainFormManager=new MainFormManager();

			mainFormManager.CurrentForm=new Form1();
			Application.Run(mainFormManager);
		}

		[STAThread]
		static void Main() 
		{
			new App();
		}
	}
}
