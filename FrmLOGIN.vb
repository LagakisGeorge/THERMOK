﻿Public Class FrmLOGIN
    Dim xuserid As Integer
    Dim xcountx As Integer
    Dim ix As Double

    Private Sub FrmLOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim i As Integer
        ' For i = 0 To 100
        ' Me.Opacity = Me.Opacity + 1
        ' Application.DoEvents()
        ' Next
        'FILLComboBox ("SELECT  FROM TBL_U
        xcountx = 0
        xlock = False
        username = ""
        xuserid = xUser_ID
        xUser_ID = 0
        txtuser.Text = "admin"
        txtpassword.Text = "admin"
        txtuser.Select()
        If Not checkServer() Then
            xUser_ID = 1
            'Me.Close()
            FrmSERVERSETTINGS.ShowDialog()
        End If
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        On Error Resume Next
        Dim timex As String
        'If e.KeyCode = 13 Then




        If Not checkServer() Then
            FrmSERVERSETTINGS.ShowDialog()
            Exit Sub
        End If
        sqlSTR = "SELECT * FROM TBL_Users WHERE Username='" & (txtuser.Text) & "' AND UserPass ='" & (txtpassword.Text) & "'"

        'MsgBox(sqlSTR)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count = 0 Then
            MsgBox("λαθος χρήστης ή κωδικός")
            Exit Sub
        End If
        If sqlDT.Rows.Count > 0 Then
            'MDIMain.Show()
            For i = 0 To sqlDT.Rows.Count - 1
                If sqlDT.Rows(i)("username") <> txtuser.Text Or sqlDT.Rows(i)("userpass") <> txtpassword.Text Then
                    MsgBox("Access denied username and password !!!", MsgBoxStyle.Information, "Sales and Inventory")
                    xcountx = xcountx + 1
                    If xcountx >= 3 Then
                        MsgBox("You have reach the maximum time of login !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                        End
                    End If
                    Exit Sub
                End If
            Next
            'xuserid = xUser_ID

            username = sqlDT.Rows(0)("Username")
            xUser_ID = sqlDT.Rows(0)("User_id")
            xUser_Access = sqlDT.Rows(0)("Access_Type")

            timex = TimeOfDay

            '  _USER.Value = sqlDT.Rows(0)("lastname") & ", " & sqlDT.Rows(0)("firstname") & " " & sqlDT.Rows(0)("middlename")

            'sqlSTR = "INSERT INTO TBL_Audit_Log (User_ID, LOGIN) VALUES(" & xUser_ID & ", '" & timex & "')"
            'ExecuteSQLQuery(sqlSTR)

            'sqlSTR = "SELECT * FROM TBL_Audit_Log ORDER BY LOG_ID DESC"
            'ExecuteSQLQuery(sqlSTR)

            LOGID = xUser_ID  'sqlDT.Rows(0)("LOG_ID")

            If LOGID = 9 Then ' username = "admin" Then
                MDIMain.toexcel.Enabled = True
                MDIMain.ListaErgasion.Enabled = True
                MDIMain.excelanal.Enabled = True
                MDIMain.cmdERGATES.Enabled = True
                MDIMain.cmdCustomerOrder.Enabled = True
                MDIMain.Button1.Enabled = True
                MDIMain.Button2.Enabled = True
                MDIMain.Button3.Enabled = True
                MDIMain.cmdERGASIES.Enabled = True

                MDIMain.cmdSalesReceipt.Enabled = True



            End If




            If LOGID = 12 Then ' username = "admin" Then
                'MDIMain.jobs.Enabled = True
                'MDIMain.ListaErgasion.Enabled = True
                'MDIMain.cmdCashiering.Enabled = True
                'MDIMain.cmdERGATES.Enabled = True
                MDIMain.cmdCustomerOrder.Enabled = True
                MDIMain.Button1.Enabled = True
                MDIMain.Button2.Enabled = True
                MDIMain.Button3.Enabled = True
                MDIMain.cmdSalesReceipt.Enabled = False


            End If

            If LOGID = 13 Then ' username = "admin" Then
                'MDIMain.jobs.Enabled = True
                'MDIMain.ListaErgasion.Enabled = True
                'MDIMain.cmdCashiering.Enabled = True
                'MDIMain.cmdERGATES.Enabled = True
                MDIMain.cmdCustomerOrder.Enabled = True
                MDIMain.Button1.Enabled = True
                MDIMain.Button2.Enabled = True
                MDIMain.Button3.Enabled = True

                MDIMain.cmdSalesReceipt.Enabled = False

            End If








        End If

        Me.Close()




          
    End Sub


    Private Sub cmdserver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdserver.Click
        FrmSERVERSETTINGS.ShowDialog()
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = 13 Then
            Call cmdlogin_Click(0, AcceptButton)
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End
    End Sub
End Class