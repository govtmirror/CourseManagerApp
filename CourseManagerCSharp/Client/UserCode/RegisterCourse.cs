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
    public partial class RegisterCourse
    {
        partial void RegisterCourse_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.EnrollmentProperty = new Enrollment();
            this.Text_Title = "Course Registration";
            this.AcademicYear = 2011;

            // StudentId is an optional screen parameter
            if (StudentId.HasValue)
            {
                // If StudentId is set, run a query to get the student record, pre-set the student field on the screen
                this.EnrollmentProperty.Student = DataWorkspace.ApplicationData.Students_Single(StudentId);
            }

            // SectionId is an optional screen parameter
            if (SectionId.HasValue)
            {
                // If SectionId is set, run a query to get the section record, pre-set the section field on the screen
                this.EnrollmentProperty.Section = DataWorkspace.ApplicationData.Sections_Single(SectionId);
            }
        }

        partial void RegisterCourse_Saved()
        {
            // Write your code here.
            this.Close(false);
        }
    }
}