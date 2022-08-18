Public Class Form1
    '  Inherits System.Windows.Forms.Form

    ' declare our class array collection to be used with its event(s)
    ' and set it up with 5 classes in it.
    Private WithEvents MyClassArray As New ClassArrayExample.ClassArray(5)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' call the addbuttons sub to add some buttons to the gui
        ' this sub creates, sets propertiess, and places the buttons.
        AddButtons()
    End Sub
    Private Sub AddButtons()

        Dim top As Integer = 20
        Dim left As Integer = 5

        Dim i As Integer

        Dim newButton As Button

        For i = 1 To 14

            newButton = New Button()

            'set the properties for the new button
            With newButton
                .Width = 90
                .Height = 50
                .Text = "Button #" & i.ToString
                .Top = top
                .Left = left
            End With

            ' make the ButtonClick method handle the click event
            ' of this button
            AddHandler newButton.Click, AddressOf ButtonClick

            ButtonGroup.Controls.Add(newButton)

            ' here we just make sure to neatly arrange the buttons =)
            If (ButtonGroup.Width - left) < 190 Then
                top += 70
                left = 5
            Else
                left += 95
            End If

        Next i

    End Sub

    ' this sub is triggered everytime a button is clicked. it must have the
    ' same signature of the buttons click event.
    Private Sub ButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show(sender.text)
    End Sub



End Class