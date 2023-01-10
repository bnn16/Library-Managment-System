create Table login(
id int not null identity(1,1) primary key,
username varchar(150) not null,
pass varchar(150) not null
)

create table books(
id int not null Identity(1,1) primary key,
book_name varchar(250) not null,
author varchar(250) not null,
genre varchar(250) not null,
pages int not null,
isbn19 int not null,
publish_date varchar(250) not null,
book_description varchar(1500) not null
)

drop table books

remove into login (username, pass) values('bogdan', 'pass')



DELETE FROM login where id = 1;