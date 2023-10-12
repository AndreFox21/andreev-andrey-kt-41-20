using System.Text.RegularExpressions;

namespace AndreevAndreyKT_41_20.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int AcademGroupId { get; set; }
        public string StudentDescription { get; set; }
        public AcademGroup AcademGroup { get; set; }

        public bool IsValidStudentName() // Проверка формата ввода StudentName (Имя Ф.О.)
        {
            return Regex.Match(StudentName, @"\S+\w*\s{1}\w{1}.\w{1}.$").Success;
        }

    }
}
