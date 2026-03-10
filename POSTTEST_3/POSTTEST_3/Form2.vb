Imports System.IO

Public Class FormHasil

    Public nama As String
    Public umur As String
    Public tanggalLahir As String
    Public noTelepon As String
    Public alamat As String
    Public jenisKelamin As String
    Public hobby As String
    Public fotoPath As String

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.BorderStyle = BorderStyle.FixedSingle

        lblNamaHasil.Text = "Nama : " & nama
        lblUmurHasil.Text = "Umur : " & umur
        lblTanggalLahirHasil.Text = "Tanggal Lahir : " & tanggalLahir
        lblJKHasil.Text = "Jenis Kelamin : " & jenisKelamin
        lblTeleponHasil.Text = "No Telepon : " & noTelepon
        lblAlamatHasil.Text = "Alamat : " & alamat
        lblHobbyHasil.Text = "Hobby : " & hobby

        If fotoPath <> "" AndAlso File.Exists(fotoPath) Then
            picHasil.Image = Image.FromFile(fotoPath)
        End If
    End Sub

End Class