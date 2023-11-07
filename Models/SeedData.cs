using CourseCatalog.Data;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new CourseCatalogContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CourseCatalogContext>>());
        if (context == null || context.Course == null)
        {
            throw new ArgumentNullException("Null CourseCatalogContext");
        }
            
        if (context.Course.Any())
        {
            return;
        }

        context.Course.AddRange(
            new Course
            {
                Id = 1,
                CourseName = "Course One",
                CourseDescription = "Course One teaches course one",
                RoomNumber = 116,
                StartTime = TimeOnly.Parse("12:00 PM"),
                EndTime = TimeOnly.Parse("12:50 PM")
            },

            new Course
            {
                Id = 2,
                CourseName = "Course Two",
                CourseDescription = "Course Two teaches course two",
                RoomNumber = 200,
                StartTime = TimeOnly.Parse("12:00 PM"),
                EndTime = TimeOnly.Parse("12:50 PM")
            },

            new Course
            {
                Id = 3,
                CourseName = "Course Three",
                CourseDescription = "Course Three teaches course three",
                RoomNumber = 116,
                StartTime = TimeOnly.Parse("01:00 PM"),
                EndTime = TimeOnly.Parse("01:50 PM")
            },

            new Course
            {
                Id = 4,
                CourseName = "Course Four",
                CourseDescription = "Course Four teaches course four",
                RoomNumber = 200,
                StartTime = TimeOnly.Parse("01:00 PM"),
                EndTime = TimeOnly.Parse("01:50 PM")
            },
                
            new Course
            {
                Id = 5,
                CourseName = "Course Five",
                CourseDescription = "Course Five teaches course five",
                RoomNumber = 200,
                StartTime = TimeOnly.Parse("08:00 AM"),
                EndTime = TimeOnly.Parse("09:50 PM")
            }
        );
        context.SaveChanges();
    }
}