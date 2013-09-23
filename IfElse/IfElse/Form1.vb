Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        'if user enters a non-number, then end
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: Please type a number.")
            Return
        End If

            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

        'if user enters a negative number, then end
        If num1 < 0 Or num2 < 0 Then
            MessageBox.Show("Error: Please type a positive number.")
            Return
        End If

        'if all entered correctly, then
            If num1 > num2 Then
                txtResult.Text = "The larger number is " & num1

            ElseIf (num1 < num2) Then
                txtResult.Text = "The larger number is " & num2
            Else
                txtResult.Text = "The two are equal."
            End If



    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
