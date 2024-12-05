<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btn_compute = New Button()
        Label1 = New Label()
        rate_per_hour = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        hour_per_day = New TextBox()
        Label4 = New Label()
        num_days_work = New TextBox()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        deduct_tax = New TextBox()
        Label8 = New Label()
        deduct_ph = New TextBox()
        Label9 = New Label()
        deduct_sss = New TextBox()
        result = New Label()
        Label10 = New Label()
        Label11 = New Label()
        employee_identifier = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSeaGreen
        Panel1.Controls.Add(btn_compute)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(898, 49)
        Panel1.TabIndex = 0
        ' 
        ' btn_compute
        ' 
        btn_compute.BackColor = Color.ForestGreen
        btn_compute.Cursor = Cursors.Hand
        btn_compute.FlatStyle = FlatStyle.Flat
        btn_compute.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_compute.ForeColor = Color.White
        btn_compute.Location = New Point(797, 8)
        btn_compute.Name = "btn_compute"
        btn_compute.Size = New Size(89, 32)
        btn_compute.TabIndex = 1
        btn_compute.Text = "COMPUTE"
        btn_compute.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 25)
        Label1.TabIndex = 0
        Label1.Text = "Payroll System"
        ' 
        ' rate_per_hour
        ' 
        rate_per_hour.BorderStyle = BorderStyle.FixedSingle
        rate_per_hour.Enabled = False
        rate_per_hour.Location = New Point(213, 147)
        rate_per_hour.Name = "rate_per_hour"
        rate_per_hour.ReadOnly = True
        rate_per_hour.Size = New Size(206, 25)
        rate_per_hour.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(82, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 17)
        Label2.TabIndex = 2
        Label2.Text = "Rate Per Hour:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(87, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 17)
        Label3.TabIndex = 4
        Label3.Text = "Hour Per Day:"
        ' 
        ' hour_per_day
        ' 
        hour_per_day.BorderStyle = BorderStyle.FixedSingle
        hour_per_day.Enabled = False
        hour_per_day.Location = New Point(213, 190)
        hour_per_day.Name = "hour_per_day"
        hour_per_day.ReadOnly = True
        hour_per_day.Size = New Size(206, 25)
        hour_per_day.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(36, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 17)
        Label4.TabIndex = 6
        Label4.Text = "Number of days work:"
        ' 
        ' num_days_work
        ' 
        num_days_work.BorderStyle = BorderStyle.FixedSingle
        num_days_work.Enabled = False
        num_days_work.Location = New Point(213, 231)
        num_days_work.Name = "num_days_work"
        num_days_work.ReadOnly = True
        num_days_work.Size = New Size(206, 25)
        num_days_work.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGray
        Panel3.ForeColor = Color.WhiteSmoke
        Panel3.Location = New Point(460, 49)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1, 433)
        Panel3.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DimGray
        Panel2.Location = New Point(-2, 275)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(463, 1)
        Panel2.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(57, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 30)
        Label5.TabIndex = 10
        Label5.Text = "Info:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(57, 293)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 30)
        Label6.TabIndex = 11
        Label6.Text = "Deductions:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(114, 343)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 17)
        Label7.TabIndex = 13
        Label7.Text = "Tax (15%):"
        ' 
        ' deduct_tax
        ' 
        deduct_tax.BorderStyle = BorderStyle.FixedSingle
        deduct_tax.Enabled = False
        deduct_tax.Location = New Point(213, 340)
        deduct_tax.Name = "deduct_tax"
        deduct_tax.ReadOnly = True
        deduct_tax.Size = New Size(206, 25)
        deduct_tax.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(79, 386)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 17)
        Label8.TabIndex = 15
        Label8.Text = "Philhealth (5%):"
        ' 
        ' deduct_ph
        ' 
        deduct_ph.BorderStyle = BorderStyle.FixedSingle
        deduct_ph.Enabled = False
        deduct_ph.Location = New Point(213, 383)
        deduct_ph.Name = "deduct_ph"
        deduct_ph.ReadOnly = True
        deduct_ph.Size = New Size(206, 25)
        deduct_ph.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(118, 430)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 17)
        Label9.TabIndex = 17
        Label9.Text = "SSS (2%):"
        ' 
        ' deduct_sss
        ' 
        deduct_sss.BorderStyle = BorderStyle.FixedSingle
        deduct_sss.Enabled = False
        deduct_sss.Location = New Point(213, 427)
        deduct_sss.Name = "deduct_sss"
        deduct_sss.ReadOnly = True
        deduct_sss.Size = New Size(206, 25)
        deduct_sss.TabIndex = 16
        ' 
        ' result
        ' 
        result.BackColor = Color.WhiteSmoke
        result.FlatStyle = FlatStyle.Flat
        result.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        result.Location = New Point(482, 107)
        result.Name = "result"
        result.Size = New Size(394, 366)
        result.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.DarkSeaGreen
        Label10.Font = New Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(482, 64)
        Label10.Name = "Label10"
        Label10.Size = New Size(394, 43)
        Label10.TabIndex = 19
        Label10.Text = "Computation:"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(123, 109)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 17)
        Label11.TabIndex = 21
        Label11.Text = "* Name:"
        ' 
        ' employee_identifier
        ' 
        employee_identifier.BorderStyle = BorderStyle.FixedSingle
        employee_identifier.Location = New Point(213, 107)
        employee_identifier.Name = "employee_identifier"
        employee_identifier.Size = New Size(206, 25)
        employee_identifier.TabIndex = 20
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(896, 482)
        Controls.Add(Label11)
        Controls.Add(employee_identifier)
        Controls.Add(Label10)
        Controls.Add(result)
        Controls.Add(Label9)
        Controls.Add(deduct_sss)
        Controls.Add(Label8)
        Controls.Add(deduct_ph)
        Controls.Add(Label7)
        Controls.Add(deduct_tax)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Label4)
        Controls.Add(num_days_work)
        Controls.Add(Label3)
        Controls.Add(hour_per_day)
        Controls.Add(Label2)
        Controls.Add(rate_per_hour)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Payroll System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents rate_per_hour As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hour_per_day As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents num_days_work As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_compute As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents deduct_tax As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents deduct_ph As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents deduct_sss As TextBox
    Friend WithEvents result As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents employee_identifier As TextBox

End Class
