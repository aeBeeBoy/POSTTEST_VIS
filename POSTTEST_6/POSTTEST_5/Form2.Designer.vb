<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtIdBayar = New TextBox()
        txtNamaSiswa = New TextBox()
        cboNIS = New ComboBox()
        dtpTanggalBayar = New DateTimePicker()
        cboBulan = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtJumlahBayar = New TextBox()
        cboStatus = New ComboBox()
        txtKeterangan = New TextBox()
        Label9 = New Label()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvPembayaran = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvPembayaran, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 20)
        Label1.TabIndex = 0
        Label1.Text = "ID Bayar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 20)
        Label2.TabIndex = 1
        Label2.Text = "NIS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nama Siswa"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Bayar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(390, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 4
        Label5.Text = "Bulan"
        ' 
        ' txtIdBayar
        ' 
        txtIdBayar.Location = New Point(120, 130)
        txtIdBayar.Name = "txtIdBayar"
        txtIdBayar.Size = New Size(125, 27)
        txtIdBayar.TabIndex = 5
        ' 
        ' txtNamaSiswa
        ' 
        txtNamaSiswa.Location = New Point(120, 204)
        txtNamaSiswa.Name = "txtNamaSiswa"
        txtNamaSiswa.ReadOnly = True
        txtNamaSiswa.Size = New Size(125, 27)
        txtNamaSiswa.TabIndex = 9
        ' 
        ' cboNIS
        ' 
        cboNIS.FormattingEnabled = True
        cboNIS.Location = New Point(120, 167)
        cboNIS.Name = "cboNIS"
        cboNIS.Size = New Size(151, 28)
        cboNIS.TabIndex = 10
        ' 
        ' dtpTanggalBayar
        ' 
        dtpTanggalBayar.Location = New Point(120, 247)
        dtpTanggalBayar.Name = "dtpTanggalBayar"
        dtpTanggalBayar.Size = New Size(250, 27)
        dtpTanggalBayar.TabIndex = 11
        ' 
        ' cboBulan
        ' 
        cboBulan.FormattingEnabled = True
        cboBulan.Location = New Point(511, 118)
        cboBulan.Name = "cboBulan"
        cboBulan.Size = New Size(151, 28)
        cboBulan.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(390, 162)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 20)
        Label6.TabIndex = 13
        Label6.Text = "Jumlah Bayar"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(390, 204)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 20)
        Label7.TabIndex = 14
        Label7.Text = "Status Bayar"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(390, 252)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 20)
        Label8.TabIndex = 15
        Label8.Text = "Keterangan"
        ' 
        ' txtJumlahBayar
        ' 
        txtJumlahBayar.Location = New Point(511, 159)
        txtJumlahBayar.Name = "txtJumlahBayar"
        txtJumlahBayar.Size = New Size(137, 27)
        txtJumlahBayar.TabIndex = 16
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(511, 201)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(151, 28)
        cboStatus.TabIndex = 17
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(511, 243)
        txtKeterangan.Multiline = True
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(125, 34)
        txtKeterangan.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 334)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 20)
        Label9.TabIndex = 19
        Label9.Text = "Cari Data"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(102, 331)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(373, 27)
        txtCari.TabIndex = 20
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(133, 289)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 21
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(267, 289)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 22
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(392, 289)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 23
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(511, 289)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 24
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvPembayaran
        ' 
        dgvPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPembayaran.Location = New Point(22, 366)
        dgvPembayaran.Name = "dgvPembayaran"
        dgvPembayaran.RowHeadersWidth = 51
        dgvPembayaran.Size = New Size(766, 82)
        dgvPembayaran.TabIndex = 25
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Smart_English__5_
        ClientSize = New Size(800, 450)
        Controls.Add(dgvPembayaran)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtCari)
        Controls.Add(Label9)
        Controls.Add(txtKeterangan)
        Controls.Add(cboStatus)
        Controls.Add(txtJumlahBayar)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(cboBulan)
        Controls.Add(dtpTanggalBayar)
        Controls.Add(cboNIS)
        Controls.Add(txtNamaSiswa)
        Controls.Add(txtIdBayar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgvPembayaran, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdBayar As TextBox
    Friend WithEvents txtNamaSiswa As TextBox
    Friend WithEvents cboNIS As ComboBox
    Friend WithEvents dtpTanggalBayar As DateTimePicker
    Friend WithEvents cboBulan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJumlahBayar As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvPembayaran As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
