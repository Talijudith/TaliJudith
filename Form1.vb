Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dailyCharge As Decimal
        Dim days As Integer
        Dim totalCost As Decimal

        'Check whether a vehicle has been selected
        If cboVehicleType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a vehicle type.")
            Exit Sub
        End If

        'Check whether days is a valid number
        If Not Integer.TryParse(txtDays.Text, days) OrElse days <= 0 Then
            MessageBox.Show("Please enter a valid number of days.")
            txtDays.Focus()
            Exit Sub
        End If

        'Determine the daily charge
        If cboVehicleType.Text = "Sedan" Then
            dailyCharge = 150000

        ElseIf cboVehicleType.Text = "SUV" Then
            dailyCharge = 290000

        ElseIf cboVehicleType.Text = "Truck" Then
            dailyCharge = 350000
        End If

        'Display daily charge
        txtDailyCharge.Text = dailyCharge.ToString("N0")

        'Calculate total rental cost
        totalCost = dailyCharge * days

        'Display total cost
        txtTotalCost.Text = totalCost.ToString("N0")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboVehicleType.SelectedIndex = -1
        txtDays.Clear()
        txtDailyCharge.Clear()
        txtTotalCost.Clear()

        cboVehicleType.Focus()

    End Sub
End Class
