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
        Me.btnSubmitText = New System.Windows.Forms.Button()
        Me.txtWeekday = New System.Windows.Forms.TextBox()
        Me.txtMonthName = New System.Windows.Forms.TextBox()
        Me.lstEvents = New System.Windows.Forms.ListBox()
        Me.lstDaysOfMonth = New System.Windows.Forms.ListBox()
        Me.btnMonthForward = New System.Windows.Forms.Button()
        Me.btnMonthBackward = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtEventDetails = New System.Windows.Forms.TextBox()
        Me.btnEnterText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSubmitText
        '
        Me.btnSubmitText.Location = New System.Drawing.Point(244, 396)
        Me.btnSubmitText.Name = "btnSubmitText"
        Me.btnSubmitText.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitText.TabIndex = 19
        Me.btnSubmitText.Text = "Submit Text"
        Me.btnSubmitText.UseVisualStyleBackColor = True
        '
        'txtWeekday
        '
        Me.txtWeekday.Location = New System.Drawing.Point(12, 128)
        Me.txtWeekday.Name = "txtWeekday"
        Me.txtWeekday.ReadOnly = True
        Me.txtWeekday.Size = New System.Drawing.Size(118, 20)
        Me.txtWeekday.TabIndex = 16
        Me.txtWeekday.TabStop = False
        Me.txtWeekday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonthName
        '
        Me.txtMonthName.Location = New System.Drawing.Point(12, 102)
        Me.txtMonthName.Name = "txtMonthName"
        Me.txtMonthName.ReadOnly = True
        Me.txtMonthName.Size = New System.Drawing.Size(118, 20)
        Me.txtMonthName.TabIndex = 14
        Me.txtMonthName.TabStop = False
        Me.txtMonthName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstEvents
        '
        Me.lstEvents.FormattingEnabled = True
        Me.lstEvents.Location = New System.Drawing.Point(12, 154)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(118, 264)
        Me.lstEvents.TabIndex = 13
        '
        'lstDaysOfMonth
        '
        Me.lstDaysOfMonth.FormattingEnabled = True
        Me.lstDaysOfMonth.Location = New System.Drawing.Point(136, 12)
        Me.lstDaysOfMonth.Name = "lstDaysOfMonth"
        Me.lstDaysOfMonth.Size = New System.Drawing.Size(21, 407)
        Me.lstDaysOfMonth.TabIndex = 12
        '
        'btnMonthForward
        '
        Me.btnMonthForward.Location = New System.Drawing.Point(72, 38)
        Me.btnMonthForward.Name = "btnMonthForward"
        Me.btnMonthForward.Size = New System.Drawing.Size(58, 58)
        Me.btnMonthForward.TabIndex = 11
        Me.btnMonthForward.Text = "Next Month"
        Me.btnMonthForward.UseVisualStyleBackColor = True
        '
        'btnMonthBackward
        '
        Me.btnMonthBackward.Location = New System.Drawing.Point(12, 38)
        Me.btnMonthBackward.Name = "btnMonthBackward"
        Me.btnMonthBackward.Size = New System.Drawing.Size(58, 58)
        Me.btnMonthBackward.TabIndex = 10
        Me.btnMonthBackward.Text = "Previous Month"
        Me.btnMonthBackward.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(12, 12)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(118, 20)
        Me.txtYear.TabIndex = 15
        Me.txtYear.TabStop = False
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEventDetails
        '
        Me.txtEventDetails.Location = New System.Drawing.Point(163, 12)
        Me.txtEventDetails.Multiline = True
        Me.txtEventDetails.Name = "txtEventDetails"
        Me.txtEventDetails.Size = New System.Drawing.Size(156, 378)
        Me.txtEventDetails.TabIndex = 20
        '
        'btnEnterText
        '
        Me.btnEnterText.Location = New System.Drawing.Point(163, 396)
        Me.btnEnterText.Name = "btnEnterText"
        Me.btnEnterText.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterText.TabIndex = 18
        Me.btnEnterText.Text = "Edit Text"
        Me.btnEnterText.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 467)
        Me.Controls.Add(Me.txtEventDetails)
        Me.Controls.Add(Me.btnSubmitText)
        Me.Controls.Add(Me.btnEnterText)
        Me.Controls.Add(Me.txtWeekday)
        Me.Controls.Add(Me.txtMonthName)
        Me.Controls.Add(Me.lstEvents)
        Me.Controls.Add(Me.lstDaysOfMonth)
        Me.Controls.Add(Me.btnMonthForward)
        Me.Controls.Add(Me.btnMonthBackward)
        Me.Controls.Add(Me.txtYear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmitText As System.Windows.Forms.Button
    Friend WithEvents txtWeekday As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthName As System.Windows.Forms.TextBox
    Friend WithEvents lstEvents As System.Windows.Forms.ListBox
    Friend WithEvents lstDaysOfMonth As System.Windows.Forms.ListBox
    Friend WithEvents btnMonthForward As System.Windows.Forms.Button
    Friend WithEvents btnMonthBackward As System.Windows.Forms.Button
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtEventDetails As System.Windows.Forms.TextBox
    Friend WithEvents btnEnterText As System.Windows.Forms.Button

End Class
