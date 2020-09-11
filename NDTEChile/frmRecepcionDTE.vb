Imports System.Xml
Imports MySql.Data.MySqlClient
Imports System.Configuration


Public Class frmRecepcionDTE

    Dim MiCommand As New MySqlCommand
    Dim MiDataAdapter As MySqlDataAdapter
    Dim MiDataset As DataSet

    Private Sub frmRecepcionDTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEmpresaEmisora.Text = NDTEChile.lblEmpresaEmisora.Text
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        MiCommand.Connection = MiConexionMySql
        Dim sql As String = "select * from recepcion_dte where rut_receptor = '" & lblEmpresaEmisora.Text & "'"

        MiCommand.CommandText = sql
        MiDataAdapter = New MySqlDataAdapter(MiCommand)

        MiDataset = New DataSet()
        MiDataAdapter.Fill(MiDataset)
        DGDocumentosRecibidos.DataSource = MiDataset.Tables(0)

    End Sub
End Class