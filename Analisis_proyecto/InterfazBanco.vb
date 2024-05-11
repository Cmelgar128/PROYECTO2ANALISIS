Public Class InterfazBanco
    Private Sub CreacionCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionCuentaToolStripMenuItem.Click
        AperturaCta.Show()
    End Sub

    Private Sub ModificacionCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionCuentaToolStripMenuItem.Click
        CancelacionActivacionCta.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class