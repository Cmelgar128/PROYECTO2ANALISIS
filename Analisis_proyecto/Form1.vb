Imports Oracle.ManagedDataAccess.Client

Public Class Form1

    Private Sub inicio_Click(sender As Object, e As EventArgs) Handles inicio.Click
        Dim user As String = usuarioo.Text
        Dim pass As String = passwordd.Text

        ' Cadena de conexión a la base de datos Oracle

        Using conn As New OracleConnection(My.Settings.Conexion)
            Try
                ' Abrir la conexión
                conn.Open()

                ' Consulta SQL para verificar las credenciales del usuario
                Dim query As String = "select * from login where usuario='" & user & "' and pass='" & pass & "'"

                ' Ejecutar la consulta y obtener el resultado
                Dim command2 As New OracleCommand(query, conn)
                Dim reader As OracleDataReader = command2.ExecuteReader()

                ' Verificar si se encontró algún registro
                If reader.Read() Then
                    ' Si se encontró un registro, significa que las credenciales son correctas
                    MessageBox.Show("Inicio de sesión exitoso.")
                    InterfazBanco.Show()
                    ' Aquí puedes redirigir al usuario a la página principal de tu aplicación
                Else
                    ' Si no se encontró ningún registro, las credenciales son incorrectas
                    MessageBox.Show("Usuario o contraseña incorrectos.")
                End If
                'End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class