using System;
using System.Collections.Generic;
using System.Text;

namespace CrossPlatformApp
{
    class Courses
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return Title;
        }
        public static List<Courses> GetCourseList()
        {
            var courseList = new List<Courses>();
            courseList.Add(new Courses
            {
                Title = "Building Cross Platform Apps with Xamarin Part 1",
                Author = "Jim Wilson"
            });
            courseList.Add(new Courses
            {
                Title = "Building Cross Platform Apps with Xamarin Part 2",
                Author = "Jim Wilson"
            });
            courseList.Add(new Courses
            {
                Title = "Building Google Glass Apps with c# and Xamarin",
                Author = "Jim Wilson"
            });
            courseList.Add(new Courses
            {
                Title = "Android for .NET Developers",
                Author = "Jim Wilson"
            });

            return courseList;
        }
    }
}
