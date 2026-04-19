Imports System.Data

Public Class Form2

    Private Sub Kosong()
        txtIdBayar.Clear()
        cboNIS.SelectedIndex = -1
        txtNamaSiswa.Clear()
        dtpTanggalBayar.Value = Date.Now
        cboBulan.SelectedIndex = -1
        txtJumlahBayar.Clear()
        cboStatus.SelectedIndex = -1
        txtKeterangan.Clear()
        txtCari.Clear()
        ErrorProvider1.Clear()
        txtIdBayar.Focus()
    End Sub

    Private Sub TampilData()
        dgvPembayaran.DataSource = GetAllPembayaran()
    End Sub

    Private Sub AturGrid()
        dgvPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembayaran.MultiSelect = False
        dgvPembayaran.ReadOnly = True
        dgvPembayaran.AllowUserToAddRows = False

        If dgvPembayaran.Columns.Count > 0 Then
            dgvPembayaran.Columns("id_bayar").HeaderText = "ID Bayar"
            dgvPembayaran.Columns("nis").HeaderText = "NIS"
            dgvPembayaran.Columns("nama_siswa").HeaderText = "Nama Siswa"
            dgvPembayaran.Columns("tanggal_bayar").HeaderText = "Tanggal Bayar"
            dgvPembayaran.Columns("bulan").HeaderText = "Bulan"
            dgvPembayaran.Columns("jumlah_bayar").HeaderText = "Jumlah Bayar"
            dgvPembayaran.Columns("status_bayar").HeaderText = "Status"
            dgvPembayaran.Columns("keterangan").HeaderText = "Keterangan"
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtSiswa As DataTable = GetAllSiswaForCombo()
        cboNIS.DataSource = dtSiswa
        cboNIS.DisplayMember = "nis"
        cboNIS.ValueMember = "nis"
        cboNIS.SelectedIndex = -1

        cboBulan.Items.Clear()
        cboBulan.Items.Add("Januari")
        cboBulan.Items.Add("Februari")
        cboBulan.Items.Add("Maret")
        cboBulan.Items.Add("April")
        cboBulan.Items.Add("Mei")
        cboBulan.Items.Add("Juni")
        cboBulan.Items.Add("Juli")
        cboBulan.Items.Add("Agustus")
        cboBulan.Items.Add("September")
        cboBulan.Items.Add("Oktober")
        cboBulan.Items.Add("November")
        cboBulan.Items.Add("Desember")

        cboStatus.Items.Clear()
        cboStatus.Items.Add("Lunas")
        cboStatus.Items.Add("Belum Lunas")

        TampilData()
        AturGrid()
        Kosong()
    End Sub

    Private Sub cboNIS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNIS.SelectedIndexChanged
        If cboNIS.SelectedIndex >= 0 AndAlso cboNIS.SelectedItem IsNot Nothing Then
            Dim drv As DataRowView = TryCast(cboNIS.SelectedItem, DataRowView)
            If drv IsNot Nothing Then
                txtNamaSiswa.Text = drv("nama_siswa").ToString()
            Else
                txtNamaSiswa.Clear()
            End If
        Else
            txtNamaSiswa.Clear()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiPembayaran(ErrorProvider1, txtIdBayar, cboNIS, txtJumlahBayar, cboBulan, cboStatus) Then
            Exit Sub
        End If

        Dim idBayar As String = txtIdBayar.Text.Trim()
        Dim nis As String = ""
        If cboNIS.SelectedValue IsNot Nothing Then
            nis = cboNIS.SelectedValue.ToString()
        End If

        Dim tanggalBayar As Date = dtpTanggalBayar.Value.Date
        Dim bulan As String = cboBulan.Text.Trim()
        Dim jumlahBayar As Decimal = Convert.ToDecimal(txtJumlahBayar.Text.Trim())
        Dim statusBayar As String = cboStatus.Text.Trim()
        Dim keterangan As String = txtKeterangan.Text.Trim()

        If IdBayarSudahAda(idBayar) Then
            MessageBox.Show("ID Bayar sudah terdaftar",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtIdBayar.Focus()
            Exit Sub
        End If

        If SimpanPembayaran(idBayar, nis, tanggalBayar, bulan, jumlahBayar, statusBayar, keterangan) Then
            MessageBox.Show("Data pembayaran berhasil disimpan",
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

        If Not ValidasiPembayaran(ErrorProvider1, txtIdBayar, cboNIS, txtJumlahBayar, cboBulan, cboStatus) Then
            Exit Sub
        End If

        Dim nis As String = ""
        If cboNIS.SelectedValue IsNot Nothing Then
            nis = cboNIS.SelectedValue.ToString()
        End If

        If UbahPembayaran(txtIdBayar.Text.Trim(),
                          nis,
                          dtpTanggalBayar.Value.Date,
                          cboBulan.Text.Trim(),
                          Convert.ToDecimal(txtJumlahBayar.Text.Trim()),
                          cboStatus.Text.Trim(),
                          txtKeterangan.Text.Trim()) Then

            MessageBox.Show("Data pembayaran berhasil diubah",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            TampilData()
            AturGrid()
            Kosong()
        Else
            MessageBox.Show("Data pembayaran tidak ditemukan",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdBayar.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtIdBayar.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data pembayaran ingin dihapus?",
                                "Konfirmasi",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusPembayaran(txtIdBayar.Text.Trim()) Then
                MessageBox.Show("Data pembayaran berhasil dihapus",
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

    Private Sub dgvPembayaran_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembayaran.CellClick
        If e.RowIndex >= 0 Then
            txtIdBayar.Text = dgvPembayaran.Rows(e.RowIndex).Cells("id_bayar").Value.ToString()
            cboNIS.SelectedValue = dgvPembayaran.Rows(e.RowIndex).Cells("nis").Value.ToString()
            txtNamaSiswa.Text = dgvPembayaran.Rows(e.RowIndex).Cells("nama_siswa").Value.ToString()
            dtpTanggalBayar.Value = Convert.ToDateTime(dgvPembayaran.Rows(e.RowIndex).Cells("tanggal_bayar").Value)
            cboBulan.Text = dgvPembayaran.Rows(e.RowIndex).Cells("bulan").Value.ToString()
            txtJumlahBayar.Text = dgvPembayaran.Rows(e.RowIndex).Cells("jumlah_bayar").Value.ToString()
            cboStatus.Text = dgvPembayaran.Rows(e.RowIndex).Cells("status_bayar").Value.ToString()
            txtKeterangan.Text = dgvPembayaran.Rows(e.RowIndex).Cells("keterangan").Value.ToString()
        End If
    End Sub

    Private Sub txtIdBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdBayar.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True

            Dim dt As DataTable = GetPembayaranById(txtIdBayar.Text.Trim())

            If dt.Rows.Count > 0 Then
                cboNIS.SelectedValue = dt.Rows(0)("nis").ToString()
                dtpTanggalBayar.Value = Convert.ToDateTime(dt.Rows(0)("tanggal_bayar"))
                cboBulan.Text = dt.Rows(0)("bulan").ToString()
                txtJumlahBayar.Text = dt.Rows(0)("jumlah_bayar").ToString()
                cboStatus.Text = dt.Rows(0)("status_bayar").ToString()
                txtKeterangan.Text = dt.Rows(0)("keterangan").ToString()
            Else
                cboNIS.SelectedIndex = -1
                txtNamaSiswa.Clear()
                cboBulan.SelectedIndex = -1
                txtJumlahBayar.Clear()
                cboStatus.SelectedIndex = -1
                txtKeterangan.Clear()
            End If

            cboNIS.Focus()
        End If
    End Sub

    Private Sub txtJumlahBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBayar.KeyPress
        HanyaAngka(e)

        If IsEnterKey(e) Then
            e.Handled = True
            txtCari.Focus()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPembayaran.DataSource = SearchPembayaran(txtCari.Text.Trim())
        End If

        AturGrid()
    End Sub


End Class