using System.Configuration;

class DbProductFactory
{
    public static IDbProduct Create()
    {

        if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
        {
            return new SQLServerProduct();
        }
        else
        {
            return new MongoDBProduct();
        }

    }

}