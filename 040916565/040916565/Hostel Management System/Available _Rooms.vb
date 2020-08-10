Public Class Available__Rooms
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnOccupants.Click
        Occupants_Details_and_Room_Number.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTypes.Click
        Types_of_Rooms_and_Prices.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        Visitors_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Employee_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Available_RoomsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Available_RoomsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Available_RoomsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)

    End Sub

    Private Sub Available__Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Hostel_Management_System_1DataSet.Available_Rooms' table. You can move, or remove it, as needed.
        Me.Available_RoomsTableAdapter.Fill(Me.DB_Hostel_Management_System_1DataSet.Available_Rooms)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Me.Validate()
        Me.Available_RoomsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Available_RoomsBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Available_RoomsBindingSource.MoveNext()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Available_RoomsBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Available_RoomsBindingSource.AddNew()

    End Sub
End Class