<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NDTEChile
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NDTEChile))
        Me.FSWDte = New System.IO.FileSystemWatcher()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckActivarProceso = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtDirectorioTimbres = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdDirectorioFacturista = New System.Windows.Forms.Button()
        Me.txtDirectorioLibFacturista = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtLibros = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSetDte = New System.Windows.Forms.TextBox()
        Me.cmdIniciarMonitor = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdDirectorioRespuestasSII = New System.Windows.Forms.Button()
        Me.txtRespuestasSII = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdDirectorioPDFProveedor = New System.Windows.Forms.Button()
        Me.cmdDirectorioXMLProveedor = New System.Windows.Forms.Button()
        Me.cmdDirectorioPDFClientes = New System.Windows.Forms.Button()
        Me.cmdDirectorioXMLCLIENTE = New System.Windows.Forms.Button()
        Me.cmdDirectorioXMLSII = New System.Windows.Forms.Button()
        Me.cmdDirectorioXMLDTE = New System.Windows.Forms.Button()
        Me.txtPDFCompras = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtXMLCompras = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPDFVentas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirmadoCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirmadoSII = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtXMLDte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPuertoPop = New System.Windows.Forms.TextBox()
        Me.txtServidorPop = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPuertoCorreo = New System.Windows.Forms.TextBox()
        Me.txtServidorCorreo = New System.Windows.Forms.TextBox()
        Me.txtContraseñaCorreo = New System.Windows.Forms.TextBox()
        Me.txtUsuarioCorreo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.lblCantidadEmpresas = New System.Windows.Forms.Label()
        Me.DgEmpresas = New System.Windows.Forms.DataGridView()
        Me.txtEmpresaEmisora = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblEmpresaEmisora = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optTermica = New System.Windows.Forms.RadioButton()
        Me.optCarta = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTFechaResolucion = New System.Windows.Forms.DateTimePicker()
        Me.txtNumResolucionSII = New System.Windows.Forms.TextBox()
        Me.txtRutEmisor = New System.Windows.Forms.TextBox()
        Me.cmdCargaCertificado = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtClaveCertificado = New System.Windows.Forms.TextBox()
        Me.txtCertiticado = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdDescargaDtes = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdCargaFolios = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.FBDBuscaDirectorio = New System.Windows.Forms.FolderBrowserDialog()
        Me.FSWPdf = New System.IO.FileSystemWatcher()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.menuFacturista = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuMinimizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.FSWFirmadoSII = New System.IO.FileSystemWatcher()
        Me.FSWRespuestasSII = New System.IO.FileSystemWatcher()
        Me.DialogoDirectorio = New System.Windows.Forms.FolderBrowserDialog()
        Me.DialogoArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.cmdOcultar = New System.Windows.Forms.Button()
        Me.FSWSET = New System.IO.FileSystemWatcher()
        Me.FSWLibros = New System.IO.FileSystemWatcher()
        Me.lblServidorSII = New System.Windows.Forms.Label()
        Me.TNuevosDTE = New System.Windows.Forms.Timer(Me.components)
        Me.TLecturaCorreos = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FSWDte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FSWPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuFacturista.SuspendLayout()
        CType(Me.FSWFirmadoSII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSWRespuestasSII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSWSET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSWLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FSWDte
        '
        Me.FSWDte.EnableRaisingEvents = True
        Me.FSWDte.Filter = "*.xml"
        Me.FSWDte.Path = "C:\"
        Me.FSWDte.SynchronizingObject = Me
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 537)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckActivarProceso)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.txtDirectorioTimbres)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.lblestado)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioFacturista)
        Me.TabPage1.Controls.Add(Me.txtDirectorioLibFacturista)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txtLibros)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtSetDte)
        Me.TabPage1.Controls.Add(Me.cmdIniciarMonitor)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioRespuestasSII)
        Me.TabPage1.Controls.Add(Me.txtRespuestasSII)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioPDFProveedor)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioXMLProveedor)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioPDFClientes)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioXMLCLIENTE)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioXMLSII)
        Me.TabPage1.Controls.Add(Me.cmdDirectorioXMLDTE)
        Me.TabPage1.Controls.Add(Me.txtPDFCompras)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtXMLCompras)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtPDFVentas)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtFirmadoCliente)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtFirmadoSII)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtXMLDte)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 511)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Directorios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckActivarProceso
        '
        Me.CheckActivarProceso.AutoSize = True
        Me.CheckActivarProceso.Checked = True
        Me.CheckActivarProceso.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckActivarProceso.Location = New System.Drawing.Point(675, 396)
        Me.CheckActivarProceso.Name = "CheckActivarProceso"
        Me.CheckActivarProceso.Size = New System.Drawing.Size(157, 17)
        Me.CheckActivarProceso.TabIndex = 39
        Me.CheckActivarProceso.Text = "Activar Procesamiento DTE"
        Me.CheckActivarProceso.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(514, 398)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(23, 20)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'txtDirectorioTimbres
        '
        Me.txtDirectorioTimbres.Location = New System.Drawing.Point(203, 396)
        Me.txtDirectorioTimbres.Name = "txtDirectorioTimbres"
        Me.txtDirectorioTimbres.Size = New System.Drawing.Size(311, 20)
        Me.txtDirectorioTimbres.TabIndex = 37
        Me.txtDirectorioTimbres.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(23, 403)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 13)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Directorio PNG Timbres"
        Me.Label23.Visible = False
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(203, 365)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(127, 18)
        Me.Label22.TabIndex = 35
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label22.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 365)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Tiempo lectura de correos"
        Me.Label18.Visible = False
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(643, 332)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(0, 13)
        Me.lblestado.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(687, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'cmdDirectorioFacturista
        '
        Me.cmdDirectorioFacturista.Location = New System.Drawing.Point(514, 332)
        Me.cmdDirectorioFacturista.Name = "cmdDirectorioFacturista"
        Me.cmdDirectorioFacturista.Size = New System.Drawing.Size(23, 20)
        Me.cmdDirectorioFacturista.TabIndex = 31
        Me.cmdDirectorioFacturista.Text = "..."
        Me.cmdDirectorioFacturista.UseVisualStyleBackColor = True
        Me.cmdDirectorioFacturista.Visible = False
        '
        'txtDirectorioLibFacturista
        '
        Me.txtDirectorioLibFacturista.Location = New System.Drawing.Point(203, 330)
        Me.txtDirectorioLibFacturista.Name = "txtDirectorioLibFacturista"
        Me.txtDirectorioLibFacturista.Size = New System.Drawing.Size(311, 20)
        Me.txtDirectorioLibFacturista.TabIndex = 30
        Me.txtDirectorioLibFacturista.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Ubicacion Facturista"
        Me.Label8.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(564, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 30)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Grabar Parametros Directorios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(516, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(517, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLibros
        '
        Me.txtLibros.Location = New System.Drawing.Point(205, 297)
        Me.txtLibros.Name = "txtLibros"
        Me.txtLibros.Size = New System.Drawing.Size(311, 20)
        Me.txtLibros.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(22, 300)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Directorio Libros CV"
        '
        'txtSetDte
        '
        Me.txtSetDte.Location = New System.Drawing.Point(206, 268)
        Me.txtSetDte.Name = "txtSetDte"
        Me.txtSetDte.Size = New System.Drawing.Size(311, 20)
        Me.txtSetDte.TabIndex = 23
        '
        'cmdIniciarMonitor
        '
        Me.cmdIniciarMonitor.Location = New System.Drawing.Point(235, 281)
        Me.cmdIniciarMonitor.Name = "cmdIniciarMonitor"
        Me.cmdIniciarMonitor.Size = New System.Drawing.Size(120, 29)
        Me.cmdIniciarMonitor.TabIndex = 18
        Me.cmdIniciarMonitor.Text = "Iniciar"
        Me.cmdIniciarMonitor.UseVisualStyleBackColor = True
        Me.cmdIniciarMonitor.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 271)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Directorio Set DTE"
        '
        'cmdDirectorioRespuestasSII
        '
        Me.cmdDirectorioRespuestasSII.Location = New System.Drawing.Point(517, 233)
        Me.cmdDirectorioRespuestasSII.Name = "cmdDirectorioRespuestasSII"
        Me.cmdDirectorioRespuestasSII.Size = New System.Drawing.Size(20, 20)
        Me.cmdDirectorioRespuestasSII.TabIndex = 21
        Me.cmdDirectorioRespuestasSII.Text = "..."
        Me.cmdDirectorioRespuestasSII.UseVisualStyleBackColor = True
        '
        'txtRespuestasSII
        '
        Me.txtRespuestasSII.Location = New System.Drawing.Point(206, 234)
        Me.txtRespuestasSII.Name = "txtRespuestasSII"
        Me.txtRespuestasSII.Size = New System.Drawing.Size(311, 20)
        Me.txtRespuestasSII.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Directorio Respuestas SII"
        '
        'cmdDirectorioPDFProveedor
        '
        Me.cmdDirectorioPDFProveedor.Location = New System.Drawing.Point(516, 203)
        Me.cmdDirectorioPDFProveedor.Name = "cmdDirectorioPDFProveedor"
        Me.cmdDirectorioPDFProveedor.Size = New System.Drawing.Size(20, 20)
        Me.cmdDirectorioPDFProveedor.TabIndex = 17
        Me.cmdDirectorioPDFProveedor.Text = "..."
        Me.cmdDirectorioPDFProveedor.UseVisualStyleBackColor = True
        '
        'cmdDirectorioXMLProveedor
        '
        Me.cmdDirectorioXMLProveedor.Location = New System.Drawing.Point(516, 167)
        Me.cmdDirectorioXMLProveedor.Name = "cmdDirectorioXMLProveedor"
        Me.cmdDirectorioXMLProveedor.Size = New System.Drawing.Size(20, 20)
        Me.cmdDirectorioXMLProveedor.TabIndex = 16
        Me.cmdDirectorioXMLProveedor.Text = "..."
        Me.cmdDirectorioXMLProveedor.UseVisualStyleBackColor = True
        '
        'cmdDirectorioPDFClientes
        '
        Me.cmdDirectorioPDFClientes.Location = New System.Drawing.Point(516, 129)
        Me.cmdDirectorioPDFClientes.Name = "cmdDirectorioPDFClientes"
        Me.cmdDirectorioPDFClientes.Size = New System.Drawing.Size(20, 20)
        Me.cmdDirectorioPDFClientes.TabIndex = 15
        Me.cmdDirectorioPDFClientes.Text = "..."
        Me.cmdDirectorioPDFClientes.UseVisualStyleBackColor = True
        '
        'cmdDirectorioXMLCLIENTE
        '
        Me.cmdDirectorioXMLCLIENTE.Location = New System.Drawing.Point(516, 92)
        Me.cmdDirectorioXMLCLIENTE.Name = "cmdDirectorioXMLCLIENTE"
        Me.cmdDirectorioXMLCLIENTE.Size = New System.Drawing.Size(20, 20)
        Me.cmdDirectorioXMLCLIENTE.TabIndex = 14
        Me.cmdDirectorioXMLCLIENTE.Text = "..."
        Me.cmdDirectorioXMLCLIENTE.UseVisualStyleBackColor = True
        '
        'cmdDirectorioXMLSII
        '
        Me.cmdDirectorioXMLSII.Location = New System.Drawing.Point(516, 59)
        Me.cmdDirectorioXMLSII.Name = "cmdDirectorioXMLSII"
        Me.cmdDirectorioXMLSII.Size = New System.Drawing.Size(20, 20)
        Me.cmdDirectorioXMLSII.TabIndex = 13
        Me.cmdDirectorioXMLSII.Text = "..."
        Me.cmdDirectorioXMLSII.UseVisualStyleBackColor = True
        '
        'cmdDirectorioXMLDTE
        '
        Me.cmdDirectorioXMLDTE.Location = New System.Drawing.Point(516, 26)
        Me.cmdDirectorioXMLDTE.Name = "cmdDirectorioXMLDTE"
        Me.cmdDirectorioXMLDTE.Size = New System.Drawing.Size(20, 20)
        Me.cmdDirectorioXMLDTE.TabIndex = 12
        Me.cmdDirectorioXMLDTE.Text = "..."
        Me.cmdDirectorioXMLDTE.UseVisualStyleBackColor = True
        '
        'txtPDFCompras
        '
        Me.txtPDFCompras.Location = New System.Drawing.Point(205, 204)
        Me.txtPDFCompras.Name = "txtPDFCompras"
        Me.txtPDFCompras.Size = New System.Drawing.Size(311, 20)
        Me.txtPDFCompras.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Directorio PDF Proveedores"
        '
        'txtXMLCompras
        '
        Me.txtXMLCompras.Location = New System.Drawing.Point(203, 167)
        Me.txtXMLCompras.Name = "txtXMLCompras"
        Me.txtXMLCompras.Size = New System.Drawing.Size(311, 20)
        Me.txtXMLCompras.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Directorio XML Proveedores"
        '
        'txtPDFVentas
        '
        Me.txtPDFVentas.Location = New System.Drawing.Point(203, 130)
        Me.txtPDFVentas.Name = "txtPDFVentas"
        Me.txtPDFVentas.Size = New System.Drawing.Size(311, 20)
        Me.txtPDFVentas.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Directorio DTE PDFs Ventas"
        '
        'txtFirmadoCliente
        '
        Me.txtFirmadoCliente.Location = New System.Drawing.Point(203, 92)
        Me.txtFirmadoCliente.Name = "txtFirmadoCliente"
        Me.txtFirmadoCliente.Size = New System.Drawing.Size(311, 20)
        Me.txtFirmadoCliente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Directorio DTE Firmado Cliente"
        '
        'txtFirmadoSII
        '
        Me.txtFirmadoSII.Location = New System.Drawing.Point(203, 59)
        Me.txtFirmadoSII.Name = "txtFirmadoSII"
        Me.txtFirmadoSII.Size = New System.Drawing.Size(311, 20)
        Me.txtFirmadoSII.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Directorio DTE Firmado SII"
        '
        'txtXMLDte
        '
        Me.txtXMLDte.Location = New System.Drawing.Point(203, 27)
        Me.txtXMLDte.Name = "txtXMLDte"
        Me.txtXMLDte.Size = New System.Drawing.Size(311, 20)
        Me.txtXMLDte.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directorio XML DTEs:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.cmdEliminar)
        Me.TabPage3.Controls.Add(Me.cmdGrabar)
        Me.TabPage3.Controls.Add(Me.lblCantidadEmpresas)
        Me.TabPage3.Controls.Add(Me.DgEmpresas)
        Me.TabPage3.Controls.Add(Me.txtEmpresaEmisora)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.lblEmpresaEmisora)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.DTFechaResolucion)
        Me.TabPage3.Controls.Add(Me.txtNumResolucionSII)
        Me.TabPage3.Controls.Add(Me.txtRutEmisor)
        Me.TabPage3.Controls.Add(Me.cmdCargaCertificado)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtClaveCertificado)
        Me.TabPage3.Controls.Add(Me.txtCertiticado)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1000, 511)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Parametros Empresas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPuertoPop)
        Me.GroupBox4.Controls.Add(Me.txtServidorPop)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.txtPuertoCorreo)
        Me.GroupBox4.Controls.Add(Me.txtServidorCorreo)
        Me.GroupBox4.Controls.Add(Me.txtContraseñaCorreo)
        Me.GroupBox4.Controls.Add(Me.txtUsuarioCorreo)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Location = New System.Drawing.Point(513, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 176)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Correos"
        '
        'txtPuertoPop
        '
        Me.txtPuertoPop.Location = New System.Drawing.Point(113, 145)
        Me.txtPuertoPop.Name = "txtPuertoPop"
        Me.txtPuertoPop.Size = New System.Drawing.Size(213, 20)
        Me.txtPuertoPop.TabIndex = 37
        '
        'txtServidorPop
        '
        Me.txtServidorPop.Location = New System.Drawing.Point(113, 119)
        Me.txtServidorPop.Name = "txtServidorPop"
        Me.txtServidorPop.Size = New System.Drawing.Size(213, 20)
        Me.txtServidorPop.TabIndex = 36
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(24, 122)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 13)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Servidor POP"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(27, 148)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 13)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Puerto POP"
        '
        'txtPuertoCorreo
        '
        Me.txtPuertoCorreo.Location = New System.Drawing.Point(113, 91)
        Me.txtPuertoCorreo.Name = "txtPuertoCorreo"
        Me.txtPuertoCorreo.Size = New System.Drawing.Size(213, 20)
        Me.txtPuertoCorreo.TabIndex = 33
        '
        'txtServidorCorreo
        '
        Me.txtServidorCorreo.Location = New System.Drawing.Point(113, 65)
        Me.txtServidorCorreo.Name = "txtServidorCorreo"
        Me.txtServidorCorreo.Size = New System.Drawing.Size(213, 20)
        Me.txtServidorCorreo.TabIndex = 32
        '
        'txtContraseñaCorreo
        '
        Me.txtContraseñaCorreo.Location = New System.Drawing.Point(114, 41)
        Me.txtContraseñaCorreo.Name = "txtContraseñaCorreo"
        Me.txtContraseñaCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaCorreo.Size = New System.Drawing.Size(213, 20)
        Me.txtContraseñaCorreo.TabIndex = 31
        '
        'txtUsuarioCorreo
        '
        Me.txtUsuarioCorreo.Location = New System.Drawing.Point(113, 16)
        Me.txtUsuarioCorreo.Name = "txtUsuarioCorreo"
        Me.txtUsuarioCorreo.Size = New System.Drawing.Size(213, 20)
        Me.txtUsuarioCorreo.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Servidor SMTP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Contrasseña"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Usuario"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Puerto SMTP"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(238, 215)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(142, 24)
        Me.cmdEliminar.TabIndex = 32
        Me.cmdEliminar.Text = "Eliminar Empresa"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Location = New System.Drawing.Point(49, 215)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(142, 24)
        Me.cmdGrabar.TabIndex = 31
        Me.cmdGrabar.Text = "Grabar/Modificar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'lblCantidadEmpresas
        '
        Me.lblCantidadEmpresas.AutoSize = True
        Me.lblCantidadEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadEmpresas.ForeColor = System.Drawing.Color.Maroon
        Me.lblCantidadEmpresas.Location = New System.Drawing.Point(741, 472)
        Me.lblCantidadEmpresas.Name = "lblCantidadEmpresas"
        Me.lblCantidadEmpresas.Size = New System.Drawing.Size(179, 20)
        Me.lblCantidadEmpresas.TabIndex = 30
        Me.lblCantidadEmpresas.Text = "lblCantidadEmpresas"
        '
        'DgEmpresas
        '
        Me.DgEmpresas.AllowUserToAddRows = False
        Me.DgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEmpresas.Location = New System.Drawing.Point(18, 276)
        Me.DgEmpresas.Name = "DgEmpresas"
        Me.DgEmpresas.Size = New System.Drawing.Size(959, 182)
        Me.DgEmpresas.TabIndex = 29
        '
        'txtEmpresaEmisora
        '
        Me.txtEmpresaEmisora.Location = New System.Drawing.Point(182, 22)
        Me.txtEmpresaEmisora.Name = "txtEmpresaEmisora"
        Me.txtEmpresaEmisora.Size = New System.Drawing.Size(194, 20)
        Me.txtEmpresaEmisora.TabIndex = 28
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(25, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(139, 13)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "RUT Empresa Emisora DTE"
        '
        'lblEmpresaEmisora
        '
        Me.lblEmpresaEmisora.AutoSize = True
        Me.lblEmpresaEmisora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaEmisora.ForeColor = System.Drawing.Color.Maroon
        Me.lblEmpresaEmisora.Location = New System.Drawing.Point(28, 184)
        Me.lblEmpresaEmisora.Name = "lblEmpresaEmisora"
        Me.lblEmpresaEmisora.Size = New System.Drawing.Size(163, 20)
        Me.lblEmpresaEmisora.TabIndex = 26
        Me.lblEmpresaEmisora.Text = "lblEmpresaEmisora"
        Me.lblEmpresaEmisora.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optTermica)
        Me.GroupBox1.Controls.Add(Me.optCarta)
        Me.GroupBox1.Location = New System.Drawing.Point(690, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 52)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "impresion"
        '
        'optTermica
        '
        Me.optTermica.AutoSize = True
        Me.optTermica.Location = New System.Drawing.Point(118, 19)
        Me.optTermica.Name = "optTermica"
        Me.optTermica.Size = New System.Drawing.Size(112, 17)
        Me.optTermica.TabIndex = 1
        Me.optTermica.Text = "Impresora Termica"
        Me.optTermica.UseVisualStyleBackColor = True
        '
        'optCarta
        '
        Me.optCarta.AutoSize = True
        Me.optCarta.Checked = True
        Me.optCarta.Location = New System.Drawing.Point(22, 20)
        Me.optCarta.Name = "optCarta"
        Me.optCarta.Size = New System.Drawing.Size(50, 17)
        Me.optCarta.TabIndex = 0
        Me.optCarta.TabStop = True
        Me.optCarta.Text = "Carta"
        Me.optCarta.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(400, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Fecha Resolución SII"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(393, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Numero Resolución SII"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Rut Emisor Autorizado"
        '
        'DTFechaResolucion
        '
        Me.DTFechaResolucion.CustomFormat = "dd-MM-yyyy"
        Me.DTFechaResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaResolucion.Location = New System.Drawing.Point(522, 48)
        Me.DTFechaResolucion.Name = "DTFechaResolucion"
        Me.DTFechaResolucion.Size = New System.Drawing.Size(143, 20)
        Me.DTFechaResolucion.TabIndex = 15
        '
        'txtNumResolucionSII
        '
        Me.txtNumResolucionSII.Location = New System.Drawing.Point(522, 19)
        Me.txtNumResolucionSII.Name = "txtNumResolucionSII"
        Me.txtNumResolucionSII.Size = New System.Drawing.Size(109, 20)
        Me.txtNumResolucionSII.TabIndex = 13
        '
        'txtRutEmisor
        '
        Me.txtRutEmisor.Location = New System.Drawing.Point(182, 50)
        Me.txtRutEmisor.Name = "txtRutEmisor"
        Me.txtRutEmisor.Size = New System.Drawing.Size(167, 20)
        Me.txtRutEmisor.TabIndex = 18
        '
        'cmdCargaCertificado
        '
        Me.cmdCargaCertificado.Location = New System.Drawing.Point(467, 79)
        Me.cmdCargaCertificado.Name = "cmdCargaCertificado"
        Me.cmdCargaCertificado.Size = New System.Drawing.Size(26, 19)
        Me.cmdCargaCertificado.TabIndex = 16
        Me.cmdCargaCertificado.Text = "..."
        Me.cmdCargaCertificado.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Contraseña"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Certificado"
        '
        'txtClaveCertificado
        '
        Me.txtClaveCertificado.Location = New System.Drawing.Point(182, 107)
        Me.txtClaveCertificado.Name = "txtClaveCertificado"
        Me.txtClaveCertificado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveCertificado.Size = New System.Drawing.Size(249, 20)
        Me.txtClaveCertificado.TabIndex = 10
        '
        'txtCertiticado
        '
        Me.txtCertiticado.Location = New System.Drawing.Point(182, 79)
        Me.txtCertiticado.Name = "txtCertiticado"
        Me.txtCertiticado.Size = New System.Drawing.Size(290, 20)
        Me.txtCertiticado.TabIndex = 8
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1000, 511)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Opciones Facturador"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdDescargaDtes)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 64)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descarga de DTEs Emitidos a Empresa"
        '
        'cmdDescargaDtes
        '
        Me.cmdDescargaDtes.Location = New System.Drawing.Point(31, 27)
        Me.cmdDescargaDtes.Name = "cmdDescargaDtes"
        Me.cmdDescargaDtes.Size = New System.Drawing.Size(134, 23)
        Me.cmdDescargaDtes.TabIndex = 0
        Me.cmdDescargaDtes.Text = "Lectura de DTEs"
        Me.cmdDescargaDtes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdCargaFolios)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 64)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Carga de Folios SII"
        '
        'cmdCargaFolios
        '
        Me.cmdCargaFolios.Location = New System.Drawing.Point(31, 25)
        Me.cmdCargaFolios.Name = "cmdCargaFolios"
        Me.cmdCargaFolios.Size = New System.Drawing.Size(134, 23)
        Me.cmdCargaFolios.TabIndex = 0
        Me.cmdCargaFolios.Text = "Carga de Folios"
        Me.cmdCargaFolios.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(713, 571)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 29)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        Me.cmdSalir.Visible = False
        '
        'FSWPdf
        '
        Me.FSWPdf.EnableRaisingEvents = True
        Me.FSWPdf.Filter = "*.xml"
        Me.FSWPdf.SynchronizingObject = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Integración NDTEChile"
        Me.NotifyIcon1.ContextMenuStrip = Me.menuFacturista
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NDTEChile"
        Me.NotifyIcon1.Visible = True
        '
        'menuFacturista
        '
        Me.menuFacturista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMinimizar})
        Me.menuFacturista.Name = "menuFacturista"
        Me.menuFacturista.Size = New System.Drawing.Size(194, 26)
        '
        'mnuMinimizar
        '
        Me.mnuMinimizar.Name = "mnuMinimizar"
        Me.mnuMinimizar.Size = New System.Drawing.Size(193, 22)
        Me.mnuMinimizar.Text = "&Minimizar a la bandeja"
        '
        'FSWFirmadoSII
        '
        Me.FSWFirmadoSII.EnableRaisingEvents = True
        Me.FSWFirmadoSII.Path = "C:\"
        Me.FSWFirmadoSII.SynchronizingObject = Me
        '
        'FSWRespuestasSII
        '
        Me.FSWRespuestasSII.EnableRaisingEvents = True
        Me.FSWRespuestasSII.Path = "c:\"
        Me.FSWRespuestasSII.SynchronizingObject = Me
        '
        'DialogoArchivo
        '
        Me.DialogoArchivo.FileName = "OpenFileDialog1"
        '
        'cmdOcultar
        '
        Me.cmdOcultar.Location = New System.Drawing.Point(870, 571)
        Me.cmdOcultar.Name = "cmdOcultar"
        Me.cmdOcultar.Size = New System.Drawing.Size(123, 28)
        Me.cmdOcultar.TabIndex = 22
        Me.cmdOcultar.Text = "Ocultar"
        Me.cmdOcultar.UseVisualStyleBackColor = True
        '
        'FSWSET
        '
        Me.FSWSET.EnableRaisingEvents = True
        Me.FSWSET.Filter = "*.xml"
        Me.FSWSET.Path = "C:\"
        Me.FSWSET.SynchronizingObject = Me
        '
        'FSWLibros
        '
        Me.FSWLibros.EnableRaisingEvents = True
        Me.FSWLibros.Filter = "*.xml"
        Me.FSWLibros.Path = "C:\"
        Me.FSWLibros.SynchronizingObject = Me
        '
        'lblServidorSII
        '
        Me.lblServidorSII.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServidorSII.ForeColor = System.Drawing.Color.Red
        Me.lblServidorSII.Location = New System.Drawing.Point(252, 579)
        Me.lblServidorSII.Name = "lblServidorSII"
        Me.lblServidorSII.Size = New System.Drawing.Size(440, 24)
        Me.lblServidorSII.TabIndex = 23
        Me.lblServidorSII.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TNuevosDTE
        '
        Me.TNuevosDTE.Interval = 3000
        '
        'TLecturaCorreos
        '
        '
        'NDTEChile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 611)
        Me.Controls.Add(Me.lblServidorSII)
        Me.Controls.Add(Me.cmdOcultar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NDTEChile"
        Me.Text = "0 "
        CType(Me.FSWDte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.FSWPdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuFacturista.ResumeLayout(False)
        CType(Me.FSWFirmadoSII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSWRespuestasSII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSWSET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSWLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FSWDte As System.IO.FileSystemWatcher
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdDirectorioPDFProveedor As System.Windows.Forms.Button
    Friend WithEvents cmdDirectorioXMLProveedor As System.Windows.Forms.Button
    Friend WithEvents cmdDirectorioPDFClientes As System.Windows.Forms.Button
    Friend WithEvents cmdDirectorioXMLCLIENTE As System.Windows.Forms.Button
    Friend WithEvents cmdDirectorioXMLSII As System.Windows.Forms.Button
    Friend WithEvents cmdDirectorioXMLDTE As System.Windows.Forms.Button
    Friend WithEvents txtPDFCompras As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtXMLCompras As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPDFVentas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFirmadoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirmadoSII As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtXMLDte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FBDBuscaDirectorio As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTFechaResolucion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumResolucionSII As System.Windows.Forms.TextBox
    Friend WithEvents txtRutEmisor As System.Windows.Forms.TextBox
    Friend WithEvents cmdCargaCertificado As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtClaveCertificado As System.Windows.Forms.TextBox
    Friend WithEvents txtCertiticado As System.Windows.Forms.TextBox
    Friend WithEvents FSWPdf As System.IO.FileSystemWatcher
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents menuFacturista As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuMinimizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdIniciarMonitor As System.Windows.Forms.Button
    Friend WithEvents FSWFirmadoSII As System.IO.FileSystemWatcher
    Friend WithEvents cmdDirectorioRespuestasSII As System.Windows.Forms.Button
    Friend WithEvents txtRespuestasSII As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FSWRespuestasSII As System.IO.FileSystemWatcher
    Friend WithEvents DialogoDirectorio As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DialogoArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdOcultar As System.Windows.Forms.Button
    Friend WithEvents txtLibros As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSetDte As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents FSWSET As System.IO.FileSystemWatcher
    Friend WithEvents FSWLibros As System.IO.FileSystemWatcher
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optTermica As System.Windows.Forms.RadioButton
    Friend WithEvents optCarta As System.Windows.Forms.RadioButton
    Friend WithEvents lblServidorSII As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDescargaDtes As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCargaFolios As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaEmisora As System.Windows.Forms.Label
    Friend WithEvents cmdDirectorioFacturista As System.Windows.Forms.Button
    Friend WithEvents txtDirectorioLibFacturista As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPuertoCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtServidorCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseñaCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents lblCantidadEmpresas As System.Windows.Forms.Label
    Friend WithEvents DgEmpresas As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmpresaEmisora As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TNuevosDTE As System.Windows.Forms.Timer
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TLecturaCorreos As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtDirectorioTimbres As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CheckActivarProceso As System.Windows.Forms.CheckBox
    Friend WithEvents txtPuertoPop As System.Windows.Forms.TextBox
    Friend WithEvents txtServidorPop As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label

End Class
