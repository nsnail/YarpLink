--清空数据库内所有的表 --注意替换数据库
USE YarpLink_Tsk 
GO
DECLARE
	@SQL VARCHAR ( 8000 )
WHILE
		( SELECT COUNT ( * ) FROM sysobjects WHERE type = 'U' ) > 0 BEGIN
		SELECT
			@SQL = 'drop table ' + name 
		FROM
			sysobjects 
		WHERE
			( type = 'U' ) 
		ORDER BY
		'drop table ' + name EXEC ( @SQL ) 
END


--清空数据库内所有的表 --注意替换数据库
USE YarpLink_Sys
GO
DECLARE
	@SQL VARCHAR ( 8000 )
WHILE
		( SELECT COUNT ( * ) FROM sysobjects WHERE type = 'U' ) > 0 BEGIN
		SELECT
			@SQL = 'drop table ' + name 
		FROM
			sysobjects 
		WHERE
			( type = 'U' ) 
		ORDER BY
		'drop table ' + name EXEC ( @SQL ) 
END


--清空数据库内所有的表 --注意替换数据库
USE YarpLink_Res
GO
DECLARE
	@SQL VARCHAR ( 8000 )
WHILE
		( SELECT COUNT ( * ) FROM sysobjects WHERE type = 'U' ) > 0 BEGIN
		SELECT
			@SQL = 'drop table ' + name 
		FROM
			sysobjects 
		WHERE
			( type = 'U' ) 
		ORDER BY
		'drop table ' + name EXEC ( @SQL ) 
END



--清空数据库内所有的表 --注意替换数据库
USE YarpLink_Cst
GO
DECLARE
	@SQL VARCHAR ( 8000 )
WHILE
		( SELECT COUNT ( * ) FROM sysobjects WHERE type = 'U' ) > 0 BEGIN
		SELECT
			@SQL = 'drop table ' + name 
		FROM
			sysobjects 
		WHERE
			( type = 'U' ) 
		ORDER BY
		'drop table ' + name EXEC ( @SQL ) 
END