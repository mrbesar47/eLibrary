using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Data.Migrations
{
    public partial class seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'41d6494a-cf54-4d58-b5c1-55e3ebc2788f', N'test@aubg.edu', N'TEST@AUBG.EDU', N'test@aubg.edu', N'TEST@AUBG.EDU', 1, N'AQAAAAEAACcQAAAAEHcBRPUenc9GEJaEu0V9bSzwhEX9RUGmwjlU3ZUoqlMmw12U74dCqgFArhklUvcEjA==', N'UW4GF3IR2SKJ5EGLIHBKE5KDQD43SIRT', N'cf2e7ce1-387b-4fe4-ac8f-8fa48c01e484', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Book] ON
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (1, N'Hamlet', N'Tragedy', N'Shapespeare', N'2020-04-01 12:58:00', N'1601-02-02 12:59:00')
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (2, N'In Search of Lost Time', N'The Greatest Books List', N'Marcel Proust', N'2020-04-01 12:59:00', N'1913-01-01 12:59:00')
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (3, N'Ulysses', N'The Greatest Books List', N'James Joyce', N'2020-04-01 13:00:00', N'1904-06-04 12:59:00')
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (4, N'Don Quixote', N'The Greatest Books List', N'Miguel de Cervantes', N'2020-04-01 13:01:00', N'1612-01-01 13:00:00')
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (5, N'The Great Gatsby', N'The Greatest Books List', N'Scott Fitzgerald', N'2020-04-01 14:59:00', N'1925-01-01 12:59:00')
SET IDENTITY_INSERT [dbo].[Book] OFF
");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
