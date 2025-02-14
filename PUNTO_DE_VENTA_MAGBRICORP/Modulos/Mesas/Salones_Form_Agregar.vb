Imports System.Data.SqlClient

Public Class Salones_Form_Agregar
    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        agregarSalon()
    End Sub

    Sub agregarSalon()
        Try
            Dim cmd As New SqlCommand("agregarSalon", conexion)
            abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", TXT_NombreSalon.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            Mesas_Config.dibujarSalones()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            TXT_NombreSalon.SelectAll()
            TXT_NombreSalon.Focus()
        End Try
    End Sub

    Private Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Me.Dispose()
    End Sub
End Class