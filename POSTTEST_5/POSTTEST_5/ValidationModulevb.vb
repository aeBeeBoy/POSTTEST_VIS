Imports System.Windows.Forms

Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.Text.Trim() = "" Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiSiswa(ep As ErrorProvider,
                                  txtNIS As TextBox,
                                  txtNama As TextBox,
                                  cboJK As ComboBox,
                                  cboLevel As ComboBox,
                                  txtAlamat As TextBox,
                                  mtbNoHP As MaskedTextBox) As Boolean

        Dim nisValid As Boolean = ValidasiTextBox(ep, txtNIS, "NIS tidak boleh kosong")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama siswa tidak boleh kosong")
        Dim jkValid As Boolean = ValidasiComboBox(ep, cboJK, "Jenis kelamin harus dipilih")
        Dim levelValid As Boolean = ValidasiComboBox(ep, cboLevel, "Level kelas harus dipilih")
        Dim alamatValid As Boolean = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")

        Dim hpValid As Boolean
        If Not mtbNoHP.MaskCompleted Then
            ep.SetError(mtbNoHP, "Nomor HP harus lengkap")
            hpValid = False
        Else
            ep.SetError(mtbNoHP, "")
            hpValid = True
        End If

        Return nisValid And namaValid And jkValid And levelValid And alamatValid And hpValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module