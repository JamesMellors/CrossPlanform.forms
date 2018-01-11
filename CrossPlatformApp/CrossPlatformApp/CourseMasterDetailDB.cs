using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossPlatformApp
{
    class CourseMasterDetailDB : MasterDetailPage
    {
        public CourseMasterDetailDB()
        {
            var listView = new ListView();
            listView.ItemsSource = Courses.GetCourseList();

            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail.BindingContext = e.SelectedItem;
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };


            Detail = new CoursePageDB();
            Detail.BindingContext = Courses.GetCourseList().First();
        }

    }
}
