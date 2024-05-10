Option Explicit On
Option Strict On

Imports System.Data.OleDb



Public Class StockManager
    Private Sub StockManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

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

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        If String.IsNullOrEmpty(Me.userName.Text.Trim()) Or
            String.IsNullOrEmpty(Me.companyName.Text.Trim()) Then

            MessageBox.Show("Please fill in all the missing fields",
                            "Missing fields",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            Exit Sub

        End If

        Dim tableName As String = userName.Text.Trim().ToUpper()


        SQL = "CREATE TABLE [" & tableName & "] (ID IDENTITY(1,1) PRIMARY KEY, Product NVARCHAR(255), Quantity INT, BuyPrice INT, SellPrice INT, TotalCost INT, TotalReturns INT)"
        Cmd = New OleDbCommand(SQL, Con)
        Cmd.Parameters.Clear()
        PerformCRUD(Cmd)

        SQL = "UPDATE " & tableName & " SET TotalCost = BuyPrice * Quantity, TotalReturns = SellPrice * Quantity"
        Cmd = New OleDbCommand(SQL, Con)
        Cmd.Parameters.Clear()
        PerformCRUD(Cmd)

        ComboBox1.Items.Add(userName.Text.Trim().ToUpper())


        MessageBox.Show("User Saved Successfully",
                           "Save User: Success",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information)


        userName.Text = ""
        companyName.Text = ""


    End Sub

End Class
