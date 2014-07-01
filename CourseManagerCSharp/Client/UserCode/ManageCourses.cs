using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class ManageCourses
    {
        partial void AddCategory_Execute()
        {
            if (Courses.SelectedItem != null && AllCategories.SelectedItem != null)
            {
                // Loop through my category list and see if I already have this category
                foreach (CourseCategory c in CourseCategories)
                {
                    if (c.Category == AllCategories.SelectedItem)
                    {
                        return;
                    }
                }
                // Add the new category to my category list
                CourseCategory cc = CourseCategories.AddNew();
                cc.Course = Courses.SelectedItem;
                cc.Category = AllCategories.SelectedItem;
            }
        }

        partial void RemoveCategory_Execute()
        {
            if (CourseCategories.SelectedItem != null)
            {
                CourseCategories.SelectedItem.Delete();
            }
        }
    }
}
