using FluentMigrator;

namespace NewShop.Data.Migration
{
    [Migration(3)]
    public class CreateCustomerTable : FluentMigrator.Migration
    {
        public override void Up()
        {

            Create.Table("CUSTOMER")
                .WithColumn("CUSTOMER_ID").AsInt64().PrimaryKey("PK_CUSTOMER")
                .WithColumn("CUSTOMER_NAME").AsString(250).NotNullable()
                .WithColumn("PHONE_NUMBER").AsString(50).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("CUSTOMER");
        }
    }
}