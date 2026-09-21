<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCarRenatl = New System.Windows.Forms.Label()
        Me.lblVehicleType = New System.Windows.Forms.Label()
        Me.cboVehicleType = New System.Windows.Forms.ComboBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblDailyCharge = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtDailyCharge = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCarRenatl
        '
        Me.lblCarRenatl.AutoSize = True
        Me.lblCarRenatl.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarRenatl.Location = New System.Drawing.Point(137, 9)
        Me.lblCarRenatl.Name = "lblCarRenatl"
        Me.lblCarRenatl.Size = New System.Drawing.Size(400, 35)
        Me.lblCarRenatl.TabIndex = 0
        Me.lblCarRenatl.Text = "Fast Company Car Rental"
        '
        'lblVehicleType
        '
        Me.lblVehicleType.AutoSize = True
        Me.lblVehicleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleType.Location = New System.Drawing.Point(97, 99)
        Me.lblVehicleType.Name = "lblVehicleType"
        Me.lblVehicleType.Size = New System.Drawing.Size(186, 32)
        Me.lblVehicleType.TabIndex = 1
        Me.lblVehicleType.Text = "Vechice Type"
        '
        'cboVehicleType
        '
        Me.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicleType.FormattingEnabled = True
        Me.cboVehicleType.Items.AddRange(New Object() {"Sedan", "SUV", "Truck"})
        Me.cboVehicleType.Location = New System.Drawing.Point(400, 103)
        Me.cboVehicleType.Name = "cboVehicleType"
        Me.cboVehicleType.Size = New System.Drawing.Size(152, 28)
        Me.cboVehicleType.TabIndex = 2
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(97, 160)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(294, 32)
        Me.lblDays.TabIndex = 3
        Me.lblDays.Text = "Rental Duration(Days)"
        '
        'lblDailyCharge
        '
        Me.lblDailyCharge.AutoSize = True
        Me.lblDailyCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyCharge.Location = New System.Drawing.Point(97, 221)
        Me.lblDailyCharge.Name = "lblDailyCharge"
        Me.lblDailyCharge.Size = New System.Drawing.Size(178, 32)
        Me.lblDailyCharge.TabIndex = 4
        Me.lblDailyCharge.Text = "Daily Charge"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(400, 167)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(152, 26)
        Me.txtDays.TabIndex = 5
        '
        'txtDailyCharge
        '
        Me.txtDailyCharge.Location = New System.Drawing.Point(400, 227)
        Me.txtDailyCharge.Name = "txtDailyCharge"
        Me.txtDailyCharge.Size = New System.Drawing.Size(152, 26)
        Me.txtDailyCharge.TabIndex = 6
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(400, 297)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(152, 26)
        Me.txtTotalCost.TabIndex = 7
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(97, 291)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(233, 32)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "Total Rental Cost"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(109, 348)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(174, 55)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(339, 348)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 55)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 582)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtDailyCharge)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.lblDailyCharge)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.cboVehicleType)
        Me.Controls.Add(Me.lblVehicleType)
        Me.Controls.Add(Me.lblCarRenatl)
        Me.Name = "Form1"
        Me.Text = "CAR RENTAL SYSTEM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCarRenatl As Label
    Friend WithEvents lblVehicleType As Label
    Friend WithEvents cboVehicleType As ComboBox
    Friend WithEvents lblDays As Label
    Friend WithEvents lblDailyCharge As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtDailyCharge As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
