<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mesas_Config
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PNL_Salones = New System.Windows.Forms.Panel()
        Me.FLP_Salones = New System.Windows.Forms.FlowLayoutPanel()
        Me.PNL_Botones = New System.Windows.Forms.Panel()
        Me.BTN_MasLetra = New System.Windows.Forms.Button()
        Me.BTN_MenosLetra = New System.Windows.Forms.Button()
        Me.BTN_MasBoton = New System.Windows.Forms.Button()
        Me.BTN_MenosBoton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNL_Busqueda = New System.Windows.Forms.Panel()
        Me.TXT_BuscarSalon = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarSalonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNL_Mesas = New System.Windows.Forms.Panel()
        Me.FLP_Mesas = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.PNL_Salones.SuspendLayout()
        Me.PNL_Botones.SuspendLayout()
        Me.PNL_Busqueda.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PNL_Mesas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PNL_Salones)
        Me.Panel1.Controls.Add(Me.PNL_Botones)
        Me.Panel1.Controls.Add(Me.PNL_Busqueda)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 450)
        Me.Panel1.TabIndex = 0
        '
        'PNL_Salones
        '
        Me.PNL_Salones.Controls.Add(Me.FLP_Salones)
        Me.PNL_Salones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_Salones.Location = New System.Drawing.Point(0, 94)
        Me.PNL_Salones.Name = "PNL_Salones"
        Me.PNL_Salones.Size = New System.Drawing.Size(349, 256)
        Me.PNL_Salones.TabIndex = 3
        '
        'FLP_Salones
        '
        Me.FLP_Salones.AutoScroll = True
        Me.FLP_Salones.AutoSize = True
        Me.FLP_Salones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Salones.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Salones.Margin = New System.Windows.Forms.Padding(0)
        Me.FLP_Salones.Name = "FLP_Salones"
        Me.FLP_Salones.Size = New System.Drawing.Size(349, 256)
        Me.FLP_Salones.TabIndex = 0
        '
        'PNL_Botones
        '
        Me.PNL_Botones.Controls.Add(Me.BTN_MasLetra)
        Me.PNL_Botones.Controls.Add(Me.BTN_MenosLetra)
        Me.PNL_Botones.Controls.Add(Me.BTN_MasBoton)
        Me.PNL_Botones.Controls.Add(Me.BTN_MenosBoton)
        Me.PNL_Botones.Controls.Add(Me.Label2)
        Me.PNL_Botones.Controls.Add(Me.Label1)
        Me.PNL_Botones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNL_Botones.Location = New System.Drawing.Point(0, 350)
        Me.PNL_Botones.Name = "PNL_Botones"
        Me.PNL_Botones.Size = New System.Drawing.Size(349, 100)
        Me.PNL_Botones.TabIndex = 2
        '
        'BTN_MasLetra
        '
        Me.BTN_MasLetra.Location = New System.Drawing.Point(308, 53)
        Me.BTN_MasLetra.Name = "BTN_MasLetra"
        Me.BTN_MasLetra.Size = New System.Drawing.Size(23, 23)
        Me.BTN_MasLetra.TabIndex = 5
        Me.BTN_MasLetra.Text = "+"
        Me.BTN_MasLetra.UseVisualStyleBackColor = True
        '
        'BTN_MenosLetra
        '
        Me.BTN_MenosLetra.Location = New System.Drawing.Point(279, 53)
        Me.BTN_MenosLetra.Name = "BTN_MenosLetra"
        Me.BTN_MenosLetra.Size = New System.Drawing.Size(23, 23)
        Me.BTN_MenosLetra.TabIndex = 4
        Me.BTN_MenosLetra.Text = "-"
        Me.BTN_MenosLetra.UseVisualStyleBackColor = True
        '
        'BTN_MasBoton
        '
        Me.BTN_MasBoton.Location = New System.Drawing.Point(308, 23)
        Me.BTN_MasBoton.Name = "BTN_MasBoton"
        Me.BTN_MasBoton.Size = New System.Drawing.Size(23, 23)
        Me.BTN_MasBoton.TabIndex = 3
        Me.BTN_MasBoton.Text = "+"
        Me.BTN_MasBoton.UseVisualStyleBackColor = True
        '
        'BTN_MenosBoton
        '
        Me.BTN_MenosBoton.Location = New System.Drawing.Point(279, 23)
        Me.BTN_MenosBoton.Name = "BTN_MenosBoton"
        Me.BTN_MenosBoton.Size = New System.Drawing.Size(23, 23)
        Me.BTN_MenosBoton.TabIndex = 2
        Me.BTN_MenosBoton.Text = "-"
        Me.BTN_MenosBoton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tamaño de la Letra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tamaño del Botón"
        '
        'PNL_Busqueda
        '
        Me.PNL_Busqueda.Controls.Add(Me.TXT_BuscarSalon)
        Me.PNL_Busqueda.Controls.Add(Me.MenuStrip1)
        Me.PNL_Busqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_Busqueda.Location = New System.Drawing.Point(0, 0)
        Me.PNL_Busqueda.Name = "PNL_Busqueda"
        Me.PNL_Busqueda.Size = New System.Drawing.Size(349, 94)
        Me.PNL_Busqueda.TabIndex = 1
        '
        'TXT_BuscarSalon
        '
        Me.TXT_BuscarSalon.AccessibleDescription = ""
        Me.TXT_BuscarSalon.AccessibleName = ""
        Me.TXT_BuscarSalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BuscarSalon.Location = New System.Drawing.Point(12, 43)
        Me.TXT_BuscarSalon.Name = "TXT_BuscarSalon"
        Me.TXT_BuscarSalon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_BuscarSalon.Size = New System.Drawing.Size(200, 29)
        Me.TXT_BuscarSalon.TabIndex = 0
        Me.TXT_BuscarSalon.Text = "Buscar..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarSalonToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(349, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarSalonToolStripMenuItem
        '
        Me.AgregarSalonToolStripMenuItem.Name = "AgregarSalonToolStripMenuItem"
        Me.AgregarSalonToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.AgregarSalonToolStripMenuItem.Text = "+ Agregar Salon"
        '
        'PNL_Mesas
        '
        Me.PNL_Mesas.Controls.Add(Me.FLP_Mesas)
        Me.PNL_Mesas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_Mesas.Location = New System.Drawing.Point(349, 0)
        Me.PNL_Mesas.Name = "PNL_Mesas"
        Me.PNL_Mesas.Size = New System.Drawing.Size(451, 450)
        Me.PNL_Mesas.TabIndex = 1
        '
        'FLP_Mesas
        '
        Me.FLP_Mesas.BackColor = System.Drawing.SystemColors.Control
        Me.FLP_Mesas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Mesas.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Mesas.Name = "FLP_Mesas"
        Me.FLP_Mesas.Size = New System.Drawing.Size(451, 450)
        Me.FLP_Mesas.TabIndex = 0
        '
        'Mesas_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PNL_Mesas)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Mesas_Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.PNL_Salones.ResumeLayout(False)
        Me.PNL_Salones.PerformLayout()
        Me.PNL_Botones.ResumeLayout(False)
        Me.PNL_Botones.PerformLayout()
        Me.PNL_Busqueda.ResumeLayout(False)
        Me.PNL_Busqueda.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PNL_Mesas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PNL_Botones As Panel
    Friend WithEvents PNL_Busqueda As Panel
    Friend WithEvents PNL_Mesas As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarSalonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXT_BuscarSalon As TextBox
    Friend WithEvents FLP_Salones As FlowLayoutPanel
    Friend WithEvents FLP_Mesas As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_MasLetra As Button
    Friend WithEvents BTN_MenosLetra As Button
    Friend WithEvents BTN_MasBoton As Button
    Friend WithEvents BTN_MenosBoton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PNL_Salones As Panel
End Class
