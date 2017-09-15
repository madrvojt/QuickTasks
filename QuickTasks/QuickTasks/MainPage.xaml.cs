using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickTasks
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<string> tasks;

		public MainPage()
		{
			InitializeComponent();
			tasks = new ObservableCollection<string>();
			tasks.Add("Create Xamarin Apps");
			tasks.Add("Join XMDG.cz on Facebook and Twitter");
			tasks.Add("Enjoy Xamarin Prague Days");

			QuickTaskListView.ItemsSource = tasks;


			TaskButton.Clicked += (s, e) => {
				var text = TaskExtry.Text;
				tasks.Add(text);
				TaskExtry.Text = "";
			};
		}
	}
}
