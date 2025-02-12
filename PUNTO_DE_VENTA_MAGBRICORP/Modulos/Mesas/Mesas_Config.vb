Imports System.Data.SqlClient

Public Class Mesas_Config

    Dim salonSeleccionado As String = ""
    Dim id_Salon As Integer = 0

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

    Sub dibujarSalon(reader As SqlDataReader)
        Dim boton As New Button()
        Dim panelPrincipal As New Panel()
        Dim panelLateral As New Panel()

        boton.Text = If(Not IsDBNull(reader("Nombre")), reader("Nombre").ToString(), "Sin Nombre")
        boton.Name = If(Not IsDBNull(reader("Id_Salon")), reader("Id_Salon").ToString(), "0")
        boton.Dock = DockStyle.Fill
        boton.BackColor = Color.Transparent
        boton.Font = New System.Drawing.Font("Arial", 12)
        boton.FlatStyle = FlatStyle.Flat
        boton.FlatAppearance.BorderSize = 0
        'boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64)
        'boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 43, 43)
        boton.TextAlign = ContentAlignment.MiddleLeft



        panelPrincipal.Size = New System.Drawing.Size(FLP_Salones.ClientSize.Width * 0.9, FLP_Salones.ClientSize.Height * 0.15)
        panelPrincipal.Tag = boton.Name ' Guardamos el ID del salón en el panel

        ' Configuración del panel lateral
        panelLateral.Size = New System.Drawing.Size(panelPrincipal.ClientSize.Width * 0.01, FLP_Salones.ClientSize.Height)
        panelLateral.Dock = DockStyle.Left

        panelPrincipal.Controls.Add(boton)
        panelPrincipal.Controls.Add(panelLateral)
        FLP_Salones.Controls.Add(panelPrincipal)

        boton.BringToFront()
        panelLateral.SendToBack()

        AddHandler boton.Click, AddressOf btnSalonEvento
    End Sub

    ' Evento al hacer clic en un botón de salón
    Private Sub btnSalonEvento(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim botonSeleccionado As Button = DirectCast(sender, Button)
            salonSeleccionado = botonSeleccionado.Text
            id_Salon = Convert.ToInt32(botonSeleccionado.Name)

            ' Redibujar solo los paneles para actualizar la selección sin borrar todo
            For Each panel As Panel In FLP_Salones.Controls
                Dim panelLateral As Control = panel.Controls(1)
                Dim boton As Button = panel.Controls(0)

                If boton.Text = salonSeleccionado Then
                    panelLateral.BackColor = Color.OrangeRed
                    boton.BackColor = Color.FromArgb(43, 43, 43)
                    boton.ForeColor = Color.White
                Else
                    panelLateral.BackColor = Color.Transparent
                    boton.BackColor = Color.Transparent
                    boton.ForeColor = Color.Black
                End If

                boton.BringToFront()
                panelLateral.SendToBack()
            Next

            ' Ahora sí, dibujar las mesas del salón seleccionado
            dibujarMesas()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Evento cuando el usuario escribe en el cuadro de búsqueda
    Private Sub TXT_BuscarSalon_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarSalon.TextChanged
        dibujarSalones()
    End Sub

    ' Método para dibujar las mesas en el FlowLayoutPanel
    Sub dibujarMesas()
        FLP_Mesas.Controls.Clear()
        Try
            abrir()
            Dim query As String = "mostrarMesasPorSalon"
            Dim cmd As New SqlCommand(query, conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Id_Salon", id_Salon)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                dibujarMesa(reader)
            End While
            reader.Close()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Método para dibujar una mesa
    Sub dibujarMesa(reader As SqlDataReader)
        Dim boton As New Button()
        ' Manejo de DBNull para evitar errores
        Dim alto As Integer = If(Not IsDBNull(reader("Y")), Convert.ToInt32(reader("Y")), 50)
        Dim ancho As Integer = If(Not IsDBNull(reader("X")), Convert.ToInt32(reader("X")), 50)
        Dim estado As Boolean = If(Not IsDBNull(reader("Estado")), reader("Estado"), False)
        Dim tamanioLetra As Integer = If(Not IsDBNull(reader("Tamanio_Letra")), Convert.ToInt32(reader("Tamanio_Letra")), 12)

        Dim tamanio As Size = New Size(ancho, alto)

        ' Configuración del botón
        boton.Text = If(Not IsDBNull(reader("Nombre")), reader("Nombre").ToString(), "Sin Nombre")
        boton.Name = If(Not IsDBNull(reader("Id_Salon")), reader("Id_Salon").ToString(), "0")
        boton.Size = tamanio

        boton.Font = New System.Drawing.Font("Arial", tamanioLetra)
        boton.FlatStyle = FlatStyle.Flat
        boton.FlatAppearance.BorderSize = 0
        boton.ForeColor = Color.White
        boton.Cursor = Cursors.Hand
        boton.Tag = If(Not IsDBNull(reader("Id_Mesa")), reader("Id_Mesa").ToString(), "0")

        ' Agregar botón o panel al FlowLayoutPanel
        If estado Then
            boton.BackColor = Color.Green

        Else
            boton.BackColor = Color.DarkRed
        End If

        FLP_Mesas.Controls.Add(boton)
    End Sub

End Class
