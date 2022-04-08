using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Data.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                INSERT INTO[dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'51a3ec83-4b3a-4ba3-9fb5-eec95a23ba5f', N'levsamson.work@gmail.com', N'LEVSAMSON.WORK@GMAIL.COM', N'levsamson.work@gmail.com', N'LEVSAMSON.WORK@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDAoVykAtauVPYcvyyIrMfhytZrWX9R2Po32O9+g2S+61dtpaVefR7rfkA+iAJL3tA==', N'KHBOYXXRCDU5XZDXKI2MCKBRYCBCGSC5', N'd12e0386-8f39-4c59-88de-9d5627036bf2', NULL, 0, 0, NULL, 1, 0)
                INSERT INTO[dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'bf77cc46-2842-47df-a717-b44e72fc9856', N'nedra.tailog@gmail.com', N'NEDRA.TAILOG@GMAIL.COM', N'nedra.tailog@gmail.com', N'NEDRA.TAILOG@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJ6N+csQC3/Jq1tie2TEcz0FU5PTHPHfIX6llsBnm2izxeDZ4smeMRy4KZMZL4lMMA==', N'3OYAIR6MXJGJENT2QPCLNLGCPJ6M26UM', N'd2aafa63-2a25-4bff-ad0f-500776bca1fe', NULL, 0, 0, NULL, 1, 0)
 
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'dea8195d-3cb0-4acf-9fda-40f6ff1cba64', N'CanManageMovie', N'CanManageMovie', N'aeda8594-fe4c-4774-b947-45d34f691039')
 
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'51a3ec83-4b3a-4ba3-9fb5-eec95a23ba5f', N'dea8195d-3cb0-4acf-9fda-40f6ff1cba64')
            ");
            migrationBuilder.Sql(sql);
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
