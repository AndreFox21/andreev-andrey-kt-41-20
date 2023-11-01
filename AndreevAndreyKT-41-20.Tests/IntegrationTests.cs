using AndreevAndreyKT_41_20.Database;
using AndreevAndreyKT_41_20.Interfaces;
using AndreevAndreyKT_41_20.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AndreevAndreyKT_41_20.Tests
{
    public class IntegrationTests
    {
        public readonly DbContextOptions<StudDatabaseContext> _dbContextOptions;

        public IntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<StudDatabaseContext>()
                .UseInMemoryDatabase(databaseName: "test_db")
                .Options;
        }

        [Fact]
        public async Task GetStudentsByGroupAsync_KT41120_OneObject()
        {
            // Arrange
            var ctx = new StudDatabaseContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var groups = new List<AcademGroup>
            {
                new AcademGroup
                {
                    AcademGroupId = 1,
                    GroupName = "KT-31-20",
                    GroupDescription = "Факультет ИВТ"
                },
                new AcademGroup
                {
                    AcademGroupId = 2,
                    GroupName = "KT-41-20",
                    GroupDescription = "Факультет ИВТ"
                }
            };
            await ctx.Set<AcademGroup>().AddRangeAsync(groups);

            var students = new List<Student>
            {
                new Student
                {
                    StudentId = 1,
                    StudentName = "Андреев А.А.",
                    AcademGroupId = 2,
                    IsDismissed = false
                },
                new Student
                {
                    StudentId = 2,
                    StudentName = "Иванов И.И.",
                    AcademGroupId = 1,
                    IsDismissed = true
                },
                new Student
                {
                    StudentId = 3,
                    StudentName = "Макаров А.В.",
                    AcademGroupId = 2,
                    IsDismissed = false
                }
            };
            await ctx.Set<Student>().AddRangeAsync(students);

            await ctx.SaveChangesAsync();

            // Act
            var filter = new Filters.StudentGroupFilter
            {
                GroupName = "KT-41-20",
                StudentName = "Андреев А.А.",
                IsDismissed = false
            };
            var studentsResult = await studentService.GetStudentsByGroupAsync(filter, CancellationToken.None);

            // Assert
            Assert.Single(studentsResult);

        }
    }
}
