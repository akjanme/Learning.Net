 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertStudentData]    Script Date: 11/12/2022 8:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[sp_InsertStudentData]
(
 @name nvarchar(100),
 @fathername nvarchar(100),
 @mothername nvarchar(100),
 @phone nvarchar(10),
 @gender nvarchar(10),
 @address nvarchar(100),
 @imagepath nvarchar(100)
)
as 
begin 
 insert into student (Name,FatherName,MotherName,Phone,Gender,Address,ImagePath)
			values (@name,@fathername,@mothername,@phone,@gender,@address,@imagepath)

end