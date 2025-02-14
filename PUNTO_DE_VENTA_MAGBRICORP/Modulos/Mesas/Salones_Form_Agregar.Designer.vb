<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salones_Form_Agregar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_Volver = New System.Windows.Forms.Button()
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.LBL_NombreSalon = New System.Windows.Forms.Label()
        Me.TXT_NombreSalon = New System.Windows.Forms.TextBox()
        Me.lbl_AgregarSalon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Volver
        '
        Me.BTN_Volver.BackColor = System.Drawing.Color.Red
        Me.BTN_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Volver.ForeColor = System.Drawing.Color.White
        Me.BTN_Volver.Location = New System.Drawing.Point(112, 323)
        Me.BTN_Volver.Name = "BTN_Volver"
        Me.BTN_Volver.Size = New System.Drawing.Size(160, 39)
        Me.BTN_Volver.TabIndex = 9
        Me.BTN_Volver.Text = "Volver"
        Me.BTN_Volver.UseVisualStyleBackColor = False
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.BackColor = System.Drawing.Color.Green
        Me.BTN_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Guardar.ForeColor = System.Drawing.Color.White
        Me.BTN_Guardar.Location = New System.Drawing.Point(112, 245)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.Size = New System.Drawing.Size(160, 57)
        Me.BTN_Guardar.TabIndex = 8
        Me.BTN_Guardar.Text = "Guardar"
        Me.BTN_Guardar.UseVisualStyleBackColor = False
        '
        'LBL_NombreSalon
        '
        Me.LBL_NombreSalon.AutoSize = True
        Me.LBL_NombreSalon.Location = New System.Drawing.Point(68, 194)
        Me.LBL_NombreSalon.Name = "LBL_NombreSalon"
        Me.LBL_NombreSalon.Size = New System.Drawing.Size(145, 13)
        Me.LBL_NombreSalon.TabIndex = 7
        Me.LBL_NombreSalon.Text = "Ingrese el nombre de la mesa"
        '
        'TXT_NombreSalon
        '
        Me.TXT_NombreSalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NombreSalon.Location = New System.Drawing.Point(71, 210)
        Me.TXT_NombreSalon.Name = "TXT_NombreSalon"
        Me.TXT_NombreSalon.Size = New System.Drawing.Size(254, 29)
        Me.TXT_NombreSalon.TabIndex = 6
        '
        'lbl_AgregarSalon
        '
        Me.lbl_AgregarSalon.AutoSize = True
        Me.lbl_AgregarSalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AgregarSalon.Location = New System.Drawing.Point(72, 88)
        Me.lbl_AgregarSalon.Name = "lbl_AgregarSalon"
        Me.lbl_AgregarSalon.Size = New System.Drawing.Size(231, 42)
        Me.lbl_AgregarSalon.TabIndex = 5
        Me.lbl_AgregarSalon.Text = "Definir Salon"
        '
        'Salones_Form_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 424)
        Me.Controls.Add(Me.BTN_Volver)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Controls.Add(Me.LBL_NombreSalon)
        Me.Controls.Add(Me.TXT_NombreSalon)
        Me.Controls.Add(Me.lbl_AgregarSalon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Salones_Form_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salones_Form_Agregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Volver As Button
    Friend WithEvents BTN_Guardar As Button
    Friend WithEvents LBL_NombreSalon As Label
    Friend WithEvents TXT_NombreSalon As TextBox
    Friend WithEvents lbl_AgregarSalon As Label
End Class
