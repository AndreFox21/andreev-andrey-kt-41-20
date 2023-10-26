using AndreevAndreyKT_41_20.Database.Helpers;
using AndreevAndreyKT_41_20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndreevAndreyKT_41_20.Database.Configurations
{
    public class DbConf_AcademGroup : IEntityTypeConfiguration<AcademGroup>
    {
        private const string TableName = "db_AcademGroups";
        public void Configure(EntityTypeBuilder<AcademGroup> builder)
        {
            //первичный ключ
            builder
                .HasKey(p => p.AcademGroupId)
                .HasName($"pk_{TableName}_group_id");

            // автогенерация пк
            builder.Property(p => p.AcademGroupId)
                .ValueGeneratedOnAdd();

            // описываем колонки таблицы

            builder.Property(p => p.AcademGroupId)
                .HasColumnName("group_id")
                .HasComment("ID группы");

            builder.Property(p => p.GroupName)
                .IsRequired()
                .HasColumnName("group_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название группы");

            builder.Property(p => p.GroupDescription)
                .IsRequired()
                .HasColumnName("group_description")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Описание группы");

            //

            //builder.ToTable(TableName)
            //.HasMany(p => p.Students)
            //.WithOne(p => p.AcademGroup)
            //.HasForeignKey(p => p.StudentId);
            //.OnDelete(DeleteBehavior.Cascade);



            //throw new NotImplementedException();
        }
    }
}