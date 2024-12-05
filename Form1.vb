Imports MySql.Data.MySqlClient

Public Class Form1
    Dim dbConn As New MySqlConnection("Server=localhost;Database=pf_101;User ID=root;")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbConn.Open()
        Catch ex As Exception
            MsgBox("Failed to connect to the database", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_compute_Click(sender As Object, e As EventArgs) Handles btn_compute.Click
        If employee_identifier.Text.Length <= 0 Then
            MsgBox("Please fill in the employee name with the employee's name or id.,")
            Return
        End If

        Try
            Dim command As New MySqlCommand("SELECT * from employees WHERE id = @id OR name = @name;", dbConn)
            command.Parameters.AddWithValue("@id", employee_identifier.Text)
            command.Parameters.AddWithValue("@name", employee_identifier.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                MsgBox("Success On " & reader("name"), MsgBoxStyle.OkOnly)

                Dim ratePerHour = reader.GetFloat("rate_per_hour")
                Dim hoursPerDay = reader.GetInt32("hour_per_day")
                Dim numberDaysWorked = reader.GetInt32("number_of_days_work")

                Dim grossSalary = ratePerHour * hoursPerDay * numberDaysWorked

                Dim taxDeduction = grossSalary * 0.15
                Dim philhealthDeduction = grossSalary * 0.05
                Dim sssDeduction = grossSalary * 0.02
                Dim totalDeduction = taxDeduction + philhealthDeduction + sssDeduction

                Dim netSalary = grossSalary - totalDeduction

                rate_per_hour.Text = "₱ " & ratePerHour.ToString()
                hour_per_day.Text = "₱ " & hoursPerDay.ToString()
                num_days_work.Text = "₱ " & numberDaysWorked.ToString()

                deduct_tax.Text = "₱ " & taxDeduction
                deduct_ph.Text = "₱ " & philhealthDeduction
                deduct_sss.Text = "₱ " & sssDeduction

                result.Text = ""
                result.Text += "================================================" & vbCrLf
                result.Text += "* Rate per hour = ₱ " & ratePerHour & vbCrLf
                result.Text += "* Hours per day = ₱ " & hoursPerDay & vbCrLf
                result.Text += "* Days Worked = ₱ " & numberDaysWorked & vbCrLf & vbCrLf & vbCrLf
                result.Text += "= GROSS SALARY = ₱ " & grossSalary & vbCrLf
                result.Text += "================================================"
                result.Text += "* Tax (15%) = ₱ " & taxDeduction & vbCrLf
                result.Text += "* PhilHealth (5%) = ₱ " & philhealthDeduction & vbCrLf
                result.Text += "* SSS (2%) = ₱ " & sssDeduction & vbCrLf & vbCrLf & vbCrLf
                result.Text += "= TOTAL DEDUCTION = ₱ " & totalDeduction & vbCrLf
                result.Text += "================================================"
                result.Text += "* GROSS SALARY = ₱ " & grossSalary & vbCrLf
                result.Text += "* TOTAL DEDUCTION = ₱ " & totalDeduction & vbCrLf & vbCrLf & vbCrLf
                result.Text += "= NET SALARY = ₱ " & netSalary & vbCrLf
                result.Text += "================================================"
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Failed to query database" & ex.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        dbConn.Close()
    End Sub
End Class
