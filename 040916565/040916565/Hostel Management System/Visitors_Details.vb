Public Class Visitors_Details
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOccupants.Click
        Occupants_Details_and_Room_Number.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnTypes.Click
        Types_of_Rooms_and_Prices.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAvailable.Click
        Available__Rooms.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Employee_Details.Show()
        Me.Hide()

    End Sub

    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VisitorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)

    End Sub

    Private Sub Visitors_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Hostel_Management_System_1DataSet.Visitors' table. You can move, or remove it, as needed.
        Me.VisitorsTableAdapter.Fill(Me.DB_Hostel_Management_System_1DataSet.Visitors)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        VisitorsBindingSource.Filter = "Room  LIKE'" + ToolStripTextBox1.Text + "%'"

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        VisitorsBindingSource.MovePrevious()


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        VisitorsBindingSource.MoveNext()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        VisitorsBindingSource.RemoveCurrent()


    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        VisitorsBindingSource.MoveFirst()

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        VisitorsBindingSource.MoveLast()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        VisitorsBindingSource.AddNew()

    End Sub
End Class
