<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionDTE
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
        Me.DGDocumentosRecibidos = New System.Windows.Forms.DataGridView()
        Me.cmdRechazar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdRefrescar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblEmpresaEmisora = New System.Windows.Forms.Label()
        CType(Me.DGDocumentosRecibidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGDocumentosRecibidos
        '
        Me.DGDocumentosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDocumentosRecibidos.Location = New System.Drawing.Point(23, 105)
        Me.DGDocumentosRecibidos.Name = "DGDocumentosRecibidos"
        Me.DGDocumentosRecibidos.Size = New System.Drawing.Size(888, 370)
        Me.DGDocumentosRecibidos.TabIndex = 6
        '
        'cmdRechazar
        '
        Me.cmdRechazar.Image = Global.NDTEChile.My.Resources.Resources.fileclose
        Me.cmdRechazar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdRechazar.Location = New System.Drawing.Point(246, 46)
        Me.cmdRechazar.Name = "cmdRechazar"
        Me.cmdRechazar.Size = New System.Drawing.Size(93, 53)
        Me.cmdRechazar.TabIndex = 9
        Me.cmdRechazar.Text = "Rechzar DTE"
        Me.cmdRechazar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRechazar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = Global.NDTEChile.My.Resources.Resources.verificacion32
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(136, 46)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(93, 53)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "Aceptar DTE"
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = Global.NDTEChile.My.Resources.Resources.impresora32
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdImprimir.Location = New System.Drawing.Point(24, 46)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(93, 53)
        Me.cmdImprimir.TabIndex = 7
        Me.cmdImprimir.Text = "Imprimir DTE"
        Me.cmdImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.Image = Global.NDTEChile.My.Resources.Resources.refresh_32
        Me.cmdRefrescar.Location = New System.Drawing.Point(822, 46)
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(79, 53)
        Me.cmdRefrescar.TabIndex = 5
        Me.cmdRefrescar.Text = "Refrescar"
        Me.cmdRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRefrescar.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(35, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(139, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "RUT Empresa Emisora DTE"
        '
        'lblEmpresaEmisora
        '
        Me.lblEmpresaEmisora.AutoSize = True
        Me.lblEmpresaEmisora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaEmisora.ForeColor = System.Drawing.Color.Maroon
        Me.lblEmpresaEmisora.Location = New System.Drawing.Point(242, 9)
        Me.lblEmpresaEmisora.Name = "lblEmpresaEmisora"
        Me.lblEmpresaEmisora.Size = New System.Drawing.Size(163, 20)
        Me.lblEmpresaEmisora.TabIndex = 28
        Me.lblEmpresaEmisora.Text = "lblEmpresaEmisora"
        '
        'frmRecepcionDTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 487)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblEmpresaEmisora)
        Me.Controls.Add(Me.cmdRechazar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.DGDocumentosRecibidos)
        Me.Controls.Add(Me.cmdRefrescar)
        Me.Name = "frmRecepcionDTE"
        Me.Text = "Recepcion DTE"
        CType(Me.DGDocumentosRecibidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdRechazar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents DGDocumentosRecibidos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdRefrescar As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaEmisora As System.Windows.Forms.Label
End Class
