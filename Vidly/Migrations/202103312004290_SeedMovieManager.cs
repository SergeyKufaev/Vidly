namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedMovieManager : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'8f7fa09e-db88-4c2b-9e41-b7be263e1c2e', N'moviemanager@vidly.com', 0, N'AIcbOv0L6TxSr9rfjK4UMm90iwdAIg6+hK6Ktv9z9X/A8o7gM4f8mFAnMFmhtaU17w==', N'857e1528-6270-4bf6-ab6b-fd68af0c75d3', NULL, 0, 0, NULL, 1, 0, N'moviemanager@vidly.com', N'12345', N'1234567')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f7fa09e-db88-4c2b-9e41-b7be263e1c2e', N'0c84edbe-53ea-4434-8409-89cddbe05aef')
");
        }

        public override void Down()
        {
        }
    }
}
