using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CrossPlatformApp
{
	public class ListViewPage1 : ContentView
	{
		public ListViewPage1 ()
		{
            var className = new[]
            {
                "1",
                "2",
                "3",
                "4"
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            listView.ItemsSource = className;
            listView.ItemSelected += (sender, e) =>
             {
                
                 Debug.WriteLine("Selected: "+ e.SelectedItem);
            };
			Content = listView;
		}
	}
}