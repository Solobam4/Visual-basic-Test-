Public Class Occupants_Details_and_Room_Number
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnTypesOfRooms.Click
        Types_of_Rooms_and_Prices.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Employee_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        Visitors_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAvailable.Click
        Available__Rooms.Show()
        Me.Hide()
    End Sub

    Private Sub Occupants_Details_and_Room_Number_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Hostel_Management_System_1DataSet.Occupants_Details_and__Room_Numbers' table. You can move, or remove it, as needed.
        Me.Occupants_Details_and__Room_NumbersTableAdapter.Fill(Me.DB_Hostel_Management_System_1DataSet.Occupants_Details_and__Room_Numbers)

    End Sub

    Private Sub Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Occupants_Details_and__Room_NumbersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Me.Validate()
        Me.Occupants_Details_and__Room_NumbersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)


    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click


    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Occupants_Details_and__Room_NumbersBindingSource.Filter = "Room LIKE'" + ToolStripTextBox1.Text + "%'"
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Occupants_Details_and__Room_NumbersBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Occupants_Details_and__Room_NumbersBindingSource.CurrentChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Occupants_Details_and__Room_NumbersBindingSource.MoveNext()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Occupants_Details_and__Room_NumbersBindingSource.MovePrevious()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Occupants_Details_and__Room_NumbersBindingSource.RemoveCurrent()


    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        Occupants_Details_and__Room_NumbersBindingSource.MoveFirst()


    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Occupants_Details_and__Room_NumbersBindingSource.MoveLast()

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Occupants_Details_and__Room_NumbersBindingSource.AddNew()

    End Sub
End Class