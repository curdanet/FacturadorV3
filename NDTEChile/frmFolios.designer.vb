<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFolios
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
        Me.DGFolios = New System.Windows.Forms.DataGridView()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.lblValorFinal = New System.Windows.Forms.Label()
        Me.lblValorInicial = New System.Windows.Forms.Label()
        Me.txtValorActual = New System.Windows.Forms.TextBox()
        Me.cmdBuscaCaf = New System.Windows.Forms.Button()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblValorFinal1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRUTFolios = New System.Windows.Forms.TextBox()
        CType(Me.DGFolios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGFolios
        '
        Me.DGFolios.AllowUserToAddRows = False
        Me.DGFolios.AllowUserToDeleteRows = False
        Me.DGFolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFolios.Location = New System.Drawing.Point(12, 244)
        Me.DGFolios.Name = "DGFolios"
        Me.DGFolios.Size = New System.Drawing.Size(723, 140)
        Me.DGFolios.TabIndex = 0
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(636, 405)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(83, 31)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRUTFolios)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdEliminar)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.CheckActivo)
        Me.GroupBox1.Controls.Add(Me.lblValorFinal)
        Me.GroupBox1.Controls.Add(Me.lblValorInicial)
        Me.GroupBox1.Controls.Add(Me.txtValorActual)
        Me.GroupBox1.Controls.Add(Me.cmdBuscaCaf)
        Me.GroupBox1.Controls.Add(Me.txtUbicacion)
        Me.GroupBox1.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblValorFinal1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 198)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga de Folios"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(574, 145)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(83, 31)
        Me.cmdEliminar.TabIndex = 13
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(470, 145)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(83, 31)
        Me.cmdAgregar.TabIndex = 12
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'CheckActivo
        '
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(263, 152)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(56, 17)
        Me.CheckActivo.TabIndex = 11
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'lblValorFinal
        '
        Me.lblValorFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValorFinal.Location = New System.Drawing.Point(133, 152)
        Me.lblValorFinal.Name = "lblValorFinal"
        Me.lblValorFinal.Size = New System.Drawing.Size(100, 15)
        Me.lblValorFinal.TabIndex = 10
        Me.lblValorFinal.Text = "Label6"
        Me.lblValorFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorInicial
        '
        Me.lblValorInicial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValorInicial.Location = New System.Drawing.Point(133, 128)
        Me.lblValorInicial.Name = "lblValorInicial"
        Me.lblValorInicial.Size = New System.Drawing.Size(100, 13)
        Me.lblValorInicial.TabIndex = 9
        Me.lblValorInicial.Text = "Label6"
        Me.lblValorInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValorActual
        '
        Me.txtValorActual.Location = New System.Drawing.Point(134, 101)
        Me.txtValorActual.Name = "txtValorActual"
        Me.txtValorActual.Size = New System.Drawing.Size(100, 20)
        Me.txtValorActual.TabIndex = 8
        Me.txtValorActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdBuscaCaf
        '
        Me.cmdBuscaCaf.Location = New System.Drawing.Point(507, 74)
        Me.cmdBuscaCaf.Name = "cmdBuscaCaf"
        Me.cmdBuscaCaf.Size = New System.Drawing.Size(29, 23)
        Me.cmdBuscaCaf.TabIndex = 7
        Me.cmdBuscaCaf.Text = "..."
        Me.cmdBuscaCaf.UseVisualStyleBackColor = True
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(132, 75)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(379, 20)
        Me.txtUbicacion.TabIndex = 6
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Items.AddRange(New Object() {"", "Factura Electronica", "Factura Exenta Electronica", "Nota de Credito Electronica", "Nota de Debito Electronica ", "Guia de Despacho Electronica", "Boleta Electronica", "Boleta Exenta Electronica"})
        Me.cboTipoDocumento.Location = New System.Drawing.Point(132, 49)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(187, 21)
        Me.cboTipoDocumento.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ubicacion"
        '
        'lblValorFinal1
        '
        Me.lblValorFinal1.AutoSize = True
        Me.lblValorFinal1.Location = New System.Drawing.Point(22, 154)
        Me.lblValorFinal1.Name = "lblValorFinal1"
        Me.lblValorFinal1.Size = New System.Drawing.Size(56, 13)
        Me.lblValorFinal1.TabIndex = 2
        Me.lblValorFinal1.Text = "Valor Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor actual"
        '
        'OFD
        '
        Me.OFD.Filter = "Archivos de Folios|*.xml"
        Me.OFD.Title = "Abrir archivo de folios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "RUT Folios"
        '
        'txtRUTFolios
        '
        Me.txtRUTFolios.Location = New System.Drawing.Point(134, 19)
        Me.txtRUTFolios.Name = "txtRUTFolios"
        Me.txtRUTFolios.Size = New System.Drawing.Size(158, 20)
        Me.txtRUTFolios.TabIndex = 15
        '
        'frmFolios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(747, 448)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.DGFolios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFolios"
        Me.Text = "Carga de Folios"
        CType(Me.DGFolios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGFolios As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblValorFinal As System.Windows.Forms.Label
    Friend WithEvents lblValorInicial As System.Windows.Forms.Label
    Friend WithEvents txtValorActual As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscaCaf As System.Windows.Forms.Button
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblValorFinal1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtRUTFolios As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
