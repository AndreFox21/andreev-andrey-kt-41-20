namespace AndreevAndreyKT_41_20.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int AcademGroupId { get; set; }
        public AcademGroup AcademGroup { get; set; }

    }
}
