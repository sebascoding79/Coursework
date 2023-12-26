IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semester]') AND type in (N'U'))
DROP TABLE [dbo].[semester]
GO