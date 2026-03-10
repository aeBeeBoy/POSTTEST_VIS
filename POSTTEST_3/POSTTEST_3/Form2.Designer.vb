<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        picHasil = New PictureBox()
        lblNamaHasil = New Label()
        lblUmurHasil = New Label()
        lblTanggalLahirHasil = New Label()
        lblJKHasil = New Label()
        lblTeleponHasil = New Label()
        lblAlamatHasil = New Label()
        lblHobbyHasil = New Label()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picHasil
        ' 
        picHasil.Location = New Point(65, 98)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(186, 250)
        picHasil.TabIndex = 0
        picHasil.TabStop = False
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.Location = New Point(312, 98)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(49, 20)
        lblNamaHasil.TabIndex = 1
        lblNamaHasil.Text = "Nama"
        ' 
        ' lblUmurHasil
        ' 
        lblUmurHasil.AutoSize = True
        lblUmurHasil.Location = New Point(312, 129)
        lblUmurHasil.Name = "lblUmurHasil"
        lblUmurHasil.Size = New Size(45, 20)
        lblUmurHasil.TabIndex = 2
        lblUmurHasil.Text = "Umur"
        ' 
        ' lblTanggalLahirHasil
        ' 
        lblTanggalLahirHasil.AutoSize = True
        lblTanggalLahirHasil.Location = New Point(312, 165)
        lblTanggalLahirHasil.Name = "lblTanggalLahirHasil"
        lblTanggalLahirHasil.Size = New Size(97, 20)
        lblTanggalLahirHasil.TabIndex = 3
        lblTanggalLahirHasil.Text = "Tanggal Lahir"
        ' 
        ' lblJKHasil
        ' 
        lblJKHasil.AutoSize = True
        lblJKHasil.Location = New Point(312, 198)
        lblJKHasil.Name = "lblJKHasil"
        lblJKHasil.Size = New Size(98, 20)
        lblJKHasil.TabIndex = 4
        lblJKHasil.Text = "Jenis Kelamin"
        ' 
        ' lblTeleponHasil
        ' 
        lblTeleponHasil.AutoSize = True
        lblTeleponHasil.Location = New Point(312, 235)
        lblTeleponHasil.Name = "lblTeleponHasil"
        lblTeleponHasil.Size = New Size(89, 20)
        lblTeleponHasil.TabIndex = 5
        lblTeleponHasil.Text = "No. Telepon"
        ' 
        ' lblAlamatHasil
        ' 
        lblAlamatHasil.AutoSize = True
        lblAlamatHasil.Location = New Point(312, 268)
        lblAlamatHasil.Name = "lblAlamatHasil"
        lblAlamatHasil.Size = New Size(57, 20)
        lblAlamatHasil.TabIndex = 6
        lblAlamatHasil.Text = "Alamat"
        ' 
        ' lblHobbyHasil
        ' 
        lblHobbyHasil.AutoSize = True
        lblHobbyHasil.Location = New Point(312, 299)
        lblHobbyHasil.Name = "lblHobbyHasil"
        lblHobbyHasil.Size = New Size(54, 20)
        lblHobbyHasil.TabIndex = 7
        lblHobbyHasil.Text = "Hobby"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Smart_English__2_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblHobbyHasil)
        Controls.Add(lblAlamatHasil)
        Controls.Add(lblTeleponHasil)
        Controls.Add(lblJKHasil)
        Controls.Add(lblTanggalLahirHasil)
        Controls.Add(lblUmurHasil)
        Controls.Add(lblNamaHasil)
        Controls.Add(picHasil)
        Name = "FormHasil"
        Text = "Form2"
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picHasil As PictureBox
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblUmurHasil As Label
    Friend WithEvents lblTanggalLahirHasil As Label
    Friend WithEvents lblJKHasil As Label
    Friend WithEvents lblTeleponHasil As Label
    Friend WithEvents lblAlamatHasil As Label
    Friend WithEvents lblHobbyHasil As Label
End Class
