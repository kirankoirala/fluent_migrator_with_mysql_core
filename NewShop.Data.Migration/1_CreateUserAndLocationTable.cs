using System;
using FluentMigrator;

namespace NewShop.Data.Migration
{
    [Migration(1)]
    public class NewShopData : FluentMigrator.Migration
    {
        public override void Up()
        {

            Create.Table("LOCATION")
                .WithColumn("LOCATION_ID").AsInt64().PrimaryKey("PK_USER")
                .WithColumn("ADDRESS").AsString(250).NotNullable()
                .WithColumn("PHONE_NUMBER").AsString(50).NotNullable();

            Create.Table("USER")
                .WithColumn("USER_ID").AsDecimal(19, 0).PrimaryKey("PK_USER")
                .WithColumn("FIRST_NAME").AsString(50).NotNullable()
                .WithColumn("LAST_NAME").AsString(50).NotNullable()
                .WithColumn("LOCATION_ID").AsInt64().ForeignKey("FK_USER_LOCATION", "LOCATION", "LOCATION_ID");
        }

        public override void Down()
        {
            Delete.Table("USER");
            Delete.Table("LOCATION");
        }
    }
}
