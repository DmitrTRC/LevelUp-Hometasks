SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopItems](
	[Id] [uniqueidentifier] NOT NULL,
	[SkuId] [uniqueidentifier] NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ShopItems] ADD  CONSTRAINT [PK_ShopItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ShopItems]  WITH CHECK ADD  CONSTRAINT [FK_ShopItems_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ShopItemCategories] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShopItems] CHECK CONSTRAINT [FK_ShopItems_Category]
GO
ALTER TABLE [dbo].[ShopItems]  WITH CHECK ADD  CONSTRAINT [FK_ShopItems_SKU] FOREIGN KEY([SkuId])
REFERENCES [dbo].[StockKeepingUnits] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ShopItems] CHECK CONSTRAINT [FK_ShopItems_SKU]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Information about the goods of your shop' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShopItems'
GO
