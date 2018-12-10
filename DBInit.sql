create table AAA
(
	Id int identity primary key,
	Name varchar(30),
	Age int
)

select * from [AAA];

alter database Test set read_committed_snapshot on;