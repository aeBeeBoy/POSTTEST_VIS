<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNIS = New TextBox()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        cboJK = New ComboBox()
        cboLevel = New ComboBox()
        mtbnoHP = New MaskedTextBox()
        Label7 = New Label()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvSiswa = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1 = New MenuStrip()
        mnuKeluar = New ToolStripMenuItem()
        mnuRefresh = New ToolStripMenuItem()
        mnuKosongkan = New ToolStripMenuItem()
        CType(dgvSiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(178, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 20)
        Label1.TabIndex = 0
        Label1.Text = "NIS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(178, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama Siswa"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(186, 284)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 3
        Label4.Text = "Level Kelas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(186, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 4
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(188, 358)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 5
        Label6.Text = "No. HP"
        ' 
        ' txtNIS
        ' 
        txtNIS.Location = New Point(216, 156)
        txtNIS.Name = "txtNIS"
        txtNIS.Size = New Size(193, 27)
        txtNIS.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(274, 193)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(104, 27)
        txtNama.TabIndex = 7
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(274, 322)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(125, 27)
        txtAlamat.TabIndex = 10
        ' 
        ' cboJK
        ' 
        cboJK.FormattingEnabled = True
        cboJK.Items.AddRange(New Object() {"Laki-laki", "", "Perempuan"})
        cboJK.Location = New Point(282, 235)
        cboJK.Name = "cboJK"
        cboJK.Size = New Size(151, 28)
        cboJK.TabIndex = 12
        ' 
        ' cboLevel
        ' 
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Beginner", "", "Intermediate", "", "Advanced"})
        cboLevel.Location = New Point(282, 281)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(128, 28)
        cboLevel.TabIndex = 13
        ' 
        ' mtbnoHP
        ' 
        mtbnoHP.Location = New Point(274, 355)
        mtbnoHP.Mask = "0000-0000-0000"
        mtbnoHP.Name = "mtbnoHP"
        mtbnoHP.Size = New Size(125, 27)
        mtbnoHP.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(186, 399)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 20)
        Label7.TabIndex = 16
        Label7.Text = "Cari data"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(274, 399)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 17
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Blue
        btnSimpan.ForeColor = SystemColors.ActiveCaptionText
        btnSimpan.Location = New Point(577, 489)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 18
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Yellow
        btnUbah.Location = New Point(705, 489)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 19
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Location = New Point(826, 489)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 20
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Gray
        btnBatal.Location = New Point(947, 489)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 21
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvSiswa
        ' 
        dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSiswa.Location = New Point(581, 174)
        dgvSiswa.Name = "dgvSiswa"
        dgvSiswa.RowHeadersWidth = 51
        dgvSiswa.Size = New Size(460, 267)
        dgvSiswa.TabIndex = 22
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuKeluar, mnuRefresh, mnuKosongkan})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1180, 28)
        MenuStrip1.TabIndex = 23
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(65, 24)
        mnuKeluar.Text = "Keluar"
        ' 
        ' mnuRefresh
        ' 
        mnuRefresh.Name = "mnuRefresh"
        mnuRefresh.Size = New Size(108, 24)
        mnuRefresh.Text = "Refresh Data"
        ' 
        ' mnuKosongkan
        ' 
        mnuKosongkan.Name = "mnuKosongkan"
        mnuKosongkan.Size = New Size(134, 24)
        mnuKosongkan.Text = "Kosongkan Form"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Smart_English__3_1
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1180, 588)
        Controls.Add(dgvSiswa)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(Label7)
        Controls.Add(mtbnoHP)
        Controls.Add(cboLevel)
        Controls.Add(cboJK)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(txtNIS)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        CType(dgvSiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNIS As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cboJK As ComboBox
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents mtbnoHP As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvSiswa As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents mnuRefresh As ToolStripMenuItem
    Friend WithEvents mnuKosongkan As ToolStripMenuItem

End Class
