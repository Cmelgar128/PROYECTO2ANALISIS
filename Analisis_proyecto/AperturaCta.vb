Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Client
Imports System.Runtime.InteropServices
Imports System.Data

Public Class AperturaCta


#Region "VARIABLES"

#End Region

    Public Sub Limpiar()
        txtConsecutivo.Enabled = True
        txtNombre.Enabled = True
        txtApertura.Enabled = True
        txtnoCuenta.Text = ""
        txtConsecutivo.Text = ""
        txtNombre.Text = ""
        txtCliente.Text = ""
        txtApertura.Text = ""
        btnTransmitir.Enabled = True
    End Sub

    Private Sub buscar_cliente()
        Using conn As New OracleConnection(My.Settings.Conexion)
            Try
                conn.Open()

                'Dim consulta As String = ("select * from BAN_CLIENTES where cli_consecutivo = " & txtConsecutivo.Text & "")
                'Dim command As New OracleCommand(consulta, conn)
                'Dim reader As OracleDataReader = command.ExecuteReader()


                'If reader.Read() Then
                '    txtCliente.Text = reader("cli_nombre")
                'Else
                '    MessageBox.Show("CLIENTE NO EXISTE")
                '    txtCliente.Text = ""
                'End If


                Dim command As New OracleCommand("sp_apertura_cta", conn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New OracleParameter("opcion", 2))
                command.Parameters.Add(New OracleParameter("cliente", txtConsecutivo.Text))
                command.Parameters.Add(New OracleParameter("nombre", ""))
                command.Parameters.Add(New OracleParameter("fechaApertura", ""))
                command.Parameters.Add(New OracleParameter("estado", ""))
                command.Parameters.Add(New OracleParameter("tipocta", ""))
                command.Parameters.Add(New OracleParameter("montoaper", 0))
                command.Parameters.Add(New OracleParameter("disponible", 0))

                Dim reader As OracleDataReader = command.ExecuteReader()
                If reader.Read() Then
                    txtCliente.Text = reader("cli_nombre")
                Else
                    MessageBox.Show("CLIENTE NO EXISTE")
                    txtCliente.Text = ""
                End If

            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub Apertura_Cuenta()
        Using conn As New OracleConnection(My.Settings.Conexion)
            Try

                conn.Open()

                'Dim consulta As String = ("INSERT INTO BAN_CUENTAS(cta_noCuenta,cta_cliente) VALUES (6," & txtConsecutivo.Text & ")")
                'Dim command As New OracleCommand(consulta, conn)
                Dim fecha As String
                fecha = Format(CDate(Date.Now), "dd/MM/yyyy")

                Dim command As New OracleCommand("sp_apertura_cta", conn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New OracleParameter("opcion", 1))
                command.Parameters.Add(New OracleParameter("cliente", txtConsecutivo.Text))
                command.Parameters.Add(New OracleParameter("nombre", txtNombre.Text))
                command.Parameters.Add(New OracleParameter("fechaApertura", fecha))
                command.Parameters.Add(New OracleParameter("estado", "A"))
                command.Parameters.Add(New OracleParameter("tipocta", cbTipoProducto.Text))
                command.Parameters.Add(New OracleParameter("montoaper", txtApertura.Text))
                command.Parameters.Add(New OracleParameter("disponible", txtApertura.Text))

                If command.ExecuteNonQuery() Then
                    MessageBox.Show("CUENTA APERTURADA")
                    btnTransmitir.Enabled = False

                    Dim consulta As String = ("select max(cta_noCuenta) from BAN_CUENTAS")
                    Dim command2 As New OracleCommand(consulta, conn)

                    Dim reader As OracleDataReader = command2.ExecuteReader()
                    If reader.Read() Then
                        txtnoCuenta.Text = reader("max(cta_noCuenta)")
                    Else
                        MessageBox.Show("NO EXISTE CTA")
                        txtnoCuenta.Text = ""
                    End If

                    txtConsecutivo.Enabled = False
                    txtApertura.Enabled = False
                    txtNombre.Enabled = False
                Else

                    MessageBox.Show("FALLO AL APERTURAR")
                End If

            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)

            End Try
        End Using

    End Sub

    Private Sub AperturaCta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCliente.Enabled = False
        txtnoCuenta.Enabled = False
        cbTipoProducto.Items.Add("AHORROS")
        cbTipoProducto.Items.Add("MONETARIOS")
        Limpiar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_cliente()
    End Sub

    Private Sub btnTransmitir_Click(sender As Object, e As EventArgs) Handles btnTransmitir.Click


        If (MessageBox.Show("¿Esta seguro de aperturar la cuenta?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes) Then

            If txtApertura.Text = "" Or txtConsecutivo.Text = "" Or txtCliente.Text = "" Or txtNombre.Text = "" Or cbTipoProducto.Text = "" Then
                MessageBox.Show("LLENE LOS CAMPOS OBLIGATORIOS")
            Else
                Apertura_Cuenta()
            End If
        End If

    End Sub

    Private Sub txtApertura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApertura.KeyPress
        'e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        'If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        '    MsgBox("AGREGAR MONTO VALIDO")
        'End If
        Dim cadena As String = txtApertura.Text
        Dim filtro As String = "1234567890"

        'If Len(cadena) = 0 Then
        '    filtro += "-"
        'End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            txtApertura.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            txtApertura.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class