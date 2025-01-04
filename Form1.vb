Public Class Form1

    Private Sub HoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoraToolStripMenuItem.Click
        Label1.Text = TimeString
    End Sub

    Private Sub FechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaToolStripMenuItem.Click
        Label1.Text = DateString
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
    End Sub
    Private Sub AbrirToolStripButton_Click(sender As Object, e As EventArgs) Handles AbrirToolStripButton.Click
        OpenFileDialog1.Filter = "PNG (*.png)|*.png"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile _
            (OpenFileDialog1.FileName)
        End If
    End Sub
End Class
