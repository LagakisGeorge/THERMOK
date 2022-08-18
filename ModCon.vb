

'Created on August 16, 2010
'Tan, Angelito S.

'Date update dec 12, 2010
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Module ModCon
    'Public fso As New filesystemobject
    'Public ParamDVFrom As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamDVTo As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyName As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyLoc As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyContact As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyTIN As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public _USER As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public mReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public sqlDT As New DataTable
    Public sqlDaTaSet As New DataSet
    Public sqlDTx As New DataTable
    Public openedFileStream As System.IO.Stream
    Dim xsize As Integer
    'Public Const cnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=../database/SaleInv_DB.mdb"
    'Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB; Trusted_Connection=yes;"
    'Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB;Uid=sa; Pwd=angelito;"

    'Public Const cnstring As String = "Provider=SQLOLEDB;" & _
    '                                  "Data Source=;" & _
    '                                  "Network=CPAT;" & _
    '                                  "Initial Catalog=SaleInv_DB;" & _
    '                                  "User Id=sa;" & _
    '                                  "Password=angelito"
    '192.168.1.104;" & _'                           

    Public gConnect As String

    'Public conn As OleDbConnection = New OleDbConnection(cnString)
    ' Public DataFileLock As New System.Threading.ReaderWriterLock
    Public gPHDHMAGENNA As Integer
    Public gPHDHMAnextOXEIA As Integer
    Public gAPOGnextOXEIA As Integer





    Public sqlSTR As String
    Public Rpt_SqlStr As String
    Public pass As Boolean
    Public VAT As Double
    Public username As String
    Public xUser_ID As Integer
    Public xUser_Access As String
    Public Pending_ID As Integer
    Public Pending_QTY As Integer
    Public Pending_Item_ID As Integer
    Public dataBytes() As Byte
    Public xpass As Boolean
    Public howx As Integer
    Public xid(1) As Integer
    Public xlock As Boolean
    Public iMin As Integer
    Public tmpStr As String
    Public LOGID As Integer
    Public PreviousPage, NextPage As Integer
    Public i_Print As Integer

    Public Function checkServer() As Boolean
        Dim c As String

        c = Application.StartupPath & "\Config.ini"

        Try

            With FrmSERVERSETTINGS
                .OpenFileDialog1.FileName = c
                openedFileStream = .OpenFileDialog1.OpenFile()
            End With

            ReDim dataBytes(openedFileStream.Length - 1) 'Init 
            openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
            openedFileStream.Close()
            tmpStr = System.Text.Encoding.Unicode.GetString(dataBytes)

            With FrmSERVERSETTINGS
                If Split(tmpStr, ":")(4) = "1" Then
                    'network
                    gConnect = "Provider=SQLOLEDB.1;" & _
                               ";Password=" & Split(tmpStr, ":")(3) & _
                               ";Persist Security Info=True ;User Id=" & Split(tmpStr, ":")(2) & _
                               ";Initial Catalog=thermo" & _
                               ";Data Source=" & Split(tmpStr, ":")(1)

                    ' gConnect = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=emp;Data Source=logisthrio\sqlexpress"
                    '"dsn=thermo;uid=sa;pwd=12345678"
                    ' gConnect=""Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;pwd=12345678;Initial Catalog=ASOP"
                Else
                    'local
                    'MsgBox(Split(tmpStr, ":")(1))
                    gConnect = "Provider=SQLOLEDB;Server=" & Split(tmpStr, ":")(1) & _
                               ";Database=thermo; Trusted_Connection=yes;"
                End If
                ' OK DOYLEYEI ALLA KALYTERA APO CONFIG   gConnect = "Provider=SQLOLEDB.1;Password=12345678;Persist Security Info=True;User ID=sa;Initial Catalog=THERMO;Data Source=hp530\sql2012"
            End With
            Dim sqlCon As New OleDbConnection
            sqlCon.ConnectionString = gConnect
            sqlCon.Open()
            checkServer = True
            sqlCon.Close()
        Catch ex As Exception
            checkServer = False
        End Try
    End Function

    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataTable
        Try
            Dim sqlCon As New OleDbConnection(gConnect)

            Dim sqlDA As New OleDbDataAdapter(SQLQuery, sqlCon)

            Dim sqlCB As New OleDbCommandBuilder(sqlDA)
            sqlDT.Reset() ' refresh 
            sqlDA.Fill(sqlDT)
            'rowsAffected = command.ExecuteNonQuery();
            ' sqlDA.Fill(sqlDaTaSet, "PEL")

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
            If Err.Number = 5 Then
                MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Else
                MsgBox("Error : " & ex.Message)
            End If
            MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
            MsgBox(SQLQuery)
        End Try
        Return sqlDT
    End Function
    Public Sub ExecuteSQLQuery(ByVal SQLQuery As String, ByRef SQLDT As DataTable)
        Try
            Dim sqlCon As New OleDbConnection(gConnect)

            Dim sqlDA As New OleDbDataAdapter(SQLQuery, sqlCon)

            Dim sqlCB As New OleDbCommandBuilder(sqlDA)
            sqlDT.Reset() ' refresh 
            sqlDA.Fill(sqlDT)
            ' sqlDA.Fill(sqlDaTaSet, "PEL")

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
            If Err.Number = 5 Then
                MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Else
                MsgBox("Error : " & ex.Message)
            End If
            MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
            MsgBox(SQLQuery)
        End Try
        'Return sqlDT
    End Sub
    Public Sub FILLComboBox(ByVal sql As String, ByVal cb As ComboBox)
        Dim conn As OleDbConnection = New OleDbConnection(gConnect)
        cb.Items.Clear()
        Try
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(sql, conn)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(0).ToString & " - " & rdr(1).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub FILLComboBox2(ByVal sql As String, ByVal cb As ComboBox, ByRef ids As Array)
        Dim conn As OleDbConnection = New OleDbConnection(gConnect)
        cb.Items.Clear()
        Try
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(sql, conn)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            Dim n As Integer = 0
            While rdr.Read
                cb.Items.Add(rdr(0).ToString)
                ids(n) = rdr(1)
                n = n + 1
            End While
            rdr.Close()

        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Function DataSourceConnection_Report()
        'If Split(tmpStr, ":")(4) = "1" Then
        '    'mReport.DataSourceConnections
        '    'mReport()
        '    'mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
        '    mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", False)
        '    'MsgBox(Split(tmpStr, ":")(2) & "  " & Split(tmpStr, ":")(3))
        '    mReport.DataSourceConnections(0).SetLogon(Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
        'Else

        '    mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", True)
        'End If
        ''MsgBox(mReport.DataSourceConnections(0).ServerName.ToString)
        'Return 0
    End Function

    Public Sub FillListView(ByVal sqlData As DataTable, ByVal lvList As ListView, ByVal imageID As Integer)
        Dim i As Integer
        Dim j As Integer
        'lvList.Refresh()
        lvList.Clear()
        For i = 0 To sqlData.Columns.Count - 1
            lvList.Columns.Add(sqlData.Columns(i).ColumnName)
        Next i

        For i = 0 To sqlData.Rows.Count - 1
            lvList.Items.Add(sqlData.Rows(i).Item(0), imageID)
            For j = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(j)) Then
                    lvList.Items(i).SubItems.Add(sqlData.Rows(i).Item(j))
                Else
                    lvList.Items(i).SubItems.Add("")
                End If
            Next j
        Next i

        For i = 0 To sqlData.Columns.Count - 1
            xsize = lvList.Width / sqlData.Columns.Count - 8
            'MsgBox(xsize)
            'If xsize > 1440 Then
            lvList.Columns(i).Width = xsize
            'Else
            '   lvList.Columns(i).Width = 2000
            'End If
            'lvList.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        Next i
    End Sub


    'his articles helps user to Insert, Update, Delete, and Select data in Excel files using the OLEDBDataProvider in VB.NET.

    'Here is the connection string to connect with Excel using OleDBDataProvider:

    'Hide   Copy Code
    'Here is the code on the button click event to select and insert data in an Excel file:

    'Hide   Shrink    Copy Code
    Private Sub EXCEL7(ByVal FILE As String)
        Dim connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" + FILE + ";Extended Properties=""Excel 8.0;HDR=YES;"""
        Dim pram As OleDbParameter
        Dim dr As DataRow
        Dim olecon As OleDbConnection
        Dim olecomm As OleDbCommand
        Dim olecomm1 As OleDbCommand
        Dim oleadpt As OleDbDataAdapter
        Dim ds As DataSet
        Try
            olecon = New OleDbConnection
            olecon.ConnectionString = connstring
            olecomm = New OleDbCommand
            olecomm.CommandText = _
               "Select FirstName, LastName, Age, Phone from [Sheet1$]"
            olecomm.Connection = olecon
            olecomm1 = New OleDbCommand
            olecomm1.CommandText = "Insert into [Sheet1$] " & _
                "(FirstName, LastName, Age, Phone) values " & _
                "(@FName, @LName, @Age, @Phone)"
            olecomm1.Connection = olecon
            pram = olecomm1.Parameters.Add("@FName", OleDbType.VarChar)
            pram.SourceColumn = "FirstName"
            pram = olecomm1.Parameters.Add("@LName", OleDbType.VarChar)
            pram.SourceColumn = "LastName"
            pram = olecomm1.Parameters.Add("@Age", OleDbType.VarChar)
            pram.SourceColumn = "Age"
            pram = olecomm1.Parameters.Add("@Phone", OleDbType.VarChar)
            pram.SourceColumn = "Phone"
            oleadpt = New OleDbDataAdapter(olecomm)
            ds = New DataSet
            olecon.Open()
            oleadpt.Fill(ds, "Sheet1")
            If IsNothing(ds) = False Then
                dr = ds.Tables(0).NewRow
                dr("FirstName") = "Raman"
                dr("LastName") = "Tayal"
                dr("Age") = 24
                dr("Phone") = 98989898
                ds.Tables(0).Rows.Add(dr)
                oleadpt = New OleDbDataAdapter
                oleadpt.InsertCommand = olecomm1
                Dim i As Integer = oleadpt.Update(ds, "Sheet1")
                MessageBox.Show(i & " row affected")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            olecon.Close()
            olecon = Nothing
            olecomm = Nothing
            oleadpt = Nothing
            ds = Nothing
            dr = Nothing
            pram = Nothing
        End Try
    End Sub


    'Imports Excel = Microsoft.Office.Interop.Excel
    'Public Class Form1

    '    Private Sub Button1_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs) Handles Button1.Click
    '        MsgBox(Read_from_excel("c:\test.xlsx", "sheet1", 1, 1))

    '    End Sub

    '#Region "Read and write to excel file, use functions Read_from_excel and Text_to_excel"
    Public Function Read_from_excel(ByVal filename As String, ByVal sheetname As String, ByVal row As Integer, ByVal column As Integer)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Open(filename)
        xlWorkSheet = xlWorkBook.Worksheets(sheetname)

        Dim value As String
        value = xlWorkSheet.Cells(row, column).value

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        Return value
    End Function

    Public Sub Text_to_excel(ByVal filename As String, ByVal sheetname As String, ByVal row As Integer, ByVal column As Integer, ByVal text As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Open(filename)
        xlWorkSheet = xlWorkBook.Worksheets(sheetname)

        xlWorkSheet.Cells(row, column) = text

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub


    Public Sub mreleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    '#End Region

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    'ADD THIS LINE 
    'OF CODE INSIDE THE 
    'WINDOWS FORM GENERATED CODE

    '<System.STAThread()> _
    'WIN XP THEMS STIS FORMES
    'Public 
    'Shared 
    '   Sub Main()

    '       System.Windows.Forms.Application.EnableVisualStyles()

    '   System.Windows.Forms.Application.Run(New 
    'frmDecode)  ' replace frmDecode by the name of your 
    'form!!!

    '       End
    'Sub


End Module
