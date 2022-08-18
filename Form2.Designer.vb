<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SynoloOres
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SynoloOres))
        Me.ergates = New System.Windows.Forms.ComboBox
        Me.ergasia = New System.Windows.Forms.ComboBox
        Me.KATAX = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.apoH = New System.Windows.Forms.ComboBox
        Me.apoM = New System.Windows.Forms.ComboBox
        Me.eosM = New System.Windows.Forms.ComboBox
        Me.eosH = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.kila = New System.Windows.Forms.TextBox
        Me.kilalab = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button
        Me.day = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ergates
        '
        Me.ergates.FormattingEnabled = True
        Me.ergates.Location = New System.Drawing.Point(2, 26)
        Me.ergates.Name = "ergates"
        Me.ergates.Size = New System.Drawing.Size(185, 21)
        Me.ergates.TabIndex = 0
        '
        'ergasia
        '
        Me.ergasia.FormattingEnabled = True
        Me.ergasia.Location = New System.Drawing.Point(193, 26)
        Me.ergasia.Name = "ergasia"
        Me.ergasia.Size = New System.Drawing.Size(205, 21)
        Me.ergasia.TabIndex = 1
        '
        'KATAX
        '
        Me.KATAX.Enabled = False
        Me.KATAX.Location = New System.Drawing.Point(454, 50)
        Me.KATAX.Name = "KATAX"
        Me.KATAX.Size = New System.Drawing.Size(112, 24)
        Me.KATAX.TabIndex = 2
        Me.KATAX.Text = "oldΚαταχώρηση"
        Me.KATAX.UseVisualStyleBackColor = True
        Me.KATAX.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "..."
        '
        'ComboBox1
        '
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(923, 256)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(93, 21)
        Me.ComboBox1.TabIndex = 20
        Me.ComboBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = ".."
        '
        'apoH
        '
        Me.apoH.FormattingEnabled = True
        Me.apoH.Items.AddRange(New Object() {"04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.apoH.Location = New System.Drawing.Point(641, 12)
        Me.apoH.Name = "apoH"
        Me.apoH.Size = New System.Drawing.Size(53, 21)
        Me.apoH.TabIndex = 22
        '
        'apoM
        '
        Me.apoM.FormattingEnabled = True
        Me.apoM.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", ""})
        Me.apoM.Location = New System.Drawing.Point(700, 12)
        Me.apoM.Name = "apoM"
        Me.apoM.Size = New System.Drawing.Size(53, 21)
        Me.apoM.TabIndex = 24
        '
        'eosM
        '
        Me.eosM.FormattingEnabled = True
        Me.eosM.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", ""})
        Me.eosM.Location = New System.Drawing.Point(700, 39)
        Me.eosM.Name = "eosM"
        Me.eosM.Size = New System.Drawing.Size(53, 21)
        Me.eosM.TabIndex = 26
        '
        'eosH
        '
        Me.eosH.FormattingEnabled = True
        Me.eosH.Items.AddRange(New Object() {"04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.eosH.Location = New System.Drawing.Point(641, 39)
        Me.eosH.Name = "eosH"
        Me.eosH.Size = New System.Drawing.Size(53, 21)
        Me.eosH.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(592, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Από"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(592, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Εως"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(638, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 22)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Ακυρο/Αλλαγή Εργασίας"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'kila
        '
        Me.kila.Location = New System.Drawing.Point(502, 16)
        Me.kila.Name = "kila"
        Me.kila.Size = New System.Drawing.Size(64, 20)
        Me.kila.TabIndex = 32
        '
        'kilalab
        '
        Me.kilalab.AutoSize = True
        Me.kilalab.Location = New System.Drawing.Point(443, 21)
        Me.kilalab.Name = "kilalab"
        Me.kilalab.Size = New System.Drawing.Size(58, 13)
        Me.kilalab.TabIndex = 33
        Me.kilalab.Text = "Ποσότητα"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(759, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 25)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ωρες"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(759, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(127, 43)
        Me.ListBox1.TabIndex = 35
        '
        'Button3
        '
        Me.Button3.ImageKey = "cancel_48.png"
        Me.Button3.ImageList = Me.ImageList4
        Me.Button3.Location = New System.Drawing.Point(857, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 25)
        Me.Button3.TabIndex = 36
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "print_64.png")
        Me.ImageList4.Images.SetKeyName(1, "cancel_48.png")
        Me.ImageList4.Images.SetKeyName(2, "search_48.png")
        Me.ImageList4.Images.SetKeyName(3, "Delete.png")
        Me.ImageList4.Images.SetKeyName(4, "Edit.png")
        Me.ImageList4.Images.SetKeyName(5, "Add.png")
        Me.ImageList4.Images.SetKeyName(6, "lock_48.png")
        Me.ImageList4.Images.SetKeyName(7, "home.ico")
        Me.ImageList4.Images.SetKeyName(8, "home_64.png")
        '
        'Button4
        '
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 8
        Me.Button4.ImageList = Me.ImageList4
        Me.Button4.Location = New System.Drawing.Point(920, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 24)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Εξοδος"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'day
        '
        Me.day.AutoSize = True
        Me.day.Location = New System.Drawing.Point(8, 7)
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(0, 13)
        Me.day.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(2, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2000, 583)
        Me.Panel1.TabIndex = 40
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(2, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(110, 20)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(118, 52)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 22)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "Διαγραφή εργασιών"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(920, 10)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 26)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Καταχώρηση"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'SynoloOres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 519)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.day)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kilalab)
        Me.Controls.Add(Me.kila)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.eosM)
        Me.Controls.Add(Me.eosH)
        Me.Controls.Add(Me.apoM)
        Me.Controls.Add(Me.apoH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KATAX)
        Me.Controls.Add(Me.ergasia)
        Me.Controls.Add(Me.ergates)
        Me.Name = "SynoloOres"
        Me.Text = "Φόρμα Εργασιών"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ergates As System.Windows.Forms.ComboBox
    Friend WithEvents ergasia As System.Windows.Forms.ComboBox
    Friend WithEvents KATAX As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents apoH As System.Windows.Forms.ComboBox
    Friend WithEvents apoM As System.Windows.Forms.ComboBox
    Friend WithEvents eosM As System.Windows.Forms.ComboBox
    Friend WithEvents eosH As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents kila As System.Windows.Forms.TextBox
    Friend WithEvents kilalab As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents day As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
