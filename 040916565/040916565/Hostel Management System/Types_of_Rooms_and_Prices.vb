Public Class Types_of_Rooms_and_Prices
    Private Sub Types_of_Rooms_and_PricesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Types_of_Rooms_and_PricesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Types_of_Rooms_and_PricesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)

    End Sub

    Private Sub Types_of_Rooms_and_Prices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Hostel_Management_System_1DataSet.Types_of_Rooms_and_Prices' table. You can move, or remove it, as needed.
        Me.Types_of_Rooms_and_PricesTableAdapter.Fill(Me.DB_Hostel_Management_System_1DataSet.Types_of_Rooms_and_Prices)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Me.Validate()
        Me.Types_of_Rooms_and_PricesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Hostel_Management_System_1DataSet)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnOccupants.Click
        Occupants_Details_and_Room_Number.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Employee_Details.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAvailable.Click
        Available__Rooms.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        Visitors_Details.Show()
        Me.Hide()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Types_of_Rooms_and_PricesBindingSource.MovePrevious()


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Types_of_Rooms_and_PricesBindingSource.MoveNext()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Types_of_Rooms_and_PricesBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Types_of_Rooms_and_PricesBindingSource.AddNew()

    End Sub
End Class