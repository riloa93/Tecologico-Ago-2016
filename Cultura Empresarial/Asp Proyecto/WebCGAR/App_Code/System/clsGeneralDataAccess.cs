using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Alan Rivera Last Update Nov 2016
/// </summary>
public class clsGenericDataAccess
{
    public static DataTable ExecuteSelectCommand(DbCommand command)
    {
        DataTable table;

        try
        {
            command.Connection.Open();
            DbDataReader reader = command.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            reader.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            command.Connection.Close();
        }
        return table;
    }
    
    public static DbCommand CreateCommand()
    {
        string dataProviderName = clsConfiguration.DbProviderName;
        string connectionString = clsConfiguration.DbConnectionString;
        DbProviderFactory factory = DbProviderFactories.
        GetFactory(dataProviderName);
        DbConnection conn = factory.CreateConnection();
        conn.ConnectionString = connectionString;
        DbCommand comm = conn.CreateCommand();
        return comm;
    }

    public static int ExecuteNonQuery(DbCommand command)
    {
        int affectedRows = -1;

        try
        {
            command.Connection.Open();
            affectedRows = command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            command.Connection.Close();
        }
        return affectedRows;
    }
}