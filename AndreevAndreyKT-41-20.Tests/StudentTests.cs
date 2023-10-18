using AndreevAndreyKT_41_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreevAndreyKT_41_20.Tests
{
    public class StudentTests
    {
        [Fact]
        public void IsValidStudentName_AndreevAA_True()
        {
            var testStud = new Student
            {
                StudentId = 1,
                StudentName = "Андреев А.А.",
                AcademGroupId = 1,
                StudentDescription = "Студент 4 курса"
            };

            var result = testStud.IsValidStudentName();

            Assert.True(result);

        }
    }
}
