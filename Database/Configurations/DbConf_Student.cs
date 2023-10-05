using AndreevAndreyKT_41_20.Database.Helpers;
using AndreevAndreyKT_41_20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndreevAndreyKT_41_20.Database.Configurations
{
    public class DbConf_Student : IEntityTypeConfiguration<Student>
    {
        private const string TableName = "db_Students";
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //первичный ключ
            builder
                .HasKey(p => p.StudentId)
                .HasName($"pk_{TableName}_student_id");

            // автогенерация пк
            builder.Property(p => p.StudentId)
                .ValueGeneratedOnAdd();

            // описываем колонки таблицы

            builder.Property(p => p.StudentId)
                .HasColumnName("student_id")
                .HasComment("ID студента");

            builder.Property(p => p.StudentName)
                .IsRequired()
                .HasColumnName("student_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("ФИО студента");

            builder.Property(p => p.AcademGroupId)
                .IsRequired()
                .HasColumnName("academ_group_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("ID группы");

            // описываем связи

            builder.ToTable(TableName)
                .HasOne(p => p.AcademGroup)                   // один
                .WithMany()                                   // ко многим
                .HasForeignKey(p => p.AcademGroupId)          // по ключу
                .HasConstraintName("fk_f_academ_group_id")    // название столбца
                .OnDelete(DeleteBehavior.Cascade);            // имеет каскадное удаление (при удалении группы)

            builder.ToTable(TableName)
                .HasIndex(p => p.AcademGroupId, $"idx_{TableName}_fk_f_academ_group_id");

            // явная автоподгрузка связанной сущности
            builder.Navigation(p => p.AcademGroup)
                .AutoInclude();

            //throw new NotImplementedException();
        }
    }
}
