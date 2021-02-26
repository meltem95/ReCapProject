SET IDENTITY_INSERT [dbo].[Colors] ON
INSERT INTO [dbo].[Colors] ([ColorId], [ColorName]) VALUES (1, N'Black')
INSERT INTO [dbo].[Colors] ([ColorId], [ColorName]) VALUES (2, N'White')
INSERT INTO [dbo].[Colors] ([ColorId], [ColorName]) VALUES (3, N'Gray')
INSERT INTO [dbo].[Colors] ([ColorId], [ColorName]) VALUES (4, N'Kirmizi')
INSERT INTO [dbo].[Colors] ([ColorId], [ColorName]) VALUES (5, N'Green')
INSERT INTO [dbo].[Colors] ([ColorId], [ColorName]) VALUES (6, N'Pink')
INSERT INTO [dbo].[Colors] ([ColorId], [ColorName]) VALUES (7, N'Blue')
SET IDENTITY_INSERT [dbo].[Colors] OFF
Update Colors set ColorName ='Red' where ColorName='Kirmizi'