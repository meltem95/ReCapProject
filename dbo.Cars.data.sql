SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (1, 1, 1, N'2019', CAST(3000 AS Decimal(18, 0)), N'2019 model BMW')
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (2, 1, 2, N'2009', CAST(2000 AS Decimal(18, 0)), N'kiralik')
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (3, 6, 4, N'2015', CAST(200 AS Decimal(18, 0)), N'2015 model Audi')
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (4, 3, 3, N'2020', CAST(750 AS Decimal(18, 0)), N'2020 model Opel')
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (5, 2, 2, N'2017', CAST(400 AS Decimal(18, 0)), N'2017 model Ford')
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (6, 4, 1, N'2018', CAST(1000 AS Decimal(18, 0)), N'2018 model Mercedes')
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (7, 2, 4, N'2019', CAST(500 AS Decimal(18, 0)), N'2019 model Ford')
INSERT INTO [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (1002, 2, 7, N'2011', CAST(300 AS Decimal(18, 0)), N'2011 Model Ford')
SET IDENTITY_INSERT [dbo].[Cars] OFF

Delete from Cars where ModelYear='2011'