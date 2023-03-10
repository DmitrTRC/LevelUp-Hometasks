SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockKeepingUnits](
	[Id] [uniqueidentifier] NOT NULL,
	[StockId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Amount] [float] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StockKeepingUnits] ADD  CONSTRAINT [PK_StockKeepingUnits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StockKeepingUnits]  WITH CHECK ADD  CONSTRAINT [FK_StockKeepingUnits_Stock] FOREIGN KEY([StockId])
REFERENCES [dbo].[Stocks] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockKeepingUnits] CHECK CONSTRAINT [FK_StockKeepingUnits_Stock]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Stock items in your warehouses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'StockKeepingUnits'
GO
