using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Data.Migrations
{
    public partial class testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
SET IDENTITY_INSERT [dbo].[Book] ON
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (6, N'Test', N'Test', N'B', N'2020-04-02 13:00:00', N'2020-04-02 13:00:00')
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (9, N'Test', N'T', N'A', N'2020-04-12 13:00:00', N'2020-04-05 12:59:00')
INSERT INTO [dbo].[Book] ([Id], [Name], [Description], [Author], [DateAdded], [PublishDate]) VALUES (10, N'Let', N'Testing', N'Let me test', N'2020-04-12 12:59:00', N'2020-04-06 12:59:00')
SET IDENTITY_INSERT [dbo].[Book] OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
