Imports capaEntidad

Public Class CNEmpleado
    Public Function validarDatos(ByVal empleado As CEEmpleados) As Boolean
        Dim Resultado As Boolean = True

        If empleado.Nombre = "" Then
            Resultado = False

            MessageBox.Show("El nombre es Obligatorio")
        End If

        If empleado.Apellido = "" Then
            Resultado = False
            MessageBox.Show("El Apellido es obligatorio")
        End If

        Return Resultado
    End Function
End Class
