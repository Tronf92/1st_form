﻿Public Class Form1

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()


    End Sub

    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click

        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            PictureBox1.Load(OpenFileDialog1.FileName)

        End If
        
    End Sub

    Private Sub backgroundButton_Click(sender As Object, e As EventArgs) Handles backgroundButton.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        PictureBox1.Image = Nothing


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
