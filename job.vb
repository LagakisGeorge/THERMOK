
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Text


Public Class FormJobs
    'Create connection
    Dim conn As SqlConnection
    Dim iderg(100) As Long
    'Dim idergasies(100) As Long
    'create data adapter
    Dim da As SqlDataAdapter

    'create dataset
    Dim ds As DataSet = New DataSet

    'Set up connection string
    Dim cnString As String
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '  FILLComboBox2("select NAME,ID FROM CERGASIES", CERGASIES, iderg)
        '1  81->11
        '2  10->80
        '3  149 -85
        '4  82 -148


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim K As Integer
        ExecuteSQLQuery("ALTER TABLE  THESEIS ADD ID INT IDENTITY(1,1)")
        For K = 10 To 149
            ExecuteSQLQuery("INSERT INTO THESEIS (N1,N2) VALUES (" + Str(K) + ",1)")
            ExecuteSQLQuery("INSERT INTO THESEIS (N1,N2) VALUES (" + Str(K) + ",2)")
        Next K

        'cnString = "Data Source=localhost\SQLEXPRESS;Integrated Security=True;database=thermo"
        ''Str_Connection = cnString
        'Dim SQLqry
        'SQLqry = Label1.Text '"SELECT NAME,N1,ID FROM ERGATES " ' ORDER BY HME "
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
        '    '  GridView1.ClearSelection()
        '    ' GridView1.DataSource = ds
        '    'GridView1.DataMember = "PEL"

        'Catch ex As SqlException
        '    MsgBox(ex.ToString)
        'Finally
        '    ' Close connection
        '    conn.Close()
        'End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' ExecuteSQLQuery("SELECT * FROM THESEIS")
        '  Dim M As Integer, M2 As Integer
        ' M = CERGASIES.SelectedIndex
        '  M2 = iderg(M)
        ' Dim myDate As Date = APO
        'MsgBox(Format(myDate, "MMddyy"))
        'MsgBox(myDate.ToString("MMddyy"))

        Dim jobS As New DataTable

        Dim M3 As Integer
        Dim K As Integer
        Dim METRA As Integer

        ExecuteSQLQuery("SELECT * FROM JOBS where ENERGOS=1  and ID NOT IN(SELECT IDERGASIAS FROM JOBDETAIL) ", jobS)
        Dim n As Integer

        For n = 0 To jobS.Rows.Count - 1
            M3 = jobS.Rows(n)("id") 'sqlDT.Rows(0)("ID")


            Dim THESEIS As New DataTable
            ExecuteSQLQuery("SELECT * FROM THESEIS ", THESEIS)

            Dim NN As Integer = THESEIS.Rows.Count
            Dim TH(300, 2) As Integer

            For K = 0 To NN - 1
                TH(K, 1) = THESEIS.Rows(K)("N1")
                TH(K, 2) = THESEIS.Rows(K)("N2")
            Next

            Dim N1 As Integer, N2 As Integer
            For K = 0 To NN - 1
                N1 = THESEIS.Rows(K)("N1")
                N2 = THESEIS.Rows(K)("N2")
                'OK DOYLEYEI KAI ETSI   ExecuteSQLQuery("INSERT INTO JOBS (IDCERGASIA,N1,N2) VALUES(" + Str(M3) + "," + Str(TH(K, 1)) + "," + Str(TH(K, 2)) + ")")

                'μονές σειρές είναι μήκους 65 μέτρων και οι ζυγές 70
                If N1 Mod 2 = 0 Then
                    METRA = 70
                Else
                    METRA = 65
                End If

                If jobS.Rows(0)("SEIRES") = 1 Then ' ME KILA
                    METRA = 0
                End If


                ExecuteSQLQuery("INSERT INTO JOBDETAIL (IDERGASIAS,N1,N2,METRA,IDERGATH) VALUES(" + Str(M3) + "," + Str(N1) + "," + Str(N2) + "," + Str(METRA) + ",0)")
            Next

        Next


        MsgBox("ΔΗΜΙΟΥΡΓΗΘΗΚΕ ΤΟ ΑΡΧΕΙΟ ΤΩΝ ΕΡΓΑΣΙΩΝ")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class