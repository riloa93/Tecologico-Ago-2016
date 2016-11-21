using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;

/// <summary>
/// Summary description for clsMonitorAlmacen
/// Programming by Alan Rivera. 2016
/// </summary>
public class clsMonitorAlmacen
{
    public static DataTable leePartida()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Partida_Almacen";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static void actualizaSemanas(int Actual)
    {
        int Anterior = Actual;
        Actual++;
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "UPDATE Partida_Almacen SET Semana_Actual='"+ Actual+"', Semana_Anterior='"+ Anterior +"', Generador='N'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static DataTable leerMovimientos()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM MovimientosAlmacen";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable leerPedidos()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT OrdenProductoID, pClienteID, pProductoID, pCantidad ,pEstado FROM PedidosAlmacen INNER JOIN Pedidos_ProductosAlmacen ON OrdenProductoID = pOrdenProductoID";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable leerClientes()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM ClientesAlmacen";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static void reiniciarPartida()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM EntradasAutAlmacen";
        clsGenericDataAccess.ExecuteNonQuery(comm);

        comm.CommandText = "DELETE FROM MovimientosAlmacen";
        clsGenericDataAccess.ExecuteNonQuery(comm);

        comm.CommandText = "UPDATE Partida_Almacen SET Semana_Actual='0',Semana_Anterior='0',Generador='N'";
        clsGenericDataAccess.ExecuteNonQuery(comm);

        comm.CommandText = "DELETE FROM Pedidos_ProdDup";
        clsGenericDataAccess.ExecuteNonQuery(comm);

        comm.CommandText = "DELETE FROM Pedidos_ProductosAlmacen";
        clsGenericDataAccess.ExecuteNonQuery(comm);

        comm.CommandText = "DELETE FROM PedidosAlmacen";
        clsGenericDataAccess.ExecuteNonQuery(comm);

        comm.CommandText = "DELETE FROM ProductosAlmacen";
        clsGenericDataAccess.ExecuteNonQuery(comm);

        comm.CommandText = "DELETE FROM UbicacionAlamacen";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
}