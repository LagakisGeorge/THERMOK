Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Text
Public Class SynoloOres
    Dim btn(200) As Button

    Dim but(200, 2) As Button


    Dim btn1(200) As Button
    Dim btn2(200) As Button
    Dim btn3(200) As Button
    Dim btn4(200) As Button


    Dim fLab(200) As Label
    Dim mc() As System.Drawing.Color = {Color.Red, Color.Blue, Color.YellowGreen}

    Dim iderg(100) As Integer
    Dim idergasies(100) As Integer

    Dim f_othoni As Integer
    Dim f_Arxh As Integer
    Dim f_telos As Integer
    Dim f_step As Integer

    Dim f_metra As Integer
    Dim F_FIRST As Integer = 1
    Dim F_FIRST1 As Integer = 1
    Dim btnState(300)

    Dim mSTHLH As Integer

    Dim f_ores As Single



    Dim Ores_Erg(100, 4) As Integer, nOres_Erg As Integer


    Dim mStep As Integer ' +1 / -1 analoga me to f_step

    '  Inherits System.Windows.Forms.Form

    ' declare our class array collection to be used with its event(s)
    ' and set it up with 5 classes in it.
    Private WithEvents MyClassArray As New ClassArrayExample.ClassArray(5)


    'Create connection
    Dim conn As SqlConnection

    'create data adapter
    Dim da As SqlDataAdapter

    'create dataset
    Dim ds As DataSet = New DataSet

    'Set up connection string
    Dim cnString As String



    Public Structure ColoredComboboxItem
        Dim Text As String
        Dim Color As Color
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Structure


    Public Property f_othonia() As Integer
        Get
            Return mSTHLH
        End Get
        Set(ByVal Value As Integer)
            ' If Value < 1 Or Value > 12 Then
            ' Error processing for invalid value. 
            'Else
            mSTHLH = Value
            'End If
        End Set
    End Property




    Public Sub textReadWrite()


        'Imports System
        'Imports System.IO
        'Imports System.Text

        Dim path As String = "c:\temp\MyTest.txt"

        Try
            'If File.Exists(path) Then
            ' File.Delete(path)
            ' End If

            Dim sw As StreamWriter = New StreamWriter(path)
            sw.WriteLine("This")
            sw.WriteLine("is some text")
            sw.WriteLine("to test")
            sw.WriteLine("Reading")
            sw.Close()

            Dim sr As StreamReader = New StreamReader(path)

            Do While sr.Peek() >= 0
                Console.WriteLine(sr.ReadLine())
            Loop
            sr.Close()
        Catch e As Exception
            Console.WriteLine("The process failed: {0}", e.ToString())
        End Try
    End Sub



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'Dim iderg(100) As Long
        'Dim idergasies(100) As Long

        FILLComboBox2("select NAME,ID FROM ERGATES WHERE ENERGOS=1", ergates, iderg)
        FILLComboBox2("select (CASE WHEN SEIRES=1 THEN '*' + NAME ELSE NAME END ) AS ONOMA,ID FROM JOBS WHERE ENERGOS=1 ", ergasia, idergasies)

        day.Text = Now

        'διαβάζω ποιά οθόνη είναι απο το αρχείο c:\mercvb\config.ini
        Try

            Dim path As String = "c:\mercvb\config.ini"
            ''If File.Exists(path) Then
            '' File.Delete(path)
            '' End If


            'Dim sr As StreamReader = New StreamReader(Path)

            'Do While sr.Peek() >= 0
            '    'Console.WriteLine(sr.ReadLine())
            '    f_othoni = Val(sr.ReadLine())
            '    f_Arxh = Val(sr.ReadLine())
            '    f_telos = Val(sr.ReadLine())
            '    f_step = Val(sr.ReadLine())
            '    f_metra = Val(sr.ReadLine())

            '    'δεν θελω να διαβασει τις παρακατω σειρες που ειναι σχολια
            '    Exit Do

            'Loop
            'sr.Close()
            f_othoni = Me.f_othonia
            If f_othoni = 1 Then
                f_Arxh = 81 : f_telos = 11 : f_step = -2
            End If
            If f_othoni = 2 Then
                f_Arxh = 10 : f_telos = 80 : f_step = 2
            End If
            If f_othoni = 3 Then
                f_Arxh = 149 : f_telos = 85 : f_step = -2
            End If
            If f_othoni = 4 Then
                f_Arxh = 82 : f_telos = 148 : f_step = 2
            End If



            If f_step < 0 Then mStep = -1 Else mStep = +1
        Catch ee As Exception
            Console.WriteLine("The process failed: {0}", ee.ToString())
        End Try

        'If LOGID = 9 Then
        '    Button5.Visible = False
        '    KATAX.Visible = False
        '    Button6.Visible = False
        'End If



        '        WHEN FORM LOADS, LOAD SOME DATA INTO THE COMBOBOX:

        Dim myItem As New ColoredComboboxItem
        With myItem
            .Text = "Festo AG"
            .Color = Color.Blue
        End With
        ComboBox1.Items.Add(myItem)

        myItem = New ColoredComboboxItem
        With myItem
            .Text = "Bosch-Rexroth"
            .Color = Color.Green

        End With
        ComboBox1.Items.Add(myItem)

        myItem = New ColoredComboboxItem
        With myItem
            .Text = "Parcon"
            .Color = Color.Turquoise
        End With
        ComboBox1.Items.Add(myItem)


        'combobox1.dDrawItem property set to OwnerDrawFixed






        'cnString = "Data Source=localhost\SQLEXPRESS;Integrated Security=True;database=thermo"
        ''Str_Connection = cnString
        'Dim SQLqry
        'SQLqry = "SELECT NAME,N1,ID FROM ERGATES " ' ORDER BY HME "
        'conn = New SqlConnection(cnString)
        'Try
        '    ' Open connection
        '    conn.Open()

        '    da = New SqlDataAdapter(SQLqry, conn)

        '    'create command builder
        '    Dim cb As SqlCommandBuilder = New SqlCommandBuilder(da)
        '    ds.Clear()
        '    'fill dataset
        '    da.Fill(ds, "PEL")
        '    For k = 1 To ds.rows()

        'Catch ex As SqlException
        '    MsgBox(ex.ToString)
        'Finally
        '    ' Close connection
        '    conn.Close()
        'End Try












        ' call the addbuttons sub to add some buttons to the gui
        ' this sub creates, sets propertiess, and places the buttons.
        AddButtons()
    End Sub
    Private Sub AddButtons()

        'Dim top As Integer = 20
        'Dim left As Integer = 5

        'Dim i As Integer

        'Dim newButton As Button

        'For i = 1 To 70

        '    newButton = New Button()

        '    'set the properties for the new button
        '    With newButton
        '        .Width = 10
        '        .Height = 150
        '        .Text = "" & i.ToString
        '        .BackColor = Color.Black
        '        .Top = top
        '        .Left = left
        '    End With

        '    ' make the ButtonClick method handle the click event
        '    ' of this button
        '    AddHandler newButton.Click, AddressOf ButtonClick

        '    'buttongroup.Controls.Add(newButton)

        '    ' here we just make sure to neatly arrange the buttons =)
        '    'If (buttongroup.Width - left) < 190 Then
        '    'top += 10
        '    'left = 5
        '    'Else
        '    left += 12
        '    'End If

        'Next i

    End Sub

    ' this sub is triggered everytime a button is clicked. it must have the
    ' same signature of the buttons click event.
    ' Private Sub ButtonClick(ByVal sender As Object, ByVal e As EventArgs)
    '    MessageBox.Show(sender.text)
    'End Sub


    'Private Sub ComboBox1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem
    '    e.DrawBackground()
    '    'GET ITEM TO DRAW
    '    If Not e.Index = -1 Then
    '        Dim myItem As ColoredComboboxItem = DirectCast(ComboBox1.Items(e.Index), ColoredComboboxItem)
    '        'DRAW TEXT USING SPECIFIED FONT AND COLOR
    '        ListBox1.Items.Add(CInt(e.State).ToString)
    '        If e.State = 769 Or e.State = 785 Or e.State = 4881 Then
    '            e.Graphics.DrawString(myItem.Text, e.Font, New SolidBrush(Color.White), e.Bounds)
    '        Else
    '            e.Graphics.DrawString(myItem.Text, e.Font, New SolidBrush(myItem.Color), e.Bounds)
    '        End If
    '    End If
    '    e.DrawFocusRectangle()
    'End Sub

    Private Sub ComboBox1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem
        e.DrawBackground()

        'The ComboBox control has a DrawItem event which needs to be implemented in the code to achieve this. 
        'There is a property called 
        'DrawMode for the ComboBox control which determines whether the Operating System or the code will handle the drawing of the items in the list. 
        'This property must be set to ‘OwnerDrawFixed’ using the Properties window in order for the DrawItem event implementation to be called.





        'GET ITEM TO DRAW
        Dim rect As Rectangle
        rect = e.Bounds

        'Dim d As ArrayList ("aas","aass")

        'If (e.Index >= 0) Then
        '    Dim n As String
        '        n = ((ComboBox1)sender).Items[e.Index].ToString();
        '        Font font = new Font("Arial", 9, FontStyle.Regular);
        '        Color color = Color.FromName(n);
        '        Brush brush = new SolidBrush(color);

        '        e.Graphics.DrawString(n, font, Brushes.Black, rect.X, rect.Top);
        '        e.Graphics.FillRectangle(brush, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);

        'End If





        If Not e.Index = -1 Then
            Dim myItem As ColoredComboboxItem = DirectCast(ComboBox1.Items(e.Index), ColoredComboboxItem)
            'DRAW TEXT USING SPECIFIED FONT AND COLOR
            'Listbox1.Items.Add(CInt(e.State).ToString)

            Dim brush As SolidBrush
            brush = New SolidBrush(mc(e.Index))



            'If e.Index = 0 Then
            '    brush = New SolidBrush(Color.Red)
            'ElseIf e.Index = 1 Then
            '    brush = New SolidBrush(Color.Blue)
            'ElseIf e.Index = 2 Then
            '    brush = New SolidBrush(Color.YellowGreen)
            'End If


            e.Graphics.FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Height)
            'e.Graphics.DrawString(n, font, Brushes.Black, rect.X, rect.Top);
            'e.Graphics.FillRectangle(brush, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);

            If e.State = 769 Or e.State = 785 Or e.State = 4881 Then
                e.Graphics.DrawString(myItem.Text, e.Font, New SolidBrush(Color.White), e.Bounds)
            Else
                e.Graphics.DrawString(myItem.Text, e.Font, New SolidBrush(myItem.Color), e.Bounds)
            End If



        End If
        e.DrawFocusRectangle()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CreateGrid()
    End Sub

    Private Sub CreateGrid()

        'Create the button
        Dim Oth As Integer


        Dim marx As Integer = 149
        Dim mtel As Integer = 85

        ergates.Enabled = False
        ergasia.Enabled = False





        If Len(Dir("c:\mercvb\mercpath.txt")) > 1 Then
            Oth = 1
        End If
        Dim mErgaths As Integer
        Dim mergasia As Integer

        mErgaths = ergates.SelectedIndex
        mergasia = ergasia.SelectedIndex

        '1  81->11
        '2  10->80
        '3  149 -85
        '4  82 -148

        'Specify the 
        'location and the size
        Dim k As Long = 30

        Dim dx As Integer = 14
        Dim mc As Integer = 0




        Dim THESEIS As New DataTable


        ' ExecuteSQLQuery("SELECT * FROM JOBDETAIL  WHERE IDERGASIAS=" + Str(idergasies(mergasia)), THESEIS)
        ExecuteSQLQuery("SELECT E.NAME,*  FROM JOBDETAIL J LEFT JOIN ERGATES E ON J.IDERGATH=E.ID   WHERE IDERGASIAS=" + Str(idergasies(mergasia)), THESEIS)

        Dim NN As Integer = THESEIS.Rows.Count
        Dim TH(300, 2) As Integer
        Dim ono(300, 2) As String

        'ΒΡΙΣΚΩ ΤΗΝ ΚΑΘΕ ΘΕΣΗ ΣΕ ΤΙ ΚΑΤΑΣΤΑΣΗ ΕΙΝΑΙ
        For k = 0 To NN - 1
            If k = 57 Then
                k = 57
            End If

            TH(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = THESEIS.Rows(k)("IDERGATH")
            If THESEIS.Rows(k)("IDERGATH") > 0 Then 'ONOMA ERGATH
                ono(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = THESEIS.Rows(k)("NAME")
            Else
                ono(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = ""
            End If

            Debug.Print(k, TH(k, 1), TH(k, 2))
        Next

        ' k = 10
        ' mc = 1


        dx = 22 '14


        Dim dx2 As Integer = 37
        '  Dim sx As Integer
        '  sx = 12





        For k = f_Arxh To f_telos Step f_step

            If k = 57 Then
                k = 57
            End If


            If F_FIRST = 1 Then
                'F_FIRST = 0
                btn(k) = New Button()
            End If

            mc = mc + 1

            'labels me aritmoys
            fLab(k) = New Label()
            'fLab(k).BackColor = Color.Red
            'fLab(k).Location = New System.Drawing.Point(sx, 91)  palio mexri 1-4-15
            fLab(k).Location = New System.Drawing.Point(18 + mc * dx - dx, 91)
            ' fLab(k).Font.



            fLab(k).Size = New System.Drawing.Size(25, 13)
            fLab(k).Text = LTrim(Str(k))
            If F_FIRST = 1 Then
                Me.Controls.Add(fLab(k))
            End If


            fLab(k + 1) = New Label()
            ' fLab(k + 1).BackColor = Color.Red
            '  fLab(k + 1).Location = New System.Drawing.Point(sx, 415)
            fLab(k + 1).Location = New System.Drawing.Point(18 + mc * dx - dx, 415)

            fLab(k + 1).Size = New System.Drawing.Size(25, 13)
            fLab(k + 1).Text = LTrim(Str(k))
            If F_FIRST = 1 Then
                Me.Controls.Add(fLab(k + 1))
            End If

            '  sx = sx + 44 '50 '28  2/4/2015



            btn(k).Location = New System.Drawing.Point(4 + mc * dx - dx, 115)
            btn(k).Size = New System.Drawing.Size(dx, 288)  '15,288
            btn(k).Text = Str(k)
            If TH(k, 1) = 0 Then
                btn(k).BackColor = Color.Beige
                btnState(k) = 1
                ToolTip1.SetToolTip(btn(k), "")
            Else
                btn(k).BackColor = Color.Red
                btnState(k) = 0
                'btn(k).AccessibilityObject 
                ' Visual Basic 2008
                ToolTip1.SetToolTip(btn(k), ono(k, 1))
            End If

            'Add it to the forms control collection
            If F_FIRST = 1 Then
                Me.Controls.Add(btn(k))
                AddHandler btn(k).Click, AddressOf AllButtons_Click
                AddHandler btn(k).MouseMove, AddressOf AllButtons_mousemove
            End If

            '------------------------------------------------------------------
            If F_FIRST = 1 Then
                btn(k + mStep) = New Button()
            End If

            mc = mc + 1
            btn(k + mStep).Location = New System.Drawing.Point(4 + mc * dx - dx, 115)
            btn(k + mStep).Size = New System.Drawing.Size(dx, 288) '15,288

            If k Mod 2 = 0 Then
                btn(k + mStep).Text = Str(k) + "Δ"
            Else
                btn(k + mStep).Text = Str(k) + "Α"
            End If




            btn(k + mStep).TextAlign = ContentAlignment.BottomRight
            If TH(k, 2) = 0 Then
                btn(k + mStep).BackColor = Color.Yellow
                ToolTip1.SetToolTip(btn(k + mStep), "")
            Else
                btn(k + mStep).BackColor = Color.Red
                ToolTip1.SetToolTip(btn(k + mStep), ono(k, 2))
            End If

            'btn(k + mStep).BackColor = Color.Yellow
            'Add it to the forms control collection
            If F_FIRST = 1 Then
                Me.Controls.Add(btn(k + mStep))
                AddHandler btn(k + mStep).Click, AddressOf AllButtons_Click
                AddHandler btn(k + mStep).MouseMove, AddressOf AllButtons_mousemove
            End If
        Next



        F_FIRST = 0


        'Link the event to the event handler
        ' AddHandler btn.Click, AddressOf Me.ClickButton

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Panel1.Visible = False

    '    If Not Panel1.Controls.OfType(Of Button).Any() Then
    '        For x As Integer = 1 To 10
    '            For y As Integer = 1 To 10
    '                Dim btn As New Button()
    '                btn.Size = New Size(45, 45)
    '                btn.Location = New Point((x - 1) * 45, (y - 1) * 45)
    '                btn.Text = (x * y).ToString()
    '                Panel1.Controls.Add(btn)
    '                btn.Visible = True
    '            Next
    '        Next
    '    End If

    '    Panel1.Visible = True
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Panel1.Visible = False
    '    Panel1.Controls.Clear()
    '    Panel1.Visible = True
    'End Sub
    Sub CREATEGRID_ALL(ByVal YPSOS As Integer, ByVal DY As Integer, ByRef BTN() As Button)
        'Create the button
        Dim Oth As Integer


        Dim marx As Integer = 149
        Dim mtel As Integer = 85

        ergates.Enabled = False
        ergasia.Enabled = False





        If Len(Dir("c:\mercvb\mercpath.txt")) > 1 Then
            Oth = 1
        End If
        Dim mErgaths As Integer
        Dim mergasia As Integer

        mErgaths = ergates.SelectedIndex
        mergasia = ergasia.SelectedIndex

        '1  81->11
        '2  10->80
        '3  149 -85
        '4  82 -148

        'Specify the 
        'location and the size
        Dim k As Long = 30

        Dim dx As Integer = 14
        Dim mc As Integer = 0




        Dim THESEIS As New DataTable


        ' ExecuteSQLQuery("SELECT * FROM JOBDETAIL  WHERE IDERGASIAS=" + Str(idergasies(mergasia)), THESEIS)
        ExecuteSQLQuery("SELECT E.NAME,*  FROM JOBDETAIL J LEFT JOIN ERGATES E ON J.IDERGATH=E.ID   WHERE IDERGASIAS=" + Str(idergasies(mergasia)), THESEIS)

        Dim NN As Integer = THESEIS.Rows.Count
        Dim TH(300, 2) As Integer
        Dim ono(300, 2) As String

        'ΒΡΙΣΚΩ ΤΗΝ ΚΑΘΕ ΘΕΣΗ ΣΕ ΤΙ ΚΑΤΑΣΤΑΣΗ ΕΙΝΑΙ
        For k = 0 To NN - 1
            If k = 57 Then
                k = 57
            End If

            TH(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = THESEIS.Rows(k)("IDERGATH")
            If THESEIS.Rows(k)("IDERGATH") > 0 Then 'ONOMA ERGATH
                ono(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = THESEIS.Rows(k)("NAME")
            Else
                ono(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = ""
            End If

            'Debug.Print(k, TH(k, 1), TH(k, 2))
        Next

        ' k = 10
        ' mc = 1


        dx = 22 '14


        Dim dx2 As Integer = 37
        '  Dim sx As Integer
        '  sx = 12





        For k = f_Arxh To f_telos Step f_step

            If k = 57 Then
                k = 57
            End If


            If F_FIRST1 = 1 Then
                'F_FIRST = 0
                BTN(k) = New Button()
            End If

            mc = mc + 1

            ''labels me aritmoys
            'fLab(k) = New Label()
            'fLab(k).Location = New System.Drawing.Point(18 + mc * dx - dx, 91)
            'fLab(k).Size = New System.Drawing.Size(25, 13)
            'fLab(k).Text = LTrim(Str(k))

            'If F_FIRST = 1 Then
            '    Me.Controls.Add(fLab(k))
            'End If


            'fLab(k + 1) = New Label()
            'fLab(k + 1).Location = New System.Drawing.Point(18 + mc * dx - dx, 415)
            'fLab(k + 1).Size = New System.Drawing.Size(25, 13)
            'fLab(k + 1).Text = LTrim(Str(k))
            'If F_FIRST = 1 Then
            '    Me.Controls.Add(fLab(k + 1))
            'End If


            BTN(k).Location = New System.Drawing.Point(4 + mc * dx - dx, YPSOS) '115
            BTN(k).Size = New System.Drawing.Size(dx, DY)  '15,288
            BTN(k).Text = Str(k)
            If TH(k, 1) = 0 Then
                BTN(k).BackColor = Color.Beige
                btnState(k) = 1
                ToolTip1.SetToolTip(BTN(k), "")
            Else
                BTN(k).BackColor = Color.Red
                btnState(k) = 0
                ToolTip1.SetToolTip(BTN(k), ono(k, 1))
            End If

            'Add it to the forms control collection
            If F_FIRST1 = 1 Then
                Panel1.Controls.Add(BTN(k))
                'Me.Controls.Add(BTN(k))
                AddHandler BTN(k).Click, AddressOf AllButtons_Click
                AddHandler BTN(k).MouseMove, AddressOf AllButtons_mousemove
            End If

            '------------------------------------------------------------------
            If F_FIRST1 = 1 Then
                BTN(k + mStep) = New Button()
            End If

            mc = mc + 1
            BTN(k + mStep).Location = New System.Drawing.Point(4 + mc * dx - dx, YPSOS)
            BTN(k + mStep).Size = New System.Drawing.Size(dx, DY) '15,288

            If k Mod 2 = 0 Then
                BTN(k + mStep).Text = Str(k) + "Δ"
            Else
                BTN(k + mStep).Text = Str(k) + "Α"
            End If




            BTN(k + mStep).TextAlign = ContentAlignment.BottomRight
            If TH(k, 2) = 0 Then
                BTN(k + mStep).BackColor = Color.Yellow
                ToolTip1.SetToolTip(BTN(k + mStep), "")
            Else
                BTN(k + mStep).BackColor = Color.Red
                ToolTip1.SetToolTip(BTN(k + mStep), ono(k, 2))
            End If

            If F_FIRST = 1 Then
                Panel1.Controls.Add(BTN(k + mStep))
                ' Me.Controls.Add(BTN(k + mStep))
                AddHandler BTN(k + mStep).Click, AddressOf AllButtons_Click
                AddHandler BTN(k + mStep).MouseMove, AddressOf AllButtons_mousemove
            End If

            BTN(k) = Nothing
            BTN(k + mStep) = Nothing

        Next



        ' F_FIRST1 = 0
        '  For k = f_Arxh To f_telos Step f_step
        ' BTN(k).Dispose()
        ' BTN(k + mStep).Dispose()
        ' Next

        'Link the event to the event handler
        ' AddHandler btn.Click, AddressOf Me.ClickButton


    End Sub




    REM AllButtons_Click is a sub I created, note that it doesn't have a "handles" statement at the end
    Private Sub AllButtons_mousemove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'ByVal sender As System.Object, ByVal e As System.EventArgs)


        'MsgBox("You Pushed The Button Named " & sender.ToString)


        'REM a button object that we will "link" to the actual button
        Dim TempButton As Button

        'REM Convert the "sender" object, which is a System.Object to a Button.
        'REM This makes sure that we can set and check Button properties.
        TempButton = CType(sender, Button)


        'REM Make a visible change to the button pushed.
        Label1.Text = TempButton.Text ' = "Pushed"

    End Sub

    REM AllButtons_Click is a sub I created, note that it doesn't have a "handles" statement at the end
    Private Sub AllButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("You Pushed The Button Named " & sender.ToString)


        'REM a button object that we will "link" to the actual button
        Dim TempButton As Button

        'REM Convert the "sender" object, which is a System.Object to a Button.
        'REM This makes sure that we can set and check Button properties.
        TempButton = CType(sender, Button)


        'REM Make a visible change to the button pushed.
        '  MsgBox(TempButton.Text) ' = "Pushed"

        If TempButton.BackColor = Color.Red Then
            MsgBox("Εχει γίνει η εργασία από άλλον " + ToolTip1.GetToolTip(TempButton))

        Else
            If TempButton.BackColor = Color.Green Then
                If InStr(TempButton.Text, "Δ") > 0 Or InStr(TempButton.Text, "Α") > 0 Then
                    TempButton.BackColor = Color.Yellow
                Else
                    TempButton.BackColor = Color.Beige
                End If

            Else
                TempButton.BackColor = Color.Green
            End If
        End If

    End Sub



    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Label1.Text = "button2"
    End Sub

    Private Sub ergates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ergates.SelectedIndexChanged
        Dim mErgaths As Integer = ergates.SelectedIndex
        Dim SYNORES As New DataTable
        ExecuteSQLQuery("SELECT SUM(ORES) AS SS FROM JOBDETAIL WHERE MONTH(APO)=MONTH(GETDATE()) AND DAY(APO)=DAY(GETDATE()) AND IDERGATH=" + Str(iderg(mErgaths)), SYNORES)
        Label5.Text = Math.Round(IIf(IsDBNull(SYNORES.Rows(0)(0)), 0, SYNORES.Rows(0)(0)), 2)

    End Sub



    Private Sub ergasia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ergasia.SelectedIndexChanged
        If LOGID = 9 Then
            Button5.Visible = True
            ' KATAX.Visible = False
            ' KATAX.Enabled = False
            ' Panel1.Visible = False
            ' Panel1.Controls.Clear()
            '  Panel1.Visible = True
            DateTimePicker1.Visible = True

            '  SHOW_ALL()

            ' Exit Sub
        End If
        Panel1.Visible = False 'Controls.Add(BTN(k))
        'KATAX.Visible = True


        Panel1.Controls.Clear()
        Panel1.Visible = True
        DateTimePicker1.Visible = True

        If Mid(ergasia.Text, 1, 1) = "*" Then
            ' GroupBox1.Visible = True
            kila.Visible = True
            kilalab.Visible = True
            SHOW2_ALL()
            'CreateGrid()
        Else
            'GroupBox1.Visible = False
            kila.Visible = False
            kilalab.Visible = False
            SHOW2_ALL()
            'CreateGrid()
        End If
        KATAX.Enabled = True
        f_ores = 0
    End Sub

    Private Sub eosH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eosH.SelectedIndexChanged
        Dim LEPTA As Single
        'Dim ORES As Single
        LEPTA = (Val(eosH.Text) * 60 + Val(eosM.Text)) - (Val(apoH.Text) * 60 + Val(apoM.Text))
        Label5.Text = Math.Round(LEPTA / 60, 2)

    End Sub

    Private Sub eosM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eosM.SelectedIndexChanged
        Dim LEPTA As Single
        'Dim ORES As Single
        LEPTA = (Val(eosH.Text) * 60 + Val(eosM.Text)) - (Val(apoH.Text) * 60 + Val(apoM.Text))
        Label5.Text = Math.Round(LEPTA / 60, 2)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ergates.Enabled = True
        ergasia.Enabled = True
        KATAX.Enabled = True
    End Sub

    Private Sub KATAX_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KATAX.Click
        kataxorisi()
    End Sub

    Private Sub kataxorisi()
        Dim Gdb As New ADODB.Connection
        Gdb.Open(gConnect)
        Dim KN As Integer
        Dim mErgaths As Integer
        Dim mergasia As Integer
        Dim SQL As String

        mErgaths = ergates.SelectedIndex
        mergasia = ergasia.SelectedIndex

        If Mid(ergasia.Text, 1, 1) = "*" Then  ' DIADROMOI METRA

            If Val(Replace(kila.Text, ",", ".")) = 0 Then
                MsgBox("ΔΕΝ ΔΙΑΛΕΞΑΤΕ ΚΙΛΑ")
                Exit Sub
            End If

        End If
        Dim MAXORES As Integer = 16
        Dim SYNORES As New DataTable
        ExecuteSQLQuery("SELECT SUM(ORES) AS SS FROM JOBDETAIL WHERE MONTH(APO)=MONTH(GETDATE()) AND DAY(APO)=DAY(GETDATE()) AND IDERGATH=" + Str(iderg(mErgaths)), SYNORES)
        If f_ores + IIf(IsDBNull(SYNORES.Rows(0)(0)), 0, SYNORES.Rows(0)(0)) > MAXORES Then
            MsgBox("OI ΩΡΕΣ ΠΟΥ ΔΗΛΩΣΑΤΕ EINAI ΠΕΡΙΣΣΟΤΕΡΕΣ ΑΠΟ " + Str(MAXORES))
            Exit Sub
        End If

        Label5.Text = Math.Round(f_ores + IIf(IsDBNull(SYNORES.Rows(0)(0)), 0, SYNORES.Rows(0)(0)), 2)




        ergates.Enabled = True
        ergasia.Enabled = True



        '        If Mid(ergasia.Text, 1, 1) = "*" Then  ' DIADROMOI

        Dim PROBLEM As Integer = 0
        Dim First As Integer = 1
        Dim k As Integer
        Dim SHMADECE As Integer = 0
        For k = f_Arxh To f_telos Step f_step
            If btn(k).BackColor = Color.Green Then
                SHMADECE = 1
            End If
        Next
        If SHMADECE = 0 Then
            MsgBox("ΔΕΝ ΔΙΑΛΕΞΑΤΕ ΔΙΑΔΡΟΜΟΥΣ ")
            Exit Sub
        End If








        Dim poses_prasines As Integer = 0
        Dim kilaAnaDiadromo As Single
        For k = f_Arxh To f_telos Step f_step
            If btn(k).BackColor = Color.Green Then
                poses_prasines = poses_prasines + 1
            End If
        Next
        kilaAnaDiadromo = 0
        If poses_prasines > 0 Then
            kilaAnaDiadromo = Val(kila.Text) / poses_prasines
        End If
        For k = f_Arxh To f_telos Step f_step
            If btn(k).BackColor = Color.Green Then

                Gdb.Execute("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                'ExecuteSQLQuery("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)))
                If KN = 0 Then
                    PROBLEM = 1
                End If



                If First = 1 Then
                    Gdb.Execute("update JOBDETAIL SET  ORES=" + Replace(VB6.Format(f_ores, "##.00"), ",", ".") + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                    '+ ", APOH=" + apoH.Text + ",APOM=" + apoM.Text + ",EOSH=" + eosH.Text + ",EOSM=" + eosM.Text +
                    First = 0
                    If Mid(ergasia.Text, 1, 1) = "*" Then  ' DIADROMOI
                        'Else
                        Gdb.Execute("update JOBDETAIL SET  KILA=" + Replace(VB6.Format(Val(Replace(kila.Text, ",", ".")), "####.00"), ",", ".") + "  WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                    End If
                    'ExecuteSQLQuery("update JOBDETAIL SET APOH=" + apoH.Text + ",APOM=" + apoM.Text + ",EOSH=" + eosH.Text + ",EOSM=" + eosM.Text + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)))
                End If
            End If
            'ΠΡΟΣΟΧΗ +1 ;H -1 ???
            If btn(k + mStep).BackColor = Color.Green Then
                'K+MSTEP
                Gdb.Execute("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + " WHERE N2=2 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                If KN = 0 Then
                    PROBLEM = 1
                End If




                If First = 1 Then
                    First = 0
                    Gdb.Execute("update JOBDETAIL SET ORES=" + Replace(VB6.Format(f_ores, "##.00"), ",", ".") + " WHERE N2=2 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                    '", APOH=" + apoH.Text + ",APOM=" + apoM.Text + ",EOSH=" + eosH.Text + ",EOSM=" + eosM.Text 

                    If Mid(ergasia.Text, 1, 1) = "*" Then  ' DIADROMOI
                        '  Else
                        Gdb.Execute("update JOBDETAIL SET  KILA=" + Replace(VB6.Format(kilaAnaDiadromo, "##.00"), ",", ".") + " WHERE N2=2 AND N1=" + Str(k + mStep) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                    End If

                End If
            End If

        Next

        If PROBLEM = 1 Then
            MsgBox("ΔΕΝ ΕΝΗΜΕΡΩΘΗΚΕ")
        End If

        Dim SQL2 As String
        Dim NN As Integer
        For NN = 1 To nOres_Erg

            SQL2 = "(DATE,APOH,APOM,EOSH,EOSM,IDERGATH,IDERGASIAS) VALUES (GETDATE(),"
            SQL2 = SQL2 + Str(Ores_Erg(NN, 1)) + ","
            SQL2 = SQL2 + Str(Ores_Erg(NN, 2)) + ","
            SQL2 = SQL2 + Str(Ores_Erg(NN, 3)) + ","
            SQL2 = SQL2 + Str(Ores_Erg(NN, 4)) + "," + Str(iderg(mErgaths)) + "," + Str(idergasies(mergasia)) + ")"
            Gdb.Execute("insert into DETAIL " + SQL2)
        Next

        For NN = 1 To nOres_Erg
            Ores_Erg(NN, 1) = 0
            Ores_Erg(NN, 2) = 0
            Ores_Erg(NN, 3) = 0
            Ores_Erg(NN, 4) = 0
        Next


        nOres_Erg = 1
        ListBox1.Items.Clear()
        f_ores = 0
        KATAX.Enabled = False





        MessageBox.Show("κατεχωρήθη")


    End Sub


    '    CREATE TABLE [dbo].[DETAIL](
    '	[IDERGASIAS] [int] NOT NULL,
    '	[IDERGATH] [int] NOT NULL,
    '	[ID] [int] IDENTITY(1,1) NOT NULL,
    '	[DATE] [datetime] NULL,

    '	[ORES] [real] NULL,
    '	[APOH] [int] NULL,
    '	[APOM] [int] NULL,
    '	[EOSH] [int] NULL,
    '	[EOSM] [int] NULL,
    '	[KILA] [numeric](9, 2) NULL
    ') ON [PRIMARY]

    'GO





    'Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    f_othoni = Val(TextBox1.Text)

    '    If f_othoni = 1 Then
    '        f_Arxh = 81 : f_telos = 11 : f_step = -2
    '    End If
    '    If f_othoni = 2 Then
    '        f_Arxh = 10 : f_telos = 80 : f_step = 2
    '    End If
    '    If f_othoni = 3 Then
    '        f_Arxh = 149 : f_telos = 85 : f_step = -2
    '    End If
    '    If f_othoni = 4 Then
    '        f_Arxh = 82 : f_telos = 148 : f_step = 2
    '    End If

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Ores_Erg(nOres_Erg, 1) = Val(apoH.Text)
        Ores_Erg(nOres_Erg, 2) = Val(apoM.Text)
        Ores_Erg(nOres_Erg, 3) = Val(eosH.Text)
        Ores_Erg(nOres_Erg, 4) = Val(eosM.Text)

        nOres_Erg = nOres_Erg + 1

        Dim LEPTA As Single
        Dim ORES As Single
        LEPTA = (Val(eosH.Text) * 60 + Val(eosM.Text)) - (Val(apoH.Text) * 60 + Val(apoM.Text))
        ORES = Math.Round(LEPTA / 60, 2)

        If LEPTA = 0 Then
            MsgBox("ΔΕΝ ΔΙΑΛΕΞΑΤΕ ΩΡΕΣ")
            Exit Sub
        End If



        If ORES < 0 Then
            MsgBox("ΛΑΘΟΣ ΩΡΕΣ")
            Exit Sub
        End If
        f_ores = f_ores + ORES

        ListBox1.Items.Add(apoH.Text + ":" + apoM.Text + "-" + eosH.Text + ":" + eosM.Text + "--" + VB6.Format(ORES, "#0.00"))


        apoH.SelectedIndex = eosH.SelectedIndex
        apoM.SelectedIndex = eosM.SelectedIndex

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub SHOW_ALL()

        If ergasia.SelectedIndex < 0 Then
            MsgBox("ΕΠΙΛΕΞΤΕ ΕΡΓΑΣΙΑ")
            Exit Sub
        End If
        Dim M As Integer
        If F_FIRST1 = 1 Then M = 1 Else M = 1
        F_FIRST1 = M
        ' f_othoni = Me.f_othonia
        f_othoni = 1
        f_Arxh = 81 : f_telos = 11 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID_ALL(100, 100, btn1)


        'For K = f_Arxh To f_telos Step f_step
        '    btn1(K).Dispose()
        'Next






        F_FIRST1 = M
        f_othoni = 2
        f_Arxh = 80 : f_telos = 10 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID_ALL(220, 100, btn2)


        'For K = f_Arxh To f_telos Step f_step
        '    btn2(K).Dispose()
        'Next




        F_FIRST1 = M
        f_othoni = 3
        f_Arxh = 149 : f_telos = 85 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID_ALL(340, 100, btn3)

        'For K = f_Arxh To f_telos Step f_step
        '    btn3(K).Dispose()
        'Next






        F_FIRST1 = M
        f_othoni = 4
        f_Arxh = 148 : f_telos = 82 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID_ALL(460, 100, btn4)

        'For K = f_Arxh To f_telos Step f_step
        '    btn4(K).Dispose()
        'Next


    End Sub
    Sub SHOW2_ALL()
        If ergasia.SelectedIndex < 0 Then
            MsgBox("ΕΠΙΛΕΞΤΕ ΕΡΓΑΣΙΑ")
            Exit Sub
        End If
        Panel1.Visible = True

        Dim M As Integer
        If F_FIRST1 = 1 Then M = 1 Else M = 1
        F_FIRST1 = M
        ' f_othoni = Me.f_othonia
        f_othoni = 1
        f_Arxh = 81 : f_telos = 11 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID2_ALL(100, 100)


      




        F_FIRST1 = M
        'Me.Text = btn(9).BackColor.ToString
        f_othoni = 2
        f_Arxh = 80 : f_telos = 10 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID2_ALL(220, 100)


     


        F_FIRST1 = M
        f_othoni = 3
        f_Arxh = 149 : f_telos = 85 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID2_ALL(340, 100)






        F_FIRST1 = M
        f_othoni = 4
        f_Arxh = 148 : f_telos = 82 : f_step = -2
        If f_step < 0 Then mStep = -1 Else mStep = +1
        CREATEGRID2_ALL(460, 100)

     
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim mErgaths As Integer
        Dim mergasia As Integer
        Dim SQL As String

        mErgaths = ergates.SelectedIndex
        mergasia = ergasia.SelectedIndex
        Dim ANS As Integer

        Dim MDAY As String = VB6.Format(DateTimePicker1.Value, "dd")
        Dim Mmonth As String = VB6.Format(DateTimePicker1.Value, "mm")


        ExecuteSQLQuery("select sum(ORES)  from JOBDETAIL WHERE DAY(APO)=" + MDAY + " and month(APO)=" + Mmonth + " AND IDERGASIAS=" + Str(idergasies(mergasia)) + " and IDERGATH=" + Str(iderg(mErgaths)))

        If sqlDT.Rows(0)(0) > 0 Then

            ANS = MsgBox("ΘΑ ΣΒΗΣΤΟΥΝ " + VB6.Format(sqlDT.Rows(0)(0), "###.00") + ". ΕΙΣΤΕ ΣΙΓΟΥΡΟΣ ?", MsgBoxStyle.YesNo)
            If ANS = vbYes Then

                ExecuteSQLQuery("delete from JOBDETAIL WHERE DAY(APO)=" + MDAY + " and month(APO)=" + Mmonth + " AND IDERGASIAS=" + Str(idergasies(mergasia)) + " and IDERGATH=" + Str(iderg(mErgaths)))
                MsgBox("ΔΙΕΓΡΑΦΗ")
            End If
        Else
            MsgBox("δεν βρεθηκανε αγγραφές")

        End If

    End Sub

    Sub CREATEGRID2_ALL(ByVal YPSOS As Integer, ByVal DY As Integer)
        'Create the button
        Dim Oth As Integer


        Dim marx As Integer = 149
        Dim mtel As Integer = 85

        ergates.Enabled = False
        ergasia.Enabled = False





        If Len(Dir("c:\mercvb\mercpath.txt")) > 1 Then
            Oth = 1
        End If
        Dim mErgaths As Integer
        Dim mergasia As Integer

        mErgaths = ergates.SelectedIndex
        mergasia = ergasia.SelectedIndex

        '1  81->11
        '2  10->80
        '3  149 -85
        '4  82 -148

        'Specify the 
        'location and the size
        Dim k As Long = 30

        Dim dx As Integer = 14
        Dim mc As Integer = 0




        Dim THESEIS As New DataTable


        ' ExecuteSQLQuery("SELECT * FROM JOBDETAIL  WHERE IDERGASIAS=" + Str(idergasies(mergasia)), THESEIS)
        ExecuteSQLQuery("SELECT E.NAME,*  FROM JOBDETAIL J LEFT JOIN ERGATES E ON J.IDERGATH=E.ID   WHERE IDERGASIAS=" + Str(idergasies(mergasia)), THESEIS)

        Dim NN As Integer = THESEIS.Rows.Count
        Dim TH(300, 2) As Integer
        Dim ono(300, 2) As String

        'ΒΡΙΣΚΩ ΤΗΝ ΚΑΘΕ ΘΕΣΗ ΣΕ ΤΙ ΚΑΤΑΣΤΑΣΗ ΕΙΝΑΙ
        For k = 0 To NN - 1
            If k = 57 Then
                k = 57
            End If

            TH(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = THESEIS.Rows(k)("IDERGATH")
            If THESEIS.Rows(k)("IDERGATH") > 0 Then 'ONOMA ERGATH
                ono(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = THESEIS.Rows(k)("NAME")
            Else
                ono(THESEIS.Rows(k)("N1"), THESEIS.Rows(k)("N2")) = ""
            End If

            'Debug.Print(k, TH(k, 1), TH(k, 2))
        Next

        ' k = 10
        ' mc = 1


        dx = 22 '14


        Dim dx2 As Integer = 37
        '  Dim sx As Integer
        '  sx = 12





        For k = f_Arxh To f_telos Step f_step
            If f_Arxh = 81 Then ' h seira 83 den yparxei
                but(83, 1) = New Button()
                but(83, 2) = New Button()
                Panel1.Controls.Add(but(83, 1))
                Panel1.Controls.Add(but(83, 2))

            End If

            If F_FIRST1 = 1 Then
                'F_FIRST = 0
                but(k, 1) = New Button()
            End If

            mc = mc + 1

            ''labels me aritmoys
            'fLab(k) = New Label()
            'fLab(k).Location = New System.Drawing.Point(18 + mc * dx - dx, 91)
            'fLab(k).Size = New System.Drawing.Size(25, 13)
            'fLab(k).Text = LTrim(Str(k))

            'If F_FIRST = 1 Then
            '    Me.Controls.Add(fLab(k))
            'End If


            'fLab(k + 1) = New Label()
            'fLab(k + 1).Location = New System.Drawing.Point(18 + mc * dx - dx, 415)
            'fLab(k + 1).Size = New System.Drawing.Size(25, 13)
            'fLab(k + 1).Text = LTrim(Str(k))
            'If F_FIRST = 1 Then
            '    Me.Controls.Add(fLab(k + 1))
            'End If


            but(k, 1).Location = New System.Drawing.Point(4 + mc * dx - dx, YPSOS) '115
            but(k, 1).Size = New System.Drawing.Size(dx, DY)  '15,288
            but(k, 1).Text = Str(k)
            If TH(k, 1) = 0 Then
                but(k, 1).BackColor = Color.Beige
                btnState(k) = 1
                ToolTip1.SetToolTip(but(k, 1), "")
            Else
                but(k, 1).BackColor = Color.Red
                btnState(k) = 0
                ToolTip1.SetToolTip(but(k, 1), ono(k, 1))
            End If

            'Add it to the forms control collection
            If F_FIRST1 = 1 Then
                Panel1.Controls.Add(but(k, 1))
                'Me.Controls.Add(BTN(k))
                AddHandler but(k, 1).Click, AddressOf AllButtons_Click
                AddHandler but(k, 1).MouseMove, AddressOf AllButtons_mousemove
            End If

            '------------------------------------------------------------------
            If F_FIRST1 = 1 Then
                but(k, 2) = New Button()
            End If

            mc = mc + 1

            but(k, 2).Location = New System.Drawing.Point(4 + mc * dx - dx, YPSOS)
            but(k, 2).Size = New System.Drawing.Size(dx, DY) '15,288

            If k Mod 2 = 0 Then
                but(k, 2).Text = Str(k) + "Δ"
            Else
                but(k, 2).Text = Str(k) + "Α"
            End If




            but(k, 2).TextAlign = ContentAlignment.BottomRight
            If TH(k, 2) = 0 Then
                but(k, 2).BackColor = Color.Yellow
                ToolTip1.SetToolTip(but(k, 2), "")
            Else
                but(k, 2).BackColor = Color.Red
                ToolTip1.SetToolTip(but(k, 2), ono(k, 2))
            End If

            If F_FIRST = 1 Then
                Panel1.Controls.Add(but(k, 2))
                ' Me.Controls.Add(BTN(k + mStep))
                AddHandler but(k, 2).Click, AddressOf AllButtons_Click
                AddHandler but(k, 2).MouseMove, AddressOf AllButtons_mousemove
            End If

            ' but(k, 1) = Nothing
            ' but(k, 2) = Nothing

        Next



        ' F_FIRST1 = 0
        '  For k = f_Arxh To f_telos Step f_step
        ' BTN(k).Dispose()
        ' BTN(k + mStep).Dispose()
        ' Next

        'Link the event to the event handler
        ' AddHandler btn.Click, AddressOf Me.ClickButton


    End Sub








   
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        Dim Gdb As New ADODB.Connection
        Gdb.Open(gConnect)
        Dim KN As Integer
        Dim mErgaths As Integer
        Dim mergasia As Integer
        Dim SQL As String

        mErgaths = ergates.SelectedIndex
        mergasia = ergasia.SelectedIndex

        If Mid(ergasia.Text, 1, 1) = "*" Then  ' DIADROMOI METRA

            If Val(Replace(kila.Text, ",", ".")) = 0 Then
                MsgBox("ΔΕΝ ΔΙΑΛΕΞΑΤΕ ΚΙΛΑ")
                Exit Sub
            End If

        End If
        Dim MAXORES As Integer = 16
        Dim SYNORES As New DataTable
        ExecuteSQLQuery("SELECT SUM(ORES) AS SS FROM JOBDETAIL WHERE MONTH(APO)=MONTH(GETDATE()) AND DAY(APO)=DAY(GETDATE()) AND IDERGATH=" + Str(iderg(mErgaths)), SYNORES)
        If f_ores + IIf(IsDBNull(SYNORES.Rows(0)(0)), 0, SYNORES.Rows(0)(0)) > MAXORES Then
            MsgBox("OI ΩΡΕΣ ΠΟΥ ΔΗΛΩΣΑΤΕ EINAI ΠΕΡΙΣΣΟΤΕΡΕΣ ΑΠΟ " + Str(MAXORES))
            Exit Sub
        End If

        Label5.Text = Math.Round(f_ores + IIf(IsDBNull(SYNORES.Rows(0)(0)), 0, SYNORES.Rows(0)(0)), 2)




        ergates.Enabled = True
        ergasia.Enabled = True



        '        If Mid(ergasia.Text, 1, 1) = "*" Then  ' DIADROMOI

        Dim PROBLEM As Integer = 0
        Dim First As Integer = 1
        Dim k As Integer
        Dim SHMADECE As Integer = 0
        'f_Arxh = 81 : f_telos = 11 : f_step = -2
        'For k = f_Arxh To f_telos Step f_step
        'If btn1(k).BackColor = Color.Green Then
        'SHMADECE = 1
        'End If
        'Next

        f_Arxh = 10 : f_telos = 149 : f_step = 1 ' leipei 83
        Dim n As Integer
        For k = f_Arxh To f_telos Step f_step
            For n = 1 To 2
                If but(k, n).BackColor = Color.Green Then
                    SHMADECE = 1
                    'but(81,1).BackColor =
                End If
            Next

        Next





        If SHMADECE = 0 Then
            MsgBox("ΔΕΝ ΔΙΑΛΕΞΑΤΕ ΔΙΑΔΡΟΜΟΥΣ ")
            Exit Sub
        End If




        ' If f_step < 0 Then mStep = -1 Else mStep = +1
        '  CREATEGRID2_ALL(100, 100, btn1)

        Dim poses_prasines As Integer = 0
        Dim kilaAnaDiadromo As Single
        For k = f_Arxh To f_telos Step f_step
            For n = 1 To 2
                If but(k, n).BackColor = Color.Green Then  ' buk(k,1) =>  buk(k,n)
                    poses_prasines = poses_prasines + 1
                End If
            Next
        Next

        kilaAnaDiadromo = 0
        If poses_prasines > 0 Then
            kilaAnaDiadromo = Val(kila.Text) / poses_prasines
        End If
        For k = f_Arxh To f_telos Step f_step
            If but(k, 1).BackColor = Color.Green Then

                Gdb.Execute("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                'ExecuteSQLQuery("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)))
                If KN = 0 Then
                    PROBLEM = 1
                End If



                If First = 1 Then
                    Gdb.Execute("update JOBDETAIL SET  ORES=" + Replace(VB6.Format(f_ores, "##.00"), ",", ".") + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                    '+ ", APOH=" + apoH.Text + ",APOM=" + apoM.Text + ",EOSH=" + eosH.Text + ",EOSM=" + eosM.Text +
                    First = 0
                    If Mid(ergasia.Text, 1, 1) = "*" Then  ' DIADROMOI
                        'Else
                        Gdb.Execute("update JOBDETAIL SET  KILA=" + Replace(VB6.Format(Val(Replace(kila.Text, ",", ".")), "####.00"), ",", ".") + "  WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                    End If
                    'ExecuteSQLQuery("update JOBDETAIL SET APOH=" + apoH.Text + ",APOM=" + apoM.Text + ",EOSH=" + eosH.Text + ",EOSM=" + eosM.Text + " WHERE N2=1 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)))
                End If
            End If
            'ΠΡΟΣΟΧΗ +1 ;H -1 ???
            If but(k, 2).BackColor = Color.Green Then
                'K+MSTEP
                Gdb.Execute("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + " WHERE N2=2 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                If KN = 0 Then
                    PROBLEM = 1
                End If




                If First = 1 Then
                    First = 0
                    Gdb.Execute("update JOBDETAIL SET ORES=" + Replace(VB6.Format(f_ores, "##.00"), ",", ".") + " WHERE N2=2 AND N1=" + Str(k) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                    '", APOH=" + apoH.Text + ",APOM=" + apoM.Text + ",EOSH=" + eosH.Text + ",EOSM=" + eosM.Text 

                    If Mid(ergasia.Text, 1, 1) = "*" Then ' DIADROMOI
                        '  Else

                        ' If kilaAnaDiadromo > 0 Then
                        'ETSI HTAN  Gdb.Execute("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + ", KILA=" + Replace(VB6.Format(kilaAnaDiadromo, "#####.00"), ",", ".") + " WHERE N2=2 AND N1=" + Str(k + mStep) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                        Gdb.Execute("update JOBDETAIL SET APO=GETDATE(),IDERGATH=" + Str(iderg(mErgaths)) + ", KILA=" + Replace(VB6.Format(Val(Replace(kila.Text, ",", ".")), "####.00"), ",", ".") + " WHERE N2=2 AND N1=" + Str(k + mStep) + " AND IDERGASIAS=" + Str(idergasies(mergasia)), KN)
                        

                    End If

                End If
            End If
            but(k, 1) = Nothing
            but(k, 2) = Nothing
        Next

        If PROBLEM = 1 Then
            MsgBox("ΔΕΝ ΕΝΗΜΕΡΩΘΗΚΕ")
            Exit Sub
        End If

        Dim SQL2 As String
        Dim NN As Integer
        'For NN = 1 To nOres_Erg

        '    SQL2 = "(DATE,APOH,APOM,EOSH,EOSM,IDERGATH,IDERGASIAS) VALUES (GETDATE(),"
        '    SQL2 = SQL2 + Str(Ores_Erg(NN, 1)) + ","
        '    SQL2 = SQL2 + Str(Ores_Erg(NN, 2)) + ","
        '    SQL2 = SQL2 + Str(Ores_Erg(NN, 3)) + ","
        '    SQL2 = SQL2 + Str(Ores_Erg(NN, 4)) + "," + Str(iderg(mErgaths)) + "," + Str(idergasies(mergasia)) + ")"
        '    Gdb.Execute("insert into DETAIL " + SQL2)
        'Next

        For NN = 1 To nOres_Erg
            Ores_Erg(NN, 1) = 0
            Ores_Erg(NN, 2) = 0
            Ores_Erg(NN, 3) = 0
            Ores_Erg(NN, 4) = 0
        Next


        nOres_Erg = 1
        ListBox1.Items.Clear()
        f_ores = 0
        KATAX.Enabled = False

        Dim SYNKILA As New DataTable
        ExecuteSQLQuery("SELECT SUM(ORES) AS SORES,SUM(KILA) AS SKILA,SUM(METRA) AS SMETRA FROM JOBDETAIL WHERE MONTH(APO)=MONTH(GETDATE()) AND DAY(APO)=DAY(GETDATE()) AND IDERGATH=" + Str(iderg(mErgaths)), SYNKILA)


        Dim mOr As String = VB6.Format(SYNKILA.Rows(0)(0), "#####.00")
        Dim mki As String = VB6.Format(SYNKILA.Rows(0)(1), "#####.00")
        Dim mMe As String = VB6.Format(SYNKILA.Rows(0)(2), "#####.00")


        MessageBox.Show("κατεχωρήθη" + Chr(13) + "Σύνολο ημέρας : Κιλά " + mki + " Ωρες " + mOr + "  Μέτρα " + mMe)


        ' Me.Close()


        ' ξαναφορτωνω τα ιδια οπως μετα το διάλεγμα της εργασίας
        Panel1.Visible = False 'Controls.Add(BTN(k))
        Panel1.Controls.Clear()
        Panel1.Visible = True
        DateTimePicker1.Visible = True

        If Mid(ergasia.Text, 1, 1) = "*" Then
            ' GroupBox1.Visible = True
            kila.Visible = True
            kilalab.Visible = True
            SHOW2_ALL()
            'CreateGrid()
        Else
            'GroupBox1.Visible = False
            kila.Visible = False
            kilalab.Visible = False
            SHOW2_ALL()
            'CreateGrid()
        End If
        KATAX.Enabled = True
        f_ores = 0
























    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class