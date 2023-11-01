# Добавление данных в бд:

insert into "AcademGroups" (group_name, group_description)
select 'КТ-41-20', 'Факультет ИВТ';

insert into "AcademGroups" (group_name, group_description)
select 'КТ-42-20', 'Факультет ИВТ';

insert into "AcademGroups" (group_name, group_description)
select 'КТ-41-18', 'Факультет ИВТ';

insert into "db_Students" (student_name, academ_group_id, is_dismissed)
select 'Иванов И.В.', 1, false;

insert into "db_Students" (student_name, academ_group_id, is_dismissed)
select 'Николаев А.А.', 1,false;

insert into "db_Students" (student_name, academ_group_id, is_dismissed)
select 'Давыдов Н.Н.', 1, true;

insert into "db_Students" (student_name, academ_group_id, is_dismissed)
select 'Петров Г.Д.', 2,false;

insert into "db_Students" (student_name, academ_group_id, is_dismissed)
select 'Иванов Е.Е.', 2,false;

insert into "db_Students" (student_name, academ_group_id, is_dismissed)
select 'Сидоров С.К.', 3, false;

insert into "db_Students" (student_name, academ_group_id, is_dismissed)
select 'Андреев А.А.', 1, false;
