using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class CourseCategory
    {
        partial void Summary_Compute(ref string result)
        {
            if (Category != null)
            {
                result = Category.Name;
            }
        }
    }
}
