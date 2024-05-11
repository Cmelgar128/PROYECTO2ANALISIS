<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InterfazBanco
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaBancariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreacionCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarTransaccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreacionUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CuentaBancariaToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearClienteToolStripMenuItem, Me.ModificacionClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(27, 26)
        Me.ClientesToolStripMenuItem.Text = " "
        '
        'CrearClienteToolStripMenuItem
        '
        Me.CrearClienteToolStripMenuItem.Name = "CrearClienteToolStripMenuItem"
        Me.CrearClienteToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.CrearClienteToolStripMenuItem.Text = "Crear Cliente"
        '
        'ModificacionClienteToolStripMenuItem
        '
        Me.ModificacionClienteToolStripMenuItem.Name = "ModificacionClienteToolStripMenuItem"
        Me.ModificacionClienteToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ModificacionClienteToolStripMenuItem.Text = "Modificacion Cliente"
        '
        'CuentaBancariaToolStripMenuItem
        '
        Me.CuentaBancariaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreacionCuentaToolStripMenuItem, Me.ModificacionCuentaToolStripMenuItem})
        Me.CuentaBancariaToolStripMenuItem.Name = "CuentaBancariaToolStripMenuItem"
        Me.CuentaBancariaToolStripMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.CuentaBancariaToolStripMenuItem.Text = "BANCO"
        '
        'CreacionCuentaToolStripMenuItem
        '
        Me.CreacionCuentaToolStripMenuItem.Name = "CreacionCuentaToolStripMenuItem"
        Me.CreacionCuentaToolStripMenuItem.Size = New System.Drawing.Size(333, 26)
        Me.CreacionCuentaToolStripMenuItem.Text = "Apertura Cuenta"
        '
        'ModificacionCuentaToolStripMenuItem
        '
        Me.ModificacionCuentaToolStripMenuItem.Name = "ModificacionCuentaToolStripMenuItem"
        Me.ModificacionCuentaToolStripMenuItem.Size = New System.Drawing.Size(333, 26)
        Me.ModificacionCuentaToolStripMenuItem.Text = "Cancelacion o Activacion de Cuenta "
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarTransaccionToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'RealizarTransaccionToolStripMenuItem
        '
        Me.RealizarTransaccionToolStripMenuItem.Name = "RealizarTransaccionToolStripMenuItem"
        Me.RealizarTransaccionToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.RealizarTransaccionToolStripMenuItem.Text = "Realizar Transaccion"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreacionUsuarioToolStripMenuItem, Me.ModificarUsuarioToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'CreacionUsuarioToolStripMenuItem
        '
        Me.CreacionUsuarioToolStripMenuItem.Name = "CreacionUsuarioToolStripMenuItem"
        Me.CreacionUsuarioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CreacionUsuarioToolStripMenuItem.Text = "Creacion Usuario"
        '
        'ModificarUsuarioToolStripMenuItem
        '
        Me.ModificarUsuarioToolStripMenuItem.Name = "ModificarUsuarioToolStripMenuItem"
        Me.ModificarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ModificarUsuarioToolStripMenuItem.Text = "Modificar Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(687, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cerrar Sesion"
        '
        'InterfazBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.Analisis_proyecto.My.Resources.Resources.LIBERTY
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 511)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InterfazBanco"
        Me.Text = "InterfazBanco"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificacionClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentaBancariaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreacionCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificacionCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarTransaccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreacionUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
