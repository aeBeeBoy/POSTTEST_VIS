Imports System.Data

Public Class Form1

    Private Sub Kosong()
        txtNIS.Clear()
        txtNama.Clear()
        cboJK.SelectedIndex = -1
        cboLevel.SelectedIndex = -1
        txtAlamat.Clear()
        mtbnoHP.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtNIS.Focus()
    End Sub

    Private Sub TampilData()
        dgvSiswa.DataSource = GetAllSiswa()
    End Sub

    Private Sub AturGrid()
        dgvSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSiswa.MultiSelect = False
        dgvSiswa.ReadOnly = True
        dgvSiswa.AllowUserToAddRows = False

        If dgvSiswa.Columns.Count > 0 Then
            dgvSiswa.Columns("nis").HeaderText = "NIS"
            dgvSiswa.Columns("nama_siswa").HeaderText = "Nama Siswa"
            dgvSiswa.Columns("jenis_kelamin").HeaderText = "Jenis Kelamin"
            dgvSiswa.Columns("level_kelas").HeaderText = "Level Kelas"
            dgvSiswa.Columns("alamat").HeaderText = "Alamat"
            dgvSiswa.Columns("no_hp").HeaderText = "No. HP"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboJK.Items.Clear()
        cboJK.Items.Add("Laki-laki")
        cboJK.Items.Add("Perempuan")

        cboLevel.Items.Clear()
        cboLevel.Items.Add("Beginner")
        cboLevel.Items.Add("Intermediate")
        cboLevel.Items.Add("Advanced")

        TampilData()
        AturGrid()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiSiswa(ErrorProvider1, txtNIS, txtNama, cboJK, cboLevel, txtAlamat, mtbnoHP) Then
            Exit Sub
        End If

        Dim nis As String = txtNIS.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim jk As String = cboJK.Text.Trim()
        Dim levelKelas As String = cboLevel.Text.Trim()
        Dim alamat As String = txtAlamat.Text.Trim()
        Dim noHp As String = mtbnoHP.Text.Trim()

        If NISSudahAda(nis) Then
            MessageBox.Show("NIS sudah terdaftar",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtNIS.Focus()
            Exit Sub
        End If

        If SimpanSiswa(nis, nama, jk, levelKelas, alamat, noHp) Then
            MessageBox.Show("Data berhasil disimpan",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            TampilData()
            AturGrid()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidasiSiswa(ErrorProvider1, txtNIS, txtNama, cboJK, cboLevel, txtAlamat, mtbnoHP) Then
            Exit Sub
        End If

        If UbahSiswa(txtNIS.Text.Trim(),
                     txtNama.Text.Trim(),
                     cboJK.Text.Trim(),
                     cboLevel.Text.Trim(),
                     txtAlamat.Text.Trim(),
                     mtbnoHP.Text.Trim()) Then

            MessageBox.Show("Data berhasil diubah",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            TampilData()
            AturGrid()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNIS.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtNIS.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?",
                                "Konfirmasi",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusSiswa(txtNIS.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus",
                                "Informasi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                TampilData()
                AturGrid()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
        AturGrid()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        Form2.ShowDialog()
    End Sub

    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        If e.RowIndex >= 0 Then
            txtNIS.Text = dgvSiswa.Rows(e.RowIndex).Cells("nis").Value.ToString()
            txtNama.Text = dgvSiswa.Rows(e.RowIndex).Cells("nama_siswa").Value.ToString()
            cboJK.Text = dgvSiswa.Rows(e.RowIndex).Cells("jenis_kelamin").Value.ToString()
            cboLevel.Text = dgvSiswa.Rows(e.RowIndex).Cells("level_kelas").Value.ToString()
            txtAlamat.Text = dgvSiswa.Rows(e.RowIndex).Cells("alamat").Value.ToString()
            mtbnoHP.Text = dgvSiswa.Rows(e.RowIndex).Cells("no_hp").Value.ToString()
        End If
    End Sub

    Private Sub txtNIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIS.KeyPress
        HanyaAngka(e)

        If IsEnterKey(e) Then
            e.Handled = True

            Dim dt As DataTable = GetSiswaByNIS(txtNIS.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtNIS.Text = dt.Rows(0)("nis").ToString()
                txtNama.Text = dt.Rows(0)("nama_siswa").ToString()
                cboJK.Text = dt.Rows(0)("jenis_kelamin").ToString()
                cboLevel.Text = dt.Rows(0)("level_kelas").ToString()
                txtAlamat.Text = dt.Rows(0)("alamat").ToString()
                mtbnoHP.Text = dt.Rows(0)("no_hp").ToString()
            Else
                txtNama.Clear()
                cboJK.SelectedIndex = -1
                cboLevel.SelectedIndex = -1
                txtAlamat.Clear()
                mtbnoHP.Clear()
            End If

            txtNama.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub mtbNoHP_Leave(sender As Object, e As EventArgs) Handles mtbnoHP.Leave
        If Not mtbnoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbnoHP, "Nomor HP harus lengkap, contoh: 0812-3456-7890")
        Else
            ErrorProvider1.SetError(mtbnoHP, "")
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvSiswa.DataSource = SearchSiswa(txtSearch.Text.Trim())
        End If

        AturGrid()
    End Sub

    Private Sub mnuRefresh_Click(sender As Object, e As EventArgs) Handles mnuRefresh.Click
        TampilData()
        AturGrid()
    End Sub

    Private Sub mnuKosongkan_Click(sender As Object, e As EventArgs) Handles mnuKosongkan.Click
        Kosong()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Me.Close()
    End Sub

End Class