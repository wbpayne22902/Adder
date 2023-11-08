Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Try
            TextBox3.Text = Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
