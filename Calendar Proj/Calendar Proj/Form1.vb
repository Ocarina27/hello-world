Public Class Form1
    Dim monthNum As Integer = 1
    Dim daysPerMonth As Integer, numEvents As Integer = 0
    Dim Year As Integer = Now.Year
    Dim enteredEvents As Boolean = False
    Dim makeNewEvent, deleteEvent As Boolean
    ''''''''''''''''''''''''''''''''''''
    Public eventTime(0) As String
    Public eventName(0) As String
    Public eventDetails(0) As String

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        makeNewEvent = False
        deleteEvent = False
        txtEventDetails.Enabled = False
        'Dim Weekday(6) As Integer
        txtMonthName.Text = Now.Month
        lstDaysOfMonth.Select()
        whichmonth(1)
        txtEventDetails.Enabled = False
        btnEnterText.Enabled = True
        btnMonthBackward.Enabled = True
        btnMonthForward.Enabled = True
        lstDaysOfMonth.Enabled = True
        lstEvents.Enabled = True
        txtMonthName.Enabled = True
        txtWeekday.Enabled = True
        txtYear.Enabled = True
    End Sub

    Public Structure structEvent
        Public eventTime As String
        Public eventName As String
        Public eventDetails As String
        ' Public (for multiple events per day)
    End Structure
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim eventInfo(0) As structEvent
    Sub storeStructureData()
        Dim numStructures As Integer = eventInfo.Count
        Dim unwantedIndex As Integer
        If makeNewEvent Then
            numStructures = eventInfo.Count
            ReDim Preserve eventInfo(numStructures + 1)    'structure array
            ReDim Preserve eventTime(numStructures + 1)    'non-structure variable arrays
            ReDim Preserve eventName(numStructures + 1)    'non-structure variable arrays
            ReDim Preserve eventDetails(numStructures + 1) 'non-structure variable arrays
            eventInfo(numStructures + 1) = getNewSructure(numStructures)
            makeNewEvent = False
        End If
        If deleteEvent Then
            shiftArrayvalues(eventInfo, unwantedIndex)
            ReDim eventInfo(numStructures - 1)
            deleteEvent = False
        End If
    End Sub

    Sub shiftArrayvalues(ByRef eventInfo() As structEvent, ByVal unwantedIndex As Integer)
        If eventInfo.Count - 1 = unwantedIndex Then
            For i As Integer = unwantedIndex + 1 To eventInfo.Count - 1
                eventInfo(i - 1) = eventInfo(i)
            Next
        End If
    End Sub

    Function getNewSructure(ByVal numStructures As Integer) As structEvent
        Dim newStructure As New structEvent
        Return newStructure
    End Function

    Private Sub lstDaysOfMonth_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDaysOfMonth.DoubleClick
        If lstDaysOfMonth.Items.Count > 0 Then

            eventName(0) = InputBox("Enter event name:", "Event Name")
            eventTime(0) = InputBox("When will this event take place?", "Event Time")
            lstEvents.Items.Clear() '<-----------------*change later*-----------------------------only allows 1 event per day
            lstEvents.Items.Add(eventTime(0))
            lstEvents.Items.Add(eventName(0))
            lstEvents.Items.Add("Click here to view details.")
            lstEvents.Items.Add("")
        End If
    End Sub

    Private Sub monthForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthForward.Click
        monthNum += 1
        If monthNum = 13 Then
            monthNum = 1
            Year += 1
        End If
        whichmonth(monthNum)
    End Sub

    Private Sub btnMonthBackward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthBackward.Click
        monthNum -= 1
        If monthNum = 0 Then
            monthNum = 12
            Year -= 1
        End If
        whichmonth(monthNum)
    End Sub

    Sub whichmonth(ByVal monthNum As Integer)
        Select Case monthNum
            Case 1
                txtMonthName.Text = "January"
                daysPerMonth = 31
            Case 2 +
                txtMonthName.Text = "Febuary"
                If Year Mod 4 = 0 Then
                    daysPerMonth = 29
                Else
                    daysPerMonth = 28
                End If
            Case 3
                txtMonthName.Text = "March"
                daysPerMonth = 31
            Case 4
                txtMonthName.Text = "April"
                daysPerMonth = 30
            Case 5
                txtMonthName.Text = "May"
                daysPerMonth = 31
            Case 6
                txtMonthName.Text = "June"
                daysPerMonth = 30
            Case 7
                txtMonthName.Text = "July"
                daysPerMonth = 31
            Case 8
                txtMonthName.Text = "August"
                daysPerMonth = 31
            Case 9
                txtMonthName.Text = "September"
                daysPerMonth = 30
            Case 10
                txtMonthName.Text = "October"
                daysPerMonth = 31
            Case 11
                txtMonthName.Text = "November"
                daysPerMonth = 30
            Case 12
                txtMonthName.Text = "December"
                daysPerMonth = 31
        End Select
        lstDaysOfMonth.Items.Clear()
        For i As Integer = 0 To daysPerMonth - 1
            lstDaysOfMonth.Items.Add(i + 1)
        Next
        txtYear.Text = Year
    End Sub

    Private Sub lstEvents_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstEvents.DoubleClick
        If lstEvents.Text = "Click here to view details." Then
            txtEventDetails.Text = eventInfo(0).eventDetails
        End If
    End Sub

    Private Sub btnEnterText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterText.Click

    End Sub

    Private Sub btnSubmitText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitText.Click
        If 
            makeNewEvent = True
            storeStructureData()
        End If
        txtEventDetails.Enabled = False
        btnEnterText.Enabled = True
        btnMonthBackward.Enabled = True
        btnMonthForward.Enabled = True
        lstDaysOfMonth.Enabled = True
        lstEvents.Enabled = True
        txtMonthName.Enabled = True
        txtWeekday.Enabled = True
        txtYear.Enabled = True
    End Sub

    Private Sub lstDaysOfMonth_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDaysOfMonth.MouseHover

    End Sub

    Private Sub lstDaysOfMonth_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDaysOfMonth.SelectedIndexChanged

    End Sub
End Class
