<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AperturaCta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AperturaCta))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnoCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApertura = New System.Windows.Forms.TextBox()
        Me.txtConsecutivo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTransmitir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(267, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "No. Cuenta: "
        '
        'txtnoCuenta
        '
        Me.txtnoCuenta.Location = New System.Drawing.Point(271, 45)
        Me.txtnoCuenta.Name = "txtnoCuenta"
        Me.txtnoCuenta.Size = New System.Drawing.Size(252, 22)
        Me.txtnoCuenta.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "[Cliente:] "
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(171, 162)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(531, 22)
        Me.txtCliente.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "[Tipo Cuenta:]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nombre de la Cuenta:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(207, 193)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(495, 22)
        Me.txtNombre.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(370, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Monto Apertura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(36, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LIMPIAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(148, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SALIR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 16)
        Me.Label9.TabIndex = 15
        '
        'cbTipoProducto
        '
        Me.cbTipoProducto.FormattingEnabled = True
        Me.cbTipoProducto.Location = New System.Drawing.Point(149, 225)
        Me.cbTipoProducto.Name = "cbTipoProducto"
        Me.cbTipoProducto.Size = New System.Drawing.Size(215, 24)
        Me.cbTipoProducto.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.txtnoCuenta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(19, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 118)
        Me.Panel1.TabIndex = 17
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.limpiar__1_
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Location = New System.Drawing.Point(25, 10)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(76, 76)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.boton
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Location = New System.Drawing.Point(129, 10)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 76)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(301, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "TRANSMITIR"
        '
        'txtApertura
        '
        Me.txtApertura.Location = New System.Drawing.Point(521, 227)
        Me.txtApertura.Name = "txtApertura"
        Me.txtApertura.Size = New System.Drawing.Size(181, 22)
        Me.txtApertura.TabIndex = 19
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(19, 162)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Size = New System.Drawing.Size(102, 22)
        Me.txtConsecutivo.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.proximo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(127, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 31)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTransmitir
        '
        Me.btnTransmitir.BackColor = System.Drawing.Color.Transparent
        Me.btnTransmitir.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.salvar
        Me.btnTransmitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTransmitir.Location = New System.Drawing.Point(302, 276)
        Me.btnTransmitir.Name = "btnTransmitir"
        Me.btnTransmitir.Size = New System.Drawing.Size(89, 80)
        Me.btnTransmitir.TabIndex = 13
        Me.btnTransmitir.UseVisualStyleBackColor = False
        '
        'AperturaCta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 389)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtConsecutivo)
        Me.Controls.Add(Me.txtApertura)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbTipoProducto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnTransmitir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AperturaCta"
        Me.Text = "Apertura Cuenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnoCuenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTransmitir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTipoProducto As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtApertura As TextBox
    Friend WithEvents txtConsecutivo As TextBox
    Friend WithEvents Button1 As Button
End Class
