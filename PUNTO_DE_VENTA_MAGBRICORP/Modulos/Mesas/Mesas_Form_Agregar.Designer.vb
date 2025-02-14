<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesas_Form_Agregar
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
        Me.lbl_AgregarMesa = New System.Windows.Forms.Label()
        Me.TXT_NombreMesa = New System.Windows.Forms.TextBox()
        Me.LBL_NombreMesa = New System.Windows.Forms.Label()
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.BTN_Volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_AgregarMesa
        '
        Me.lbl_AgregarMesa.AutoSize = True
        Me.lbl_AgregarMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AgregarMesa.Location = New System.Drawing.Point(72, 76)
        Me.lbl_AgregarMesa.Name = "lbl_AgregarMesa"
        Me.lbl_AgregarMesa.Size = New System.Drawing.Size(227, 42)
        Me.lbl_AgregarMesa.TabIndex = 0
        Me.lbl_AgregarMesa.Text = "Definir Mesa"
        '
        'TXT_NombreMesa
        '
        Me.TXT_NombreMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NombreMesa.Location = New System.Drawing.Point(71, 198)
        Me.TXT_NombreMesa.Name = "TXT_NombreMesa"
        Me.TXT_NombreMesa.Size = New System.Drawing.Size(254, 29)
        Me.TXT_NombreMesa.TabIndex = 1
        '
        'LBL_NombreMesa
        '
        Me.LBL_NombreMesa.AutoSize = True
        Me.LBL_NombreMesa.Location = New System.Drawing.Point(68, 182)
        Me.LBL_NombreMesa.Name = "LBL_NombreMesa"
        Me.LBL_NombreMesa.Size = New System.Drawing.Size(145, 13)
        Me.LBL_NombreMesa.TabIndex = 2
        Me.LBL_NombreMesa.Text = "Ingrese el nombre de la mesa"
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.BackColor = System.Drawing.Color.Green
        Me.BTN_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Guardar.ForeColor = System.Drawing.Color.White
        Me.BTN_Guardar.Location = New System.Drawing.Point(112, 233)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.Size = New System.Drawing.Size(160, 57)
        Me.BTN_Guardar.TabIndex = 3
        Me.BTN_Guardar.Text = "Guardar"
        Me.BTN_Guardar.UseVisualStyleBackColor = False
        '
        'BTN_Volver
        '
        Me.BTN_Volver.BackColor = System.Drawing.Color.Red
        Me.BTN_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Volver.ForeColor = System.Drawing.Color.White
        Me.BTN_Volver.Location = New System.Drawing.Point(112, 311)
        Me.BTN_Volver.Name = "BTN_Volver"
        Me.BTN_Volver.Size = New System.Drawing.Size(160, 39)
        Me.BTN_Volver.TabIndex = 4
        Me.BTN_Volver.Text = "Volver"
        Me.BTN_Volver.UseVisualStyleBackColor = False
        '
        'Mesas_Form_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 424)
        Me.Controls.Add(Me.BTN_Volver)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Controls.Add(Me.LBL_NombreMesa)
        Me.Controls.Add(Me.TXT_NombreMesa)
        Me.Controls.Add(Me.lbl_AgregarMesa)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mesas_Form_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesas_Form_Agregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_AgregarMesa As Label
    Friend WithEvents TXT_NombreMesa As TextBox
    Friend WithEvents LBL_NombreMesa As Label
    Friend WithEvents BTN_Guardar As Button
    Friend WithEvents BTN_Volver As Button
End Class
