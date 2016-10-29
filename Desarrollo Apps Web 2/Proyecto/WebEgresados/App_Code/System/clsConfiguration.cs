using System.Configuration;
/// <summary>
/// Carlos Garcia & Alan Rivera
/// Last UpDate May 2016
/// </summary>
public static class clsConfiguration
{
    private static string dbConnectionString;
    private static string dbProviderName;

    static clsConfiguration()
    {
        dbConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        dbProviderName = ConfigurationManager.ConnectionStrings["Connection"].ProviderName;
    }

    public static string DbConnectionString
    {
        get { return dbConnectionString; }
    }

    public static string DbProviderName
    {
        get { return dbProviderName; }
    }
}