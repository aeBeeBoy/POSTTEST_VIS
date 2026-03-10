<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        picFoto = New PictureBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        LinkLabel1 = New LinkLabel()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggalLahir = New Label()
        lblNoTelepon = New Label()
        lblJenisKelamin = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelepon = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        grpJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLakiLaki = New RadioButton()
        grpHobby = New GroupBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox1 = New CheckBox()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpJenisKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = SystemColors.ActiveCaption
        picFoto.Location = New Point(12, 24)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(223, 351)
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(62, 387)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(90, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(438, 387)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(94, 29)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(0, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 20)
        LinkLabel1.TabIndex = 3
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(266, 38)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(266, 71)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(45, 20)
        lblUmur.TabIndex = 5
        lblUmur.Text = "Umur"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.Location = New Point(266, 104)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(97, 20)
        lblTanggalLahir.TabIndex = 6
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblNoTelepon
        ' 
        lblNoTelepon.AutoSize = True
        lblNoTelepon.Location = New Point(266, 140)
        lblNoTelepon.Name = "lblNoTelepon"
        lblNoTelepon.Size = New Size(89, 20)
        lblNoTelepon.TabIndex = 7
        lblNoTelepon.Text = "No. Telepon"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Location = New Point(15, 0)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(98, 20)
        lblJenisKelamin.TabIndex = 8
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(21, 0)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(54, 20)
        lblHobby.TabIndex = 9
        lblHobby.Text = "Hobby"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(266, 171)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 10
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(392, 31)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 11
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(392, 64)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(125, 27)
        txtUmur.TabIndex = 12
        ' 
        ' txtNoTelepon
        ' 
        txtNoTelepon.Location = New Point(392, 140)
        txtNoTelepon.Name = "txtNoTelepon"
        txtNoTelepon.Size = New Size(125, 27)
        txtNoTelepon.TabIndex = 13
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(392, 173)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(125, 27)
        txtAlamat.TabIndex = 14
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(392, 104)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(250, 27)
        dtpTanggalLahir.TabIndex = 15
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.Controls.Add(rbPerempuan)
        grpJenisKelamin.Controls.Add(rbLakiLaki)
        grpJenisKelamin.Controls.Add(lblJenisKelamin)
        grpJenisKelamin.Location = New Point(266, 203)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(230, 178)
        grpJenisKelamin.TabIndex = 16
        grpJenisKelamin.TabStop = False
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(15, 65)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 10
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Location = New Point(15, 26)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(96, 24)
        rbLakiLaki.TabIndex = 18
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki - Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(CheckBox2)
        grpHobby.Controls.Add(CheckBox3)
        grpHobby.Controls.Add(CheckBox4)
        grpHobby.Controls.Add(CheckBox5)
        grpHobby.Controls.Add(CheckBox6)
        grpHobby.Controls.Add(CheckBox7)
        grpHobby.Controls.Add(CheckBox8)
        grpHobby.Controls.Add(CheckBox9)
        grpHobby.Controls.Add(CheckBox10)
        grpHobby.Controls.Add(CheckBox1)
        grpHobby.Controls.Add(lblHobby)
        grpHobby.Location = New Point(521, 203)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(253, 178)
        grpHobby.TabIndex = 17
        grpHobby.TabStop = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 62)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(77, 24)
        CheckBox2.TabIndex = 19
        CheckBox2.Text = "Menari"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(6, 88)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(97, 24)
        CheckBox3.TabIndex = 20
        CheckBox3.Text = "Membaca"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 118)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(92, 24)
        CheckBox4.TabIndex = 21
        CheckBox4.Text = "Olahraga"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(6, 148)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(121, 24)
        CheckBox5.TabIndex = 22
        CheckBox5.Text = "Menggambar"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(142, 28)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(82, 24)
        CheckBox6.TabIndex = 23
        CheckBox6.Text = "Menulis"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(142, 58)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(109, 24)
        CheckBox7.TabIndex = 24
        CheckBox7.Text = "Memancing"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(142, 88)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(94, 24)
        CheckBox8.TabIndex = 25
        CheckBox8.Text = "Menyanyi"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(142, 118)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(91, 24)
        CheckBox9.TabIndex = 26
        CheckBox9.Text = "Traveling"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(142, 148)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(79, 24)
        CheckBox10.TabIndex = 27
        CheckBox10.Text = "Coding"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 32)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(83, 24)
        CheckBox1.TabIndex = 18
        CheckBox1.Text = "Gaming"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grpHobby)
        Controls.Add(grpJenisKelamin)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTelepon)
        Controls.Add(lblTanggalLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(LinkLabel1)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Name = "FormCetak"
        Text = "Form1"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpJenisKelamin.ResumeLayout(False)
        grpJenisKelamin.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblNoTelepon As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents grpJenisKelamin As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox

End Class
