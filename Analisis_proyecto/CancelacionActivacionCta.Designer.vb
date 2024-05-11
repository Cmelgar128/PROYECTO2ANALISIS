<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelacionActivacionCta
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnoCuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTransmitir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.boton
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(129, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 76)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtnoCuenta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(21, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 118)
        Me.Panel1.TabIndex = 18
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
        'txtnoCuenta
        '
        Me.txtnoCuenta.Location = New System.Drawing.Point(271, 45)
        Me.txtnoCuenta.Name = "txtnoCuenta"
        Me.txtnoCuenta.Size = New System.Drawing.Size(252, 22)
        Me.txtnoCuenta.TabIndex = 2
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(292, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "TRANSMITIR"
        '
        'btnTransmitir
        '
        Me.btnTransmitir.BackColor = System.Drawing.Color.Transparent
        Me.btnTransmitir.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.salvar
        Me.btnTransmitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTransmitir.Location = New System.Drawing.Point(293, 289)
        Me.btnTransmitir.Name = "btnTransmitir"
        Me.btnTransmitir.Size = New System.Drawing.Size(89, 80)
        Me.btnTransmitir.TabIndex = 19
        Me.btnTransmitir.UseVisualStyleBackColor = False
        '
        'CancelacionActivacionCta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(738, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnTransmitir)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CancelacionActivacionCta"
        Me.Text = "CancelacionActivacionCta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnoCuenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnTransmitir As Button
End Class
