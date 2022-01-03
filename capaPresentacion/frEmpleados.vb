Imports capaEntidad
Imports capaNegocio

Public Class frEmpleados
    Dim NegocioEmpleado As New CNEmpleado()
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim empleado As New CEEmpleados()

        Dim Validacion As Boolean

        empleado.Id = txtId.Value
        empleado.Nombre = txtNombre.Text
        empleado.Apellido = txtApellido.Text
        empleado.Foto = picFoto.ImageLocation

        Validacion = NegocioEmpleado.validarDatos(empleado)

        If Validacion = False Then Exit Sub

        MessageBox.Show("Guardar")

    End Sub
End Class
