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
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblPredikat = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(567, 100)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(213, 27)
        txtIPS.TabIndex = 0
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(567, 207)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(213, 27)
        txtIPK.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(415, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 2
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(415, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 3
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(645, 262)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(42, 20)
        lblPredikat.TabIndex = 4
        lblPredikat.Text = "Hasil"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(567, 142)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(97, 36)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(670, 142)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(110, 36)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1191, 450)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(lblPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button

End Class
