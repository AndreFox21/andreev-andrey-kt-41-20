namespace AndreevAndreyKT_41_20.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public AcademGroup? AcademGroup { get; set; }

    }
}
