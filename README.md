# andreev-andrey-kt-41-20

Добавление данных в бд:

insert into "AcademGroups" (group_name, group_description)
select 'КТ-41-20', 'Не удалена';

insert into "AcademGroups" (group_name, group_description)
select 'КТ-42-20', 'Не удалена';

insert into "AcademGroups" (group_name, group_description)
select 'КТ-41-18', 'Удалена';

insert into "db_Students" (student_name, academ_group_id, student_description)
select 'Иванов И.В.', 1,'Студент';

insert into "db_Students" (student_name, academ_group_id, student_description)
select 'Николаев А.А.', 1,'Отчислен';

insert into "db_Students" (student_name, academ_group_id, student_description)
select 'Давыдов Н.Н.', 1,'Студент';

insert into "db_Students" (student_name, academ_group_id, student_description)
select 'Петров Г.Д.', 2,'Студент';

insert into "db_Students" (student_name, academ_group_id, student_description)
select 'Иванов Е.Е.', 2,'Студент';

insert into "db_Students" (student_name, academ_group_id, student_description)
select 'Сидоров С.К.', 3,'Студент';
