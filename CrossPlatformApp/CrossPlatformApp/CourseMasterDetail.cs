using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossPlatformApp
{
    class CourseMasterDetail : MasterDetailPage
    {
        public CourseMasterDetail()
        {
            var listView = new ListView();
            listView.ItemsSource = Courses.GetCourseList();

            listView.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem != null)
                {
                    Detail = new CoursePage(e.SelectedItem as Courses);
                    IsPresented = false;
                }
            };
            Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };

            Detail = new CoursePage(Courses.GetCourseList().First());
        }
    }
}
