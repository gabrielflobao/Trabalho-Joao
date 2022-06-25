Public Class Form1
    Dim Costumer1 As New Customer
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs)



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        numMinutes.Value = 0
        numTexts.Value = 0
        numData.Value = 0


    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Costumer1.setName(TextBox1.Text)
        Costumer1.setAdress(TextBox2.Text)
        Costumer1.setMobileNumber(MaskedTextBox2.Text)
        TextBox4.SelectedText = Costumer1.getName
            TextBox3.SelectedText = Costumer1.GetMobileNumber
            MsgBox("Costumer Save with successful")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim costcontract, costminutes, costtexts, costdata, total As Double
        costcontract = 0

        Select Case ComboBox2.SelectedItem

            Case "3G"
                costcontract = 10
            Case "4G"
                costcontract = 20
            Case "5G"
                costcontract = 30
        End Select



        costminutes = IIf(numMinutes.Value > 500, numMinutes.Value - 500, 0) * 0.2
        costtexts = IIf(numTexts.Value > 500, numTexts.Value - 500, 0) * 0.1
        costdata = IIf(numData.Value > 500, numData.Value - 500, 0) * 0.5
        total = costcontract + costminutes + costtexts + costdata

        MsgBox("The Costumer : " & Costumer1.getName & Chr(13) & "With adress :" & Costumer1.getAdress & Chr(13) & "Has to pay :" & Chr(13) & "Minutes  :R$ :" & costminutes & Chr(13) & "Texts : R$ :" & costtexts & Chr(13) & " Data : R$ :" & costdata & Chr(13) & "Total : R$ " & total & Chr(13) & "Plan used :" & ComboBox2.SelectedItem)
    End Sub
End Class
