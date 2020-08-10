Public Class Employee_Details
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnOccupants.Click
        Occupants_Details_and_Room_Number.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTypes.Click
        Types_of_Rooms_and_Prices.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        Visitors_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAvailable.Click
        Available__Rooms.Show()
        Me.Hide()
    End Sub

    Private Sub Employees__DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Employees__DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Employees__DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)

    End Sub

    Private Sub Employee_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Hostel_Management_System_1DataSet.Employees__Details' table. You can move, or remove it, as needed.
        Me.Employees__DetailsTableAdapter.Fill(Me.DB_Hostel_Management_System_1DataSet.Employees__Details)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Me.Validate()
        Me.Employees__DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click


    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Employees__DetailsBindingSource.Filter = "Employee_ID  LIKE'" + ToolStripTextBox1.Text + "%'"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Employees__DetailsBindingSource.MoveNext()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Employees__DetailsBindingSource.MovePrevious()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Employees__DetailsBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        Employees__DetailsBindingSource.MoveFirst()

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Employees__DetailsBindingSource.MoveLast()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Employees__DetailsBindingSource.AddNew()

    End Sub
End Class