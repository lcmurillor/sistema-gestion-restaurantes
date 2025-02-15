﻿Imports System.Net.Mail
Imports System.Net
Imports System.IO
Module ENVIO_A_CORREOS
    Private correos As New MailMessage
    Private envios As New SmtpClient
 
    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta As String)
        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            If ruta <> "" Then
                Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
                correos.Attachments.Add(archivo)
            End If

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)

        Catch ex As Exception

        End Try

    End Sub
End Module
