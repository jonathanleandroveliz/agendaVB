<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFINALGUI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFINALGUI))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnFiltrarSeleccion = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLeer = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-89, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 712)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Location = New System.Drawing.Point(221, 26)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(276, 26)
        Me.txtNombre.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTelefono.Location = New System.Drawing.Point(221, 88)
        Me.txtTelefono.MaxLength = 15
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(276, 26)
        Me.txtTelefono.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Location = New System.Drawing.Point(221, 142)
        Me.txtDireccion.MaxLength = 30
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(276, 26)
        Me.txtDireccion.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(16, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 23)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "NOMBRE Y APELLIDO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(16, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 23)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "DIRECCION:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "TELEFONO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(300, 500)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 42)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnFiltrarSeleccion
        '
        Me.btnFiltrarSeleccion.Image = CType(resources.GetObject("btnFiltrarSeleccion.Image"), System.Drawing.Image)
        Me.btnFiltrarSeleccion.Location = New System.Drawing.Point(463, 433)
        Me.btnFiltrarSeleccion.Name = "btnFiltrarSeleccion"
        Me.btnFiltrarSeleccion.Size = New System.Drawing.Size(61, 42)
        Me.btnFiltrarSeleccion.TabIndex = 7
        Me.btnFiltrarSeleccion.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(300, 433)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 42)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(150, 433)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(61, 42)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(19, 433)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(61, 42)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lstDatos
        '
        Me.lstDatos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstDatos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.Location = New System.Drawing.Point(19, 278)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(505, 134)
        Me.lstDatos.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(370, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 23)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "TELEFONO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(26, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 23)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "NOMBRE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(201, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 23)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "DIRECCION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLeer
        '
        Me.btnLeer.Image = CType(resources.GetObject("btnLeer.Image"), System.Drawing.Image)
        Me.btnLeer.Location = New System.Drawing.Point(463, 500)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(61, 42)
        Me.btnLeer.TabIndex = 9
        Me.btnLeer.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(12, 500)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 26)
        Me.TextBox1.TabIndex = 74
        '
        'frmFINALGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 554)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnFiltrarSeleccion)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lstDatos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLeer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFINALGUI"
        Me.Text = "AGENDA VIRTUAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnFiltrarSeleccion As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstDatos As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLeer As Button
    Friend WithEvents TextBox1 As TextBox
End Class
