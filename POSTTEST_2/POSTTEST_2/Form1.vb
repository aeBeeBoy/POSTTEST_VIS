Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ColumnCount = 2
        DataGridView1.Columns(0).Name = "Judul Buku"
        DataGridView1.Columns(1).Name = "Genre"

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub TampilkanData()

        DataGridView1.Rows.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            DataGridView1.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Judul dan Genre harus diisi!")
            Exit Sub
        End If

        TambahBuku(txtJudul.Text, txtGenre.Text)

        TampilkanData()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim index As Integer = CariIndexBuku(txtHapus.Text)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan!")
        Else
            HapusBuku(index)
            TampilkanData()
            MessageBox.Show("Buku berhasil dihapus!")
        End If

        txtHapus.Clear()

    End Sub

End Class