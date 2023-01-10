create Table login(
id int not null identity(1,1) primary key,
username varchar(150) not null,
pass varchar(150) not null
)
select * from login

create table books(
id int not null Identity(1,1) primary key,
book_name varchar(250) not null,
author varchar(250) not null,
genre varchar(250) not null,
pages int not null,
isbn19 bigint not null,
publish_date varchar(250) not null,
book_description varchar(1500) not null,
book_quantity int not null
)

select * from books

create table students(
id int not null identity(1,1) primary key,
students_name varchar(250) not null,
pcn bigint not null,
students_email varchar(250)not null
)

create table book_history(
id int not null identity(1,1) primary key,
pcn bigint not null,
students_name varchar(250) not null,
students_email varchar(250) not null,
book_name varchar(250) not null,
book_issue_date varchar(250) not null,
book_return_date varchar(250)
)

drop table books

remove into login (username, pass) values('bogdan', 'pass')

select * from book_history where book_return_date is not null and pcn = '123'

insert into books (book_name, author, genre, pages, isbn19, publish_date, book_description, book_quantity) values ('test','test','test',123,1231231231, '12/02/2003', 'test',22)
DELETE FROM login where id = 1;