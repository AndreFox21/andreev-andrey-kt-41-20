﻿// <auto-generated />
using AndreevAndreyKT_41_20.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AndreevAndreyKT_41_20.Migrations
{
    [DbContext(typeof(StudDatabaseContext))]
    partial class StudDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AndreevAndreyKT_41_20.Models.AcademGroup", b =>
                {
                    b.Property<int>("AcademGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("group_id")
                        .HasComment("ID группы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AcademGroupId"));

                    b.Property<string>("GroupDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("group_description")
                        .HasComment("Описание группы");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("group_name")
                        .HasComment("Название группы");

                    b.HasKey("AcademGroupId")
                        .HasName("pk_db_AcademGroups_group_id");

                    b.ToTable("AcademGroups");
                });

            modelBuilder.Entity("AndreevAndreyKT_41_20.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("student_id")
                        .HasComment("ID студента");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<int>("AcademGroupId")
                        .HasColumnType("int4")
                        .HasColumnName("academ_group_id")
                        .HasComment("ID группы");

                    b.Property<bool>("IsDismissed")
                        .HasColumnType("bool")
                        .HasColumnName("is_dismissed")
                        .HasComment("Статус отчисления");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("student_name")
                        .HasComment("ФИО студента");

                    b.HasKey("StudentId")
                        .HasName("pk_db_Students_student_id");

                    b.HasIndex(new[] { "AcademGroupId" }, "idx_db_Students_fk_f_academ_group_id");

                    b.ToTable("db_Students", (string)null);
                });

            modelBuilder.Entity("AndreevAndreyKT_41_20.Models.Student", b =>
                {
                    b.HasOne("AndreevAndreyKT_41_20.Models.AcademGroup", "AcademGroup")
                        .WithMany()
                        .HasForeignKey("AcademGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_academ_group_id");

                    b.Navigation("AcademGroup");
                });
#pragma warning restore 612, 618
        }
    }
}
