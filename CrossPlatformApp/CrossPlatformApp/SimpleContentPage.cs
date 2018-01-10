using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CrossPlatformApp
{
	public class SimpleContentPage : ContentPage
	{
		public SimpleContentPage ()
		{
            var lable1 = new Label
            {
                Text = "Test Label",
                Font = Font.BoldSystemFontOfSize(NamedSize.Large)

            };

            var entry1 = new Entry
            {
                Placeholder = "Type Here"
            };

            var button1 = new Button
            {
                Text = "test button"
                                
            };

            button1.Clicked += (sender, e) =>
            {
                lable1.Text = "User types " + entry1.Text;
            };

            Content = new StackLayout
            {
                Padding = 30,

                Spacing = 10,
                Children = { lable1, entry1, button1 }
            };
		}

        
    }
}