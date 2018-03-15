Public Class frmCalculator

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        tbAnswer.Text &= "0"
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        tbAnswer.Text &= "1"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        tbAnswer.Text &= "2"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        tbAnswer.Text &= "3"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        tbAnswer.Text &= "4"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        tbAnswer.Text &= "5"
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        tbAnswer.Text &= "6"
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        tbAnswer.Text &= "7"
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        tbAnswer.Text &= "8"
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        tbAnswer.Text &= "9"
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        tbAnswer.Text &= "."
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            tbAnswer.Text = tbAnswer.Text.Remove(tbAnswer.Text.Length - 1)
        Catch ex As Exception
            'niks
        End Try
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        tbAnswer.Text = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        tbAnswer.Text &= "*"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        tbAnswer.Text &= "/"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        tbAnswer.Text &= "+"
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        tbAnswer.Text &= "-"
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Try
            Dim sum As String = tbAnswer.Text
            Dim result As Double = New DataTable().Compute(sum, Nothing)
            tbAnswer.Text = Replace(Str(result), " ", "")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnParenthesesLeft_Click(sender As Object, e As EventArgs) Handles btnParenthesesLeft.Click
        tbAnswer.Text &= "("
    End Sub

    Private Sub btnParenthesesRight_Click(sender As Object, e As EventArgs) Handles btnParenthesesRight.Click
        tbAnswer.Text &= ")"
    End Sub

End Class
