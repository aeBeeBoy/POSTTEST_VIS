Imports MySqlConnector
Imports System.Data
Imports System.Windows.Forms

Module DataModule

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

End Module