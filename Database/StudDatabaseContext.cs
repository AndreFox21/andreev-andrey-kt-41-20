using Microsoft.EntityFrameworkCore;

namespace AndreevAndreyKT_41_20.Database
{
    public class StudDatabaseContext:DbContext
    {
        public StudDatabaseContext(DbContextOptions<StudDatabaseContext> options) : base(options)
        {

        }
    }
}
