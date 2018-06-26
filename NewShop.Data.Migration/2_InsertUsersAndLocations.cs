using FluentMigrator;

namespace NewShop.Data.Migration
{
    [Migration(2)]
    public class InsertUsersAndLocations:FluentMigrator.Migration
    {
        public override void Up()
        {
            Insert.IntoTable("LOCATION").Row(new {LOCATION_ID = 1, ADDRESS = "TEMPORARY ADDRESS", PHONE_NUMBER = "1234567890"});
            Insert.IntoTable("LOCATION").Row(new {LOCATION_ID = 2, ADDRESS = "PERMANENT ADDRESS", PHONE_NUMBER = "0987654321"});

            Insert.IntoTable("USER").Row(new {USER_ID = 1,FIRST_NAME = "KIRAN", LAST_NAME = "KOIRALA", LOCATION_ID=1});
            Insert.IntoTable("USER").Row(new {USER_ID = 2,FIRST_NAME = "RAM", LAST_NAME = "TAMANG", LOCATION_ID = 2 });
        }

        public override void Down()
        {
            Delete.FromTable("USER").AllRows();
            Delete.FromTable("LOCATION").AllRows();
        }
    }
}
