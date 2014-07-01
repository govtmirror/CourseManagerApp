using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Instructors_Updating(Instructor entity)
        {
            entity.UpdatedTime = DateTime.Now;
            entity.UpdatedBy = Application.User.Name;
        }

        partial void Students_Updating(Student entity)
        {
            entity.UpdatedTime = DateTime.Now;
            entity.UpdatedBy = Application.User.Name;
        }

        partial void AvailableSections_PreprocessQuery(int? StudentId, ref IQueryable<Section> query)
        {
            if (StudentId.HasValue)
            {
                // Return only sections which the student has not registered
                query = from Section s in query
                        where (!(s.Enrollments.Any(f => f.Student.Id == StudentId)))
                        select s;
            }
        }

        partial void SectionsByCategory_PreprocessQuery(int? CategoryId, ref IQueryable<Section> query)
        {
            if (CategoryId.HasValue)
            {
                // Return only sections which fall into the category
                query = from Section s in query
                        where s.Course.CourseCategories.Any(f => f.Category.Id == CategoryId)
                        select s;
            }
        }

        partial void Sections_All_PreprocessQuery(ref IQueryable<Section> query)
        {
            // Specify default sort order for selecting all sections
            query = from Section s in query
                    orderby s.Course.Title, s.SectionID, s.AcademicYear, s.AcademicQuarter
                    select s;
        }

        partial void Students_All_PreprocessQuery(ref IQueryable<Student> query)
        {
            // Specify default sort order for selecting all students
            query = from Student s in query
                    orderby s.LastName, s.FirstName
                    select s;
        }

        partial void Categories_All_PreprocessQuery(ref IQueryable<Category> query)
        {
            // Specify default sort order for selecting all categories
            query = from Category c in query
                    orderby c.Name
                    select c;
        }

        partial void Instructors_All_PreprocessQuery(ref IQueryable<Instructor> query)
        {
            // Specify default sort order for selecting all instructors
            query = from Instructor i in query
                    orderby i.LastName, i.FirstName
                    select i;
        }

        partial void Enrollments_Validate(Enrollment entity, EntitySetValidationResultsBuilder results)
        {
            // If the section has reached the max enrollment limit, show an error
            if (entity.Section.SpaceRemaining < 0)
            {
                results.AddEntityError("This section is full.");
            }
        }

    }
}
