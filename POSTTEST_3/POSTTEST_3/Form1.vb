Imports System.IO
Imports System.Text

Public Class FormCetak

    Private fotoPath As String = ""

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.BorderStyle = BorderStyle.FixedSingle

        dtpTanggalLahir.Format = DateTimePickerFormat.Custom
        dtpTanggalLahir.CustomFormat = "dd/MM/yyyy"
        dtpTanggalLahir.Value = Date.Today

        dtpTanggalLahir.MaxDate = Date.Today

        Me.BackColor = Color.WhiteSmoke
        grpJenisKelamin.BackColor = Color.White
        grpHobby.BackColor = Color.White
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelepon.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto Profile"

        If ofd.ShowDialog() = DialogResult.OK Then
            fotoPath = ofd.FileName
            picFoto.Image = Image.FromFile(fotoPath)
        End If
    End Sub

    Private Function GetJenisKelamin() As String
        If rbLakiLaki.Checked Then
            Return "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            Return "Perempuan"
        End If

        Return ""
    End Function

    Private Function GetHobby() As String
        Dim daftarHobby As New List(Of String)

        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    daftarHobby.Add(cb.Text)
                End If
            End If
        Next

        Return String.Join(", ", daftarHobby)
    End Function

    Private Function ValidasiInput() As Boolean
        If picFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnBrowse.Focus()
            Return False
        End If

        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return False
        End If

        If txtUmur.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return False
        End If

        If txtNoTelepon.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNoTelepon.Focus()
            Return False
        End If

        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return False
        End If

        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            grpJenisKelamin.Focus()
            Return False
        End If

        Dim adaHobby As Boolean = False
        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    adaHobby = True
                    Exit For
                End If
            End If
        Next

        If Not adaHobby Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            grpHobby.Focus()
            Return False
        End If

        If dtpTanggalLahir.Value.Date >= Date.Today Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTanggalLahir.Focus()
            Return False
        End If

        Dim umur As Integer
        If Not Integer.TryParse(txtUmur.Text.Trim(), umur) Then
            MessageBox.Show("Umur harus berupa angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return False
        End If

        If Not IsNumeric(txtNoTelepon.Text.Trim()) Then
            MessageBox.Show("Nomor telepon harus berupa angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNoTelepon.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Not ValidasiInput() Then
            Exit Sub
        End If

        Dim frm As New FormHasil()

        frm.nama = txtNama.Text.Trim()
        frm.umur = txtUmur.Text.Trim()
        frm.tanggalLahir = dtpTanggalLahir.Value.ToString("dd/MM/yyyy")
        frm.noTelepon = txtNoTelepon.Text.Trim()
        frm.alamat = txtAlamat.Text.Trim()
        frm.jenisKelamin = GetJenisKelamin()
        frm.hobby = GetHobby()
        frm.fotoPath = fotoPath

        frm.ShowDialog()
    End Sub

End Class