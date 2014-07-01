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
    public partial class SectionDetail
    {
        partial void Section_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Section);
        }

        partial void Section_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Section);
        }

        partial void SectionDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Section);
        }

        partial void RegisterCourse_Execute()
        {
            // Open RegisterCourse screen with section id as its parameter
            Application.ShowRegisterCourse(null, Section.Id);
        }

        partial void RegisterCourse_CanExecute(ref bool result)
        {
            // Write your code here.
            result = Section != null;
        }
    }
}