Public Class Form1
    Dim fila As New Queue
    Dim arr() As Object


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fila.Enqueue(TextBox3.Text)
        TextBox6.Clear()
        arr = fila.ToArray
        For J = 0 To UBound(arr)
            TextBox6.Text &= arr(J) & vbNewLine
        Next
        TextBox3.Clear()


    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    'pergunt
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        If (MessageBox.Show("Quer mesmo? ", "Atenção", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            TextBox1.Text = fila.Dequeue()
            TextBox2.Text = fila.Count


        End If
    End Sub
    'Acrescentas aviões
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If (fila.Count > 0) Then
            TextBox1.Text = fila.Dequeue()
            TextBox2.Text = fila.Count
        Else

            MessageBox.Show("Já não à aviões para descolar")

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox6.Visible = True
        Label6.Visible = True


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
