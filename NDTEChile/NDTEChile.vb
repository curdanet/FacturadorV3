Imports System.Data.OleDb
Imports System.Xml

Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Text
Imports System.Xml.Schema
Imports System.Reflection
Imports System.Globalization

Public Class NDTEChile





    Public dbConnection As OleDbConnection
    '
    Public dbDataTable As Data.DataTable
    Public dbDataSet As Data.DataSet
    Public dbDataAdapter As OleDbDataAdapter
    '
    Public CadenaConexion As String
    Public CadenaSelect As String
    Public ArchivoDatos As String
    Public PrimeraVez As Boolean = True
    Public servidorsii As String = ""






    Private Sub FSWDte_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FSWDte.Changed

    End Sub

    Private Sub FSWDte_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FSWDte.Created
        'MsgBox("se ha creado un archivo nuevo" & e.Name)
        'Dim NombreArchivo As String = e.Name
        'Dim NombreArchivoConPath As String = e.FullPath
        'Dim UbicacionCAF As String = ""
        'Dim TipodocEmpresa() As String

        ''Parsear el archivo para saber el tipo y buscar su CAF activo

        'Dim Contador As Integer
        'For Contador = 1 To 100000
        '    System.Windows.Forms.Application.DoEvents()
        '    System.Windows.Forms.Application.DoEvents()
        'Next

        'Dim ArchivoXMLDTE As New Xml.XmlDocument
        'Try
        '    Dim Leido As Boolean = False
        '    Try
        '        While Leido = False
        '            Try
        '                ArchivoXMLDTE.Load(e.FullPath)
        '                Leido = True
        '            Catch ex As Exception
        '                Leido = False
        '            End Try

        '        End While
        '    Catch ex As Exception

        '    End Try
        '    ' MsgBox("Archivo leido")


        '    Dim DatosXML As String = ArchivoXMLDTE.InnerXml


        '    'Primero consultar si es un DTE o un comando

        '    Dim TipoDte As String = DetectaTipoXML(DatosXML)

        '    'If TipoDte <> "" Then
        '    '    MsgBox(TipoDte)
        '    'End If

        '    If InStr(TipoDte, "COMANDO") > 0 Then
        '        Dim DatosComando() As String = Split(TipoDte, ";")
        '        If DatosComando(1) = "ENVIA SET" Then
        '            GeneraSET()
        '        End If
        '    End If


        '    '


        '    TipodocEmpresa = Split(BuscaTipoDocyRUTEmpresa(DatosXML), ";")
        '    Dim TipoGlosa As String
        '    Select Case TipodocEmpresa(0)
        '        Case "33"
        '            TipoGlosa = "Factura Electrónica"
        '            'UbicacionCAF = txtArchivoFolios33.Text
        '        Case "61"
        '            TipoGlosa = "Nota de Crédito Electrónica"
        '            'UbicacionCAF = txtArchivoFolios61.Text
        '        Case "56"
        '            TipoGlosa = "Nota de Débito Electrónica"
        '            'UbicacionCAF = txtArchivoFolios56.Text
        '    End Select
        '    'MsgBox("COD SII  " & TipodocEmpresa(0) & vbCrLf & "Tipo de Documento " & TipoGlosa & vbCrLf & "R.U.T. Emisor " & TipodocEmpresa(1) & vbCrLf & "R.U.T. Receptor " & TipodocEmpresa(2), MsgBoxStyle.Information, "Demo NDTEChile")



        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, "Error al leer archivo XML")
        '    Exit Sub
        'End Try

        ''MsgBox("UbicacionCAF " & UbicacionCAF)

        ''Consultar si esta conectado a la base de datos

        'Try
        '    MiConexionMySql.Close()
        'Catch ex As Exception

        'End Try
        'Try
        '    MiConexionMySql.Open()

        'Catch ex As Exception
        '    ' MsgBox("Conexion reabierta")
        'End Try


        'MiComandoMySql.CommandText = "select * from caf where rut_contribuyente = '" & TipodocEmpresa(1) & "' and tipo_doc = '" & TipodocEmpresa(0) & "' and Activo = 1 and " & TipodocEmpresa(3) & " between valor_inicial and valor_final"

        'MiDrMySql = MiComandoMySql.ExecuteReader


        'If MiDrMySql.Read Then
        '    UbicacionCAF = MiDrMySql("ubicacion_caf")
        'Else
        '    MsgBox("No se puede obtener el CAF para este tipo de DTE", MsgBoxStyle.Information, "Obtensión de Folios")
        '    MiDrMySql.Close()
        '    Exit Sub
        'End If
        'MiDrMySql.Close()
        ''Sacar el RUT de la empresa para buscar los datos de Fecha Resolucion y numero de resolucion
        'Dim FechaResolucion As String = Format(DTFechaResolucion.Value, "yyyy-MM-dd")
        'Dim NumeroResolucion As String = txtNumResolucionSII.Text
        'Dim Certificado As String = txtCertiticado.Text
        'Dim txtClaveCert As String = txtClaveCertificado.Text



        'Dim myProcess As New Process()
        'Dim NombreBat As String = System.Windows.Forms.Application.StartupPath & "\Firma" & Format(Now, "ddmmyyyyHHmmss") & ".bat"
        'Dim MiArchivoBat As System.IO.Stream
        'Dim MiStreamWriter As System.IO.StreamWriter
        'Dim MiStreamWriter1 As System.IO.StreamWriter
        'Try
        '    MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
        'Catch ex As Exception

        'End Try
        'Dim NombreFirmadoSII As String
        'Try
        '    NombreFirmadoSII = Replace(UCase(NombreArchivo), ".XML", "firmadoSII.xml")
        '    Dim Respuesta As String = txtFirmadoSII.Text & "\" & NombreFirmadoSII
        '    MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '    MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

        '    Debug.Print("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Chr(34) & Respuesta & Chr(34))
        '    MiStreamWriter.WriteLine("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Chr(34) & Respuesta & Chr(34))
        '    MiStreamWriter.Close()


        '    If System.IO.File.Exists(NombreBat) Then


        '        Dim NombreVBS As String
        '        NombreVBS = System.Windows.Forms.Application.StartupPath & "\FirmaSII" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".vbs"
        '        Try
        '            MiArchivoBat = System.IO.File.Create(NombreVBS, IO.FileMode.Open)
        '        Catch ex As Exception

        '        End Try
        '        MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '        MiStreamWriter.WriteLine("set objshell = createobject(""wscript.shell"")")
        '        MiStreamWriter.WriteLine("objshell.run """ & NombreBat & """" & ",vbhide")
        '        MiStreamWriter.Close()
        '        If System.IO.File.Exists(NombreVBS) Then
        '            myProcess.StartInfo.UseShellExecute = True
        '            myProcess.StartInfo.FileName = NombreVBS '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '            myProcess.StartInfo.CreateNoWindow = False
        '            myProcess.Start()

        '            myProcess.WaitForExit()
        '            myProcess.Close()
        '        End If


        '        'myProcess.StartInfo.UseShellExecute = True
        '        'myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '        'myProcess.StartInfo.CreateNoWindow = True
        '        ''myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
        '        'myProcess.Start()



        '        ' myProcess.WaitForExit()
        '    End If

        '    'Firmar cliente
        '    NombreBat = System.Windows.Forms.Application.StartupPath & "\FirmaClienteT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
        '    Try
        '        MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
        '    Catch ex As Exception

        '    End Try

        '    Dim NombreFirmadoCliente As String = Replace(UCase(NombreArchivo), ".XML", "firmadoCLiente.xml")
        '    Respuesta = txtFirmadoCliente.Text & "\" & NombreFirmadoCliente
        '    MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '    MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

        '    Debug.Print("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & """ > " & Chr(34) & Respuesta & Chr(34))
        '    MiStreamWriter.WriteLine("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & """ > " & Chr(34) & Respuesta & Chr(34))
        '    MiStreamWriter.Close()


        '    If System.IO.File.Exists(NombreBat) Then

        '        Dim NombreVBS As String
        '        NombreVBS = System.Windows.Forms.Application.StartupPath & "\FirmaCliente" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".vbs"
        '        Try
        '            MiArchivoBat = System.IO.File.Create(NombreVBS, IO.FileMode.Open)
        '        Catch ex As Exception

        '        End Try
        '        MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '        MiStreamWriter.WriteLine("set objshell = createobject(""wscript.shell"")")
        '        MiStreamWriter.WriteLine("objshell.run """ & NombreBat & """" & ",vbhide")
        '        MiStreamWriter.Close()
        '        If System.IO.File.Exists(NombreVBS) Then
        '            myProcess.StartInfo.UseShellExecute = True
        '            myProcess.StartInfo.FileName = NombreVBS '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '            myProcess.StartInfo.CreateNoWindow = False
        '            myProcess.Start()

        '            myProcess.WaitForExit()
        '            myProcess.Close()
        '        End If



        '        'myProcess.StartInfo.UseShellExecute = True
        '        'myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '        'myProcess.StartInfo.CreateNoWindow = False
        '        ''myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
        '        'myProcess.Start()



        '        'myProcess.WaitForExit()
        '    End If



        '    For Contador = 1 To 100000
        '        System.Windows.Forms.Application.DoEvents()
        '        System.Windows.Forms.Application.DoEvents()
        '    Next

        '    Try
        '        System.IO.File.Move(e.FullPath, "C:\NDTEChile\xml_procesados\" & Replace(e.Name, ".xml", Format(Now, "yyyyMMddHHmmss") & ".xml"))

        '    Catch ex As Exception
        '        MsgBox("Error al mover archivo " & e.FullPath)
        '    End Try




        '    'Dim Mifrom1 As New Form1
        '    'Mifrom1.ShowDialog()
        '    'Mifrom1.Dispose()


        '    'If optCarta.Checked = True Then

        '    '    '    MsgBox("Versión Demo no crea PDFs", MsgBoxStyle.Information, "NDTEChile")
        '    '    NombreBat = System.Windows.Forms.Application.StartupPath & "\GeneraPDFT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
        '    '    Try
        '    '        MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
        '    '    Catch ex As Exception

        '    '    End Try


        '    '    '    Respuesta = txtFirmadoCliente.Text & "\" & Replace(UCase(NombreArchivo), ".XML", "firmadoCLiente.xml")
        '    '    MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '    '    MiStreamWriter.WriteLine("cd ""C:\hefesto""")

        '    '    Debug.Print("gen.exe " & Respuesta)
        '    '    MiStreamWriter.WriteLine("gen.exe " & txtFirmadoCliente.Text & "\" & NombreFirmadoCliente)
        '    '    MiStreamWriter.WriteLine("WshShell.Sendkeys ""{Enter}""")
        '    '    MiStreamWriter.Close()


        '    '    If System.IO.File.Exists(NombreBat) Then

        '    '        Dim NombreVBS As String
        '    '        NombreVBS = System.Windows.Forms.Application.StartupPath & "\CreaPDFs" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".vbs"
        '    '        Try
        '    '            MiArchivoBat = System.IO.File.Create(NombreVBS, IO.FileMode.Open)
        '    '        Catch ex As Exception

        '    '        End Try
        '    '        MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '    '        MiStreamWriter.WriteLine("set objshell = createobject(""wscript.shell"")")
        '    '        MiStreamWriter.WriteLine("objshell.run """ & NombreBat & """" & ",vbhide")
        '    '        MiStreamWriter.Close()
        '    '        If System.IO.File.Exists(NombreVBS) Then
        '    '            myProcess.StartInfo.UseShellExecute = True
        '    '            myProcess.StartInfo.FileName = NombreVBS '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '    '            myProcess.StartInfo.CreateNoWindow = False
        '    '            myProcess.Start()

        '    '            myProcess.WaitForExit()
        '    '            myProcess.Close()
        '    '        End If


        '    '    End If
        '    'End If


        '    'Enviar Al SII
        '    Dim NombreOriginal As String = txtFirmadoSII.Text & "\" & NombreFirmadoSII
        '    NombreBat = System.Windows.Forms.Application.StartupPath & "\EnvioSIIT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
        '    Try
        '        MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
        '    Catch ex As Exception

        '    End Try


        '    Respuesta = txtRespuestasSII.Text & "\RespuestaEnvio-" & Replace(NombreFirmadoSII, ".xml", ".txt")
        '    MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '    MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

        '    Debug.Print("facturista.exe  --enviar " & Chr(34) & NombreOriginal & Chr(34) & " " & Chr(34) & Respuesta & Chr(34) & " " & """Servidor=palena.sii.cl;Puerto=443;SSL=1;ArchivoP12=" & txtCertiticado.Text & ";ContrasenaP12=" & txtClaveCertificado.Text & """")
        '    MiStreamWriter.WriteLine("facturista.exe  --enviar " & Chr(34) & NombreOriginal & Chr(34) & " " & Chr(34) & Respuesta & Chr(34) & " " & """Servidor=palena.sii.cl;Puerto=443;SSL=1;ArchivoP12=" & txtCertiticado.Text & ";ContrasenaP12=" & txtClaveCertificado.Text & """")


        '    MiStreamWriter.Close()


        '    If System.IO.File.Exists(NombreBat) Then


        '        Dim NombreVBS As String
        '        NombreVBS = System.Windows.Forms.Application.StartupPath & "\Envia" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".vbs"
        '        Try
        '            MiArchivoBat = System.IO.File.Create(NombreVBS, IO.FileMode.Open)
        '        Catch ex As Exception

        '        End Try
        '        MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '        MiStreamWriter.WriteLine("set objshell = createobject(""wscript.shell"")")
        '        MiStreamWriter.WriteLine("objshell.run """ & NombreBat & """" & ",vbhide")
        '        MiStreamWriter.Close()
        '        If System.IO.File.Exists(NombreVBS) Then
        '            myProcess.StartInfo.UseShellExecute = True
        '            myProcess.StartInfo.FileName = NombreVBS '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '            myProcess.StartInfo.CreateNoWindow = False
        '            myProcess.Start()

        '            myProcess.WaitForExit()
        '            myProcess.Close()
        '        End If


        '        'myProcess.StartInfo.UseShellExecute = True
        '        'myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '        'myProcess.StartInfo.CreateNoWindow = False
        '        ''myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
        '        'myProcess.Start()



        '        'myProcess.WaitForExit()
        '    End If


        '    ''Firmar cliente
        '    NombreBat = System.Windows.Forms.Application.StartupPath & "\EnvioCorreoT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
        '    Try
        '        MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
        '    Catch ex As Exception

        '    End Try



        '    MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
        '    MiStreamWriter.WriteLine("cd """ & "c:\Python27" & """")

        '    'Buscar correo de cliente
        '    Dim CorreoCliente As String = ""
        '    Try
        '        MiComandoMySql.CommandText = "select * from clientes where rut = '" & TipodocEmpresa(2) & "'"
        '        MiDrMySql = MiComandoMySql.ExecuteReader

        '        If MiDrMySql.Read Then
        '            CorreoCliente = MiDrMySql("email")
        '        Else
        '            CorreoCliente = "ndiaz@ndtechile.cl;clabra@cliven.cl;nelson.diaz.n@gmail.com;mandreoli@cliven.cl"
        '        End If
        '        MiDrMySql.Close()
        '    Catch ex As Exception

        '    End Try

        '    Debug.Print("python c:\ndtechile\enviacorreoadjunto.py " & txtUsuarioCorreo.Text & " " & txtContraseñaCorreo.Text & " " & txtServidorCorreo.Text & " " & CorreoCliente & " " & Replace(txtFirmadoCliente.Text & "\" & NombreFirmadoCliente, "\", "\\") & " " & txtPuertoCorreo.Text)

        '    MiStreamWriter.WriteLine("python c:\ndtechile\enviacorreoadjunto.py " & txtUsuarioCorreo.Text & " " & txtContraseñaCorreo.Text & " " & txtServidorCorreo.Text & " " & CorreoCliente & " " & Replace(txtFirmadoCliente.Text & "\" & NombreFirmadoCliente, "\", "\\") & " " & txtPuertoCorreo.Text)


        '    MiStreamWriter.Close()


        '    If System.IO.File.Exists(NombreBat) Then
        '        myProcess.StartInfo.UseShellExecute = True
        '        myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
        '        myProcess.StartInfo.CreateNoWindow = False
        '        'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
        '        myProcess.Start()



        '        myProcess.WaitForExit()
        '    End If



        'Catch ex1 As Exception
        '    Debug.Print((ex1.Message))
        'End Try


    End Sub

    Public Function DeImagen_a_Bytes(ByVal Imagen As Image) As Byte()
        If Not Imagen Is Nothing Then
            'Crea un archivo temporal de cero bytes y nombre único en el disco y devuelve la ruta
            'de acceso completa a ese archivo.
            Dim ATemporal As String = IO.Path.GetTempFileName()
            'Inicializa una nueva instancia de la clase FileStream con el permiso de lectura/escritura,
            'el modo de creación y la ruta de acceso especificados.
            Dim filestream As New IO.FileStream(ATemporal, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            'Puede modificar el formato de la imagen a la hora de salvarla.
            Imagen.Save(filestream, System.Drawing.Imaging.ImageFormat.Bmp)
            filestream.Position = 0
            Dim imgLength As Integer = CInt(filestream.Length)
            Dim bytes(0 To imgLength - 1) As Byte
            filestream.Read(bytes, 0, imgLength)
            filestream.Close()
            Return bytes
        Else
            Return Nothing
        End If
    End Function

    Private Function BuscaTipoDocyRUTEmpresa(XML As String) As String
        Dim DatosDTE As String
        'Dim InicioTipoDoc As Integer = InStr(XML, "<TipoDTE>") + 9
        'Dim TerminoDoc As Integer = InStr(XML, "</TipoDTE>") - 1
        'Dim InicioRUTEmpresa As Integer = InStr(XML, "<RUTEmisor>") + 11
        'Dim FinRutEMpresa As Integer = InStr(XML, "</RUTEmisor>")
        'Dim InicioRUTCliente As Integer = InStr(XML, "<RUTRecep>") + 10
        'Dim FinRutCliente As Integer = InStr(XML, "</RUTRecep>")

        'DatosDTE = Mid(XML, InicioTipoDoc, TerminoDoc - InicioTipoDoc + 1) & ";" & Mid(XML, InicioRUTEmpresa, FinRutEMpresa - InicioRUTEmpresa) & ";" & Mid(XML, InicioRUTCliente, FinRutCliente - InicioRUTCliente)

        Dim MiDocXML As XmlDocument

        MiDocXML = New XmlDocument()

        Try
            MiDocXML.LoadXml(XML)
            Dim MiNodoRutEmisor As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor").InnerText
            Dim MiTipoDTE As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
            Dim MiFolioDTE As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/Folio").InnerText
            Dim MiRutReceptor As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RUTRecep").InnerText
            DatosDTE = MiTipoDTE & ";" & MiNodoRutEmisor & ";" & MiRutReceptor & ";" & MiFolioDTE
        Catch ex As Exception
            DatosDTE = "Error"
        End Try

        Return DatosDTE
    End Function

    Private Function DetectaTipoXML(XML As String) As String
        Dim DatosDTE As String

        Dim MiDocXML As XmlDocument

        MiDocXML = New XmlDocument()

        Try
            MiDocXML.LoadXml(XML)
            Dim MiNodoRutEmisor As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor").InnerText
            Dim MiTipoDTE As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
            Dim MiFolioDTE As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/Folio").InnerText
            Dim MiRutReceptor As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RUTRecep").InnerText
            DatosDTE = "DTE"

        Catch ex As Exception
            DatosDTE = "Error " & Err.Number & " " & Err.Description
            Try
                MiDocXML.LoadXml(XML)
                Dim MiComando As String = MiDocXML.SelectSingleNode("//COMANDO_NDTE/Comando").InnerText

                DatosDTE = "COMANDO;" & MiComando

            Catch ex1 As Exception
                DatosDTE = "Error " & Err.Number & " " & Err.Description
            End Try
        End Try







        Return DatosDTE
    End Function

    Private Function GeneraPDF417(XML As String) As String
        Dim DatosDTE As String

        Dim MiDocXML As XmlDocument

        MiDocXML = New XmlDocument()

        Try
            MiDocXML.LoadXml(XML)

            Dim MiNodoRutEmisor As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor").InnerText
            Dim MiTipoDTE As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
            Dim MiFolioDTE As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/Folio").InnerText
            Dim MiRutReceptor As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RUTRecep").InnerText
            DatosDTE = "DTE"

        Catch ex As Exception
            DatosDTE = "Error"
            Try
                MiDocXML.LoadXml(XML)
                Dim MiComando As String = MiDocXML.SelectSingleNode("//COMANDO_NDTE/Comando").InnerText

                DatosDTE = "COMANDO;" & MiComando

            Catch ex1 As Exception
                DatosDTE = "Error"
            End Try
        End Try







        Return DatosDTE
    End Function

    Private Sub NDTEChile_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick

    End Sub

    Private Sub NDTEChile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Opcion As Integer = MsgBox("Realmente desea salir de Integracion NDTEChile", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir Integracion NDTEChile")
        If Opcion = vbYes Then
            NotifyIcon1.Visible = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub NDTEChile_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub NDTEChile_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        NotifyIcon1.ShowBalloonTip(5, "NDTEChile", "Aplicación de Integración NDTEChile", ToolTipIcon.None)

        'MsgBox("Aplicacion NDTEChile")

        'FSWDte.EnableRaisingEvents = False
        'FSWPdf.EnableRaisingEvents = False

        Dim Servidor As String = ConfigurationSettings.AppSettings("ipservidor").ToString
        Dim BaseDatos As String = ConfigurationSettings.AppSettings("basedatos").ToString ' MiDrMySql("directorio_firmado_sii")
        Dim usuario As String = ConfigurationSettings.AppSettings("usuario").ToString 'MiDrMySql("directorio_firmado_cliente")
        Dim contrasena As String = ConfigurationSettings.AppSettings("contrasena").ToString 'MiDrMySql("directorio_pdf")
        Dim EmpresaEmisora As String = "" 'ConfigurationSettings.AppSettings("rutemisor").ToString 'MiDrMySql("directorio_pdf")
        Dim TiempoLecturaCorreos As Integer = 500000 ' CInt(ConfigurationSettings.AppSettings("tiempolecturacorreos").ToString) 'MiDrMySql("directorio_pdf")
        servidorsii = ConfigurationSettings.AppSettings("servidorsii").ToString 'MiDrMySql("directorio_pdf")
        ' Dim port As String = ConfigurationSettings.AppSettings("port").ToString 'puerto de prueba
        If servidorsii = "maullin" Then lblServidorSII.Text = "Desarrollo SII"
        If servidorsii = "palena" Then lblServidorSII.Text = "Produccion SII"
        'Dim port As String = "3008" 'solo para pruebas
        Dim port As String = ConfigurationSettings.AppSettings("puerto").ToString 'MiDrMySql("directorio_pdf")
        TLecturaCorreos.Interval = TiempoLecturaCorreos


        lblEmpresaEmisora.Text = EmpresaEmisora

        Dim CadenaConexion As String = "Server=" & Servidor & ";Database=" & BaseDatos & "; Uid=" & usuario & ";Pwd=" & contrasena & ";Port=" & port & "; "

        Try
            ' Conexion para Consultas de revision de Condiciones - CU - 2020
            ConsultConexionMySql.ConnectionString = CadenaConexion
            ConsultConexionMySql.Open()

            MiConexionMySql.ConnectionString = CadenaConexion
            MiConexionMySql.Open()


            NotifyIcon1.ShowBalloonTip(5, "NDTEChile", "Conexion OK con MySql", ToolTipIcon.None) '"Conexion OK con MySql", MsgBoxStyle.Information, "Conexion a base de datos")
            MiConexionMySqlAux.ConnectionString = CadenaConexion
            MiConexionMySqlAux.Open()
        Catch ex As Exception


            MessageBox.Show("Error al crear la conexión:" & vbCrLf & ex.Message)
            Exit Sub
        End Try
        'dbConnection.Open()

        MiComandoMySql.Connection = MiConexionMySql

        MiComandoMySql.CommandText = "select * from parametros_facturista"

        MiDrMySql = MiComandoMySql.ExecuteReader
        While MiDrMySql.Read
            txtXMLDte.Text = MiDrMySql("directorio_xml_dte")
            txtFirmadoSII.Text = MiDrMySql("directorio_firmado_sii")
            txtFirmadoCliente.Text = MiDrMySql("directorio_firmado_cliente")
            txtPDFVentas.Text = MiDrMySql("directorio_pdf")
            txtXMLCompras.Text = MiDrMySql("directorio_xml_proveedores")
            txtPDFCompras.Text = MiDrMySql("directorio_pdf_proveedores")
            'txtNumResolucionSII.Text = MiDrMySql("numero_resolucion_sii")
            'DTFechaResolucion.Value = MiDrMySql("fecha_resolucion_sii")
            'txtRutEmisor.Text = MiDrMySql("rut_emisor_dte")
            'txtCertiticado.Text = MiDrMySql("ubicacion_certificado")
            'txtClaveCertificado.Text = MiDrMySql("clave_certificado")
            txtRespuestasSII.Text = MiDrMySql("directorio_respuesta_sii")
            txtDirectorioLibFacturista.Text = MiDrMySql("directorio_lib_facturista")
            txtSetDte.Text = MiDrMySql("directorio_setdte")
            txtLibros.Text = MiDrMySql("directorio_lcv")
            'txtUsuarioCorreo.Text = MiDrMySql("emaildte")
            'txtContraseñaCorreo.Text = MiDrMySql("claveusu")
            'txtServidorCorreo.Text = MiDrMySql("servidor")
            'txtPuertoCorreo.Text = MiDrMySql("puerto")
        End While
        MiDrMySql.Close()



        ''Leer datos de clinica
        'MiComandoMySql.CommandText = "select * from empresas"

        'MiDrMySql = MiComandoMySql.ExecuteReader
        'While MiDrMySql.Read
        '    txtUsuarioCorreo.Text = MiDrMySql("emaildte")
        '    txtContraseñaCorreo.Text = MiDrMySql("claveusu")
        '    txtServidorCorreo.Text = MiDrMySql("servidor")
        '    txtPuertoCorreo.Text = MiDrMySql("puerto")
        'End While
        'MiDrMySql.Close()




        FSWDte.Path = txtXMLDte.Text
        FSWPdf.Path = txtFirmadoCliente.Text
        FSWFirmadoSII.Path = txtFirmadoSII.Text
        FSWRespuestasSII.Path = txtRespuestasSII.Text
        FSWLibros.Path = txtLibros.Text
        FSWSET.Path = txtSetDte.Text
        FSWDte.EnableRaisingEvents = True
        FSWPdf.EnableRaisingEvents = True
        FSWFirmadoSII.EnableRaisingEvents = True
        FSWRespuestasSII.EnableRaisingEvents = True
        FSWLibros.EnableRaisingEvents = True
        FSWSET.EnableRaisingEvents = True
        'TLecturaCorreos.Interval = CDbl(TiempoLecturaCorreos)
        TLecturaCorreos.Enabled = False

        Call CargaEmpresas()
    End Sub

    Private Sub CargaEmpresas()
        Dim MiCommand As New MySqlCommand
        Dim MiDataAdapter As MySqlDataAdapter
        Dim MiDataset As DataSet

        MiCommand.Connection = MiConexionMySql
        Dim sql As String = "select * from parametros_facturista"

        MiCommand.CommandText = sql
        MiDataAdapter = New MySqlDataAdapter(MiCommand)

        MiDataset = New DataSet()
        MiDataAdapter.Fill(MiDataset)
        DgEmpresas.DataSource = MiDataset.Tables(0)

        lblCantidadEmpresas.Text = "Cantidad Empresas (" & DgEmpresas.RowCount & ")"
    End Sub

    Private Sub FSWPdf_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FSWPdf.Changed

    End Sub

    Private Sub FSWPdf_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FSWPdf.Created

        If InStr(UCase(e.Name), "PDF") > 0 Then
            'MsgBox("PDF no generado en modo DEMO (" & e.FullPath & ")", MsgBoxStyle.Information, "NDTEChile")
            'Exit Sub
            'Dim Proc As New System.Diagnostics.Process
            'Proc.StartInfo.FileName = txtFirmadoCliente.Text & "\" & e.Name
            'Proc.Start()
            Dim MiPDF As New frmPDF
            MiPDF.WBPdf.Navigate(txtFirmadoCliente.Text & "\" & e.Name)
            MiPDF.Show()

        ElseIf InStr(UCase(e.Name), "XML") > 0 Then

            'Dim MiDocXML As XmlDocument
            'MiDocXML = New XmlDocument()

            'Dim ArchivoXMLDTECB As New Xml.XmlDocument
            'Dim ContenidoXML As String
            'Dim Leido As Boolean = False
            'Dim TipoArchivoXML As String = ""
            'Try
            '    While Leido = False

            '        Try
            '            MiDocXML.Load(e.FullPath)
            '            ContenidoXML = ArchivoXMLDTECB.InnerXml

            '            MsgBox(ContenidoXML)
            '            TipoArchivoXML = MiDocXML.DocumentElement.Name
            '            Leido = True
            '        Catch ex As Exception

            '        End Try



            '    End While
            'Catch ex As Exception
            '    MsgBox("Error en lectura de XML")

            'End Try
            'ArchivoXMLDTECB = Nothing

            'Si es un EnvioDTE

            'Dim xmlmanager As System.Xml.XmlNamespaceManager = New XmlNamespaceManager(MiDocXML.NameTable)
            'xmlmanager.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance")
            'xmlmanager.AddNamespace("sii", "http://www.sii.cl/SiiDte")

            'Dim Prueba As String = ""
            'Dim TipoDTE As String
            'Dim Folio As String = ""
            'Dim FchEmis As String = ""
            'Dim RUTEmisor As String = ""
            'Dim RznSoc As String = ""
            'Dim RUTRecep As String = ""
            'Dim MntNeto As String = ""
            'Dim TasaIVA As String = ""
            'Dim IVA As String = ""
            'Dim MntTotal As String = ""

            'Try
            '    ContenidoXML = Replace(ContenidoXML, "xmlns=""http://www.sii.cl/SiiDte"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.sii.cl/SiiDte EnvioDTE_v10.xsd"" version=""1.0""", "")
            '    ContenidoXML = Replace(ContenidoXML, "xmlns=""http://www.sii.cl/SiiDte"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" version=""1.0"" xsi:schemaLocation=""http://www.sii.cl/SiiDte EnvioDTE_v10.xsd""", "")
            '    MiDocXML.LoadXml(ContenidoXML)
            '    'Prueba = MiDocXML.SelectSingleNode("//EnvioDTE/SetDTE/DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText

            '    'MiComandoMySql.Connection = MiConexionMySql
            '    'MiComandoMySql.CommandText = "update estadosdte set ticketsii = '" & TrackID & "',statusii='" & sTATUS & "',fechupload='" & TimeStamp & "' where rutemisor = '" & RutEmisor & "' and tipodte = '" & "33" & "' and foliodte = '" & "6" & "'"
            '    'MiComandoMySql.ExecuteNonQuery()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            'MsgBox(Prueba)

            'If TipoArchivoXML = "EnvioDTE" Then
            '    Dim TED As String
            '    Try
            '        TED = MiDocXML.SelectSingleNode("sii:EnvioDTE/sii:SetDTE/sii:DTE/sii:Documento/sii:TED", xmlmanager).InnerXml
            '        TED = ("<TED>" & TED & "</TED>")
            '        TipoDTE = MiDocXML.SelectSingleNode("sii:EnvioDTE/sii:SetDTE/sii:DTE/sii:Documento/sii:Encabezado/sii:IdDoc/sii:TipoDTE", xmlmanager).InnerText
            '        Folio = MiDocXML.SelectSingleNode("sii:EnvioDTE/sii:SetDTE/sii:DTE/sii:Documento/sii:Encabezado/sii:IdDoc/sii:Folio", xmlmanager).InnerText
            '        RUTEmisor = MiDocXML.SelectSingleNode("sii:EnvioDTE/sii:SetDTE/sii:DTE/sii:Documento/sii:Encabezado/sii:Emisor/sii:RUTEmisor", xmlmanager).InnerText
            '    Catch ex As Exception
            '        MsgBox(Err.Number & " " & Err.Description, MsgBoxStyle.Exclamation, "Error XPath")
            '    End Try

            '    Dim MiNodo As XmlNode
            '    Dim ContadorNodos As Integer = 0

            '    Dim DTEPaso As XmlDocument
            '    DTEPaso = New XmlDocument
            '    For ContadorNodos = 0 To MiListaDTE.Count - 1
            '        DTEPaso.LoadXml(MiListaDTE.Item(ContadorNodos).OuterXml)
            '        TipoDTE = DTEPaso.SelectSingleNode("//DTE/Documento/TED", ).InnerXml
            '        Folio = DTEPaso.SelectSingleNode("//DTE/Documento/TED").InnerXml
            '        RUTEmisor = DTEPaso.SelectSingleNode("//DTE/Documento/TED").InnerXml
            '        TipoArchivoXML = DTEPaso.SelectSingleNode("//DTE/Documento/TED").InnerXml

            '        'MsgBox("<TED version=""1.0"">" & TipoDTE & "</TED>")

            '    Next

            '    Dim pdf417 As New BarcodePDF417
            '    pdf417.SetText(TED)
            '    Dim Imagen As System.Drawing.Bitmap = New Bitmap(pdf417.CreateDrawingImage(Color.Black, Color.White))

            '    MiComandoMySql.CommandText = "insert into imagenes (imagen,tipoDTE,folioDTE,rut_Emisor,TED) values (?imagen,'" & TipoDTE & "'," & Folio & ",'" & RUTEmisor & "','" & TED & "')"

            '    MiComandoMySql.Parameters.Add("?imagen", System.Data.SqlDbType.Image)



            '    PictureBox1.Image = Imagen

            '    Dim Imag As Byte()
            '    Imag = Imagen_Bytes(Me.PictureBox1.Image)

            '    MiComandoMySql.Parameters.AddWithValue("?imagen", Imag)


            '    Imagen.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            '    'Imagen.Save(System.Windows.Forms.Application.StartupPath & "\Prueba" & Format(Now, "yyyyMMdd") & ".jpg")

            '    MiComandoMySql.Parameters("?imagen").Value = MS.GetBuffer()
            '    MiComandoMySql.ExecuteNonQuery()
            '    MiComandoMySql.Parameters.Clear()
            '    Debug.Print("Imagen Guardada Correctamente")
            '    ArchivoXMLDTECB = Nothing

            'End If








        End If
    End Sub

    Public Shared Function MemStream2String(ByVal memStream As MemoryStream) As String
        'devuelve un string a partir de un MemoryStream

        Dim pos = memStream.Position
        memStream.Position = 0
        'Dim reader As New StreamReader(memStream, Encoding.UTF8 )
        Dim reader As New StreamReader(memStream, True)

        Dim str = reader.ReadToEnd()
        memStream.Position = pos
        Return str

    End Function

    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        NotifyIcon1.Visible = False
        Me.Close()

    End Sub

    Private Sub menuFacturista_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menuFacturista.Opening

    End Sub

    Private Sub mnuMinimizar_Click(sender As Object, e As EventArgs) Handles mnuMinimizar.Click
        If mnuMinimizar.Text = "&Minimizar a la bandeja" Then
            mnuMinimizar.Text = "&Abrir"
            Me.Hide()
            Exit Sub
        Else
            mnuMinimizar.Text = "&Minimizar a la bandeja"
            Me.Show()
            Exit Sub
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        mnuMinimizar_Click(sender, e)
    End Sub

    Private Sub cmdIniciarMonitor_Click(sender As Object, e As EventArgs) Handles cmdIniciarMonitor.Click
        If cmdIniciarMonitor.Text = "Iniciar" Then
            If txtXMLDte.Text <> "" And
                txtFirmadoSII.Text <> "" And
                txtFirmadoCliente.Text <> "" And
                txtPDFVentas.Text <> "" And
                txtXMLCompras.Text <> "" And
                txtPDFCompras.Text <> "" And
                txtRutEmisor.Text <> "" And
                txtNumResolucionSII.Text <> "" And
                txtCertiticado.Text <> "" And
                txtClaveCertificado.Text <> "" And
                txtRespuestasSII.Text <> "" And
                txtDirectorioLibFacturista.Text <> "" Then


                FSWDte.Path = txtXMLDte.Text
                FSWPdf.Path = txtFirmadoCliente.Text
                FSWFirmadoSII.Path = txtFirmadoSII.Text
                FSWRespuestasSII.Path = txtRespuestasSII.Text
                FSWDte.EnableRaisingEvents = True
                FSWPdf.EnableRaisingEvents = True
                FSWFirmadoSII.EnableRaisingEvents = True
                FSWRespuestasSII.EnableRaisingEvents = True




                cmdIniciarMonitor.Text = "Detener"
            Else
                MsgBox("Debe ingresar todos los paramatros solicitador para el Facturador NDTEChile", MsgBoxStyle.Information, "NDTEChile")
                Exit Sub
            End If

        ElseIf cmdIniciarMonitor.Text = "Detener" Then
            FSWDte.EnableRaisingEvents = True
            FSWPdf.EnableRaisingEvents = True
            FSWFirmadoSII.EnableRaisingEvents = True
            FSWRespuestasSII.EnableRaisingEvents = True
            cmdIniciarMonitor.Text = "Iniciar"
        End If
    End Sub

    Private Sub FSWRespuestasSII_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FSWRespuestasSII.Created


        'Dim ArrayText As New ArrayList()
        'Dim sLine As String


        'Try
        '    Dim MiArchivo As New System.IO.StreamReader(e.FullPath)

        '    Dim Contenido As String
        '    Try
        '        Dim Leido As Boolean = False
        '        While Leido = False
        '            Try
        '                Contenido = MiArchivo.ReadToEnd
        '                Leido = True
        '            Catch ex As Exception
        '                Leido = False
        '            End Try

        '        End While
        '    Catch ex As Exception

        '    End Try

        '    'MsgBox(Contenido)


        '    Try



        '        Dim MisDatos() As String = Split(Contenido, "<?xml version=""1.0""?>")






        '        Dim ContenidoXML As String
        '        Dim Usado As Boolean = True
        '        Dim TipoArchivoXML As String = ""
        '        Dim MiDocXML As XmlDocument

        '        MiDocXML = New XmlDocument()
        '        MisDatos(0) = Replace(MisDatos(0), "xmlns=""http://www.sii.cl/SiiDte""", "")
        '        MisDatos(0) = Replace(MisDatos(0), "xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""", "")
        '        MisDatos(0) = Replace(MisDatos(0), "xsi:schemaLocation=""http://www.sii.cl/SiiDte RespuestaEnvioDTE_v10.xsd""", "")
        '        Dim ArchivoXMLDTECB As New XmlDocument

        '        'Tipo de XML
        '        Try

        '            ArchivoXMLDTECB.LoadXml(MisDatos(0))
        '            ContenidoXML = ArchivoXMLDTECB.InnerXml
        '            TipoArchivoXML = ArchivoXMLDTECB.DocumentElement.Name

        '        Catch ex As Exception
        '            Try
        '                'MsgBox("Error en carga de Datos(0)")
        '                ArchivoXMLDTECB.LoadXml(MisDatos(1))
        '                ContenidoXML = ArchivoXMLDTECB.InnerXml
        '                TipoArchivoXML = ArchivoXMLDTECB.DocumentElement.Name
        '            Catch ex1 As Exception
        '                'MsgBox("Error en carga de Datos(0)")
        '            End Try

        '        End Try



        '        If Trim(TipoArchivoXML) = "RESULTADO_ENVIO" Then
        '            Try
        '                Dim TRACKID As String = ArchivoXMLDTECB.SelectSingleNode("//RESULTADO_ENVIO/IDENTIFICACION/TRACKID").InnerText
        '                Dim Estado As String = ArchivoXMLDTECB.SelectSingleNode("//RESULTADO_ENVIO/IDENTIFICACION/ESTADO").InnerText
        '                Dim EstadoGlosa As String '= ArchivoXMLDTECB.SelectSingleNode("//RESULTADO_ENVIO/REVISIONENVIO/REVISIONDTE/DETALLE").InnerText
        '                Dim TmstFirmaResp As String = ArchivoXMLDTECB.SelectSingleNode("//RESULTADO_ENVIO/IDENTIFICACION/TMSTRECEPCION").InnerText

        '                If InStr(Estado, "RCT") > 0 Then
        '                    Try
        '                        EstadoGlosa = ArchivoXMLDTECB.SelectSingleNode("//RESULTADO_ENVIO/ERRORENVIO/DETERRENVIO").InnerText

        '                    Catch ex As Exception

        '                    End Try
        '                End If

        '                If InStr(Estado, "EPR") > 0 Then
        '                    Try
        '                        Dim Aceptado As String = ArchivoXMLDTECB.SelectSingleNode("//RESULTADO_ENVIO/ESTADISTICA/SUBTOTAL/ACEPTA").InnerText
        '                        If Aceptado = "1" Then
        '                            EstadoGlosa = "DOCUMENTO ACEPTADO OK POR SII"
        '                        ElseIf Aceptado = "3" Then
        '                            EstadoGlosa = "DOCUMENTO ACEPTADO OK POR SII"
        '                        End If


        '                    Catch ex As Exception

        '                    End Try
        '                End If
        '                Try
        '                    MiConexionMySql.Close()
        '                Catch ex As Exception

        '                End Try
        '                Try
        '                    MiConexionMySql.Open()

        '                Catch ex As Exception
        '                    ' MsgBox("Conexion reabierta")
        '                End Try
        '                Try
        '                    MiComandoMySql.Connection = MiConexionMySql
        '                    MiComandoMySql.CommandText = "update estadosdte set estrecepsii = '" & Estado & "',glosaestadosii='" & EstadoGlosa & "',fechrecepsii='" & TmstFirmaResp & "' where  ticketsii = '" & TRACKID & "'"
        '                    MiComandoMySql.ExecuteNonQuery()
        '                Catch ex As Exception

        '                End Try
        '            Catch ex As Exception
        '                'MsgBox(ex.Message)
        '            End Try



        '            'ElseIf Trim(TipoArchivoXML) = "RespuestaDTE" Then
        '            '    Dim TipoDTE As String = ArchivoXMLDTECB.SelectSingleNode("//RespuestaDTE/Resultado/ResultadoDTE/TipoDTE").InnerText
        '            '    Dim Folio As String = ArchivoXMLDTECB.SelectSingleNode("//RespuestaDTE/Resultado/ResultadoDTE/Folio").InnerText
        '            '    Dim Estado As String = ArchivoXMLDTECB.SelectSingleNode("//RespuestaDTE/Resultado/ResultadoDTE/EstadoDTE").InnerText
        '            '    Dim EstadoGlosa As String = ArchivoXMLDTECB.SelectSingleNode("//RespuestaDTE/Resultado/ResultadoDTE/EstadoDTEGlosa").InnerText
        '            '    Dim TmstFirmaResp As String = ArchivoXMLDTECB.SelectSingleNode("//RespuestaDTE/Resultado/Caratula/TmstFirmaResp").InnerText




        '        ElseIf Trim(TipoArchivoXML) = "RECEPCIONDTE" Then
        '            Try
        '                MiDocXML.LoadXml(MisDatos(1))
        '                Dim FileEnviado As String = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/FILE").InnerText
        '                Dim RutEmisor As String = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/RUTCOMPANY").InnerText
        '                Dim TimeStamp As String = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/TIMESTAMP").InnerText
        '                Dim sTATUS As String = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/STATUS").InnerText
        '                Dim TrackID As String
        '                Try
        '                    TrackID = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/TRACKID").InnerText
        '                Catch ex As Exception

        '                End Try
        '                Dim ErrorEnvio As String
        '                If CInt(sTATUS) <> 0 Then
        '                    ErrorEnvio = MiDocXML.SelectSingleNode("//RECEPCIONDTE/DETAIL/ERROR").InnerText
        '                End If

        '                Dim DatosNombre() As String = Split(FileEnviado, "-")
        '                Dim TipoDoc As Integer = CInt(Mid(DatosNombre(0), 5, 3))
        '                Dim FolioDoc As Integer = CInt(Mid(DatosNombre(0), 9, 6))


        '                Try
        '                    MiConexionMySql.Close()
        '                Catch ex As Exception

        '                End Try
        '                Try
        '                    MiConexionMySql.Open()

        '                Catch ex As Exception
        '                    ' MsgBox("Conexion reabierta")
        '                End Try



        '                MiComandoMySql.Connection = MiConexionMySql
        '                MiComandoMySql.CommandText = "update estado_dte set track_id = '" & TrackID & "',estado_upload ='" & sTATUS & "',fecha_upload='" & TimeStamp & "' where rut_emisor = '" & RutEmisor & "' and tipo_dte = '" & TipoDoc & "' and folio_dte = " & FolioDoc
        '                MiComandoMySql.ExecuteNonQuery()
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '            End Try

        '        ElseIf Trim(TipoArchivoXML) = "RESULTADO_ENVIO" Then
        '        ElseIf Trim(TipoArchivoXML) = "EnvioDTE" Then
        '            Try
        '                MsgBox(Contenido)
        '            Catch ex As Exception

        '            End Try
        '        End If





        '        MiArchivo.Close()


        '    Catch ex As Exception
        '        ' MsgBox("Error al abrir archivo en directorio respuesta SII", MsgBoxStyle.Information, "NDTChile")
        '        Exit Sub
        '    End Try




        '    'Do
        '    '    sLine = MiArchivo.ReadLine
        '    '    If Not sLine Is Nothing Then
        '    '        ArrayText.Add(sLine)

        '    '    End If
        '    'Loop
        '    MiArchivo.Close()


        'Catch ex As Exception
        '    ' MsgBox("Error al abrir archivo en directorio respuesta SII", MsgBoxStyle.Information, "NDTChile")
        '    Exit Sub
        'End Try

    End Sub

    Private Sub cmdCargaCertificado_Click(sender As Object, e As EventArgs) Handles cmdCargaCertificado.Click
        DialogoArchivo.Title = "Carga de Certificado pfx ó p12"
        DialogoArchivo.Filter = "(Certificados)*.pfx;*.p12|*.pfx;*.p12"
        DialogoArchivo.FileName = ""
        Dim Ubicacion As String = DialogoArchivo.ShowDialog
        If Ubicacion <> "" Then txtCertiticado.Text = DialogoArchivo.FileName


    End Sub

    Private Sub cmdDirectorioFacturista_Click(sender As Object, e As EventArgs)
        DialogoDirectorio.ShowDialog()
        txtDirectorioLibFacturista.Text = DialogoDirectorio.SelectedPath

    End Sub

    Private Sub cmdDirectorioXMLDTE_Click(sender As Object, e As EventArgs) Handles cmdDirectorioXMLDTE.Click
        DialogoDirectorio.ShowDialog()
        txtXMLDte.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub cmdDirectorioXMLSII_Click(sender As Object, e As EventArgs) Handles cmdDirectorioXMLSII.Click
        DialogoDirectorio.ShowDialog()
        txtFirmadoSII.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub cmdDirectorioXMLCLIENTE_Click(sender As Object, e As EventArgs) Handles cmdDirectorioXMLCLIENTE.Click
        DialogoDirectorio.ShowDialog()
        txtFirmadoCliente.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub cmdDirectorioPDFClientes_Click(sender As Object, e As EventArgs) Handles cmdDirectorioPDFClientes.Click
        DialogoDirectorio.ShowDialog()
        txtPDFVentas.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub cmdDirectorioXMLProveedor_Click(sender As Object, e As EventArgs) Handles cmdDirectorioXMLProveedor.Click
        DialogoDirectorio.ShowDialog()
        txtXMLCompras.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub cmdDirectorioPDFProveedor_Click(sender As Object, e As EventArgs) Handles cmdDirectorioPDFProveedor.Click
        DialogoDirectorio.ShowDialog()
        txtPDFCompras.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub cmdDirectorioRespuestasSII_Click(sender As Object, e As EventArgs) Handles cmdDirectorioRespuestasSII.Click
        DialogoDirectorio.ShowDialog()
        txtRespuestasSII.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub cmdOcultar_Click(sender As Object, e As EventArgs) Handles cmdOcultar.Click
        mnuMinimizar_Click(sender, e)
    End Sub



    Private Sub NDTEChile_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If PrimeraVez Then
            PrimeraVez = False
            mnuMinimizar_Click(sender, e)
        End If
    End Sub

    Private Sub FSWRespuestasSII_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FSWRespuestasSII.Changed

    End Sub



    Private Sub FSWLibros_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FSWLibros.Changed



    End Sub

    Private Sub FSWLibros_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FSWLibros.Created
        Dim NombreArchivo As String = e.Name
        Dim NombreArchivoConPath As String = e.FullPath
        Dim UbicacionCAF As String = ""
        'Dim TipodocEmpresa() As String

        'Parsear el archivo para saber el tipo y buscar su CAF activo

        Dim Contador As Integer
        For Contador = 1 To 100000
            System.Windows.Forms.Application.DoEvents()
            System.Windows.Forms.Application.DoEvents()
        Next

        Dim ArchivoXMLDTE As New Xml.XmlDocument
        Try
            Dim Leido As Boolean = False
            Try
                While Leido = False
                    ArchivoXMLDTE.Load(e.FullPath)
                    Leido = True
                End While
            Catch ex As Exception

            End Try
            ' MsgBox("Archivo leido")





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error al leer archivo XML")
            Exit Sub
        End Try

        'MsgBox("UbicacionCAF " & UbicacionCAF)

        'Consultar si esta conectado a la base de datos

        Try
            MiConexionMySql.Close()
        Catch ex As Exception

        End Try
        Try
            MiConexionMySql.Open()

        Catch ex As Exception
            MsgBox("Conexion reabierta")
        End Try

        'Sacar el RUT de la empresa para buscar los datos de Fecha Resolucion y numero de resolucion
        Dim FechaResolucion As String = Format(DTFechaResolucion.Value, "yyyy-MM-dd")
        Dim NumeroResolucion As String = txtNumResolucionSII.Text
        Dim Certificado As String = txtCertiticado.Text
        Dim txtClaveCert As String = txtClaveCertificado.Text



        Dim myProcess As New Process()
        Dim NombreBat As String = System.Windows.Forms.Application.StartupPath & "\Firma" & Format(Now, "ddmmyyyyHHmmss") & ".bat"
        Dim MiArchivoBat As System.IO.Stream
        Dim MiStreamWriter As System.IO.StreamWriter
        'Dim MiStreamWriter1 As System.IO.StreamWriter
        MiArchivoBat = New System.IO.MemoryStream()
        Try
            MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
        Catch ex As Exception

        End Try
        Dim NombreFirmadoSII As String
        Try
            NombreFirmadoSII = Replace(UCase(NombreArchivo), ".XML", "firmadoSII.xml")
            Dim Respuesta As String = txtFirmadoSII.Text & "\" & NombreFirmadoSII
            MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
            MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

            Debug.Print("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " > " & Chr(34) & Respuesta & Chr(34))
            MiStreamWriter.WriteLine("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " > " & Chr(34) & Respuesta & Chr(34))
            MiStreamWriter.Close()


            If System.IO.File.Exists(NombreBat) Then
                myProcess.StartInfo.UseShellExecute = True
                myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
                myProcess.StartInfo.CreateNoWindow = True
                'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
                myProcess.Start()



                myProcess.WaitForExit()
            End If



            'Enviar correo cliente
            Dim NombreOriginal As String = txtFirmadoSII.Text & "\" & NombreFirmadoSII
            NombreBat = System.Windows.Forms.Application.StartupPath & "\EnvioSIILCV" & Format(Now, "ddMMyyyyHHmmss") & ".bat"
            Try
                MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
            Catch ex As Exception

            End Try


            Respuesta = txtRespuestasSII.Text & "\RespuestaEnvio-" & NombreFirmadoSII
            MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
            MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

            Debug.Print("facturista.exe  --enviar " & Chr(34) & NombreOriginal & Chr(34) & " " & Chr(34) & Respuesta & Chr(34) & " " & """Servidor=palena.sii.cl;Puerto=443;SSL=1;ArchivoP12=" & txtCertiticado.Text & ";ContrasenaP12=" & txtClaveCertificado.Text & """")
            MiStreamWriter.WriteLine("facturista.exe  --enviar " & Chr(34) & NombreOriginal & Chr(34) & " " & Chr(34) & Respuesta & Chr(34) & " " & """Servidor=palena.sii.cl;Puerto=443;SSL=1;ArchivoP12=" & txtCertiticado.Text & ";ContrasenaP12=" & txtClaveCertificado.Text & """")


            MiStreamWriter.Close()


            If System.IO.File.Exists(NombreBat) Then
                myProcess.StartInfo.UseShellExecute = True
                myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
                myProcess.StartInfo.CreateNoWindow = False
                'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
                myProcess.Start()



                myProcess.WaitForExit()
            End If


            ''Firmar cliente

            'NombreBat = System.Windows.Forms.Application.StartupPath & "\EnvioCorreoT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
            'Try
            '    MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
            'Catch ex As Exception

            'End Try


            'Respuesta = txtRespuestasSII.Text & "\RespuestaEnvio-" & NombreFirmadoSII
            'MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
            'MiStreamWriter.WriteLine("cd """ & "c:\ndtechile" & """")

            ''Buscar correo de cliente

            'MiComandoMySql.CommandText = "select * from clientes where rut = '" & TipodocEmpresa(2) & "'"
            'MiDrMySql = MiComandoMySql.ExecuteReader
            'Dim CorreoCliente As String = ""
            'If MiDrMySql.Read Then
            '    CorreoCliente = MiDrMySql("email")
            'Else
            '    CorreoCliente = "ndiaz@ndtechile.cl"
            'End If
            'MiDrMySql.Close()
            'Debug.Print("python enviacorreoadjunto.py dtecliven@cliven.cl patricio mail.cliven.cl " & CorreoCliente & " c:\\NDTEChile\\out_cliente\\NDTE033F000002firmadoCLiente.xml 587")
            'MiStreamWriter.WriteLine("python enviacorreoadjunto.py " & txtUsuarioCorreo.Text & " " & txtContraseñaCorreo.Text & " " & txtServidorCorreo.Text & " " & CorreoCliente & " " & Replace(txtFirmadoCliente.Text & "\" & NombreFirmadoCliente, "\", "\\") & " " & txtPuertoCorreo.Text)


            'MiStreamWriter.Close()


            'If System.IO.File.Exists(NombreBat) Then
            '    myProcess.StartInfo.UseShellExecute = True
            '    myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
            '    myProcess.StartInfo.CreateNoWindow = False
            '    'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
            '    myProcess.Start()



            '    myProcess.WaitForExit()
            'End If



        Catch ex1 As Exception
            Debug.Print((ex1.Message))
        End Try
    End Sub

    Private Sub FSWSET_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FSWSET.Changed

    End Sub

    Private Sub FSWSET_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FSWSET.Created
        'MsgBox("se ha creado un archivo nuevo" & e.Name)
        If InStr(UCase(e.Name), "FIRMADO") = 0 Then
            Dim NombreArchivo As String = e.Name
            Dim NombreArchivoConPath As String = e.FullPath
            Dim UbicacionCAF As String = ""
            Dim TipodocEmpresa() As String

            'Parsear el archivo para saber el tipo y buscar su CAF activo

            Dim Contador As Integer
            For Contador = 1 To 100000
                System.Windows.Forms.Application.DoEvents()
                System.Windows.Forms.Application.DoEvents()
            Next

            Dim ArchivoXMLDTE As New Xml.XmlDocument
            Try
                Dim Leido As Boolean = False
                Try
                    While Leido = False
                        ArchivoXMLDTE.Load(e.FullPath)
                        Leido = True
                    End While
                Catch ex As Exception

                End Try
                ' MsgBox("Archivo leido")


                Dim DatosXML As String = ArchivoXMLDTE.InnerXml
                'MsgBox(DatosXML)

                TipodocEmpresa = Split(BuscaTipoDocyRUTEmpresa(DatosXML), ";")
                Dim TipoGlosa As String
                Select Case TipodocEmpresa(0)
                    Case "33"
                        TipoGlosa = "Factura Electrónica"
                        'UbicacionCAF = txtArchivoFolios33.Text
                    Case "61"
                        TipoGlosa = "Nota de Crédito Electrónica"
                        'UbicacionCAF = txtArchivoFolios61.Text
                    Case "56"
                        TipoGlosa = "Nota de Débito Electrónica"
                        'UbicacionCAF = txtArchivoFolios56.Text
                End Select
                'MsgBox("COD SII  " & TipodocEmpresa(0) & vbCrLf & "Tipo de Documento " & TipoGlosa & vbCrLf & "R.U.T. Emisor " & TipodocEmpresa(1) & vbCrLf & "R.U.T. Receptor " & TipodocEmpresa(2), MsgBoxStyle.Information, "Demo NDTEChile")



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error al leer archivo XML")
                Exit Sub
            End Try

            'MsgBox("UbicacionCAF " & UbicacionCAF)

            'Consultar si esta conectado a la base de datos

            Try
                MiConexionMySql.Close()
            Catch ex As Exception

            End Try
            Try
                MiConexionMySql.Open()

            Catch ex As Exception
                MsgBox("Conexion reabierta")
            End Try


            MiComandoMySql.CommandText = "select * from caesii where RE = '" & TipodocEmpresa(1) & "' and TD = '" & TipodocEmpresa(0) & "' and estado = 'VIGENTE' and " & TipodocEmpresa(3) & " between D and H"

            MiDrMySql = MiComandoMySql.ExecuteReader


            If MiDrMySql.Read Then
                UbicacionCAF = MiDrMySql("archivocaf")
            Else
                'MsgBox("No se puede obtener el CAF para este tipo de DTE", MsgBoxStyle.Information, "Obtensión de Folios")
                Exit Sub
            End If
            MiDrMySql.Close()
            'Sacar el RUT de la empresa para buscar los datos de Fecha Resolucion y numero de resolucion
            Dim FechaResolucion As String = Format(DTFechaResolucion.Value, "yyyy-MM-dd")
            Dim NumeroResolucion As String = txtNumResolucionSII.Text
            Dim Certificado As String = txtCertiticado.Text
            Dim txtClaveCert As String = txtClaveCertificado.Text



            Dim myProcess As New Process()
            Dim NombreBat As String = System.Windows.Forms.Application.StartupPath & "\Firma" & Format(Now, "ddmmyyyyHHmmss") & ".bat"
            Dim MiArchivoBat As System.IO.Stream
            Dim MiStreamWriter As System.IO.StreamWriter
            'Dim MiStreamWriter1 As System.IO.StreamWriter
            MiArchivoBat = New System.IO.MemoryStream()
            Try
                MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
            Catch ex As Exception

            End Try
            Dim NombreFirmadoSII As String
            Try
                NombreFirmadoSII = Replace(UCase(NombreArchivoConPath), ".XML", "firmadoSET.xml")
                Dim Respuesta As String = NombreFirmadoSII
                MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
                MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

                Debug.Print("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & """ > " & Chr(34) & Respuesta & Chr(34))
                MiStreamWriter.WriteLine("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & """ > " & Chr(34) & Respuesta & Chr(34))
                MiStreamWriter.Close()


                If System.IO.File.Exists(NombreBat) Then
                    myProcess.StartInfo.UseShellExecute = True
                    myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
                    myProcess.StartInfo.CreateNoWindow = True
                    'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
                    myProcess.Start()



                    myProcess.WaitForExit()
                End If

                ''Firmar cliente
                'NombreBat = System.Windows.Forms.Application.StartupPath & "\FirmaClienteT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
                'Try
                '    MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
                'Catch ex As Exception

                'End Try

                'Dim NombreFirmadoCliente As String = Replace(UCase(NombreArchivo), ".XML", "firmadoCLiente.xml")
                'Respuesta = txtFirmadoCliente.Text & "\" & NombreFirmadoCliente
                'MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
                'MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

                'Debug.Print("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & """ > " & Chr(34) & Respuesta & Chr(34))
                'MiStreamWriter.WriteLine("facturista.exe  --firmar_p12 " & Chr(34) & NombreArchivoConPath & Chr(34) & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & UbicacionCAF & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & """ > " & Chr(34) & Respuesta & Chr(34))
                'MiStreamWriter.Close()


                'If System.IO.File.Exists(NombreBat) Then
                '    myProcess.StartInfo.UseShellExecute = True
                '    myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
                '    myProcess.StartInfo.CreateNoWindow = False
                '    'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
                '    myProcess.Start()



                '    myProcess.WaitForExit()
                'End If



                '    'Genera PDFs

                ''    MsgBox("Versión Demo no crea PDFs", MsgBoxStyle.Information, "NDTEChile")
                'NombreBat = System.Windows.Forms.Application.StartupPath & "\GeneraPDFT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
                'Try
                '    MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
                'Catch ex As Exception

                'End Try


                ''    Respuesta = txtFirmadoCliente.Text & "\" & Replace(UCase(NombreArchivo), ".XML", "firmadoCLiente.xml")
                'MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
                'MiStreamWriter.WriteLine("cd ""C:\hefesto""")

                'Debug.Print("gen.exe " & Respuesta)
                'MiStreamWriter.WriteLine("gen.exe " & txtFirmadoCliente.Text & "\" & NombreFirmadoCliente)
                'MiStreamWriter.WriteLine("WshShell.Sendkeys ""{Enter}""")
                'MiStreamWriter.Close()


                'If System.IO.File.Exists(NombreBat) Then

                '    Dim NombreVBS As String
                '    NombreVBS = System.Windows.Forms.Application.StartupPath & "\CreaPDFs" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".vbs"
                '    Try
                '        MiArchivoBat = System.IO.File.Create(NombreVBS, IO.FileMode.Open)
                '    Catch ex As Exception

                '    End Try
                '    MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
                '    MiStreamWriter.WriteLine("set objshell = createobject(""wscript.shell"")")
                '    MiStreamWriter.WriteLine("objshell.run """ & NombreBat & """" & ",vbhide")
                '    MiStreamWriter.Close()
                '    If System.IO.File.Exists(NombreVBS) Then
                '        myProcess.StartInfo.UseShellExecute = True
                '        myProcess.StartInfo.FileName = NombreVBS '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
                '        myProcess.StartInfo.CreateNoWindow = False
                '        myProcess.Start()

                '        myProcess.WaitForExit()
                '        myProcess.Close()
                '    End If


                'End If

                'Enviar correo cliente
                'Dim NombreOriginal As String = txtFirmadoSII.Text & "\" & NombreFirmadoSII
                'NombreBat = System.Windows.Forms.Application.StartupPath & "\EnvioSIIT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
                'Try
                '    MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
                'Catch ex As Exception

                'End Try


                'Respuesta = txtRespuestasSII.Text & "\RespuestaEnvio-" & NombreFirmadoSII
                'MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
                'MiStreamWriter.WriteLine("cd """ & txtDirectorioLibFacturista.Text & """")

                'Debug.Print("facturista.exe  --enviar " & Chr(34) & NombreOriginal & Chr(34) & " " & Chr(34) & Respuesta & Chr(34) & " " & """Servidor=palena.sii.cl;Puerto=443;SSL=1;ArchivoP12=" & txtCertiticado.Text & ";ContrasenaP12=" & txtClaveCertificado.Text & """")
                'MiStreamWriter.WriteLine("facturista.exe  --enviar " & Chr(34) & NombreOriginal & Chr(34) & " " & Chr(34) & Respuesta & Chr(34) & " " & """Servidor=palena.sii.cl;Puerto=443;SSL=1;ArchivoP12=" & txtCertiticado.Text & ";ContrasenaP12=" & txtClaveCertificado.Text & """")


                'MiStreamWriter.Close()


                'If System.IO.File.Exists(NombreBat) Then
                '    myProcess.StartInfo.UseShellExecute = True
                '    myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
                '    myProcess.StartInfo.CreateNoWindow = False
                '    'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
                '    myProcess.Start()



                '    myProcess.WaitForExit()
                'End If


                ''Firmar cliente

                'NombreBat = System.Windows.Forms.Application.StartupPath & "\EnvioCorreoT" & TipodocEmpresa(0) & "F" & TipodocEmpresa(1) & Format(Now, "ddmmyyyyHHmmss") & ".bat"
                'Try
                '    MiArchivoBat = System.IO.File.Create(NombreBat, IO.FileMode.Open)
                'Catch ex As Exception

                'End Try


                'Respuesta = txtRespuestasSII.Text & "\RespuestaEnvio-" & NombreFirmadoSII
                'MiStreamWriter = New IO.StreamWriter(MiArchivoBat, System.Text.Encoding.Default)
                'MiStreamWriter.WriteLine("cd """ & "c:\ndtechile" & """")

                ''Buscar correo de cliente

                'MiComandoMySql.CommandText = "select * from clientes where rut = '" & TipodocEmpresa(2) & "'"
                'MiDrMySql = MiComandoMySql.ExecuteReader
                'Dim CorreoCliente As String = ""
                'If MiDrMySql.Read Then
                '    CorreoCliente = MiDrMySql("email")
                'Else
                '    CorreoCliente = "ndiaz@ndtechile.cl"
                'End If
                'MiDrMySql.Close()
                'Debug.Print("python enviacorreoadjunto.py dtecliven@cliven.cl patricio mail.cliven.cl " & CorreoCliente & " c:\\NDTEChile\\out_cliente\\NDTE033F000002firmadoCLiente.xml 587")
                'MiStreamWriter.WriteLine("python enviacorreoadjunto.py " & txtUsuarioCorreo.Text & " " & txtContraseñaCorreo.Text & " " & txtServidorCorreo.Text & " " & CorreoCliente & " " & Replace(txtFirmadoCliente.Text & "\" & NombreFirmadoCliente, "\", "\\") & " " & txtPuertoCorreo.Text)


                'MiStreamWriter.Close()


                'If System.IO.File.Exists(NombreBat) Then
                '    myProcess.StartInfo.UseShellExecute = True
                '    myProcess.StartInfo.FileName = NombreBat '"C:\Program Files (x86)\libfacturista20150825_cl\chile\facturista.exe" ' > " & Respuesta ' --firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta '  --firmar_p1 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtCertiticado.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & "c:\repuestaSII.xml"  'Aquí  le pasarías el nombre de tu programa
                '    myProcess.StartInfo.CreateNoWindow = False
                '    'myProcess.StartInfo.Arguments = " > " & Respuesta '"--firmar_p12 " & txtArchivoEnviar.Text & " " & txtCertiticado.Text & " " & txtClaveCertificado.Text & " " & """CAF=" & txtArchivoCaf.Text & ";FechaResolucion=" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & ";NumeroResolucion=" & txtNumResolucionSII.Text & ";RUTenvio=" & txtRutEmisor.Text & ";RUTrecepcion=60803000-K"" > " & Respuesta 'Aquí le pasarías los argumentos
                '    myProcess.Start()



                '    myProcess.WaitForExit()
                'End If



            Catch ex1 As Exception
                Debug.Print((ex1.Message))
            End Try
        End If

    End Sub

    Private Sub GeneraSET()
        Dim XMLSet As String = ""
        Dim Cont33 As Integer = 0
        Dim Cont61 As Integer = 0
        Dim Cont56 As Integer = 0
        Dim MiDocXML As XmlDocument

        MiDocXML = New XmlDocument()


        For Each foundFile As String In My.Computer.FileSystem.GetFiles(txtSetDte.Text)

            If InStr(UCase(foundFile), "FIRMADOSET") > 0 Then


                Try
                    MsgBox(foundFile)
                    MiDocXML.Load(foundFile)
                    Dim XmlPaso As String = MiDocXML.InnerXml

                    XmlPaso = Replace(XmlPaso, "<?xml version=""1.0"" encoding=""ISO-8859-1""?>", "")
                    MsgBox(XmlPaso)
                    'Agrupo
                    XMLSet = XMLSet + XmlPaso
                    'Cuento el tipo de DTE
                    Dim MiTipoDTE As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
                    Select Case MiTipoDTE
                        Case "33"
                            Cont33 = Cont33 + 1
                        Case "61"
                            Cont61 = Cont61 + 1
                        Case "56"
                            Cont56 = Cont56 + 1
                    End Select

                Catch ex As Exception

                End Try

            End If
        Next

        'Genero el SET

        Dim SetDTE As String = ""

        SetDTE = SetDTE & "<?xml version=""1.0"" encoding=""ISO-8859-1""?>" & vbCrLf
        SetDTE = SetDTE & "<EnvioDTE xmlns=""http://www.sii.cl/SiiDte"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" version=""1.0"" xsi:schemaLocation=""http://www.sii.cl/SiiDte EnvioDTE_v10.xsd"">" & vbCrLf
        SetDTE = SetDTE & "<SetDTE ID=""SetDoc"">" & vbCrLf
        SetDTE = SetDTE & "<Caratula version=""1.0"">" & vbCrLf
        SetDTE = SetDTE & "<RutEmisor>" & "76223032-1" & "</RutEmisor>" & vbCrLf
        SetDTE = SetDTE & "<RutEnvia>" & txtRutEmisor.Text & "</RutEnvia>" & vbCrLf
        SetDTE = SetDTE & "<RutReceptor>60803000-K</RutReceptor>" & vbCrLf
        SetDTE = SetDTE & "<FchResol>" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & "</FchResol>" & vbCrLf
        SetDTE = SetDTE & "<NroResol>" & txtNumResolucionSII.Text & "</NroResol>" & vbCrLf

        If Cont33 > 0 Then
            SetDTE = SetDTE & "<SubTotDTE>" & vbCrLf
            SetDTE = SetDTE & "<TpoDTE>33</TpoDTE>" & vbCrLf
            SetDTE = SetDTE & "<NroDTE>" & Cont33 & "</NroDTE>" & vbCrLf
            SetDTE = SetDTE & "</SubTotDTE>" & vbCrLf
        End If
        If Cont61 > 0 Then
            SetDTE = SetDTE & "<SubTotDTE>" & vbCrLf
            SetDTE = SetDTE & "<TpoDTE>61</TpoDTE>" & vbCrLf
            SetDTE = SetDTE & "<NroDTE>" & Cont61 & "</NroDTE>" & vbCrLf
            SetDTE = SetDTE & "</SubTotDTE>" & vbCrLf
        End If
        If Cont56 > 0 Then
            SetDTE = SetDTE & "<SubTotDTE>" & vbCrLf
            SetDTE = SetDTE & "<TpoDTE>56</TpoDTE>" & vbCrLf
            SetDTE = SetDTE & "<NroDTE>" & Cont56 & "</NroDTE>" & vbCrLf
            SetDTE = SetDTE & "</SubTotDTE>" & vbCrLf
        End If

        SetDTE = SetDTE & "</Caratula>" & vbCrLf

        SetDTE = SetDTE & XMLSet & vbCrLf

        SetDTE = SetDTE & "</SetDTE>"
        SetDTE = SetDTE & "</EnvioDTE>"



        MiDocXML = Nothing
        MiDocXML = New XmlDocument()

        MiDocXML.LoadXml(SetDTE)

        MiDocXML.Save(txtSetDte.Text & "\" & "SET" & Format(Now, "yyyyMMdd") & ".xml")


    End Sub

    Private Sub FSWFirmadoSII_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FSWFirmadoSII.Changed

    End Sub

    Private Sub FSWFirmadoSII_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FSWFirmadoSII.Created
        'Genera Codigo de Barra PDF417
        Dim ArchivoXMLDTECB As New Xml.XmlDocument
        Dim ContenidoXML As String
        Dim Usado As Boolean = True
        Dim TipoArchivoXML As String = ""

        'Dim Contador As Integer
        'For Contador = 1 To 100000
        '    System.Windows.Forms.Application.DoEvents()
        '    System.Windows.Forms.Application.DoEvents()
        'Next


        ContenidoXML = ""
        Try
            While Usado = True

                Try

                    ArchivoXMLDTECB.Load(e.FullPath)
                    ContenidoXML = ArchivoXMLDTECB.InnerXml
                    TipoArchivoXML = ArchivoXMLDTECB.DocumentElement.Name
                    Usado = False
                Catch ex As Exception

                End Try
            End While


        Catch ex As Exception
            MsgBox("Error en lectura de XML")

        End Try

        Debug.Print(TipoArchivoXML)
        Debug.Print(ContenidoXML)
        'Si es un EnvioDTE


        Dim MiDocXML As XmlDocument

        MiDocXML = New XmlDocument()
        Dim Prueba As String = ""
        Dim TipoDTE As String = ""
        Dim Folio As String = ""
        Dim FchEmis As String = ""
        Dim RUTEmisor As String = ""
        Dim RznSoc As String = ""
        Dim RUTRecep As String = ""
        Dim MntNeto As String = ""
        Dim TasaIVA As String = ""
        Dim IVA As String = ""
        Dim MntTotal As String = ""
        Dim TED As String = ""

        Try
            ContenidoXML = Replace(ContenidoXML, "xmlns=""http://www.sii.cl/SiiDte"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.sii.cl/SiiDte EnvioDTE_v10.xsd"" version=""1.0""", "")
            ContenidoXML = Replace(ContenidoXML, "xmlns=""http://www.sii.cl/SiiDte"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" version=""1.0"" xsi:schemaLocation=""http://www.sii.cl/SiiDte EnvioDTE_v10.xsd""", "")
            MiDocXML.LoadXml(ContenidoXML)
            'Prueba = MiDocXML.SelectSingleNode("//EnvioDTE/SetDTE/DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText

            'MiComandoMySql.Connection = MiConexionMySql
            'MiComandoMySql.CommandText = "update estadosdte set ticketsii = '" & TrackID & "',statusii='" & sTATUS & "',fechupload='" & TimeStamp & "' where rutemisor = '" & RutEmisor & "' and tipodte = '" & "33" & "' and foliodte = '" & "6" & "'"
            'MiComandoMySql.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'MsgBox(Prueba)

        If TipoArchivoXML = "EnvioDTE" Then
            Dim MiListaDTE As XmlNodeList = MiDocXML.SelectNodes("//EnvioDTE/SetDTE/DTE")
            'Dim MiNodo As XmlNode
            Dim ContadorNodos As Integer = 0

            Dim DTEPaso As XmlDocument
            DTEPaso = New XmlDocument
            For ContadorNodos = 0 To MiListaDTE.Count - 1
                DTEPaso.LoadXml(MiListaDTE.Item(ContadorNodos).OuterXml)
                TED = DTEPaso.SelectSingleNode("//DTE/Documento/TED").InnerXml

                RUTRecep = DTEPaso.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RUTRecep").InnerText
                TipoDTE = DTEPaso.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
                Folio = DTEPaso.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/Folio").InnerText
                TED = ("<TED version=""1.0"">" & TED & "</TED>")

            Next


            Try
                MiComandoMySql.CommandText = "update vtaser set frmt = '" & TED & "' where bnumero = " & Folio & " and tipodte = '" & TipoDTE & "'"
                MiComandoMySql.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(Err.Number & " " & Err.Description, MsgBoxStyle.Critical, "Error en actualizacion VTASer")
            End Try

            Dim pdf417 As New BarcodePDF417
            pdf417.SetText(TED)
            Dim Imagen As System.Drawing.Bitmap = New Bitmap(pdf417.CreateDrawingImage(Color.Black, Color.White))
            Dim MiImagen As Image = New Bitmap(pdf417.CreateDrawingImage(Color.Black, Color.White))
            Dim ATemporal As String = IO.Path.GetTempFileName()
            Dim filestream As New IO.FileStream(ATemporal, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            'Puede modificar el formato de la imagen a la hora de salvarla.
            'Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            'MiComandoMySql.CommandText = "insert into pdf417 (rutrecep,tipodte,folio,timbre) values ('" & RUTRecep & "'," & TipoDTE & "," & Folio & ", @imagen)"
            'Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
            '' MiComandoMySql.Parameters.Add("@imagen", System.Data.SqlDbType.Image)



            'MiComandoMySql.Parameters.AddWithValue("@imagen", DeImagen_a_Bytes(MiImagen))



            'MiComandoMySql.ExecuteNonQuery()
            'MiComandoMySql.Parameters.Clear()




            Try
                MiImagen.Save("C:\NDTEChile\pdf417\" & "T" & TipoDTE & "F" & Folio & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch ex As Exception
                MsgBox("Error al guardar imagen en Disco")
            End Try



            'MsgBox("Imagen Guardada Correctamente")
        End If
    End Sub

    Private Sub cmdCargaFolios_Click(sender As Object, e As EventArgs) Handles cmdCargaFolios.Click
        frmFolios.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogoDirectorio.ShowDialog()
        txtSetDte.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogoDirectorio.ShowDialog()
        txtLibros.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim opcion As Integer = MsgBox("Va a modificar los parametros de Directorios de integracion, esta seguro ???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificacion Parametros Facturador Electronica NDTEChile")
        If opcion = vbYes Then
            'Try
            '    MiComandoMySql.CommandText = "delete  from parametros_facturista"
            '    MiComandoMySql.ExecuteNonQuery()
            'Catch ex As Exception
            '    MsgBox("Error al eliminar parametros facturador " & Err.Number & " " & Err.Description, MsgBoxStyle.Exclamation, "Modificacion de Parametros Facturador Electronico")

            'End Try

            Try
                'MiComandoMySql.CommandText = "INSERT INTO integracion.parametros_facturista" & _
                '            "(directorio_xml_dte," & _
                '            "directorio_firmado_sii," & _
                '            "directorio_firmado_cliente," & _
                '            "directorio_pdf," & _
                '            "directorio_xml_proveedores," & _
                '            "directorio_pdf_proveedores," & _
                '            "fecha_resolucion_sii," & _
                '            "numero_resolucion_sii," & _
                '            "rut_emisor_dte," & _
                '            "ubicacion_certificado," & _
                '            "clave_certificado," & _
                '            "directorio_lib_facturista," & _
                '            "directorio_lcv," & _
                '            "directorio_respuesta_sii," & _
                '            "directorio_setdte," & _
                '            "directorio_envio_correos," & _
                '            "emaildte," & _
                '            "claveusu," & _
                '            "servidor," & _
                '            "puerto, " & _
                '            "rut_empresa) " & _
                '            "VALUES " & _
                '            "('" & Replace(txtXMLDte.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtFirmadoSII.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtFirmadoCliente.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtPDFVentas.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtXMLCompras.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtPDFCompras.Text, "\", "\\") & "'," & _
                '            "'" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & "'," & _
                '            "'" & txtNumResolucionSII.Text & "'," & _
                '            "'" & txtRutEmisor.Text & "'," & _
                '            "'" & Replace(txtCertiticado.Text, "\", "\\") & "'," & _
                '            "'" & txtClaveCertificado.Text & "'," & _
                '            "'" & Replace(txtDirectorioLibFacturista.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtLibros.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtRespuestasSII.Text, "\", "\\") & "'," & _
                '            "'" & Replace(txtSetDte.Text, "\", "\\") & "'," & _
                '            "' '," & _
                '            "'" & txtUsuarioCorreo.Text & "'," & _
                '            "'" & txtContraseñaCorreo.Text & "'," & _
                '            "'" & txtServidorCorreo.Text & "'," & _
                '            "'" & txtPuertoCorreo.Text & "'," & _
                '            "'" & lblEmpresaEmisora.Text & "')"


                MiComandoMySql.CommandText = "UPDATE " &
                                            "parametros_facturista " &
                                            "SET " &
                                            "directorio_xml_dte = '" & Replace(txtXMLDte.Text, "\", "\\") & "'," &
                                            "directorio_firmado_sii = '" & Replace(txtFirmadoSII.Text, "\", "\\") & "'," &
                                            "directorio_firmado_cliente = '" & Replace(txtFirmadoCliente.Text, "\", "\\") & "'," &
                                            "directorio_pdf = '" & Replace(txtPDFVentas.Text, "\", "\\") & "'," &
                                            "directorio_xml_proveedores = '" & Replace(txtXMLCompras.Text, "\", "\\") & "'," &
                                            "directorio_pdf_proveedores = '" & Replace(txtPDFCompras.Text, "\", "\\") & "'," &
                                            "directorio_lib_facturista = '" & Replace(txtDirectorioLibFacturista.Text, "\", "\\") & "'," &
                                            "directorio_lcv = '" & Replace(txtLibros.Text, "\", "\\") & "'," &
                                            "directorio_respuesta_sii = '" & Replace(txtRespuestasSII.Text, "\", "\\") & "'," &
                                            "directorio_setdte = '" & Replace(txtSetDte.Text, "\", "\\") & "'," &
                                            "ubicacion_timbre = '" & Replace(txtDirectorioTimbres.Text, "\", "\\") & "'"

                MiComandoMySql.ExecuteNonQuery()
                MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information, "Configuracion de Parametros de Directorios")
            Catch ex As Exception
                MsgBox("Error al Grabar parametros facturador " & Err.Number & " " & Err.Description, MsgBoxStyle.Exclamation, "Modificacion de Parametros Facturador Electronico")

            End Try
        ElseIf opcion = vbNo Then

        End If






    End Sub

    Private Sub cmdDescargaDtes_Click(sender As Object, e As EventArgs) Handles cmdDescargaDtes.Click
        frmRecepcionDTE.ShowDialog()
    End Sub

    Private Sub DgEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEmpresas.CellContentClick

    End Sub

    Private Sub DgEmpresas_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgEmpresas.RowHeaderMouseDoubleClick
        If DgEmpresas.SelectedRows.Count > 0 Then
            Dim Rut_Empresa As String = DgEmpresas.SelectedRows(0).Cells(20).Value
            Dim Rut_Emisor As String = DgEmpresas.SelectedRows(0).Cells(8).Value
            Dim Certificado As String = DgEmpresas.SelectedRows(0).Cells(9).Value
            Dim ContrasenaCert As String = DgEmpresas.SelectedRows(0).Cells(10).Value
            Dim NumResolucion As String = DgEmpresas.SelectedRows(0).Cells(7).Value
            Dim FechaResolucion As String = DgEmpresas.SelectedRows(0).Cells(6).Value
            Dim Correo As String = DgEmpresas.SelectedRows(0).Cells(16).Value
            Dim ContrasenaCorreo As String = DgEmpresas.SelectedRows(0).Cells(17).Value
            Dim ServidorCorreo As String = DgEmpresas.SelectedRows(0).Cells(18).Value
            Dim PuertoCorreo As String = DgEmpresas.SelectedRows(0).Cells(19).Value
            Dim Servidorpop As String = IIf(IsDBNull(DgEmpresas.SelectedRows(0).Cells(22).Value), "", DgEmpresas.SelectedRows(0).Cells(23).Value)
            Dim PuertoPop As String = IIf(IsDBNull(DgEmpresas.SelectedRows(0).Cells(23).Value), "", DgEmpresas.SelectedRows(0).Cells(22).Value)

            txtEmpresaEmisora.Text = Rut_Empresa
            txtRutEmisor.Text = Rut_Emisor
            txtCertiticado.Text = Certificado
            txtClaveCertificado.Text = ContrasenaCert
            txtNumResolucionSII.Text = NumResolucion
            Try
                DTFechaResolucion.Value = CDate(FechaResolucion)
            Catch ex As Exception
                DTFechaResolucion.Value = Now
            End Try

            txtUsuarioCorreo.Text = Correo
            txtContraseñaCorreo.Text = ContrasenaCorreo
            txtServidorCorreo.Text = ServidorCorreo
            txtPuertoCorreo.Text = PuertoCorreo
            txtPuertoPop.Text = PuertoPop
            txtServidorPop.Text = Servidorpop


        End If
    End Sub

    Private Sub limpiarDatos()
        txtEmpresaEmisora.Text = ""
        txtRutEmisor.Text = ""
        txtCertiticado.Text = ""
        txtClaveCertificado.Text = ""
        txtNumResolucionSII.Text = ""
        DTFechaResolucion.Value = Now
        txtUsuarioCorreo.Text = ""
        txtContraseñaCorreo.Text = ""
        txtServidorCorreo.Text = ""
        txtPuertoCorreo.Text = ""
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        'Grabar o modificar datos de Emisor y mepresas
        If txtEmpresaEmisora.Text <> "" And txtRutEmisor.Text <> "" And txtCertiticado.Text <> "" And txtClaveCertificado.Text <> "" And txtNumResolucionSII.Text <> "" And DTFechaResolucion.Text <> "" And txtUsuarioCorreo.Text <> "" And txtContraseñaCorreo.Text <> "" And txtServidorCorreo.Text <> "" And txtPuertoCorreo.Text <> "" Then
            'select * from parametros_facturista where rut_Empresa = '11100335-1'
            'Verificar si existe empresa
            MiComandoMySql.Connection = MiConexionMySql

            MiComandoMySql.CommandText = "select * from parametros_facturista where rut_Empresa = '" & txtEmpresaEmisora.Text & "'"
            MiDrMySql = MiComandoMySql.ExecuteReader
            Dim ExisteRegistro As Boolean = False
            If MiDrMySql.Read Then
                ExisteRegistro = True
            Else

            End If

            MiDrMySql.Close()


            If ExisteRegistro Then
                'hacer update
                MiComandoMySql.CommandText = "UPDATE parametros_facturista " &
                                            "SET " &
                                            "directorio_xml_dte = '" & Replace(txtXMLDte.Text, "\", "\\") & "'," &
                                            "directorio_firmado_sii = '" & Replace(txtFirmadoSII.Text, "\", "\\") & "'," &
                                            "directorio_firmado_cliente = '" & Replace(txtFirmadoCliente.Text, "\", "\\") & "'," &
                                            "directorio_pdf = '" & Replace(txtPDFVentas.Text, "\", "\\") & "'," &
                                            "directorio_xml_proveedores = '" & Replace(txtXMLCompras.Text, "\", "\\") & "'," &
                                            "directorio_pdf_proveedores = '" & Replace(txtPDFCompras.Text, "\", "\\") & "'," &
                                            "fecha_resolucion_sii = '" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & "'," &
                                            "numero_resolucion_sii ='" & txtNumResolucionSII.Text & "'," &
                                            "rut_emisor_dte = '" & txtRutEmisor.Text & "'," &
                                            "ubicacion_certificado = '" & Replace(txtCertiticado.Text, "\", "\\") & "'," &
                                            "clave_certificado = '" & txtClaveCertificado.Text & "'," &
                                            "directorio_lib_facturista = '" & Replace(txtDirectorioLibFacturista.Text, "\", "\\") & "'," &
                                            "directorio_lcv = '" & Replace(txtLibros.Text, "\", "\\") & "'," &
                                            "directorio_respuesta_sii = '" & Replace(txtRespuestasSII.Text, "\", "\\") & "'," &
                                            "directorio_setdte = '" & Replace(txtSetDte.Text, "\", "\\") & "'," &
                                            "directorio_envio_correos = '" & " " & "'," &
                                            "emaildte = '" & txtUsuarioCorreo.Text & "'," &
                                            "claveusu = '" & txtContraseñaCorreo.Text & "'," &
                                            "servidor = '" & txtServidorCorreo.Text & "'," &
                                            "puerto = '" & txtPuertoCorreo.Text & "' ," &
                                            "rut_empresa = '" & txtEmpresaEmisora.Text & "'," &
                                             "puertopop = '" & txtPuertoPop.Text & "', " &
                                             "servidorpop = '" & txtServidorPop.Text & "' " &
                                            "WHERE rut_empresa = '" & txtEmpresaEmisora.Text & "'"
                Try
                    MiComandoMySql.ExecuteNonQuery()
                    MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information, "Configuracion de Parametros")

                Catch ex As Exception
                    MsgBox("Error al actualizar datos de Empresa", MsgBoxStyle.Information, "Ingreso de Datos de Empresa")
                End Try
                Call CargaEmpresas()

            Else
                'Hacer create
                MiComandoMySql.CommandText = "INSERT INTO integracion.parametros_facturista" &
                            "(directorio_xml_dte," &
                            "directorio_firmado_sii," &
                            "directorio_firmado_cliente," &
                            "directorio_pdf," &
                            "directorio_xml_proveedores," &
                            "directorio_pdf_proveedores," &
                            "fecha_resolucion_sii," &
                            "numero_resolucion_sii," &
                            "rut_emisor_dte," &
                            "ubicacion_certificado," &
                            "clave_certificado," &
                            "directorio_lib_facturista," &
                            "directorio_lcv," &
                            "directorio_respuesta_sii," &
                            "directorio_setdte," &
                            "directorio_envio_correos," &
                            "emaildte," &
                            "claveusu," &
                            "servidor," &
                            "puerto, " &
                            "servidorpop, " &
                            "puertopop, " &
                            "rut_empresa) " &
                            "VALUES " &
                            "('" & Replace(txtXMLDte.Text, "\", "\\") & "'," &
                            "'" & Replace(txtFirmadoSII.Text, "\", "\\") & "'," &
                            "'" & Replace(txtFirmadoCliente.Text, "\", "\\") & "'," &
                            "'" & Replace(txtPDFVentas.Text, "\", "\\") & "'," &
                            "'" & Replace(txtXMLCompras.Text, "\", "\\") & "'," &
                            "'" & Replace(txtPDFCompras.Text, "\", "\\") & "'," &
                            "'" & Format(DTFechaResolucion.Value, "yyyy-MM-dd") & "'," &
                            "'" & txtNumResolucionSII.Text & "'," &
                            "'" & txtRutEmisor.Text & "'," &
                            "'" & Replace(txtCertiticado.Text, "\", "\\") & "'," &
                            "'" & txtClaveCertificado.Text & "'," &
                            "'" & Replace(txtDirectorioLibFacturista.Text, "\", "\\") & "'," &
                            "'" & Replace(txtLibros.Text, "\", "\\") & "'," &
                            "'" & Replace(txtRespuestasSII.Text, "\", "\\") & "'," &
                            "'" & Replace(txtSetDte.Text, "\", "\\") & "'," &
                            "' '," &
                            "'" & txtUsuarioCorreo.Text & "'," &
                            "'" & txtContraseñaCorreo.Text & "'," &
                            "'" & txtServidorCorreo.Text & "'," &
                            "'" & txtPuertoCorreo.Text & "'," &
                             "'" & txtServidorPop.Text & "'," &
                              "'" & txtPuertoPop.Text & "'," &
                            "'" & txtEmpresaEmisora.Text & "')"
                Try
                    MiComandoMySql.ExecuteNonQuery()
                    MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information, "Configuracion de Parametros")
                Catch ex As Exception
                    MsgBox("Error al actualizar datos de Empresa", MsgBoxStyle.Information, "Ingreso de Datos de Empresa")
                End Try
            End If

            Call CargaEmpresas()
        Else
            MsgBox("Error al ingresar Empresa , faltan parametros", MsgBoxStyle.Information, "ingreso de Empresa")

        End If


        Call limpiarDatos()



    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If DgEmpresas.SelectedRows.Count > 0 Then
            Dim Opcion As Integer = MsgBox("Desea eliminar la empresa seleccionada???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar empresa")
            If Opcion = vbYes Then
                MiComandoMySql.CommandText = "delete from parametros_Facturista " &
                                             "WHERE rut_empresa = '" & txtEmpresaEmisora.Text & "'"
                Try
                    MiComandoMySql.ExecuteNonQuery()
                    MsgBox("Datos eliminados correctamente", MsgBoxStyle.Information, "Eliminar Empresa")

                Catch ex As Exception
                    MsgBox("Error al Eliminar datos de Empresa", MsgBoxStyle.Information, "Eliminar de Datos de Empresa")
                End Try

                Call CargaEmpresas()
                Call limpiarDatos()
            Else

            End If


        Else
            MsgBox("Debe seleccionar una Empresa para eliminar", MsgBoxStyle.Information, "Eliminar empresa")
        End If

    End Sub
    '-----------------------------------------------------
    ' ODS 3052 - REVISION DE CONDICIONES - 23/07/2020 - CU
    ' SEGUN INSTRUCTIVO TECNICO FACTURA ELECTRONICA SII
    Public Function EscapeCaracteresEspeciales(cadena As String) As String
        Dim txtResult = ""
        If (cadena Is Nothing) Then
            Return txtResult
        Else
            txtResult = cadena.Replace("&", "&amp;")
            txtResult = txtResult.Replace("<", "&lt;")
            txtResult = txtResult.Replace(">", "&gt;")
            txtResult = txtResult.Replace("""", "&quot;")
            txtResult = txtResult.Replace("'", "&apos;")
            Return txtResult
        End If

    End Function
    '-----------------------------------------------------
    Public Class resultRevision
        Public codigo As Integer
        Public glosa As String

    End Class
    Public Class XmlValidationErrorBuilder
        Private _errors As New List(Of ValidationEventArgs)()

        Public Sub ValidationEventHandler(ByVal sender As Object, ByVal args As ValidationEventArgs)
            If args.Severity = XmlSeverityType.Error Then
                _errors.Add(args)
            End If
        End Sub

        Public Function GetErrores() As String
            If _errors.Count <> 0 Then
                Dim builder As New StringBuilder()
                builder.Append("Los siguientes ")
                builder.Append(_errors.Count.ToString())
                builder.AppendLine(" errore(s) fueron encontrados durante la validacion del documento XML contra el Esquema XSD del SII:")
                For Each i As ValidationEventArgs In _errors
                    builder.Append("* ")
                    builder.AppendLine(i.Message)
                Next
                Return builder.ToString()
            Else
                Return Nothing
            End If
        End Function
    End Class

    '-----------------------------------------------------
    ' ODS 3052 - REVISION DE CONDICIONES - 23/07/2020 - CU
    Public Function RevisaCondicionesXML(ByVal XML As String) As resultRevision
        Dim testXML As String
        Dim codigoError As Integer
        Dim glosaResultado As String = ""
        Dim xresultado As resultRevision = New resultRevision


        ' SOLO PARA CASO INICIAL DE PRUEBA, REEMPLAZAR POR XML AL FINAL
        testXML = XML

        ' Caso 1 . XML Codificado ISO-8859-1 y Caracteres Reemplazados
        ' y Caso 4 Ajuste de Longitud de Campo <NmbItem> a 40 Caracteres
        ' y Caso 5 Requerimiento de Etiqueta Detalle
        ' y Caso 6 Maximo 60 instancias de Etiqueta Detalle
        ' Reemplazo de Caracteres

        Dim docXML As New XmlDocument
        docXML.PreserveWhitespace = True
        docXML.CreateXmlDeclaration("1.0", "ISO-8859-1", Nothing)

        docXML.LoadXml(testXML)

        Dim nodeList = docXML.SelectNodes("//*")
        Dim noExisteDetalle = True
        Dim ContadorDetalles As Integer = 0

        For Each node As XmlElement In nodeList
            If node.Name = "NmbItem" Then
                ' Caso 4
                ' Ajuste de Longitud de Campo <NmbItem> a 40 Caracteres
                If node.InnerText.Length > 40 Then
                    node.InnerText = node.InnerText.Substring(1, 40)
                End If
            End If
            If node.Name = "Detalle" Then
                ' Caso 5
                ' Debe existir al menos una instancia de la seccion Detalle
                ContadorDetalles = ContadorDetalles + 1
                noExisteDetalle = False
            End If
            ' NOT WORKING
            If Not node.HasChildNodes Then
                node.InnerText = EscapeCaracteresEspeciales(node.InnerText)
            End If
        Next
        testXML = docXML.ToString

        If noExisteDetalle Then
            codigoError = 5
            glosaResultado = "Debe existir al menos una instancia de la seccion Detalle"
        End If
        If ContadorDetalles > 60 Then
            codigoError = 6
            glosaResultado = "El maximo numero de detalles en un DTE es 60"
        End If
        If codigoError = 0 Then


            ' Caso 12 - Validacion de que los Caracteres pertenezcan al ISO-8859-1
            Dim bytes() As Byte
            Dim resultado As String
            Dim positionArray(1) As Integer


            bytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(testXML)
            resultado = Encoding.GetEncoding("ISO-8859-1").GetString(bytes)
            If (Not String.Equals(testXML, resultado)) Then
                '
                ' Hay Caracteres fuera del ISO - RUTINA DE IDENTIFICAR CARACTERES
                '
                glosaResultado = "El XML contiene caracteres no validos para el estandar ISO-8859-1. Posicion(es)"
                Dim nDif As Integer = 0
                For contChar = 0 To XML.Length
                    If (Not String.Equals(XML.Substring(contChar, 1), resultado.Substring(contChar, 1))) Then
                        nDif = nDif + 1
                        glosaResultado = String.Concat(glosaResultado, "- [", contChar, "]@pos=", nDif, ".")
                        ReDim positionArray(nDif)
                        positionArray(nDif) = contChar
                    End If
                Next
                codigoError = 12

            End If
        End If
        If codigoError = 0 Then
            ' Caso 2
            ' Verificacion de Existencia de Etiquetas requeridas por Schema
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor") IsNot Nothing) Then
                Dim xRutEmisor As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor").InnerText
            End If


            Dim xTipoDTE As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
            Dim xFolioDTE As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/Folio").InnerText
            Dim xRutReceptor As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RUTRecep").InnerText


            ' Facturas/Notas
            If (xTipoDTE = "33" Or
                    xTipoDTE = "34" Or
                    xTipoDTE = "56" Or
                    xTipoDTE = "52" Or
                    xTipoDTE = "61") Then

                Try
                    docXML.Schemas.Add("http://www.sii.cl/SiiDte", String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\EnvioDTE_v10.xsd"))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -1
                    glosaResultado = "Error Cargando XSD EnvioDTE_v10"
                End Try
                Try
                    docXML.Schemas.Add("http://www.sii.cl/SiiDte", String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\DTE_v10.xsd"))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -1
                    glosaResultado = "Error Cargando XSD DTE_v10"
                End Try
                Try
                    docXML.Schemas.Add("http://www.sii.cl/SiiDte", String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\SiiTypes_v10.xsd"))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -1
                    glosaResultado = "Error Cargando XSD SiiTypes_v10"
                End Try
                Try
                    docXML.Schemas.Add("http://www.w3.org/2000/09/xmldsig#", String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\xmldsignature_v10.xsd"))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -1
                    glosaResultado = "Error Cargando XSD xmldsignature_v10"
                End Try

                Dim errorBuilder As New XmlValidationErrorBuilder
                docXML.Validate(New ValidationEventHandler(AddressOf errorBuilder.ValidationEventHandler))
                Dim erroresText As String = errorBuilder.GetErrores()
                If erroresText IsNot Nothing Then
                    codigoError = 2
                    glosaResultado = String.Concat("Error de Schema :", erroresText)
                    ' Throw New Exception(erroresText)
                End If

            End If
            ' Boletas
            If (xTipoDTE = "39" Or xTipoDTE = "41") Then
                Try
                    Using fs As FileStream = File.OpenRead(String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\SiiTypes_v10.xsd"))
                        Dim Setts As XmlReaderSettings = New XmlReaderSettings
                        Setts.DtdProcessing = DtdProcessing.Ignore
                        Using reader As XmlReader = XmlReader.Create(fs, Setts)
                            'docXML.Schemas.Add("http://www.sii.cl/SiiDte", reader)
                        End Using
                    End Using
                    'docXML.Schemas.Add("http://www.sii.cl/SiiDte", String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\SiiTypes_v10.xsd"))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -1
                    glosaResultado = "Error Cargando XSD SiiTypes_v10"
                End Try
                Try
                    Using fs As FileStream = File.OpenRead(String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\xmldsignature_v10.xsd"))
                        Dim Setts As XmlReaderSettings = New XmlReaderSettings
                        Setts.DtdProcessing = DtdProcessing.Ignore
                        Using reader As XmlReader = XmlReader.Create(fs, Setts)
                            'docXML.Schemas.Add("http://www.w3.org/2000/09/xmldsig#", reader)
                        End Using
                    End Using
                    'docXML.Schemas.Add("http://www.w3.org/2000/09/xmldsig#", String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\xmldsignature_v10.xsd"))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -1
                    glosaResultado = "Error Cargando XSD xmldsignature_v10"
                End Try
                Try
                    Using fs As FileStream = File.OpenRead(String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\EnvioBOLETA_v11.xsd"))
                        Dim Setts As XmlReaderSettings = New XmlReaderSettings
                        Setts.DtdProcessing = DtdProcessing.Ignore
                        Using reader As XmlReader = XmlReader.Create(fs, Setts)
                            docXML.Schemas.Add("http://www.sii.cl/SiiDte", reader)
                        End Using
                    End Using
                    '    docXML.Schemas.Add("http://www.sii.cl/SiiDte", String.Concat(AppDomain.CurrentDomain.BaseDirectory, "\EnvioBOLETA_v11.xsd"))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -1
                    glosaResultado = "Error Cargando XSD EnvioBOLETA_v11"
                End Try




                Dim errorBuilder As New XmlValidationErrorBuilder
                Try
                    docXML.Validate(New ValidationEventHandler(AddressOf errorBuilder.ValidationEventHandler))
                Catch ex As Exception
                    'Error Cargando XSD
                    codigoError = -2
                    glosaResultado = "Error de Validador XSD"
                End Try

                Dim erroresText As String = errorBuilder.GetErrores()
                If erroresText IsNot Nothing Then
                    codigoError = 2
                    glosaResultado = String.Concat("Error de Schema :", erroresText)
                    ' Throw New Exception(erroresText)
                End If
            End If

        End If
        If codigoError = 0 Then
            ' Caso 3
            ' Verificacion de Ruts dentro del XML
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor") IsNot Nothing) Then
                Dim xRutEmisor As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor").InnerText
                If Not VeriRut.verifica(xRutEmisor) Then
                    codigoError = 3
                    glosaResultado = "Error de Schema : RUTEmisor Invalido"
                End If
            End If
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTRecep") IsNot Nothing) Then
                Dim xRUTRecep As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTRecep").InnerText
                If Not VeriRut.verifica(xRUTRecep) Then
                    codigoError = 3
                    glosaResultado = "Error de Schema : RUTRecep Invalido"
                End If
            End If
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTSolicita") IsNot Nothing) Then
                Dim xRUTSolicita As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTSolicita").InnerText
                If Not VeriRut.verifica(xRUTSolicita) Then
                    codigoError = 3
                    glosaResultado = "Error de Schema : RUTSolicita Invalido"
                End If
            End If
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTTrans") IsNot Nothing) Then
                Dim xRUTTrans As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTTrans").InnerText
                If Not VeriRut.verifica(xRUTTrans) Then
                    codigoError = 3
                    glosaResultado = "Error de Schema : RUTTrans Invalido"
                End If
            End If
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTChofer") IsNot Nothing) Then
                Dim xRUTChofer As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTChofer").InnerText
                If Not VeriRut.verifica(xRUTChofer) Then
                    codigoError = 3
                    glosaResultado = "Error de Schema : RUTChofer Invalido"
                End If
            End If
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTCiaTransp") IsNot Nothing) Then
                Dim xRUTCiaTransp As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTCiaTransp").InnerText
                If Not VeriRut.verifica(xRUTCiaTransp) Then
                    codigoError = 3
                    glosaResultado = "Error de Schema : RUTCiaTransp Invalido"
                End If
            End If
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTOtr") IsNot Nothing) Then
                Dim xRUTOtr As String = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTOtr").InnerText
                If Not VeriRut.verifica(xRUTOtr) Then
                    codigoError = 3
                    glosaResultado = "Error de Schema : RUTOtr Invalido"
                End If
            End If
        End If
        If codigoError = 0 Then
            ' Caso 7 (ENV-3-0) Error en Schema - [0] LSX-00210: value "0" out of range for type "#simple"  RSC - Rechazado por Error en Schema
            ' indTraslado valores de 1 a 9 validos
            Dim elemList As XmlNodeList = docXML.GetElementsByTagName("indTraslado")
            For Each node As XmlElement In elemList
                If (Integer.Parse(node.InnerText) < 1 Or Integer.Parse(node.InnerText) > 9) Then
                    codigoError = 7
                    glosaResultado = "Error de Schema : indTraslado con valores fuera del rango del 1 al 9"
                End If
            Next
        End If
        If codigoError = 0 Then
            ' Caso 8 (ENV-3-0) Error en Schema - [0] LSX-00210: data missing for type "#simple"  RSC - Rechazado por Error en Schema
            ' NmbItem debe tener valor
            Dim elemList As XmlNodeList = docXML.GetElementsByTagName("NmbItem")
            For Each node As XmlElement In elemList
                If (node.InnerText.Length = 0) Then
                    codigoError = 8
                    glosaResultado = "Error de Schema : NmbItem debe tener valor asignado"
                End If
            Next
        End If
        If codigoError = 0 Then
            ' Caso 9 (ENV-3-0) Error en Schema - [0] LSX-00009: data missing for type "FechaType"  RSC - Rechazado por Error en Schema
            ' NmbItem debe tener valor
            Dim xTipoDTE As String = ""
            If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE") IsNot Nothing) Then
                xTipoDTE = docXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
            End If

            Dim xFolioRef = ""
            Dim xFchRef = ""
            Dim yFchRef As Date
            Dim xFchEmis As String = ""
            Dim yFchEmis As Date
            Dim xCodRef = ""
            Dim elemList As XmlNodeList

            If (xTipoDTE = "61" Or
                xTipoDTE = "56") Then
                If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/FchEmis") IsNot Nothing) Then
                    xFchEmis = docXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/FchEmis").InnerText
                End If
                yFchEmis = DateTime.Parse(xFchEmis)

                elemList = docXML.GetElementsByTagName("Referencia")
                Dim masDeTres = False
                For Each node As XmlElement In elemList
                    xFolioRef = node.SelectSingleNode("FolioRef").InnerText
                    xFchRef = node.SelectSingleNode("FchRef").InnerText
                    xCodRef = node.SelectSingleNode("CodRef").InnerText

                    yFchRef = DateTime.Parse(xFchRef)
                    '-----------------------------------------------------
                    If codigoError = 0 Then
                        If yFchEmis < yFchRef Then
                            'Caso 10 - fecha de referencia mayor a la fecha de emision del documento
                            codigoError = 10
                            glosaResultado = String.Concat("La Fecha del documento referenciado mayor a la fecha de emision del documento (Ref. T", xCodRef, "F", xFolioRef, ")")
                        End If
                    End If
                    '-----------------------------------------------------
                    If codigoError = 0 Then
                        If xCodRef <> 1 Then
                            If yFchEmis < yFchRef Then
                                'Caso 10 - fecha de referencia mayor a la fecha de emision del documento
                                codigoError = 10
                                glosaResultado = String.Concat("La Fecha del documento referenciado mayor a la fecha de emision del documento (Ref. T", xCodRef, "F", xFolioRef, ")")
                            Else
                                Dim mP = 0
                                Dim mC = 0
                                If yFchEmis.Year > yFchRef.Year Then
                                    mP = (((yFchEmis.Year - yFchRef.Year) * 12) - yFchRef.Month) + yFchEmis.Month
                                Else
                                    mP = yFchEmis.Month - yFchRef.Month
                                End If
                                If (yFchEmis.Day < yFchRef.Day) Then
                                    mC = -1
                                End If
                                mP = mP + mC

                                If mP > 3 Then
                                    codigoError = 9
                                    glosaResultado = String.Concat("Es un (Ref. T", xCodRef, "F", xFolioRef, ")")
                                End If
                            End If
                        End If
                    End If
                Next
            End If

        End If
        If codigoError = 0 Then
            Dim xRutEmisor = ""
            Dim xFolioRef = ""
            Dim xFchRef = ""
            Dim xCodRef = ""
            Dim xEstadoSII = ""
            Dim queryValidacion = "select estado_sii from consulta_dte where tipo_dte=@codref and folio_dte=@folioref and rut_emisor='@rutemisor'"
            Dim elemList As XmlNodeList
            ' Caso 11 (EL DTE AL QUE HACE REFERENCIA LA NOTA DE CREDITO NO HA SIDO RECIBIDO POR EL SII
            elemList = docXML.GetElementsByTagName("Referencia")
            Dim fallo = False
            Dim cual = ""
            For Each node As XmlElement In elemList

                If (docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor") IsNot Nothing) Then
                    xRutEmisor = docXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RUTEmisor").InnerText
                    If Not VeriRut.verifica(xRutEmisor) Then
                        codigoError = 3
                        glosaResultado = String.Concat("Error de Schema : RUTChofer Invalido")
                    End If
                Else
                    codigoError = 3
                    glosaResultado = String.Concat("Error de Schema : RUTChofer no Existente")
                End If
                If (node.SelectSingleNode("FolioRef") IsNot Nothing) Then
                    xFolioRef = node.SelectSingleNode("FolioRef").InnerText
                Else
                    codigoError = 3
                    glosaResultado = String.Concat("Error de Schema : FolioRef no Existente")
                End If
                If (node.SelectSingleNode("FchRef") IsNot Nothing) Then
                    xFolioRef = node.SelectSingleNode("FchRef").InnerText
                Else
                    codigoError = 3
                    glosaResultado = String.Concat("Error de Schema : FchRef no Existente")
                End If
                If (node.SelectSingleNode("CodRef") IsNot Nothing) Then
                    xCodRef = node.SelectSingleNode("CodRef").InnerText
                Else
                    codigoError = 3
                    glosaResultado = String.Concat("Error de Schema : CodRef no Existente")
                End If
                If codigoError = 0 Then
                    xEstadoSII = ""

                    ConsultComandoMySql.CommandText = queryValidacion
                    ConsultComandoMySql.Parameters.AddWithValue("@codref", xCodRef)
                    ConsultComandoMySql.Parameters.AddWithValue("@folioref", xFolioRef)
                    ConsultComandoMySql.Parameters.AddWithValue("@rut_emisor", xRutEmisor)
                    ConsultComandoMySql.Connection = ConsultConexionMySql
                    cual = String.Concat("R", xRutEmisor, "T", xCodRef, "F", xFolioRef)
                    Try
                        ConsultDrMySql = ConsultComandoMySql.ExecuteReader()
                        If ConsultDrMySql.HasRows() Then
                            While ConsultDrMySql.Read
                                xEstadoSII = ConsultDrMySql("estado_sii")
                                If (New String() {"DOK", "FAN", "TMD", "TMC", "MMD", "MMC", "AND", "ANC"}).Contains(xEstadoSII) Then
                                    ' Todo OK
                                Else
                                    glosaResultado = String.Concat("El Documento Referido no ha sido recibido en el SII. ", cual)
                                    codigoError = 11
                                End If
                            End While
                        Else
                            codigoError = 11
                            glosaResultado = String.Concat("El Documento Referido esta registrado en la base de datos. ", cual)
                        End If
                    Catch ex As Exception
                        glosaResultado = String.Concat("Error en conexion a base de datos en consulta de referencias.")
                        codigoError = -1
                    End Try



                End If

            Next

        End If
        xresultado.codigo = codigoError
        xresultado.glosa = glosaResultado
        Return xresultado
    End Function
    '-----------------------------------------------------

    Private Sub TNuevosDTE_Tick(sender As Object, e As EventArgs) Handles TNuevosDTE.Tick
        TNuevosDTE.Enabled = False
        Dim MiComandoNuevosDTE As New MySqlCommand
        MiComandoNuevosDTE.Connection = MiConexionMySqlAux
        Dim MiDrNuevosDTE As MySqlDataReader
        Dim Estado As Integer = 0
        'Cosnultar si la tabla esta desocupada

        If Estado = 0 Then 'Desocupada
            'Try
            '    MiComandoNuevosDTE.CommandText = "update semaforo set estado = 1  where tabla= 'estado_dte' "
            '    Debug.Print("update semaforo set estado = 1  where tabla= 'estado_dte' ")
            '    MiComandoNuevosDTE.ExecuteNonQuery()
            'Catch ex As Exception

            'End Try
            'MiComandoNuevosDTE.CommandText = "select * from estado_dte where folio_dte = 1 and rut_emisor = '76671531-1' and tipo_dte = '46'"
            'MiComandoNuevosDTE.CommandText = "SELECT * FROM estado_dte where procesado=0 ORDER BY estado_dte.fecha_emis  ASC"
            MiComandoNuevosDTE.CommandText = "SELECT xmlstring,tipo_dte,folio_dte,rut_emisor  FROM estado_dte where  procesado!=0 and tipo_dte=39 and rut_emisor = '76388857-6' and folio_dte in (1) ORDER BY  estado_dte.fecha_emis  ASC limit 200"
            'MiComandoNuevosDTE.CommandText = "Select * From estado_dte Where tipo_dte = 33 and folio_dte = 109 and rut_emisor = '78563100-5' "
            If MiConexionMySql.State = ConnectionState.Broken Then MiConexionMySql.Open()
            If MiConexionMySql.State = ConnectionState.Closed Then MiConexionMySql.Open()
            'If MiConexionMySql.State = ConnectionState.Open  Then MiConexionMySql.Open()

            Try
                MiDrNuevosDTE = MiComandoNuevosDTE.ExecuteReader

                While MiDrNuevosDTE.Read
                    'MsgBox(MiDrNuevosDTE("xmlstring"))
                    Try
                        Dim MiXMLString As String = MiDrNuevosDTE("xmlstring")
                        Dim EstadoRevision As resultRevision = RevisaCondicionesXML(MiXMLString)

                        If EstadoRevision.codigo = 0 Then
                            FirmaParaPDF417(MiXMLString, MiDrNuevosDTE("tipo_dte"), MiDrNuevosDTE("folio_dte"), MiDrNuevosDTE("rut_emisor"))

                        Else
                            System.Console.WriteLine(String.Concat("Ocurrio un error codigo = ", EstadoRevision.codigo, ", Glosa=", EstadoRevision.glosa))

                        End If

                    Catch ex As Exception
                        ' MsgBox(Err.Number & " " & Err.Description, MsgBoxStyle.Information, "Lectura de DTe estado procesado = 0")
                        Debug.Print(ex.Message)
                    End Try

                End While
                MiDrNuevosDTE.Close()


            Catch ex As Exception
                'If MiDrNuevosDTE.IsClosed = False Then MiDrNuevosDTE.Close()
            End Try
            'Try
            '    MiComandoNuevosDTE.CommandText = "update semaforo Set estado = 0  where tabla= 'estado_dte' "
            '    Debug.Print("update semaforo set estado = 0  where tabla= 'estado_dte' ")
            '    MiComandoNuevosDTE.ExecuteNonQuery()
            'Catch ex As Exception

            'End Try
        End If



        TNuevosDTE.Enabled = True
    End Sub

    Private Sub FirmaParaPDF417T(xmlstring As String)
        MsgBox(xmlstring)
    End Sub

    Private Sub FirmaParaPDF417(xmlstring As String, Optional TipoDTEEx As String = "", Optional FolioDTE As String = "", Optional Rut_Emisor As String = "")
        Dim DatosXML As String = xmlstring

        Dim ValidarXML As Object = New ValidadorXml  'Instanciamos la clase ValidadorXml

        Try
            DatosXML = ValidarXML.FormateaXML(DatosXML) ' validamos el xml
        Catch ex As Exception
            MsgBox("error" & ex.Message)
            '  MiComandoMySql.CommandText = "update estado_dte set procesado=98 where tipo_dte='" & TipoDTEEx & "' and folio_dte='" & FolioDTE & "' and rut_emisor='" & Rut_Emisor & "'"
            '  MiComandoMySql.ExecuteNonQuery()
        End Try



        Dim NombreArchivo As String = ""
        Dim NombreArchivoConPath As String = ""
        Dim UbicacionCAF As String = ""
        Dim TipodocEmpresa() As String


        Dim DatosTimbre As String = "<TED version=""1.0"">" & vbCrLf
        DatosTimbre = DatosTimbre & "<DD>" & vbCrLf
        DatosTimbre = DatosTimbre & "<RE>0</RE>" & vbCrLf
        DatosTimbre = DatosTimbre & "<TD>0</TD>" & vbCrLf
        DatosTimbre = DatosTimbre & "<F>0</F>" & vbCrLf
        DatosTimbre = DatosTimbre & "<FE>0</FE>" & vbCrLf
        DatosTimbre = DatosTimbre & "<RR>0</RR>" & vbCrLf
        DatosTimbre = DatosTimbre & "<RSR>0</RSR>" & vbCrLf
        DatosTimbre = DatosTimbre & "<MNT>0</MNT>" & vbCrLf
        DatosTimbre = DatosTimbre & "<IT1>0</IT1>" & vbCrLf
        DatosTimbre = DatosTimbre & "<CAF>Poner Caf Aqui</CAF>" & vbCrLf
        DatosTimbre = DatosTimbre & "<TSTED>0</TSTED>" & vbCrLf
        DatosTimbre = DatosTimbre & "</DD>" & vbCrLf
        DatosTimbre = DatosTimbre & "<FRMT algoritmo=""SHA1withRSA"">aqui va el tiembre calculado</FRMT>" & vbCrLf
        DatosTimbre = DatosTimbre & "</TED>" & vbCrLf
        DatosTimbre = DatosTimbre & "<TmstFirma>fecha de firma del documento</TmstFirma>" & vbCrLf
        DatosTimbre = DatosTimbre & "</Documento>"

        'Primero consultar si es un DTE o un comando
        DatosXML = Replace(DatosXML, "</Documento>", DatosTimbre)
        'MsgBox(DatosXML)

        Dim TipoDte As String = DetectaTipoXML(DatosXML)

        'If TipoDte <> "" Then
        '    MsgBox(TipoDte)
        'End If

        If InStr(TipoDte, "Error") > 0 Then
            'Escribe en bitacora
            'Try
            '    MiComandoMySql.CommandText = "insert into  bitacora_dte values ('" & TipoDTEEx & "','" & "" & "'," & FolioDTE & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & "Error de XML" & "','Error','" & TipoDte & "','" & Rut_Emisor & "')"
            '    MiComandoMySql.ExecuteNonQuery()
            'Catch ex As Exception

            'End Try

            Try
                MiComandoMySql.CommandText = "UPDATE estado_dte set procesado = -1,glosa_upload = '" & TipoDte & "'  where rut_emisor = '" & Rut_Emisor & "' and tipo_Dte = '" & TipoDTEEx & "' and  folio_dte = " & FolioDTE
                MiComandoMySql.ExecuteNonQuery()



            Catch ex As Exception
                MessageBox.Show("exception")
            End Try
            Exit Sub

        End If


        Dim MiDocXML As XmlDocument
        MiDocXML = New XmlDocument()
        MiDocXML.PreserveWhitespace = True
        MiDocXML.LoadXml(DatosXML)

        Dim Tipo As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/IdDoc/TipoDTE").InnerText
        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Totales/MntTotal") IsNot Nothing) Then
            Dim MntTotal As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Totales/MntTotal").InnerText
            If Val(MntTotal) <= 0 Then
                If (MiDocXML.SelectSingleNode("//DTE/Documento/Referencia") IsNot Nothing) Then
                    Dim codref As String = MiDocXML.SelectSingleNode("//DTE/Documento/Referencia/CodRef").InnerText
                    If (Val(codref <> 2)) Then
                        MiComandoMySql.CommandText = "UPDATE estado_dte set procesado =6,glosa_upload = 'Monto Total 0'  where rut_emisor = '" & Rut_Emisor & "' and tipo_Dte = '" & TipoDTEEx & "' and  folio_dte = " & FolioDTE
                        MiComandoMySql.ExecuteNonQuery()
                    End If
                Else
                    MiComandoMySql.CommandText = "UPDATE estado_dte set procesado =6,glosa_upload = 'Monto Total 0'  where rut_emisor = '" & Rut_Emisor & "' and tipo_Dte = '" & TipoDTEEx & "' and  folio_dte = " & FolioDTE
                    MiComandoMySql.ExecuteNonQuery()
                End If
            End If
        End If


        If (MiDocXML.SelectSingleNode("//DTE/Documento/Detalle") IsNot Nothing) Then

            Dim nodeList As XmlNodeList
            nodeList = MiDocXML.SelectNodes("//DTE/Documento/Detalle")
            Dim cont As Integer = 0
            For Each node As XmlElement In nodeList
                cont = cont + 1


                If Val(Tipo = 33 Or Tipo = 52) Then

                    If (node.SelectSingleNode("NroLinDet") IsNot Nothing) Then
                        Dim NroLinDet As String = node.SelectSingleNode("NroLinDet").InnerText
                        If Val(NroLinDet) > 60 Then
                            MiComandoMySql.CommandText = "UPDATE estado_dte set procesado =4,glosa_upload = 'Sobre 60 articulos'  where rut_emisor = '" & Rut_Emisor & "' and tipo_dte = '" & TipoDTEEx & "' and  folio_dte = " & FolioDTE
                            MiComandoMySql.ExecuteNonQuery()
                            Exit Sub
                        End If


                    End If
                End If
                'If (node.SelectSingleNode("MontoItem") IsNot Nothing) Then
                '    Dim MontoItem As String = node.SelectSingleNode("MontoItem").InnerText
                '    If Val(MontoItem) <= 0 Then
                '        MiComandoMySql.CommandText = "UPDATE estado_dte set procesado =6,glosa_upload = 'Valor Item  0'  where rut_emisor = '" & Rut_Emisor & "' and tipo_dte = '" & TipoDTEEx & "' and  folio_dte = " & FolioDTE
                '        MiComandoMySql.ExecuteNonQuery()
                '    End If
                'End If
            Next
        Else
            If (MiDocXML.SelectSingleNode("//DTE/Documento/Referencia") IsNot Nothing) Then
                Dim codref As String = MiDocXML.SelectSingleNode("//DTE/Documento/Referencia/CodRef").InnerText
                If (Val(codref <> 2)) Then
                    MiComandoMySql.CommandText = "update estado_dte set procesado=6,glosa_upload = 'Sin etiqueta Detalle'  where rut_emisor = '" & Rut_Emisor & "' and tipo_dte = '" & TipoDTEEx & "' and  folio_dte = " & FolioDTE
                    MiComandoMySql.ExecuteNonQuery()
                    Exit Sub
                End If
            Else

                MiComandoMySql.CommandText = "update estado_dte set procesado=6,glosa_upload = 'Sin etiqueta Detalle'  where rut_emisor = '" & Rut_Emisor & "' and tipo_dte = '" & TipoDTEEx & "' and  folio_dte = " & FolioDTE
                MiComandoMySql.ExecuteNonQuery()
                Exit Sub
            End If


        End If






        If InStr(TipoDte, "COMANDO") > 0 Then
            Dim DatosComando() As String = Split(TipoDte, ";")
            If DatosComando(1) = "ENVIA SET" Then
                GeneraSET()
            End If
        End If


        '

        Try
            TipodocEmpresa = Split(BuscaTipoDocyRUTEmpresa(DatosXML), ";")
        Catch ex As Exception
            Exit Sub
        End Try

        Dim TipoGlosa As String = ""
        Select Case TipodocEmpresa(0)
            Case "33"
                TipoGlosa = "Factura Electrónica"
                'UbicacionCAF = txtArchivoFolios33.Text
                'MiComandoMySql.CommandText = "delete from encFactura"
                'MiComandoMySql.ExecuteNonQuery()
            Case "61"
                TipoGlosa = "Nota de Crédito Electrónica"
                'UbicacionCAF = txtArchivoFolios61.Text
            Case "56"
                TipoGlosa = "Nota de Débito Electrónica"
                'UbicacionCAF = txtArchivoFolios56.Text
            Case "39"
                TipoGlosa = "Boleta Electrónica"
                'UbicacionCAF = txtArchivoFolios56.Text
            Case "41"
                TipoGlosa = "Nota de Débito Electrónica"
                'UbicacionCAF = txtArchivoFolios56.Text
            Case "46"
                TipoGlosa = "Factura Compra Ret Electrónica"
        End Select
        lblestado.Text = ("COD SII  " & TipodocEmpresa(0) & vbCrLf & "Tipo de Documento " & TipoGlosa & vbCrLf & "R.U.T. Emisor " & TipodocEmpresa(1) & vbCrLf & "R.U.T. Receptor " & TipodocEmpresa(2))



        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, "Error al leer archivo XML")
        '    Exit Sub
        'End Try


        'ArchivoXMLDTE = Nothing
        ''MsgBox("UbicacionCAF " & UbicacionCAF)
        Dim ArchivoXMLDTE As New XmlDocument
        ArchivoXMLDTE.PreserveWhitespace = True
        ArchivoXMLDTE.LoadXml(DatosXML)
        Dim NombreArchivoPaso As String = "C:\NDTEChile\paso\T" & TipodocEmpresa(0) & "F" & TipodocEmpresa(3) & "E" & Mid(TipodocEmpresa(1), 1, Len(TipodocEmpresa(1)) - 2) & ".xml"
        If System.IO.File.Exists("C:\NDTEChile\paso\T" & TipodocEmpresa(0) & "F" & TipodocEmpresa(3) & "E" & Mid(TipodocEmpresa(1), 1, Len(TipodocEmpresa(1)) - 2) & ".xml") Then System.IO.File.Delete("C:\NDTEChile\paso\T" & TipodocEmpresa(0) & "F" & TipodocEmpresa(3) & "E" & Mid(TipodocEmpresa(1), 1, Len(TipodocEmpresa(1)) - 2) & ".xml")
        ArchivoXMLDTE.Save(NombreArchivoPaso)
        ArchivoXMLDTE = Nothing
        ''Consultar si esta conectado a la base de datos

        'Try
        '    MiConexionMySql.Close()
        'Catch ex As Exception

        'End Try
        'Try
        '    MiConexionMySql.Open()

        'Catch ex As Exception
        '    MsgBox("Conexion reabierta")
        'End Try
        'Dim rut_empresa As String
        Try
            MiComandoMySql.CommandText = "select * from caf where rut_contribuyente = '" & TipodocEmpresa(1) & "' and tipo_doc = '" & TipodocEmpresa(0) & "' and Activo = 1 and " & TipodocEmpresa(3) & " between valor_inicial and valor_final"

            MiDrMySql = MiComandoMySql.ExecuteReader


            If MiDrMySql.Read Then
                UbicacionCAF = MiDrMySql("ubicacion_caf")
            Else

                'MsgBox("No se puede obtener el CAF para este tipo de DTE", MsgBoxStyle.Information, "Obtensión de Folios")

                MiDrMySql.Close()

                MiComandoMySql.CommandText = "update estado_dte set procesado=99  where tipo_dte='" & TipoDTEEx & "' and folio_dte='" & FolioDTE & "' and rut_emisor='" & TipodocEmpresa(1) & "'"
                MiComandoMySql.ExecuteNonQuery()
                'Escribe en bitacora
                Try
                    'MiComandoMySql.CommandText = "insert into  bitacora_dte values ('" & TipodocEmpresa(0) & "','" & "" & "'," & TipodocEmpresa(3) & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & "NO SE ECÇNCUENTRA CAF" & "','ERROR','','" & TipodocEmpresa(1) & "')"
                    'MiComandoMySql.ExecuteNonQuery()
                Catch ex As Exception

                End Try
                Exit Sub
            End If
            MiDrMySql.Close()
            ''Sacar el RUT de la empresa para buscar los datos de Fecha Resolucion y numero de resolucion
        Catch ex As Exception

        End Try


        Dim FechaResolucion As String = ""
        Dim NumeroResolucion As String = ""
        Dim Certificado As String = ""
        ' Dim txtClaveCert As String
        Dim RutEmisor As String = ""


        Try
            MiComandoMySql.CommandText = "select * from parametros_facturista  where rut_empresa = '" & TipodocEmpresa(1) & "'"

            MiDrMySql = MiComandoMySql.ExecuteReader


            If MiDrMySql.Read Then
                FechaResolucion = MiDrMySql("fecha_resolucion_sii")
                NumeroResolucion = MiDrMySql("numero_resolucion_sii")
                Certificado = MiDrMySql("ubicacion_certificado")
                RutEmisor = MiDrMySql("rut_emisor_dte")
            Else
                'MsgBox("No se puede obtener datos emisor", MsgBoxStyle.Information, "Obtensión de Datos Emisor")
                Try
                    MiComandoMySql.CommandText = "insert into  bitacora_dte values ('" & TipodocEmpresa(0) & "','" & "" & "'," & TipodocEmpresa(3) & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & "NO SE ECUNCUENTRA EMPRESA" & "','ERROR','','" & TipodocEmpresa(1) & "')"
                    MiComandoMySql.ExecuteNonQuery()
                Catch ex As Exception

                End Try
                If MiDrMySql.IsClosed = False Then MiDrMySql.Close()
                Exit Sub
            End If
            MiDrMySql.Close()
        Catch ex As Exception

        End Try


        ''Exposervice 77788570-7  E3
        ''inreser     76185994-3  E1
        ''T&Q         76306415-8  E2

        ''If TipodocEmpresa(1) = "76185994-3" Then
        'FechaResolucion = Format(DTFechaResolucion.Value, "yyyy-MM-dd")
        'NumeroResolucion = txtNumResolucionSII.Text
        'Certificado = txtCertiticado.Text
        'txtClaveCert = "" 'txtClaveCertificado.Text
        'RutEmisor = txtRutEmisor.Text



        Dim MiXMLDte As String = Replace(NombreArchivoPaso, "\", "\\") ' "C:\\Users\\logrono\\Documents\\xmlpRUEBA.xml"
        Dim RutaCaf As String = Replace(UbicacionCAF, "\", "\\") '"C:\\FoliosFacturista\\FoliosInreser33.xml"
        Dim MiXml As New XmlDocument
        MiXml.PreserveWhitespace = True
        MiXml.Load(MiXMLDte)

        Dim MiFacturador As New FacturadorNDTEChile.Facturador


        MiXml = MiFacturador.generarTed(MiXml, RutaCaf)



        ''Insertar el TimeStamp
        Dim TmstFirma As XmlElement = MiXml.SelectSingleNode("DTE/Documento/TmstFirma")
        TmstFirma.InnerText = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
        MiXml.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte")

        Debug.Print(MiXml.InnerXml)


        Dim MiXmlSalidaFirmado As New XmlDocument
        MiXmlSalidaFirmado.PreserveWhitespace = True
        MiXmlSalidaFirmado = MiFacturador.timbrarTed(MiXml, RutaCaf)


        'Escribe en bitacora
        Try
            MiComandoMySql.CommandText = "insert into  bitacora_dte values ('" & TipodocEmpresa(0) & "','" & "" & "'," & TipodocEmpresa(3) & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & "Tmbra DTE" & "','OK','','" & TipodocEmpresa(1) & "')"
            MiComandoMySql.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        'MiComandoMySql.CommandText = "UPDATE estado_dte set imagen_texto = '" & ImagenString & "' where rut_emisor = '" & TipodocEmpresa(1) & "' and tipo_Dte = '" & TipodocEmpresa(0) & "' and  folio_dte = " & TipodocEmpresa(3)



        'Imagen.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
        ''Imagen.Save(System.Windows.Forms.Application.StartupPath & "\Prueba" & Format(Now, "yyyyMMdd") & ".jpg")

        ' MiComandoMySql.Parameters("?imagen").Value = Bin.GetBuffer()
        ' MiComandoMySql.ExecuteNonQuery()

        'Dim MiNameSpace As XmlNamespaceManager = New XmlNamespaceManager(MiXmlSalidaFirmado.NameTable)
        'MiNameSpace.AddNamespace("sii", "http://www.sii.cl/SiiDte")


        Debug.Print(MiXmlSalidaFirmado.InnerXml)
        'Sacar el TED del Documento
        Try
            Dim MiNodoTED As XmlElement = MiXmlSalidaFirmado.SelectSingleNode("DTE/Documento/TED")
            Dim TEdstring As String = "<TED>" & Replace(MiNodoTED.InnerXml, vbCrLf, "") & "</TED>"
            'MsgBox(TEdstring)
            Dim pdf417 As New BarcodePDF417
            pdf417.SetText(TEdstring)
            Dim Imagen As System.Drawing.Bitmap = New Bitmap(pdf417.CreateDrawingImage(Color.Black, Color.White))


            'MiComandoMySql.Parameters.Add("?imagen", System.Data.SqlDbType.Image)



            PictureBox1.Image = Imagen



            Dim Imag As Byte()
            Imag = Imagen_Bytes(Me.PictureBox1.Image)



            Dim Bin As New MemoryStream
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'Dim ImagenString As String '= MemStream2String(Bin)
            'ImagenString = ArrayToString(imageToByteArray(Imagen, System.Drawing.Imaging.ImageFormat.Png), Nothing)
            'Debug.Print(ImagenString)
            'MsgBox(ImagenString)

            MiComandoMySql.Parameters.AddWithValue("?imagen", Imag)

            'Guardar imagen a Disco
            Dim NombreImagen As String = ""
            Try
                NombreImagen = "C:\NDTEChile\PDF417\R" & TipodocEmpresa(1) & "T" & TipodocEmpresa(0) & "F" & TipodocEmpresa(3) & ".png"
                If System.IO.File.Exists("C:\NDTEChile\PDF417\R" & TipodocEmpresa(1) & "T" & TipodocEmpresa(0) & "F" & TipodocEmpresa(3) & ".png") Then System.IO.File.Delete("C:\NDTEChile\PDF417\R" & TipodocEmpresa(1) & "T" & TipodocEmpresa(0) & "F" & TipodocEmpresa(3) & ".png")
                PictureBox1.Image.Save(NombreImagen, System.Drawing.Imaging.ImageFormat.Png)
            Catch ex As Exception
                Debug.Print(Err.Number & " " & Err.Description & " creando imagen")
            End Try

            MiComandoMySql.CommandText = "UPDATE estado_dte set pdf417 = ?imagen,procesado = 1,ubicacion_pdf417 = '" & Replace(NombreImagen, "\", "\\") & "'  where rut_emisor = '" & TipodocEmpresa(1) & "' and tipo_Dte = '" & TipodocEmpresa(0) & "' and  folio_dte = " & TipodocEmpresa(3)

            'MiComandoMySql.CommandText = "UPDATE estado_dte set imagen_texto = '" & ImagenString & "' where rut_emisor = '" & TipodocEmpresa(1) & "' and tipo_Dte = '" & TipodocEmpresa(0) & "' and  folio_dte = " & TipodocEmpresa(3)



            'Imagen.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            ''Imagen.Save(System.Windows.Forms.Application.StartupPath & "\Prueba" & Format(Now, "yyyyMMdd") & ".jpg")

            ' MiComandoMySql.Parameters("?imagen").Value = Bin.GetBuffer()
            Try
                MiComandoMySql.ExecuteNonQuery()
                MiComandoMySql.Parameters.Clear()
            Catch ex As Exception

            End Try


            Try
                Try
                    MiComandoMySql.CommandText = "insert into  bitacora_dte values ('" & TipodocEmpresa(0) & "','" & "" & "'," & TipodocEmpresa(3) & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & "Genera Imagen BD" & "','OK','','" & TipodocEmpresa(1) & "')"
                    MiComandoMySql.ExecuteNonQuery()
                Catch ex As Exception

                End Try

            Catch ex As Exception

            End Try

        Catch ex As Exception
            'MsgBox(Err.Number & " " & Err.Description, MsgBoxStyle.Information, "Update estado_te")
        End Try






        Dim NombreArchivoFirmado As String = Replace(UCase(NombreArchivoPaso), ".XML", "firmadoSII.xml")
        MiXmlSalidaFirmado.Save(NombreArchivoFirmado)
        MiXmlSalidaFirmado = Nothing





        ' MsgBox("Firmar con Certificado " & NombreArchivoFirmado & " " & Certificado)

        Try



            MiXmlSalidaFirmado = MiFacturador.firmarDocumentoDTE(NombreArchivoFirmado, Certificado)

            Try
                MiComandoMySql.CommandText = "insert into  bitacora_dte values ('" & TipodocEmpresa(0) & "','" & "" & "'," & TipodocEmpresa(3) & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & "Firma con Certificado para cliente" & "','OK','','" & TipodocEmpresa(1) & "')"
                MiComandoMySql.ExecuteNonQuery()
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox(Err.Number & " " & Err.Description, MsgBoxStyle.Information, "Firma DTE")
        End Try

        Dim MiXmlFirmado As New XmlDocument
        MiXmlFirmado.PreserveWhitespace = True
        MiXmlFirmado.Load(NombreArchivoFirmado)
        Dim MiDocElement As XmlElement = MiXmlFirmado.DocumentElement
        Dim MiNameSpace As XmlNamespaceManager = New XmlNamespaceManager(MiXmlFirmado.NameTable)
        MiNameSpace.AddNamespace("sii", "http://www.sii.cl/SiiDte")

        ''saca RUT

        Dim XMLFirmado As String = MiDocElement.OuterXml

        Dim Sobre As String = ""


        Sobre = "<?xml version=""1.0"" encoding=""ISO-8859-1""?>" & vbCrLf

        Sobre = Sobre & "<EnvioDTE version=""1.0"" xmlns=""http://www.sii.cl/SiiDte"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.sii.cl/SiiDte EnvioDTE_v10.xsd"">" & vbCrLf
        Sobre = Sobre & "<SetDTE ID=""" & "NDTECHILE" & """" & ">" & vbCrLf
        Sobre = Sobre & "<Caratula version=""1.0"">" & vbCrLf
        Sobre = Sobre & "<RutEmisor>" & TipodocEmpresa(1) & "</RutEmisor>" & vbCrLf
        Sobre = Sobre & "<RutEnvia>" & RutEmisor & "</RutEnvia>" & vbCrLf
        Sobre = Sobre & "<RutReceptor>" & "60803000-K" & "</RutReceptor>" & vbCrLf
        Sobre = Sobre & "<FchResol>" & FechaResolucion & "</FchResol>" & vbCrLf
        Sobre = Sobre & "<NroResol>" & NumeroResolucion & "</NroResol>" & vbCrLf
        Sobre = Sobre & "<TmstFirmaEnv>" & DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") & "</TmstFirmaEnv>" & vbCrLf
        Sobre = Sobre & "<SubTotDTE>" & vbCrLf
        Sobre = Sobre & "<TpoDTE>" & TipodocEmpresa(0) & "</TpoDTE>" & vbCrLf
        Sobre = Sobre & "<NroDTE>1</NroDTE>" & vbCrLf
        Sobre = Sobre & "</SubTotDTE>" & vbCrLf
        Sobre = Sobre & "</Caratula>" & vbCrLf
        Sobre = Sobre & XMLFirmado
        Sobre = Sobre & "</SetDTE>" & vbCrLf
        'Insertar XMLFimrmado
        Sobre = Sobre & "</EnvioDTE>"

        MiXmlFirmado = Nothing
        MiXmlFirmado = New XmlDocument
        MiXmlFirmado.PreserveWhitespace = True
        MiXmlFirmado.LoadXml(Sobre)
        MiXmlFirmado.Save(NombreArchivoFirmado)
        MiXmlFirmado = Nothing




        MiXmlFirmado = MiFacturador.firmarDocumentoEnvioDTE(NombreArchivoFirmado, Certificado, "#NDTECHILE")

        MiXmlFirmado.Save(NombreArchivoFirmado)


        Try
            MiComandoMySql.Connection = MiConexionMySql
            MiComandoMySql.CommandText = "update estado_dte set xml_firmado_sii = '" & MiXmlFirmado.OuterXml & "' where rut_emisor = '" & TipodocEmpresa(1) & "' and tipo_dte = '" & TipodocEmpresa(0) & "' and folio_dte = " & TipodocEmpresa(3)
            MiComandoMySql.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Dim SobreCliente As String = ""
        SobreCliente = "<?xml version=""1.0"" encoding=""ISO-8859-1""?>" & vbCrLf

        SobreCliente = SobreCliente & "<EnvioDTE version=""1.0"" xmlns=""http://www.sii.cl/SiiDte"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.sii.cl/SiiDte EnvioDTE_v10.xsd"">" & vbCrLf
        SobreCliente = SobreCliente & "<SetDTE ID=""" & "NDTECHILE" & """" & ">" & vbCrLf
        SobreCliente = SobreCliente & "<Caratula version=""1.0"">" & vbCrLf
        SobreCliente = SobreCliente & "<RutEmisor>" & TipodocEmpresa(1) & "</RutEmisor>" & vbCrLf
        SobreCliente = SobreCliente & "<RutEnvia>" & RutEmisor & "</RutEnvia>" & vbCrLf
        SobreCliente = SobreCliente & "<RutReceptor>" & TipodocEmpresa(2) & "</RutReceptor>" & vbCrLf
        SobreCliente = SobreCliente & "<FchResol>" & FechaResolucion & "</FchResol>" & vbCrLf
        SobreCliente = SobreCliente & "<NroResol>" & NumeroResolucion & "</NroResol>" & vbCrLf
        SobreCliente = SobreCliente & "<TmstFirmaEnv>" & DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") & "</TmstFirmaEnv>" & vbCrLf
        SobreCliente = SobreCliente & "<SubTotDTE>" & vbCrLf
        SobreCliente = SobreCliente & "<TpoDTE>" & TipodocEmpresa(0) & "</TpoDTE>" & vbCrLf
        SobreCliente = SobreCliente & "<NroDTE>1</NroDTE>" & vbCrLf
        SobreCliente = SobreCliente & "</SubTotDTE>" & vbCrLf
        SobreCliente = SobreCliente & "</Caratula>" & vbCrLf
        SobreCliente = SobreCliente & XMLFirmado
        SobreCliente = SobreCliente & "</SetDTE>" & vbCrLf
        'Insertar XMLFimrmado
        SobreCliente = SobreCliente & "</EnvioDTE>"

        MiXmlFirmado = Nothing
        MiXmlFirmado = New XmlDocument
        MiXmlFirmado.PreserveWhitespace = True
        MiXmlFirmado.LoadXml(SobreCliente)
        MiXmlFirmado.Save(NombreArchivoFirmado)
        MiXmlFirmado = Nothing




        MiXmlFirmado = MiFacturador.firmarDocumentoEnvioDTE(NombreArchivoFirmado, Certificado, "#NDTECHILE")
        MiXmlFirmado.Save(NombreArchivoFirmado)


        Try
            MiComandoMySql.Connection = MiConexionMySql
            MiComandoMySql.CommandText = "update estado_dte set xml_firmado_cliente = '" & MiXmlFirmado.OuterXml & "' where rut_emisor = '" & TipodocEmpresa(1) & "' and tipo_dte = '" & TipodocEmpresa(0) & "' and folio_dte = " & TipodocEmpresa(3)
            MiComandoMySql.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            MiComandoMySql.CommandText = "insert into  bitacora_dte values ('" & TipodocEmpresa(0) & "','" & "" & "'," & TipodocEmpresa(3) & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & "Firma con Certificado para SII" & "','OK','','" & TipodocEmpresa(1) & "')"
            MiComandoMySql.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        ''MsgBox(Sobre)
        'Debug.Print(Sobre)
        'Dim Resultado As String



        'Dim ArchivoXMLDTECB As New XmlDocument
        'Dim TipoArchivoXML As String = ""

        'If TipodocEmpresa(0) = "33" Or TipodocEmpresa(0) = "34" Or TipodocEmpresa(0) = "61" Then
        '    Resultado = MiFacturador.EnviaSII(NombreArchivoFirmado, Certificado, NombreArchivoFirmado, TipodocEmpresa(1), RutEmisor, "palena")
        '    Try

        '        ArchivoXMLDTECB.LoadXml(Resultado)


        '        TipoArchivoXML = ArchivoXMLDTECB.DocumentElement.Name

        '    Catch ex As Exception


        '    End Try



        '    If (ArchivoXMLDTECB.DocumentElement.Name) = "RECEPCIONDTE" Then
        '        Try

        '            Dim FileEnviado As String = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/FILE").InnerText
        '            Rut_Emisor = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/RUTCOMPANY").InnerText
        '            Dim TimeStamp As String = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/TIMESTAMP").InnerText
        '            Dim sTATUS As String = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/STATUS").InnerText
        '            Dim TrackID As String
        '            Try
        '                TrackID = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/TRACKID").InnerText
        '            Catch ex As Exception
        '                TrackID = " "
        '            End Try
        '            Dim ErrorEnvio As String
        '            If CInt(sTATUS) <> 0 Then
        '                ErrorEnvio = ArchivoXMLDTECB.SelectSingleNode("//RECEPCIONDTE/DETAIL/ERROR").InnerText
        '                ErrorEnvio = Replace(ErrorEnvio, "'", "")
        '            End If

        '            'Dim DatosNombre() As String = Split(FileEnviado, "-")
        '            Dim TipoDoc As Integer
        '            Dim FolioDoc As Integer


        '            'Try
        '            '    MiConexionMySqlAux.Close()
        '            'Catch ex As Exception

        '            'End Try
        '            'Try
        '            '    MiConexionMySqlAux.Open()

        '            'Catch ex As Exception
        '            '    MsgBox("Conexion reabierta")
        '            'End Try



        '            Try
        '                MiComandoMySql.CommandText = "update estado_dte set track_id = '" & TrackID & "',estado_upload='" & sTATUS & "',fecha_upload='" & TimeStamp & "',glosa_upload = '" & ErrorEnvio & "',enviado_sii = 1  where rut_emisor = '" & Rut_Emisor & "' and tipo_dte = '" & TipodocEmpresa(0) & "' and folio_dte = " & TipodocEmpresa(3)
        '                MiComandoMySql.ExecuteNonQuery()
        '            Catch ex As Exception

        '            End Try

        '            ArchivoXMLDTECB = Nothing
        '        Catch ex As Exception
        '            'MsgBox(ex.Message)
        '            Debug.Print(Err.Number & " " & Err.Description)
        '        End Try



        '    End If


        '    Try
        '        'System.IO.File.Move(NombreArchivoFirmado, txtFirmadoCliente.Text & "\" & "T" & TipodocEmpresa(0) & "F" & TipodocEmpresa(3) & "E" & Mid(TipodocEmpresa(1), 1, Len(TipodocEmpresa(1)) - 2) & ".xml")
        '    Catch ex As Exception

        '    End Try
        'End If


        lblestado.Text = ""
    End Sub



    Public Function imageToByteArray(ByVal imageIn As System.Drawing.Image, ByVal pformato As System.Drawing.Imaging.ImageFormat) As Byte()
        Dim ms As New IO.MemoryStream
        Try
            imageIn.Save(ms, pformato)
        Catch ex As Exception
        End Try
        Return ms.ToArray()
    End Function

    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim returnImage As Image = Nothing
        Try
            Dim ms As New IO.MemoryStream(byteArrayIn)
            returnImage = Image.FromStream(ms)
        Catch ex As Exception
        End Try
        Return returnImage
    End Function



    Private Function ArrayToString(ByVal bytes() As Byte, Optional ByVal format As String = Nothing) As String
        If bytes.Length = 0 Then Return String.Empty
        Dim sb As New System.Text.StringBuilder(bytes.Length * 4)
        For Each b As Byte In bytes
            sb.Append(b.ToString(format))
            sb.Append(","c)
        Next
        sb.Length -= 1
        Return sb.ToString()
    End Function


    Private Function StringToArray(ByVal s As String, Optional ByVal style As System.Globalization.NumberStyles = Nothing) As Byte()
        If s.Length = 0 Then Return New Byte() {}
        Dim values() As String = s.Split(","c)
        Dim bytes(values.Length - 1) As Byte
        For index As Integer = 0 To values.Length - 1
            bytes(index) = Byte.Parse(values(index), style)
        Next
        Return bytes
    End Function

    'Ejemplo Imagen a String-->
    Dim strImage As String = ""



    Private Sub lblServidorSII_Click(sender As Object, e As EventArgs) Handles lblServidorSII.Click

    End Sub

    Private Sub TLecturaCorreos_Tick(sender As Object, e As EventArgs) Handles TLecturaCorreos.Tick

    End Sub

    Private Sub cmdDirectorioFacturista_Click_1(sender As Object, e As EventArgs) Handles cmdDirectorioFacturista.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DialogoDirectorio.ShowDialog()
        txtDirectorioTimbres.Text = DialogoDirectorio.SelectedPath
    End Sub

    Private Sub CheckActivarProceso_CheckedChanged(sender As Object, e As EventArgs) Handles CheckActivarProceso.CheckedChanged
        If CheckActivarProceso.Checked = True Then
            TNuevosDTE.Enabled = True
        Else
            TNuevosDTE.Enabled = False
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
