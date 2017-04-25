create table account (
	username 	varchar(16) 	not null primary key,
	password 	varchar(16) 	not null,
	Name		nvarchar(50)	not null
)

)
create table topic (
	topicid		int				not null primary key,
	topicName	nvarchar(500)	not null
)

create table topicdetail (
	topicdetailid int			not null primary key,
	topicid 	int 			not null,
	status		nvarchar(50)	not null,
	mark		int				null,
	typeoftopic nvarchar(9)		not null,
	foreign key (topicid) references topic(topicid)
)

create table student (
	studentid	varchar(8)		not null primary key,
	studentname	nvarchar(50)	not null,
	email		varchar(50)		not null,
	specialized	nvarchar(70)	not null,
	topicid		int				not null,
	foreign key (topicid) references topic(topicid)
)

create table guider (
	guiderid	int				not null,
	guidername	nvarchar(50)	not null,
	role		nvarchar(15)	not null,
	topicid		int				not null,
	primary key (guiderid, topicid)
	foreign key (topicid) references topic(topicid)
)

create table marker (
	markerid		int				not null,
	markername	nvarchar(50)	not null,
	mark		int				not null,
	comment		nvarchar(500)	not null,
	topicid		int				not null,
	primary key (markerid, mark, topicid),
	foreign key (topicid) references topic(topicid)
)

create table time (
	schoolyear	varchar(9)		not null,
	semester	varchar(3)		not null,
	topicid		int				not null,
	primary key (topicid, schoolyear, semester),
	foreign key (topicid) references topic(topicid)
)

insert into account	values ('admin','admin',N'Trần Văn Hoàng')

insert into subject values 
('CT271',N'Niên luận cơ sở - CNTT',3,
('CT466',N'Niên luận - CNTT',3),
('CT270',N'Niên luận cơ sở - THƯD',3),
('CT408',N'Niên luận - THƯD',3),
('CT252',N'Niên luận cơ sở - HTTT',3),
('CT263',N'Niên luận - HTTT',3),
('CT239',N'Niên luận cơ sở - KTPM',3),
('CT250',N'Niên luận - KTPM',3),
('CT201',N'Niên luận cơ sở - KHMT',3),
('CT208',N'Niên luận - KHMT',3),
('CT226',N'Niên luận cơ sở - MMT&TT',3),
('CT439',N'Niên luận - MMT&TT',3)

insert into topic values
(1,N'Đề tài 1'),
(2,N'Đề tài 2'),
(3,N'Đề tài 3'),
(4,N'Đề tài 4'),
(5,N'Đề tài 5'),
(6,N'Đề tài 6'),
(7,N'Đề tài 7'),
(8,N'Đề tài 8'),
(9,N'Đề tài 9'),
(10,N'Đề tài 10')

insert into topicdetail values
(1,N'Chưa hoàn thành',0,N'Niên luận',N'Nhóm','CT271'),
(2,N'Chưa hoàn thành',0,N'Luận văn',N'Sinh viên','CT466'),
(3,N'Chưa hoàn thành',0,N'Niên luận',N'Sinh viên','CT270'),
(4,N'Hoàn thành',0,N'Luận văn',N'Nhóm','CT263'),
(5,N'Hoàn thành',0,N'Đồ án',N'Nhóm','CT271'),
(6,N'Hoàn thành',0,N'Niên luận',N'Sinh viên','CT226'),
(7,N'Hoàn thành',0,N'Đồ án',N'Sinh viên','CT439'),
(8,N'Hoành thành',0,N'Niên luận',N'Nhóm','CT408'),
(9,N'Hoàn thành - trễ hạn',0,N'Luận văn',N'Nhóm','CT226'),
(10,N'Hoành thành - trễ hạn',0,N'Niên luận',N'Sinh viên','CT201'),