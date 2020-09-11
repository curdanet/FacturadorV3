Imports System.Data.SqlClient
Imports System.Xml
Imports MySql.Data


Public Class frmFolios

    Dim MiDr As MySqlClient.MySqlDataReader
    Dim MiCmd As New MySqlClient.MySqlCommand

    Dim MiDataAdapter As MySqlClient.MySqlDataAdapter
    Dim MiDataReader As MySqlClient.MySqlDataReader
    Dim MiDataset As DataSet
    Dim Mitabla As New DataTable
    Dim MiIndice As Integer = 0
    Dim Sql As String = ""


    Dim RutFolios As String = ""
    Dim TipoDocumento As String = ""
    Dim ValorInicial As String = ""
    Dim VAlorFinal As String = ""


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmFolios_Load(sender As Object, e As EventArgs) Handles Me.Load
        MiCmd.Connection = MiConexionMySqlAux

        cargaFoliosGrilla()
    End Sub

    Private Sub cargaFoliosGrilla()


        Call limpiar()

        Sql = "SELECT valor_actual ,valor_inicial,valor_final,tipo_Doc,ubicacion_caf,rut_Contribuyente, activo FROM caf "



        MiCmd.CommandText = Sql
        MiDataAdapter = New MySqlClient.MySqlDataAdapter(MiCmd)

        MiDataset = New DataSet()
        MiDataAdapter.Fill(MiDataset)
        DGFolios.DataSource = MiDataset.Tables(0)

        DGFolios.Focus()

    End Sub

    Private Sub cmdBuscaCaf_Click(sender As Object, e As EventArgs) Handles cmdBuscaCaf.Click
        OFD.ShowDialog()
        txtUbicacion.Text = OFD.FileName

        If txtUbicacion.Text <> "" Then
            'Verificar si es una archivo de folios
            Dim MiArchivoFolios As New XmlDocument
            

            Try
                MiArchivoFolios.Load(txtUbicacion.Text)
                RutFolios = MiArchivoFolios.SelectSingleNode("//AUTORIZACION/CAF/DA/RE").InnerText
                TipoDocumento = MiArchivoFolios.SelectSingleNode("//AUTORIZACION/CAF/DA/TD").InnerText
                ValorInicial = MiArchivoFolios.SelectSingleNode("//AUTORIZACION/CAF/DA/RNG/D").InnerText
                VAlorFinal = MiArchivoFolios.SelectSingleNode("//AUTORIZACION/CAF/DA/RNG/H").InnerText
                txtRUTFolios.Text = RutFolios

                Select Case Val(TipoDocumento)
                    Case 33
                        cboTipoDocumento.Text = "Factura Electronica"
                    Case 34
                        cboTipoDocumento.Text = "Factura Exenta Electronica"
                    Case 61
                        cboTipoDocumento.Text = "Nota de Credito Electronica"
                    Case 56
                        cboTipoDocumento.Text = "Nota de Debito Electronica"
                    Case 52
                        cboTipoDocumento.Text = "Guia de Despacho Electronica"
                    Case 39
                        cboTipoDocumento.Text = "Boleta Electronica"
                    Case 41
                        cboTipoDocumento.Text = "Boleta Exenta Electronica"
                End Select


                lblValorInicial.Text = ValorInicial
                lblValorFinal.Text = VAlorFinal


            Catch ex As Exception
                MsgBox("Error en archivo de folios", MsgBoxStyle.Information, "Carga de Folios")
                Call Limpiar()
            End Try



        End If
    End Sub

    Private Sub Limpiar()
        cboTipoDocumento.Text = ""
        txtUbicacion.Text = ""
        txtValorActual.Text = ""
        lblValorInicial.Text = ""
        lblValorFinal.Text = ""
        txtRUTFolios.Text = ""
        CheckActivo.Checked = False
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cboTipoDocumento.Text <> "" And txtUbicacion.Text <> "" And lblValorInicial.Text <> "" And lblValorFinal.Text <> "" And IsNumeric(txtValorActual.Text) Then 'And (Val(txtValorActual.Text) <= Val(lblValorFinal.Text) And Val(txtValorActual.Text) >= Val(lblValorInicial.Text)) Then
            MiCmd.CommandText = "insert into caf (valor_Actual,valor_inicial,valor_final,tipo_doc,ubicacion_caf,rut_contribuyente,activo) values (" & txtValorActual.Text & "," & lblValorInicial.Text & "," & lblValorFinal.Text & ",'" & TipoDocumento & "','" & Replace(txtUbicacion.Text, "\", "\\") & "','" & RutFolios & "'," & IIf(CheckActivo.Checked, 1, 0) & ")"
            Try
                MiCmd.ExecuteNonQuery()
                MsgBox("Folios cargados correctamente", MsgBoxStyle.Information, "Carga de folios")

                cargaFoliosGrilla()
            Catch ex As Exception
                MsgBox("Error en carga de folios", MsgBoxStyle.Information, "Carga de folios")
                cargaFoliosGrilla()
            End Try
        Else
            MsgBox("No esta cargado un archivo de folios correcto o no hay valor inicial", MsgBoxStyle.Information, "Carga de Folios")

        End If
    End Sub

    Private Sub DGFolios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFolios.CellContentClick

    End Sub

    Private Sub DGFolios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFolios.CellDoubleClick
        If CStr(DGFolios.SelectedRows(0).Cells(0).Value) <> "" Then
            Dim TipoDocumento As Integer = DGFolios.SelectedRows(0).Cells(3).Value
            Dim ValorInicial As Double = DGFolios.SelectedRows(0).Cells(1).Value
            Dim ValorFinal As Double = DGFolios.SelectedRows(0).Cells(2).Value
            Dim ValorActual As Double = DGFolios.SelectedRows(0).Cells(0).Value
            Dim UbicacionCAF As String = DGFolios.SelectedRows(0).Cells(4).Value

            Select Case Val(TipoDocumento)
                Case 33
                    cboTipoDocumento.Text = "Factura Electronica"
                Case 34
                    cboTipoDocumento.Text = "Factura Exenta Electronica"
                Case 61
                    cboTipoDocumento.Text = "Nota de Credito Electronica"
                Case 56
                    cboTipoDocumento.Text = "Nota de Debito Electronica"
                Case 52
                    cboTipoDocumento.Text = "Guia de Despacho Electronica"
                Case 39
                    cboTipoDocumento.Text = "Boleta Electronica"
                Case 41
                    cboTipoDocumento.Text = "Boleta Exenta Electronica"
            End Select
            txtUbicacion.Text = UbicacionCAF
            txtValorActual.Text = ValorActual
            lblValorInicial.Text = ValorInicial
            lblValorFinal.Text = ValorFinal
            If (DGFolios.SelectedRows(0).Cells(6).Value = 1) Then
                CheckActivo.Checked = True
            End If
            txtRUTFolios.Text = DGFolios.SelectedRows(0).Cells(5).Value
        End If
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If cboTipoDocumento.Text <> "" And txtUbicacion.Text <> "" And lblValorInicial.Text <> "" And lblValorFinal.Text <> "" And IsNumeric(txtValorActual.Text) Then 'And (Val(txtValorActual.Text) <= Val(lblValorFinal.Text) And Val(txtValorActual.Text) >= Val(lblValorInicial.Text)) Then
            Dim OPcion As Integer = MsgBox("Va a eliminar el folio seleccionado , esta seguro??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar Folios")
            If OPcion = vbNo Then
                cargaFoliosGrilla()
                Exit Sub
            End If
            Dim TIpoDte As String = ""
            Select Case cboTipoDocumento.Text
                Case "Factura Electronica"
                    TIpoDte = "33"
                Case "Factura Exenta Electronica"
                    TIpoDte = "34"
                Case "Nota de Credito Electronica"
                    TIpoDte = "61"
                Case "Nota de Debito Electronica"
                    TIpoDte = "56"
                Case "Guia de Despacho Electronica"
                    TIpoDte = "52"
                Case "Boleta Electronica"
                    TIpoDte = "39"
                Case "Boleta Exenta Electronica"
                    TIpoDte = "41"
            End Select


            MiCmd.CommandText = "delete from  caf where valor_inicial = " & lblValorInicial.Text & " and valor_final = " & lblValorFinal.Text & " and tipo_doc = '" & TIpoDte & "' and rut_contribuyente = '" & txtRUTFolios.Text & "'"
            Try
                MiCmd.ExecuteNonQuery()
                MsgBox("Folios cargados correctamente", MsgBoxStyle.Information, "Carga de folios")

                cargaFoliosGrilla()
            Catch ex As Exception
                MsgBox("Error en carga de folios", MsgBoxStyle.Information, "Carga de folios")
                cargaFoliosGrilla()
            End Try
        Else
            MsgBox("No se puede eliminar, no hay datos de foliso cargados", MsgBoxStyle.Information, "Eliminacion de Folios")

        End If
    End Sub
End Class