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
    public partial class Home
    {
        partial void Home_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Initialize image properties
            Image_Logo = GetImageByName("logo.png");
            Image_Search = GetImageByName("search.png");
            Image_Student = GetImageByName("student.png");
            Image_Register = GetImageByName("register.png");
            Image_Course = GetImageByName("course.png");

            // Initialize text properties
            Text_Title = "School of Fine Art - Office of Registrar";
            Text_Subtitle = "Welcome " + Application.User.FullName + "!";
            Text_Description = "This application is designed for staffs in the Office of Registrar at the School of Fine Art.";
            Text_Student = "Creates a new student in the system.";
            Text_Course = "Shows a list of courses offered by the school.";
            Text_Search = "Searches for an existing student in the system.";
            Text_Register = "Register a course for an existing student.";
        }

        partial void SearchStudents_Execute()
        {
            // Write your code here.
            Application.ShowSearchStudents();
        }

        partial void CreateStudent_Execute()
        {
            // Write your code here.
            Application.ShowCreateNewStudent();
        }

        partial void RegisterCourse_Execute()
        {
            // Write your code here.
            Application.ShowRegisterCourse(null, null);
        }

        partial void CourseCatalog_Execute()
        {
            // Write your code here.
            Application.ShowCourseCatalog();
        }

        private byte[] GetImageByName(string filename)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(typeof(Home).Namespace + ".Resources." + filename);
            return GetStreamAsByteArray(stream);
        }

        private byte[] GetStreamAsByteArray(System.IO.Stream stream)
        {
            int streamLength = Convert.ToInt32(stream.Length);
            byte[] fileData = new byte[streamLength];
            stream.Read(fileData, 0, streamLength);
            stream.Close();
            return fileData;
        }
    }
}
