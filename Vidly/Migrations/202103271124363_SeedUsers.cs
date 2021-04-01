namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1216bf97-7b48-47fb-800a-764fcd059c12', N'guest@vidly.com', 0, N'ADVxbUtdVDPELRWpbkTl/S2dJV37fHu+5lI12lXbRMO2c7UhYLp1OEm/UNOedbt2iA==', N'acb00225-2155-4783-bb09-06480e452243', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'69915b92-719b-426a-b76a-f5b3cfa57ab6', N'admin@vidly.com', 0, N'AGmD7pKm6WQSuAVIIQlaQSwwG3SMYT344LkfA8Rt3NndItZHR8LNaLlACPCBYFIbZA==', N'df92fad0-b35c-40fa-941f-d792a8e9925f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dff246ee-2bc1-4712-881d-786af0192cd2', N'Admin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0c84edbe-53ea-4434-8409-89cddbe05aef', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'69915b92-719b-426a-b76a-f5b3cfa57ab6', N'dff246ee-2bc1-4712-881d-786af0192cd2')
");
        }

        public override void Down()
        {
        }
    }
}
