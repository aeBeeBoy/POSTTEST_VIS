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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        cbDivisi = New ComboBox()
        RadioButton1 = New RadioButton()
        rbLaki = New RadioButton()
        dtpTglLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        mtxtNoHP = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        Label10 = New Label()
        btnSimpandanCetak = New Button()
        cbEvent = New CheckBox()
        cbCoaching = New CheckBox()
        cbVideoEditing = New CheckBox()
        cbContentCreator = New CheckBox()
        cbLivestream = New CheckBox()
        cbTournament = New CheckBox()
        cbScrim = New CheckBox()
        cbRankedMatch = New CheckBox()
        GroupBox1 = New GroupBox()
        rbCoach = New RadioButton()
        rbSniper = New RadioButton()
        rbSupport = New RadioButton()
        rbCorelayer = New RadioButton()
        rbCaptain = New RadioButton()
        btnSearch = New Button()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.GradientActiveCaption
        MenuStrip1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(640, 25)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(87, 21)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(91, 21)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(103, 21)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(88, 21)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(63, 21)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.AliceBlue
        Label1.Location = New Point(223, 46)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 25)
        Label1.TabIndex = 1
        Label1.Text = "EVOS MEMBER CARD"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(33, 91)
        TabControl1.Margin = New Padding(2, 2, 2, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(576, 311)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(cbDivisi)
        TabPage1.Controls.Add(RadioButton1)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpTglLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Margin = New Padding(2, 2, 2, 2)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(2, 2, 2, 2)
        TabPage1.Size = New Size(568, 282)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 8F)
        Label6.Location = New Point(300, 107)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 17)
        Label6.TabIndex = 10
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8F)
        Label5.Location = New Point(95, 171)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 17)
        Label5.TabIndex = 9
        Label5.Text = "Divisi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 8F)
        Label4.Location = New Point(95, 107)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 17)
        Label4.TabIndex = 8
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8F)
        Label3.Location = New Point(300, 40)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 17)
        Label3.TabIndex = 7
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8F)
        Label2.Location = New Point(97, 40)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 17)
        Label2.TabIndex = 6
        Label2.Text = "Nama"
        ' 
        ' cbDivisi
        ' 
        cbDivisi.Font = New Font("Microsoft Sans Serif", 8F)
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Mobile Legends", "Valorant", "PUBG Mobile", "Free Fire", "Dota 2", "CS2"})
        cbDivisi.Location = New Point(95, 194)
        cbDivisi.Margin = New Padding(2, 2, 2, 2)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(168, 24)
        cbDivisi.TabIndex = 5
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Microsoft Sans Serif", 8F)
        RadioButton1.Location = New Point(300, 160)
        RadioButton1.Margin = New Padding(2, 2, 2, 2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(102, 21)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Perempuan"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Microsoft Sans Serif", 8F)
        rbLaki.Location = New Point(300, 132)
        rbLaki.Margin = New Padding(2, 2, 2, 2)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 21)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Font = New Font("Microsoft Sans Serif", 8F)
        dtpTglLahir.Format = DateTimePickerFormat.Short
        dtpTglLahir.Location = New Point(96, 130)
        dtpTglLahir.Margin = New Padding(2, 2, 2, 2)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(167, 23)
        dtpTglLahir.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Microsoft Sans Serif", 8F)
        txtID.Location = New Point(300, 62)
        txtID.Margin = New Padding(2, 2, 2, 2)
        txtID.Name = "txtID"
        txtID.Size = New Size(168, 23)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Microsoft Sans Serif", 8F)
        txtNama.Location = New Point(96, 62)
        txtNama.Margin = New Padding(2, 2, 2, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(167, 23)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(mtxtNoHP)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Margin = New Padding(2, 2, 2, 2)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(2, 2, 2, 2)
        TabPage2.Size = New Size(568, 282)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak dan Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 8F)
        Label9.Location = New Point(167, 160)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 17)
        Label9.TabIndex = 6
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 8F)
        Label8.Location = New Point(167, 123)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 17)
        Label8.TabIndex = 5
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8F)
        Label7.Location = New Point(167, 87)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 17)
        Label7.TabIndex = 4
        Label7.Text = "No HP"
        ' 
        ' mtxtNoHP
        ' 
        mtxtNoHP.Font = New Font("Microsoft Sans Serif", 8F)
        mtxtNoHP.Location = New Point(260, 85)
        mtxtNoHP.Margin = New Padding(2, 2, 2, 2)
        mtxtNoHP.Mask = "0000-0000-0000"
        mtxtNoHP.Name = "mtxtNoHP"
        mtxtNoHP.Size = New Size(150, 23)
        mtxtNoHP.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Microsoft Sans Serif", 8F)
        txtAlamat.Location = New Point(260, 158)
        txtAlamat.Margin = New Padding(2, 2, 2, 2)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(150, 23)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Microsoft Sans Serif", 8F)
        txtEmail.Location = New Point(260, 121)
        txtEmail.Margin = New Padding(2, 2, 2, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 23)
        txtEmail.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(btnSimpandanCetak)
        TabPage3.Controls.Add(cbEvent)
        TabPage3.Controls.Add(cbCoaching)
        TabPage3.Controls.Add(cbVideoEditing)
        TabPage3.Controls.Add(cbContentCreator)
        TabPage3.Controls.Add(cbLivestream)
        TabPage3.Controls.Add(cbTournament)
        TabPage3.Controls.Add(cbScrim)
        TabPage3.Controls.Add(cbRankedMatch)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnSearch)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.Location = New Point(4, 25)
        TabPage3.Margin = New Padding(2, 2, 2, 2)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(2, 2, 2, 2)
        TabPage3.Size = New Size(568, 282)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil dan Aktivtas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 8F)
        Label10.Location = New Point(308, 50)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 17)
        Label10.TabIndex = 12
        Label10.Text = "Activity"
        ' 
        ' btnSimpandanCetak
        ' 
        btnSimpandanCetak.BackColor = SystemColors.ScrollBar
        btnSimpandanCetak.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpandanCetak.Location = New Point(16, 230)
        btnSimpandanCetak.Margin = New Padding(2, 2, 2, 2)
        btnSimpandanCetak.Name = "btnSimpandanCetak"
        btnSimpandanCetak.Size = New Size(544, 27)
        btnSimpandanCetak.TabIndex = 11
        btnSimpandanCetak.Text = "Simpan dan Cetak"
        btnSimpandanCetak.UseVisualStyleBackColor = False
        ' 
        ' cbEvent
        ' 
        cbEvent.AutoSize = True
        cbEvent.Font = New Font("Microsoft Sans Serif", 8F)
        cbEvent.Location = New Point(429, 179)
        cbEvent.Margin = New Padding(2, 2, 2, 2)
        cbEvent.Name = "cbEvent"
        cbEvent.Size = New Size(133, 21)
        cbEvent.TabIndex = 10
        cbEvent.Text = "Event Organizer"
        cbEvent.UseVisualStyleBackColor = True
        ' 
        ' cbCoaching
        ' 
        cbCoaching.AutoSize = True
        cbCoaching.Font = New Font("Microsoft Sans Serif", 8F)
        cbCoaching.Location = New Point(429, 146)
        cbCoaching.Margin = New Padding(2, 2, 2, 2)
        cbCoaching.Name = "cbCoaching"
        cbCoaching.Size = New Size(89, 21)
        cbCoaching.TabIndex = 9
        cbCoaching.Text = "Coaching"
        cbCoaching.UseVisualStyleBackColor = True
        ' 
        ' cbVideoEditing
        ' 
        cbVideoEditing.AutoSize = True
        cbVideoEditing.Font = New Font("Microsoft Sans Serif", 8F)
        cbVideoEditing.Location = New Point(429, 112)
        cbVideoEditing.Margin = New Padding(2, 2, 2, 2)
        cbVideoEditing.Name = "cbVideoEditing"
        cbVideoEditing.Size = New Size(113, 21)
        cbVideoEditing.TabIndex = 8
        cbVideoEditing.Text = "Video Editing"
        cbVideoEditing.UseVisualStyleBackColor = True
        ' 
        ' cbContentCreator
        ' 
        cbContentCreator.AutoSize = True
        cbContentCreator.Font = New Font("Microsoft Sans Serif", 8F)
        cbContentCreator.Location = New Point(429, 80)
        cbContentCreator.Margin = New Padding(2, 2, 2, 2)
        cbContentCreator.Name = "cbContentCreator"
        cbContentCreator.Size = New Size(130, 21)
        cbContentCreator.TabIndex = 7
        cbContentCreator.Text = "Content Creator"
        cbContentCreator.UseVisualStyleBackColor = True
        ' 
        ' cbLivestream
        ' 
        cbLivestream.AutoSize = True
        cbLivestream.Font = New Font("Microsoft Sans Serif", 8F)
        cbLivestream.Location = New Point(308, 179)
        cbLivestream.Margin = New Padding(2, 2, 2, 2)
        cbLivestream.Name = "cbLivestream"
        cbLivestream.Size = New Size(99, 21)
        cbLivestream.TabIndex = 6
        cbLivestream.Text = "Livestream"
        cbLivestream.UseVisualStyleBackColor = True
        ' 
        ' cbTournament
        ' 
        cbTournament.AutoSize = True
        cbTournament.Font = New Font("Microsoft Sans Serif", 8F)
        cbTournament.Location = New Point(308, 146)
        cbTournament.Margin = New Padding(2, 2, 2, 2)
        cbTournament.Name = "cbTournament"
        cbTournament.Size = New Size(107, 21)
        cbTournament.TabIndex = 5
        cbTournament.Text = "Tournament"
        cbTournament.UseVisualStyleBackColor = True
        ' 
        ' cbScrim
        ' 
        cbScrim.AutoSize = True
        cbScrim.Font = New Font("Microsoft Sans Serif", 8F)
        cbScrim.Location = New Point(308, 112)
        cbScrim.Margin = New Padding(2, 2, 2, 2)
        cbScrim.Name = "cbScrim"
        cbScrim.Size = New Size(65, 21)
        cbScrim.TabIndex = 4
        cbScrim.Text = "Scrim"
        cbScrim.UseVisualStyleBackColor = True
        ' 
        ' cbRankedMatch
        ' 
        cbRankedMatch.AutoSize = True
        cbRankedMatch.Font = New Font("Microsoft Sans Serif", 8F)
        cbRankedMatch.Location = New Point(308, 80)
        cbRankedMatch.Margin = New Padding(2, 2, 2, 2)
        cbRankedMatch.Name = "cbRankedMatch"
        cbRankedMatch.Size = New Size(121, 21)
        cbRankedMatch.TabIndex = 3
        cbRankedMatch.Text = "Ranked Match"
        cbRankedMatch.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbCoach)
        GroupBox1.Controls.Add(rbSniper)
        GroupBox1.Controls.Add(rbSupport)
        GroupBox1.Controls.Add(rbCorelayer)
        GroupBox1.Controls.Add(rbCaptain)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(168, 42)
        GroupBox1.Margin = New Padding(2, 2, 2, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 2, 2, 2)
        GroupBox1.Size = New Size(128, 170)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Role"
        ' 
        ' rbCoach
        ' 
        rbCoach.AutoSize = True
        rbCoach.Location = New Point(14, 137)
        rbCoach.Margin = New Padding(2, 2, 2, 2)
        rbCoach.Name = "rbCoach"
        rbCoach.Size = New Size(69, 21)
        rbCoach.TabIndex = 4
        rbCoach.TabStop = True
        rbCoach.Text = "Coach"
        rbCoach.UseVisualStyleBackColor = True
        ' 
        ' rbSniper
        ' 
        rbSniper.AutoSize = True
        rbSniper.Location = New Point(13, 109)
        rbSniper.Margin = New Padding(2, 2, 2, 2)
        rbSniper.Name = "rbSniper"
        rbSniper.Size = New Size(70, 21)
        rbSniper.TabIndex = 3
        rbSniper.TabStop = True
        rbSniper.Text = "Sniper"
        rbSniper.UseVisualStyleBackColor = True
        ' 
        ' rbSupport
        ' 
        rbSupport.AutoSize = True
        rbSupport.Location = New Point(13, 81)
        rbSupport.Margin = New Padding(2, 2, 2, 2)
        rbSupport.Name = "rbSupport"
        rbSupport.Size = New Size(79, 21)
        rbSupport.TabIndex = 2
        rbSupport.TabStop = True
        rbSupport.Text = "Support"
        rbSupport.UseVisualStyleBackColor = True
        ' 
        ' rbCorelayer
        ' 
        rbCorelayer.AutoSize = True
        rbCorelayer.Location = New Point(13, 53)
        rbCorelayer.Margin = New Padding(2, 2, 2, 2)
        rbCorelayer.Name = "rbCorelayer"
        rbCorelayer.Size = New Size(103, 21)
        rbCorelayer.TabIndex = 1
        rbCorelayer.TabStop = True
        rbCorelayer.Text = "Core Player"
        rbCorelayer.UseVisualStyleBackColor = True
        ' 
        ' rbCaptain
        ' 
        rbCaptain.AutoSize = True
        rbCaptain.Location = New Point(13, 25)
        rbCaptain.Margin = New Padding(2, 2, 2, 2)
        rbCaptain.Name = "rbCaptain"
        rbCaptain.Size = New Size(77, 21)
        rbCaptain.TabIndex = 0
        rbCaptain.TabStop = True
        rbCaptain.Text = "Captain"
        rbCaptain.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.DarkSlateGray
        btnSearch.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ButtonHighlight
        btnSearch.Location = New Point(16, 200)
        btnSearch.Margin = New Padding(2, 2, 2, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(134, 26)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(16, 30)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(134, 166)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(529, 44)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(80, 68)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(640, 435)
        Controls.Add(PictureBox2)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxtNoHP As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rbCoach As RadioButton
    Friend WithEvents rbSniper As RadioButton
    Friend WithEvents rbSupport As RadioButton
    Friend WithEvents rbCorelayer As RadioButton
    Friend WithEvents rbCaptain As RadioButton
    Friend WithEvents cbLivestream As CheckBox
    Friend WithEvents cbTournament As CheckBox
    Friend WithEvents cbScrim As CheckBox
    Friend WithEvents cbRankedMatch As CheckBox
    Friend WithEvents cbEvent As CheckBox
    Friend WithEvents cbCoaching As CheckBox
    Friend WithEvents cbVideoEditing As CheckBox
    Friend WithEvents cbContentCreator As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSimpandanCetak As Button
    Friend WithEvents PictureBox2 As PictureBox

End Class
