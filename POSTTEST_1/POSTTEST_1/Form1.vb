Public Class Form1

    Dim totalIPS As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ips As Double

        If Double.TryParse(txtIPS.Text, ips) Then

            totalIPS += ips
            jumlahSemester += 1

            Dim ipk As Double = totalIPS / jumlahSemester
            txtIPK.Text = ipk.ToString("0.00")

            If ipk >= 2.0 And ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            End If

            txtIPS.Clear()
            txtIPS.Focus()

        Else
            MessageBox.Show("Input harus angka!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIPS = 0
        jumlahSemester = 0
        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = ""
    End Sub

End Class