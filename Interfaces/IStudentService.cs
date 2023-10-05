using AndreevAndreyKT_41_20.Filters;
using AndreevAndreyKT_41_20.Models;
using AndreevAndreyKT_41_20.Database;
using Microsoft.EntityFrameworkCore;

namespace AndreevAndreyKT_41_20.Interfaces
{
    public interface IStudentService
    {
        public Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken);
    }
    public class StudentService : IStudentService
    {
        private readonly StudDatabaseContext _dbContext;

        public StudentService(StudDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            var students = _dbContext.Set<Student>().Where(w => w.AcademGroup.GroupName == filter.GroupName).ToArrayAsync(cancellationToken);
            return students;
        }
    }
}
