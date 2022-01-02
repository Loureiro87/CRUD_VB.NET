Public Class frEmpleados
    Private Sub frEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnNombre_Click(sender As Object, e As EventArgs) Handles btnNombre.Click

        txtId.Value = 0
        txtNombre.Text = ""
        txtApellido.Text = ""
        picFoto.Image = Nothing

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub linkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkFoto.LinkClicked

        openFoto.ShowDialog()
        If openFoto.FileName <> "" Then
            picFoto.Load(openFoto.FileName)
        End If


        openFoto.FileName = ""

    End Sub
End Class
