
Public Class FrmSERVERSETTINGS
    Dim CONSTR As String
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'Call writeFileStrData(txtip.Text & ":" & txtservername.Text & ":" & txtusername.Text & ":" & txtpassword.Text & ":" & (IIf(RadioButton1.Checked, 1, 2)), Application.StartupPath & "\Config.ini", , "Unicode")
        checkServer()
        Me.Close()
        MDIMain.Show()

        'FrmLOGIN.Show()

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
        'End
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' FrmSet.ShowDialog()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        txtip.Enabled = False
        txtpassword.Enabled = False
        txtusername.Enabled = False
        txtservername.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        txtip.Enabled = True
        txtpassword.Enabled = True
        txtservername.Enabled = True
        txtusername.Enabled = True
        txtip.Focus()
    End Sub
End Class