Imports MySql.Data.MySqlClient

Module ModuloMySQL
    'Datos conexion a MySql
    Public MiConexionMySql As New MySqlConnection
    Public MiConexionMySqlAux As New MySqlConnection
    Public MiComandoMySql As New MySqlCommand
    Public MiComandoMySqlAux As New MySqlCommand
    Public MiDrMySql As MySqlDataReader

    Public ConsultConexionMySql As New MySqlConnection
    Public ConsultConexionMySqlAux As New MySqlConnection
    Public ConsultComandoMySql As New MySqlCommand
    Public ConsultComandoMySqlAux As New MySqlCommand
    Public ConsultDrMySql As MySqlDataReader
End Module
