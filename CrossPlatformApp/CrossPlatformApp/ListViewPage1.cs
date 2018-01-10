using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CrossPlatformApp
{
	public class ListViewPage1 : ContentPage
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
            // listView.ItemsSource = className;

            listView.ItemsSource = Courses.GetCourseList();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, new Binding("Title"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("Author"));
            cell.SetValue(TextCell.TextColorProperty, Color.Blue);
            cell.SetValue(TextCell.DetailColorProperty, Color.DarkViolet);

            listView.ItemTemplate = new DataTemplate(typeof(ListViewCustom));

            listView.ItemSelected += (sender, e) =>
             {
                 if (e.SelectedItem != null)
                 {

                     Debug.WriteLine("Selected: " + e.SelectedItem);
                     listView.SelectedItem = null;
                 }
            };
			Content = listView;
		}
	}
}