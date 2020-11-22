use master

go
create database Blogs

go
use Blogs

go
create table Category(
	Id int identity primary key,
	Name nvarchar(500)
)

go
create table Article(
	Id int identity primary key,
	Title nvarchar(500),
	Des nvarchar(100),
	Detail ntext,
	CategoryId int foreign key references Category(Id),
	IsPublic bit default 1,
	DatePublic date default Getdate(),
	Thumbs nvarchar(500)
)

go
create table Position(
	Id int identity primary key,
	Name nvarchar(500)
)

go
create table ArticlePosition(
	Id int identity primary key,
	ArticleId int foreign key references Article(Id),
	PositionId int foreign key references Position(Id)
)

-- Get position
go
alter function GetPosition(@articleid int)
returns nvarchar(500)
as
begin
	DECLARE @result nvarchar(500)
	SELECT @result = ISNULL(@result, '') + Position.Name +', ' from ArticlePosition join Position on ArticlePosition.PositionId = Position.Id where ArticlePosition.ArticleId = @articleid
	select @result = substring(@result, 0, len(@result)) --trim extra "," at end
	return @result
end

select dbo.GetPosition(1) Position

go
alter function GetArticle()
returns @article table(
	Id int,
	Title nvarchar(500),
	Des nvarchar(100),
	Detail ntext,
	Category nvarchar(500),
	IsPublic nvarchar(10),
	DatePublic date,
	Position nvarchar(500),
	Thumbs nvarchar(500)
)
as 
begin
	Declare @id int, @title nvarchar(500), @des nvarchar(500), @detail nvarchar(500), @category int, @ispublic bit, @datepublic date, @thumbs nvarchar(500), @position nvarchar(500)
	DECLARE CUR CURSOR FAST_FORWARD FOR
    SELECT * FROM   Article
 
	OPEN CUR
	FETCH NEXT FROM CUR INTO @id, @title, @des, @detail, @category, @ispublic, @datepublic, @thumbs
 
	WHILE @@FETCH_STATUS = 0
	BEGIN
	   select @position = dbo.GetPosition(@id) 
	   declare @categoryname nvarchar(500)
	   select @categoryname = Name from Category where Id = @category
	   --declare @public nvarchar(10)
	   --select @public = case @ispublic when 1 then 'yes' else 'no' end
	   insert into @article
	   values(@id, @title, @des, @detail, @categoryname, case @ispublic when 1 then 'Yes' else 'No' end , @datepublic, @position, @thumbs)

	   FETCH NEXT FROM CUR INTO @id, @title, @des, @detail, @category, @ispublic, @datepublic, @thumbs
	END
	CLOSE CUR
	DEALLOCATE CUR
	
	return
end

select * from dbo.GetArticle()

go
create procedure USP_ListArticle
as
begin
	select * from dbo.GetArticle()
end

execute USP_ListArticle


go
create proc USP_GetCategory
as
begin
	select * from Category
end
go
create proc USP_GetPosition
as
begin
	select * from Position
end
exec USP_GetPosition


-- INSERT article
go
alter procedure USP_InsertArticle 
@title nvarchar(500), @des nvarchar(500), @detail ntext, @categoryid int, @ispublic bit, @datepublic date, @thumbs nvarchar(500)
as
begin
	insert into Article(Title, Des, Detail, CategoryId, IsPublic, DatePublic, Thumbs)
	values(@title, @des, @detail, @categoryid, @ispublic, @datepublic, @thumbs)

	IF (@@ROWCOUNT > 0)  
		BEGIN  
			SELECT Max(Id) from Article
		END  
end

go
create procedure USP_InsertArticlePosition
@articleid int, @positionid int
as
begin
	insert into ArticlePosition(ArticleId, PositionId)
	values(@articleid, @positionid)

	IF (@@ROWCOUNT > 0)  
		BEGIN  
			SELECT 'Insert'  
		END  
end


-- Delete article
go
create procedure USP_DeleteArticle
@id int
as
begin
	delete ArticlePosition where ArticleId = @id
	delete Article where Id = @id
end


-- Get article
go
create procedure USP_GetArticle
@id int
as
begin
	select * from Article where Id = @id 
end

exec USP_GetArticle @id =7

-- Get ArticlePosition
go
alter procedure USP_GetArticlePosition
@articleid int
as
begin
	select Position.Id, Position.Name from Position join ArticlePosition on Position.Id = ArticlePosition.PositionId where ArticlePosition.ArticleId = @articleid
end
exec USP_GetArticlePosition @articleid=7

---- Get ArticlePosition
--go
--create proc USP_GetArticlePosition @articleid int
--as
--begin
--	select Position.Id, Position.Name from Position join ArticlePosition on Position.Id = ArticlePosition.PositionId where ArticlePosition.ArticleId = @articleid
--end

--exec USP_GetArticlePosition @articleid = 7


-- Get ArticlePosition
go
alter procedure USP_UpdateArticle
@id int, @title nvarchar(500), @des nvarchar(500), @detail ntext, @categoryid int, @ispublic bit, @datepublic date, @thumbs nvarchar(500)
as
begin
	update Article set Title = @title, Des = @des, Detail = @detail, CategoryId = @categoryid,
	IsPublic = @ispublic, DatePublic = @datepublic, Thumbs = @thumbs where Id = @id
	delete ArticlePosition where ArticleId = @id
end

go
create procedure USP_SearchArticle
@searchString nvarchar(500)
as
begin
	select * from dbo.GetArticle() where Title like '%'+@searchString+'%'
end

exec USP_SearchArticle @searchString = N'động'