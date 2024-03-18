Create database lab9;
use lab9

select username as Username, real_name as Name, birthday, gender, email from khachHang;
Create Login mylogin with password='mylogin', CHECK_POLICY = OFF;
sp_changedbowner mylogin;

drop table khachHang

create table khachHang(
	username nvarchar(20) primary key,
	user_password varchar(50),
	real_name nvarchar(100),
	birthday nvarchar(100),
	gender varchar(5),
	email nvarchar(50),
	income money
)

alter table khachHang
	alter column user_password varchar(50) not null
alter table khachHang
	alter column real_name nvarchar(100) not null
alter table khachHang
	add check (dbo.checkEmail(email)=1)
alter table khachHang
	add check (income>1000000 and income<50000000)


drop function dbo.checkemail
create function checkEmail (@email nvarchar(50))
returns bit
as
begin
	RETURN CASE 
		WHEN @email LIKE '%_@__%.__%' AND CHARINDEX(' ', @email) = 0 THEN 1
    ELSE 0
	end
end

create function dbo.isLegitDate (@date nvarchar(50))
returns bit
as
begin
    DECLARE @result bit
	IF ISDATE(@date) = 1
			SET @result = 1
		ELSE
			SET @result = 0
	return @result
end


select dbo.isLegitDate('10/2/20022')
select dbo.checkEmail('a@gmail.com')