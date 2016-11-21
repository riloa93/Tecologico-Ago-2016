using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for clsReportes
/// </summary>
public class clsReportes
{
    public static DataTable buscaResultados(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT MAX(Semana) as Semana FROM DatosJuego WHERE UsuarioID = '" + UsuarioID + "'";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        if (T.Rows[0][0].ToString() != "")
        {
            comm.CommandText = "SELECT D.EmpresaID,Total,LoteServicio,InventarioMedio,DemandaAcumulada,LoteProduccion," +
                "(OrdenCompraProv1 + OrdenCompraProv2) AS Compras,CostoServicio,D.Semana,D.TipoEmpresa,D.UsuarioID FROM DatosJuego D, " +
                "CostosJuego C WHERE D.Semana = " + T.Rows[0][0].ToString() + " AND C.Semana = D.Semana AND D.EmpresaID = C.EmpresaID AND " +
                " D.UsuarioID = '" + UsuarioID + "' AND C.UsuarioID = D.UsuarioID AND D.TipoEmpresa = C.TipoEmpresa ORDER BY TipoEmpresa,EmpresaID";
            T= clsGenericDataAccess.ExecuteSelectCommand(comm);
        }
                    
        return T; 
    }

    public static DataTable buscaMaxSemana(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT MAX(Semana) as Semana FROM DatosJuego WHERE UsuarioID = '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable buscaEmpNombrePT(string UsuarioID, string EmpresaID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT EmpresaID,eNombre FROM EmpresasPT WHERE UsuarioID = '" + UsuarioID + "' AND EmpresaID =" + EmpresaID;
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaCampoHistorial(string UsuarioID,string EmpresaID,string TipoEmpresa,string Campo)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT UsuarioID,EmpresaID," + Campo + ",Semana,TipoEmpresa FROM DatosJuego " +
            "WHERE UsuarioID = '" + UsuarioID + "' AND EmpresaID = " + EmpresaID + " AND TipoEmpresa = " + TipoEmpresa + " ORDER BY Semana ";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaCampoHistorial2(string UsuarioID, string EmpresaID, string TipoEmpresa, string Campo1,string Campo2)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT UsuarioID,EmpresaID,(" + Campo1 + " + " + Campo2 +") AS Result,Semana,TipoEmpresa FROM DatosJuego " +
            "WHERE UsuarioID = '" + UsuarioID + "' AND EmpresaID = " + EmpresaID + " AND TipoEmpresa = " + TipoEmpresa + " ORDER BY Semana ";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaCampoCostosHistorial(string UsuarioID, string EmpresaID, string TipoEmpresa, string Campo)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT UsuarioID,EmpresaID," + Campo + ",Semana,TipoEmpresa FROM CostosJuego " +
            "WHERE UsuarioID = '" + UsuarioID + "' AND EmpresaID = " + EmpresaID + " AND TipoEmpresa = " + TipoEmpresa + " ORDER BY Semana ";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaEmpresasJuego(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select Distinct eNombre,D.EmpresaID,D.TipoEmpresa From DatosJuego D, EmpresasMP E " +
          "WHERE D.EmpresaID = E.EmpresaID AND D.UsuarioID ='" + UsuarioID + "' AND TipoEmpresa=0 UNION ALL " +
          "Select Distinct eNombre,D.EmpresaID,D.TipoEmpresa From DatosJuego D, EmpresasPT E WHERE D.EmpresaID = E.EmpresaID " + 
          "AND D.UsuarioID = '" + UsuarioID + "' AND TipoEmpresa=1";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaCostos(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM CostosJuego WHERE UsuarioID = '" + UsuarioID + "' ORDER BY Semana ";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable buscaProducto(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT EmpresaID,TipoEmpresa, UsuarioID,Semana,(OrdenCompraProv1 + OrdenCompraProv2) AS Proveedor, "+
            "(InvMPProv1+InvMPProv2) AS InventarioMP,NivelInventario,InventarioMedio,LoteProduccion,LoteServicio, DemandaAcumulada " +
            "FROM DatosJuego WHERE UsuarioID = '" + UsuarioID + "' ORDER BY Semana ";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}