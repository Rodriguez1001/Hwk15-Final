Public Class Form2
    Dim Courses As Course
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Courses = New Course

        Courses.m_CourseNum = CourseNum.Text
        Courses.m_CourseName = CourseNam.Text
        Courses.m_CourseUnits = CourseUnits.Text
        Courses.m_RoomNum = CourseRmNum.Text

        'Save to file

    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        'Display
        ListBox1.Items.Add("- - - - - - - Course Info - - - - -  - - - -") 'title
        ListBox1.Items.Add("Course Number: " & CourseNum.Text)
        ListBox1.Items.Add("Course Name: " & CourseNam.Text)
        ListBox1.Items.Add("Course Units: " & CourseUnits.Text)
        ListBox1.Items.Add("Room Number: " & CourseRmNum.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Download
        Dim Download As IO.StreamWriter = IO.File.CreateText("C:\Users\ACC\OneDrive - Rancho Santiago Community College District\Desktop\CE_Course.CSV")

        Download.WriteLine(CourseNum.Text & "," & CourseNam.Text & "," & CourseUnits.Text & "," & CourseRmNum.Text & ",")
        Download.Close()

        MessageBox.Show("Dowload Completed, (1/3) Forms Completed")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class