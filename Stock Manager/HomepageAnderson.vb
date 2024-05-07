Option Explicit On
Option Strict On

Imports System.Data.OleDb


Public Class HomepageAnderson

    Private ID As String = ""

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetMe()
        LoadData()
    End Sub



    Private Sub ResetMe()

        Me.ID = ""
        prodName.Text = ""
        prodQuantity.Text = ""
        prodUnitPrice.Text = ""

    End Sub

    Private Sub Execute(MySQL As String, Optional Parameter As String = "")
        Cmd = New OleDbCommand(MySQL, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)

    End Sub

    Private Sub AddParameters(str As String)

        Cmd.Parameters.Clear()

        If str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then

            Cmd.Parameters.AddWithValue("ID", Me.ID)


        End If

        Cmd.Parameters.AddWithValue("Product", prodName.Text.Trim().ToUpper())
        Cmd.Parameters.AddWithValue("Quantity", prodQuantity.Text.Trim())
        Cmd.Parameters.AddWithValue("UnitPrice", prodUnitPrice.Text.Trim())

        If str = "Update" And Not String.IsNullOrEmpty(Me.ID) Then

            Cmd.Parameters.AddWithValue("ID", Me.ID)


        End If

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrEmpty(Me.prodName.Text.Trim()) Or
            String.IsNullOrEmpty(Me.prodQuantity.Text.Trim()) Or
            String.IsNullOrEmpty(Me.prodUnitPrice.Text.Trim()) Then

            MessageBox.Show("Please fill in all the missing fields",
                            "Missing fields",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

        End If

        SQL = "INSERT INTO ANDERSON(Product, Quantity, UnitPrice) VALUES(@Product, @Quantity, @UnitPrice)"
        Execute(SQL, "Insert")

        MessageBox.Show("Product Saved Successfully",
                            "Save Product: Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        LoadData()
        ResetMe()

    End Sub
    Private Sub LoadData(Optional keyword As String = "")

        SQL = "SELECT * FROM ANDERSON ORDER BY ID ASC"


        Dim strKeyword As String = String.Format("%{0}%", keyword)

        Cmd = New OleDbCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword1", strKeyword)
        Cmd.Parameters.AddWithValue("keyword2", keyword)

        Dim dt As DataTable = PerformCRUD(Cmd)

        With DataGridView1

            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "PRODUCT"
            .Columns(2).HeaderText = "QUANTITY"
            .Columns(3).HeaderText = "UNIT PRICE($)"
            .Columns(4).HeaderText = "TOTAL PRICE($)"

            .Columns(0).Width = 100
            .Columns(1).Width = 260
            .Columns(2).Width = 160
            .Columns(3).Width = 160
            .Columns(4).Width = 170

        End With

        'Calculating Quantity and  Total profits

        Dim sumSQL As String = "SELECT SUM(Quantity) AS QuantityTotal, SUM(TotalPrice) AS TotalProfits  FROM ANDERSON"
        Cmd = New OleDbCommand(sumSQL, Con)
        Cmd.Parameters.Clear()
        Dim dtTotal As DataTable = PerformCRUD(Cmd)
        lblTotalProducts.Text = ("Total Products: " & dtTotal.Rows(0)("QuantityTotal").ToString())
        lblProfit.Text = ("Expected Returns($): " & dtTotal.Rows(0)("TotalProfits").ToString())
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim dgv As DataGridView = DataGridView1

        If e.RowIndex <> -1 Then

            Me.ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim()
            btnUpdate.Text = ("Update ID: (" & Me.ID & ")")
            btnDelete.Text = ("Delete ID: (" & Me.ID & ")")


            prodName.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value).Trim()
            prodQuantity.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value).Trim()
            prodUnitPrice.Text = Convert.ToString(dgv.CurrentRow.Cells(3).Value).Trim()

        End If

        btnSave.Visible = False



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If DataGridView1.Rows.Count = 0 Then

            Exit Sub

        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MessageBox.Show("Please select an item from the list!",
                            "Select Item",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

        End If

        If String.IsNullOrEmpty(Me.prodName.Text.Trim()) Or
          String.IsNullOrEmpty(Me.prodQuantity.Text.Trim()) Or
          String.IsNullOrEmpty(Me.prodUnitPrice.Text.Trim()) Then

            MessageBox.Show("Please fill in all the missing fields",
                            "Missing fields",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

        End If


        SQL = "UPDATE ANDERSON SET Product = @Product, Quantity = @Quantity , UnitPrice = @UnitPrice WHERE ID = @ID"


        Execute(SQL, "Update")

        MessageBox.Show("Product Updated Successfully",
                            "Product Update: Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        btnSave.Visible = True
        LoadData()
        ResetMe()
        btnDelete.Text = "Delete Product"
        btnUpdate.Text = "Update Product"



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If DataGridView1.Rows.Count = 0 Then

            Exit Sub

        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MessageBox.Show("Please select an item from the list!",
                            "Select Item",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Do you want to delete the selected product permanentl?",
                            "Delete Record",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) = DialogResult.Yes Then

            SQL = "DELETE * FROM ANDERSON WHERE ID = @ID"


            Execute(SQL, "Delete")

            MessageBox.Show("Product Deleted Successfully",
                            "Product Delete: Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            btnSave.Visible = True
            LoadData()
            ResetMe()
            btnDelete.Text = "Delete Product"
            btnUpdate.Text = "Update Product"


        End If


    End Sub
End Class