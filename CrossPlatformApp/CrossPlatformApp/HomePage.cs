﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossPlatformApp
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            Title = "Pages";

            var button1 = new Button {  Text = "Simple Page"};
            button1.Clicked += (o, e) =>
                { Navigation.PushAsync(new CoursePage(Courses.GetCourseList().First())); };

            var button2 = new Button { Text = "Master Detail" };
            button2.Clicked += (o, e) =>
                { Navigation.PushAsync(new CourseMasterDetail());  };

            var button3 = new Button { Text = "Binding" };
            button3.Clicked += (o, e) =>
                { Navigation.PushAsync(new CourseMasterDetailDB());  };

            var button4 = new Button { Text = "Tabbed" };
            button4.Clicked += (o, e) =>
            {
                var page = new TabbedPage();
                page.Title = "Courses";
                foreach(var course in Courses.GetCourseList())
                {
                    var coursePage = new CoursePageDB();
                    coursePage.BindingContext = course;
                    page.Children.Add(coursePage);
                }

                Navigation.PushAsync(page);
            };

            var button5 = new Button { Text = "Swipe" };
            button5.Clicked += (o, e) =>
            {
                var page = new CarouselPage();
                page.Title = "Courses";
                foreach (var course in Courses.GetCourseList())
                {
                    var coursePage = new CoursePageDB();
                    coursePage.BindingContext = course;
                    page.Children.Add(coursePage);
                }
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { button1, button2, button3, button4, button5 }
            };
        }
    }
}
