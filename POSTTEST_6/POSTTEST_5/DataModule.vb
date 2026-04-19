Imports MySqlConnector
Imports System.Data
Imports System.Windows.Forms

Module DataModule

    ' =========================
    ' DATA SISWA
    ' =========================

    Public Function GetAllSiswa() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT nis, nama_siswa, jenis_kelamin, level_kelas, alamat, no_hp FROM tbsiswa ORDER BY nis ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SearchSiswa(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT nis, nama_siswa, jenis_kelamin, level_kelas, alamat, no_hp FROM tbsiswa " &
                "WHERE nis LIKE @keyword OR nama_siswa LIKE @keyword OR jenis_kelamin LIKE @keyword OR " &
                "level_kelas LIKE @keyword OR alamat LIKE @keyword OR no_hp LIKE @keyword " &
                "ORDER BY nis ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetSiswaByNIS(nis As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT nis, nama_siswa, jenis_kelamin, level_kelas, alamat, no_hp FROM tbsiswa WHERE nis = @nis"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@nis", nis)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function NISSudahAda(nis As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbsiswa WHERE nis = @nis"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nis", nis)

                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanSiswa(nis As String,
                                nama As String,
                                jk As String,
                                levelKelas As String,
                                alamat As String,
                                noHp As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbsiswa (nis, nama_siswa, jenis_kelamin, level_kelas, alamat, no_hp) " &
                "VALUES (@nis, @nama, @jk, @level, @alamat, @nohp)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nis", nis)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jk", jk)
                    cmd.Parameters.AddWithValue("@level", levelKelas)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@nohp", noHp)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahSiswa(nis As String,
                              nama As String,
                              jk As String,
                              levelKelas As String,
                              alamat As String,
                              noHp As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbsiswa SET " &
                "nama_siswa = @nama, " &
                "jenis_kelamin = @jk, " &
                "level_kelas = @level, " &
                "alamat = @alamat, " &
                "no_hp = @nohp " &
                "WHERE nis = @nis"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nis", nis)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jk", jk)
                    cmd.Parameters.AddWithValue("@level", levelKelas)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@nohp", noHp)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusSiswa(nis As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbsiswa WHERE nis = @nis"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nis", nis)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    ' =========================
    ' DATA PEMBAYARAN
    ' =========================

    Public Function GetAllSiswaForCombo() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT nis, nama_siswa FROM tbsiswa ORDER BY nama_siswa ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data siswa: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetAllPembayaran() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT tbpembayaran.id_bayar, tbpembayaran.nis, tbsiswa.nama_siswa, " &
                "tbpembayaran.tanggal_bayar, tbpembayaran.bulan, tbpembayaran.jumlah_bayar, " &
                "tbpembayaran.status_bayar, tbpembayaran.keterangan " &
                "FROM tbpembayaran " &
                "INNER JOIN tbsiswa ON tbpembayaran.nis = tbsiswa.nis " &
                "ORDER BY tbpembayaran.id_bayar ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pembayaran: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SearchPembayaran(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT tbpembayaran.id_bayar, tbpembayaran.nis, tbsiswa.nama_siswa, " &
                "tbpembayaran.tanggal_bayar, tbpembayaran.bulan, tbpembayaran.jumlah_bayar, " &
                "tbpembayaran.status_bayar, tbpembayaran.keterangan " &
                "FROM tbpembayaran " &
                "INNER JOIN tbsiswa ON tbpembayaran.nis = tbsiswa.nis " &
                "WHERE tbpembayaran.id_bayar LIKE @keyword OR " &
                "tbpembayaran.nis LIKE @keyword OR " &
                "tbsiswa.nama_siswa LIKE @keyword OR " &
                "tbpembayaran.bulan LIKE @keyword OR " &
                "tbpembayaran.status_bayar LIKE @keyword " &
                "ORDER BY tbpembayaran.id_bayar ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pembayaran: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function IdBayarSudahAda(idBayar As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpembayaran WHERE id_bayar = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idBayar)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data pembayaran: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function GetPembayaranById(idBayar As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT id_bayar, nis, tanggal_bayar, bulan, jumlah_bayar, status_bayar, keterangan " &
                "FROM tbpembayaran WHERE id_bayar = @id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idBayar)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data pembayaran: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SimpanPembayaran(idBayar As String,
                                     nis As String,
                                     tanggalBayar As Date,
                                     bulan As String,
                                     jumlahBayar As Decimal,
                                     statusBayar As String,
                                     keterangan As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpembayaran (id_bayar, nis, tanggal_bayar, bulan, jumlah_bayar, status_bayar, keterangan) " &
                "VALUES (@id, @nis, @tgl, @bulan, @jumlah, @status, @ket)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idBayar)
                    cmd.Parameters.AddWithValue("@nis", nis)
                    cmd.Parameters.AddWithValue("@tgl", tanggalBayar)
                    cmd.Parameters.AddWithValue("@bulan", bulan)
                    cmd.Parameters.AddWithValue("@jumlah", jumlahBayar)
                    cmd.Parameters.AddWithValue("@status", statusBayar)
                    cmd.Parameters.AddWithValue("@ket", keterangan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pembayaran: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPembayaran(idBayar As String,
                                   nis As String,
                                   tanggalBayar As Date,
                                   bulan As String,
                                   jumlahBayar As Decimal,
                                   statusBayar As String,
                                   keterangan As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpembayaran SET nis=@nis, tanggal_bayar=@tgl, bulan=@bulan, " &
                "jumlah_bayar=@jumlah, status_bayar=@status, keterangan=@ket " &
                "WHERE id_bayar=@id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idBayar)
                    cmd.Parameters.AddWithValue("@nis", nis)
                    cmd.Parameters.AddWithValue("@tgl", tanggalBayar)
                    cmd.Parameters.AddWithValue("@bulan", bulan)
                    cmd.Parameters.AddWithValue("@jumlah", jumlahBayar)
                    cmd.Parameters.AddWithValue("@status", statusBayar)
                    cmd.Parameters.AddWithValue("@ket", keterangan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah pembayaran: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPembayaran(idBayar As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpembayaran WHERE id_bayar = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idBayar)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus pembayaran: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module