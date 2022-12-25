Imports System.ComponentModel
Imports System.IO
Public Class frmFINALGUI
    Dim NomArchivo As String = "Datos.txt"
    Dim Ubicacion As String = "C:\Users\Toto\Desktop\"
    Dim HayCambios As Boolean

    Private Sub btnLeer_Click_1(sender As Object, e As EventArgs) Handles btnLeer.Click
        Dim Opc As Integer
        If HayCambios Then
            Opc = MsgBox("No se a guardado los ultimos cambios . ¿Desea guardarlos?", vbYesNo + vbCritical)
            If Opc = vbYes Then
                Me.Guardar(Ubicacion & NomArchivo)
            End If
        End If

        Me.Leer(Ubicacion & NomArchivo)

    End Sub


    'Sub ControlarLimiteTextBox(nombre As String, direccion As String, telefono As String)

    'If (nombre.Length > 30 OrElse direccion.Length > 30 OrElse telefono.Length > 15) Then
    '       MsgBox("El nombre o direccion no puede tener mas de 30 caracteres y el telefono mas de 15 !!", vbCritical)
    'Me.txtNombre.Text = ""
    'Me.txtDireccion.Text = ""
    'Me.txtTelefono.Text = ""
    'Me.txtNombre.Focus()
    'Else
    'Me.txtNombre.Text = Mid(Me.txtNombre.Text, 1, 30)
    'Me.txtDireccion.Text = Mid(Me.txtDireccion.Text, 1, 30)
    'Me.txtTelefono.Text = Mid(Me.txtTelefono.Text, 1, 15)
    '       lstDatos.Items.Add(Space(8) + txtNombre.Text + Space(52 - Len(txtNombre.Text)) + " " + txtDireccion.Text + Space(52 - Len(txtDireccion.Text)) + " " +
    '                         txtTelefono.Text)
    '     txtNombre.Text = ""
    '    txtDireccion.Text = ""
    '   txtTelefono.Text = ""
    '  txtNombre.Focus()
    ' HayCambios = True

    'End If
    'Exit Sub
    ' End Sub

    Sub ControlarQueContengaCaracteresTexbox(nombre As String, direccion As String, telefono As String)
        If (Me.txtNombre.Text <> "" And Me.txtDireccion.Text <> "" And Me.txtTelefono.Text = "") Then
            MsgBox("¡Debe completar un teléfono!", vbCritical)
            txtTelefono.Text = ""
            txtTelefono.Focus()
        ElseIf (Me.txtNombre.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtDireccion.Text = "") Then
            MsgBox("¡Debe completar una direcciom!", vbCritical)
            txtDireccion.Text = ""
            txtDireccion.Focus()
        ElseIf (Me.txtDireccion.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtNombre.Text = "") Then
            MsgBox("¡Debe completar un nombre !", vbCritical)
            txtNombre.Text = ""
            txtNombre.Focus()
        ElseIf (Me.txtDireccion.Text <> "" And Me.txtTelefono.Text = "" And Me.txtNombre.Text = "") Then
            MsgBox("¡Debe completar un Telefono y nombreApellido !", vbCritical)
            txtNombre.Text = ""
            txtNombre.Focus()
        ElseIf (Me.txtNombre.Text <> "" And Me.txtTelefono.Text = "" And Me.txtDireccion.Text = "") Then
            MsgBox("¡Debe completar con un telefono y una direcciom!", vbCritical)
            txtTelefono.Text = ""
            txtTelefono.Focus()
        ElseIf (Me.txtNombre.Text = "" And Me.txtTelefono.Text <> "" And Me.txtDireccion.Text = "") Then
            MsgBox("¡Debe completar con un Nombre y una direcciom!", vbCritical)
            txtNombre.Text = ""
            txtNombre.Focus()
        End If
        ' If (nombre.ToString = "" OrElse direccion.ToString = "" OrElse telefono.ToString = "") Then
        'MsgBox("¡Debe completar nombre, apellido y un teléfono!", vbCritical)
        'Me.txtNombre.Text = ""
        'Me.txtDireccion.Text = ""
        'Me.txtTelefono.Text = ""
        'Me.txtNombre.Focus()
        'End If
        Exit Sub
    End Sub


    Sub Guardar(Archivo As String)
        Dim GrabarArchivo As New StreamWriter(Archivo)
        For i = 0 To lstDatos.Items.Count - 1
            Dim Linea = lstDatos.Items(i).ToString()
            GrabarArchivo.WriteLine(Linea)
        Next

        GrabarArchivo.Close()
        MsgBox("Archivo grabado Correctamente", vbInformation)
        HayCambios = False
        txtNombre.Focus()
    End Sub


    Sub Leer(Archivo As String)
        Dim leerArchivo As New StreamReader(Archivo)
        lstDatos.Items.Clear()
        Try
            While leerArchivo.Peek <> -1
                Dim linea As String = leerArchivo.ReadLine
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If

                lstDatos.Items.Add(linea)
            End While

            leerArchivo.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub Crear(Archivo As String)
        Dim CrearArchivo As FileStream = File.Create(Archivo)
        CrearArchivo.Close()
        Me.btnLeer.Visible = True
        Me.btnGuardar.Visible = True

    End Sub

    Private Sub lstDatos_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        HayCambios = True
    End Sub


    Private Sub frmFINALGUI_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Leer(Ubicacion & NomArchivo)
        Me.TextBox1.Visible = False
        HayCambios = False
    End Sub

    Private Sub frmFINALGUI_Closing_1(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If HayCambios Then
            If MsgBox("No se a guardado los ultimos cambios . ¿Desea guardarlos?", vbYesNo + vbCritical) = vbYes Then
                Me.Guardar(Ubicacion & NomArchivo)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String
        Dim direccion As String
        Dim telefono As String
        txtNombre.MaxLength = 30
        txtDireccion.MaxLength = 30
        txtTelefono.MaxLength = 15
        nombre = Me.txtNombre.Text
        direccion = Me.txtDireccion.Text
        telefono = Me.txtTelefono.Text

        ControlarQueContengaCaracteresTexbox(nombre, direccion, telefono)
        If (nombre <> "" And direccion <> "" And telefono <> "") Then
            lstDatos.Items.Add(Space(8) + txtNombre.Text + Space(52 - Len(txtNombre.Text)) + " " + txtDireccion.Text + Space(52 - Len(txtDireccion.Text)) + " " +
                              txtTelefono.Text)
            txtNombre.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
            txtNombre.Focus()

            'ControlarQueContengaCaracteresTexbox(nombre, direccion, telefono)
            ' ControlarLimiteTextBox(nombre, direccion, telefono)
            HayCambios = True
        End If


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If lstDatos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un items para modificarlo", vbCritical)
            txtNombre.Focus()
            Exit Sub
        End If
        Dim nombre, direccion, telefono As String
        nombre = Mid(lstDatos.SelectedItem.ToString, 9, 30)
        direccion = Mid(lstDatos.SelectedItem.ToString, 62, 30)
        telefono = Mid(lstDatos.SelectedItem.ToString, 115, 15)
        Me.txtNombre.Text = nombre
        Me.txtDireccion.Text = direccion
        Me.txtTelefono.Text = telefono
        Me.lstDatos.Items.Remove(lstDatos.SelectedItem.ToString())
        Me.txtNombre.focus()
        HayCambios = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.lstDatos.Items.ToString = "" Then
            MsgBox("Debe contener al menos un caracter", vbCritical,
                   "Ingrese Informacion")
            Exit Sub
        End If
        Me.Guardar(Ubicacion & NomArchivo)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If lstDatos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un items para modificarlo", vbCritical)
            txtNombre.Focus()
            Exit Sub
        End If

        Dim opc As Integer
        opc = MsgBox("Desea eliminaro", vbYesNo)
        If opc = vbYes Then
            lstDatos.Items.Remove(lstDatos.SelectedItem.ToString())
        End If
        lstDatos.ClearSelected()
        txtNombre.Focus()

    End Sub

    Private Sub btnFiltrarSeleccion_Click(sender As Object, e As EventArgs) Handles btnFiltrarSeleccion.Click
        Static contadorClikcs As Integer
        contadorClikcs += 1
        If contadorClikcs = 1 Then
            Me.TextBox1.Visible = True
        ElseIf contadorClikcs = 2 Then
            contadorClikcs = 0
            Me.TextBox1.Visible = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim i As Integer
        Dim existe As Integer
        If Len(Me.TextBox1.Text) > 0 Then
            For i = 0 To lstDatos.Items.Count - 1
                existe = lstDatos.Items(i).indexOf(TextBox1.Text)

                If existe <> -1 Then
                    Me.lstDatos.SelectedIndex() = i
                    Exit For
                End If
            Next i
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            MsgBox("Solo se permite numeros", vbInformation, "Atenicion")
            e.Handled = True
        End If
    End Sub

End Class
