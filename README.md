# MiMenu

# Descripcion

 Este proyecto consiste en una aplicacion que emplea Barras 
 de herramientas standard, barras de Menu, en la que se
 edita y personaliza cada boton para posteriormente 
 manipular el codigo de un objeto Label para cambiar el color
 de las letras, mostrar la fecha y la hora en un formato 
 preestablecido y anadir una imagen con un filtro para el 
 formato PNG. Tambien se emplean ShortKeys para definir
 comandos de atajo usados con frecuencia en el ambiente
 de un sistema operativo Microsoft Windows.

 # Actualizacion: 04/01/2025
 # Hora: 11:38

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# MyMenu

# Description

This project consists of an application that uses standard toolbars,
Menu bars, in which each button is edited and customized to
later manipulate the code of a Label object to change the color of the
letters, display the date and time in a preset format and add an image with a filter for the
PNG format. ShortKeys are also used to define shortcut commands frequently used in the
environment of a Microsoft Windows operating system.

# Update: 04/01/2025
# Time: 11:38

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/00fb7d05-cf3e-4b05-afcf-7bd63dc786ad)

Code of the Project:

Public Class Form1

    Private Sub HoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoraToolStripMenuItem.Click
        Label1.Text = TimeString
        'la etiqueta recibe en formato cadena la hora del computador
    End Sub

    Private Sub FechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaToolStripMenuItem.Click
        Label1.Text = DateString
        'la etiqueta recibe en formato cadena la fecha del computador
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
        'se abre un cuadro de dialog de la paleta de colores de Windows para seleccionar un color
        'y cambiar el color de la etiqueta
    End Sub
    Private Sub AbrirToolStripButton_Click(sender As Object, e As EventArgs) Handles AbrirToolStripButton.Click
        OpenFileDialog1.Filter = "PNG (*.png)|*.png"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile _
            (OpenFileDialog1.FileName)
        End If
        'Se establece un filtro para el formato de la imagen a buscar
        'una vez que el usuario hace click en aceptar el objeto 
        'PictureBox captura la imagen seleccionada
    End Sub
End Class
