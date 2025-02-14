Imports System.Data.SqlClient

Public Class Mesas_Form_Agregar

    Public Property id_Mesa As Integer
    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        If (TXT_NombreMesa.Text IsNot "") Then
            editarMesa("editarMesa")
        Else
            MessageBox.Show("El campo nombre no puede estar vacio")
        End If
    End Sub

    Sub editarMesa(query As String)
        Try
            Dim cmd As New SqlCommand(query, conexion)
            abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Id_Mesa", id_Mesa)
            If (query = "editarMesa") Then
                cmd.Parameters.AddWithValue("@nombre", TXT_NombreMesa.Text)
            End If
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

    Private Sub BTN_Eliminar_Click(sender As Object, e As EventArgs) Handles BTN_Eliminar.Click
        editarMesa("eliminarMesa")
    End Sub

    Private Sub Mesas_Form_Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TXT_NombreMesa.Text IsNot "" Then
            BTN_Eliminar.Visible = False
        Else
            BTN_Eliminar.Visible = True
        End If
    End Sub
End Class