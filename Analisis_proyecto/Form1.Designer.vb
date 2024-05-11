<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.usuarioo = New System.Windows.Forms.TextBox()
        Me.passwordd = New System.Windows.Forms.TextBox()
        Me.inicio = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'usuarioo
        '
        Me.usuarioo.Location = New System.Drawing.Point(114, 148)
        Me.usuarioo.Name = "usuarioo"
        Me.usuarioo.Size = New System.Drawing.Size(273, 22)
        Me.usuarioo.TabIndex = 0
        '
        'passwordd
        '
        Me.passwordd.Location = New System.Drawing.Point(114, 265)
        Me.passwordd.Name = "passwordd"
        Me.passwordd.Size = New System.Drawing.Size(273, 22)
        Me.passwordd.TabIndex = 1
        '
        'inicio
        '
        Me.inicio.Location = New System.Drawing.Point(126, 346)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(149, 35)
        Me.inicio.TabIndex = 2
        Me.inicio.Text = "TRANSMITIR"
        Me.inicio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 49)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INICIO DE SESION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.passwordd)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.inicio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.usuarioo)
        Me.Panel1.Location = New System.Drawing.Point(35, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 479)
        Me.Panel1.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.cerrar_con_llave
        Me.Panel3.Location = New System.Drawing.Point(15, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(72, 68)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.usuario
        Me.Panel2.Location = New System.Drawing.Point(16, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(71, 70)
        Me.Panel2.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents usuarioo As TextBox
    Friend WithEvents passwordd As TextBox
    Friend WithEvents inicio As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
