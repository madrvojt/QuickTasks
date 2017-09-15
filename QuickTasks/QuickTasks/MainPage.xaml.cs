using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickTasks
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			List<string> tasks = new List<string>();
			tasks.Add("Create Xamarin Apps");
			tasks.Add("Join XMDG.cz on Facebook and Twitter");
			tasks.Add("Enjoy Xamarin Prague Days");

			QuickTaskListView.ItemsSource = tasks;
		}
	}
}
