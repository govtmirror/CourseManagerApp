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
    public partial class StudentDetail
    {
        partial void Student_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Student);
        }

        partial void Student_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Student);
        }

        partial void StudentDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Student);
        }

        partial void RegisterCourse_Execute()
        {
            // Write your code here.
            Application.ShowRegisterCourse(Student.Id, null);
        }

        partial void DropCourse_CanExecute(ref bool result)
        {
            result = Enrollments.SelectedItem != null;
        }

        partial void DropCourse_Execute()
        {
            // Show a confirmation dialog before the course is dropped
            if (this.ShowMessageBox("Are you sure you want to drop this course?", "Drop Course", MessageBoxOption.YesNo) == System.Windows.MessageBoxResult.Yes)
            {
                Enrollments.SelectedItem.Delete();
            }
        }

        partial void RegisterCourse_CanExecute(ref bool result)
        {
            // Write your code here.
            result = Student != null;
        }
    }
}