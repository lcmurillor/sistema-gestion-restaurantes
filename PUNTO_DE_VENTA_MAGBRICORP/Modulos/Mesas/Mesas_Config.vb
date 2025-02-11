Imports System.Data.SqlClient


Public Class Mesas_Config

    Dim salonSelecioando As String


    Sub dibujarSalones()
        FLP_Salones.Controls.Clear()
        Try
            abrir()
            Dim query As String = "mostrarSalon"
            Dim cmd As New SqlCommand(query, conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", If(TXT_BuscarSalon.Text = "Buscar...", "", TXT_BuscarSalon.Text))

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                dibujarSalon(reader)
            End While
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub dibujarSalon(reader)
        Dim boton As New Button()
        Dim panelPrincipal As New Panel()
        Dim panelLateral As New Panel()

        boton.Text = reader("Nombre").ToString()
        boton.Name = reader("Id_Salon").ToString()
        boton.Dock = DockStyle.Fill
        boton.BackColor = Color.Transparent
        boton.Font = New System.Drawing.Font(10, 12)
        boton.FlatStyle = FlatStyle.Flat
        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64)
        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 43, 43)
        boton.ForeColor = Color.White
        boton.TextAlign = ContentAlignment.MiddleLeft

        panelPrincipal.Size = New System.Drawing.Size(349, 80)

        panelLateral.Size = New System.Drawing.Size(5, 80)
        panelLateral.Dock = DockStyle.Left

        If salonSelecioando = boton.Text Then
            panelLateral.BackColor = Color.OrangeRed
            boton.BackColor = Color.FromArgb(43, 43, 43)
        Else
            panelLateral.BackColor = Color.Transparent
            boton.BackColor = Color.Transparent
        End If

        panelPrincipal.Controls.Add(boton)
        panelPrincipal.Controls.Add(panelLateral)
        FLP_Salones.Controls.Add(panelPrincipal)

        boton.BringToFront()
        panelLateral.SendToBack()

        AddHandler boton.Click, AddressOf btnSalonEnvento

    End Sub

    Dim id_Salon As Integer
    Private Sub btnSalonEnvento(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            salonSelecioando = DirectCast(sender, Button).Text
            id_Salon = DirectCast(sender, Button).Name
            dibujarSalones()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TXT_BuscarSalon_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarSalon.TextChanged
        dibujarSalones()
    End Sub
End Class