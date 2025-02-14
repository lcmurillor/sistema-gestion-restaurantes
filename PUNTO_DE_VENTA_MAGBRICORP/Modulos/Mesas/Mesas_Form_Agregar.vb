Imports System.Data.SqlClient

Public Class Mesas_Form_Agregar

    Public Property id_Mesa As Integer
    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        editarMesa()
    End Sub

    Sub editarMesa()
        Try
            Dim cmd As New SqlCommand("editarMesa", conexion)
            abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_Mesa", id_Mesa)
            cmd.Parameters.AddWithValue("@nombre", TXT_NombreMesa.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            Mesas_Config.dibujarMesas()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            TXT_NombreMesa.SelectAll()
            TXT_NombreMesa.Focus()
        End Try
    End Sub

    Private Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Me.Dispose()
    End Sub
End Class