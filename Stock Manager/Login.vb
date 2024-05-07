Public Class StockManager
    Private Sub StockManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem.ToString().Equals("Anderson") Then

            Dim homePage As New HomepageAnderson
            homePage.Show()
            Me.Close()

        End If

        If ComboBox1.SelectedItem.ToString().Equals("Munashe") Then

            Dim homePage As New HomepageMunashe
            homePage.Show()
            Me.Close()

        End If

    End Sub

End Class
