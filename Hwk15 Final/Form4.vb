Public Class Form4
    Dim StudentsInfo As Student
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        StudentsInfo = New Student

        StudentsInfo.m_FirstName = StuFName.Text
        StudentsInfo.m_LastName = StuLName.Text
        StudentsInfo.m_EM = StuEmail.Text
        StudentsInfo.m_StudentNum = StuNumber.Text
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        'Display
        ListBox1.Items.Add("- - - - - - - Student Info - - - - -  - - - -") 'title
        ListBox1.Items.Add("First Name: " & StuFName.Text)
        ListBox1.Items.Add("Last Name: " & StuLName.Text)
        ListBox1.Items.Add("Email: " & StuEmail.Text)
        ListBox1.Items.Add("Student Number: " & StuNumber.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Download
        Dim Download As IO.StreamWriter = IO.File.CreateText("C:\Users\ACC\OneDrive - Rancho Santiago Community College District\Desktop\CE_Students.CSV")

        Download.WriteLine(StuFName.Text & "," & StuLName.Text & "," & StuEmail.Text & "," & StuNumber.Text & ",")
        Download.Close()

        MessageBox.Show("Dowload Completed, (3/3) All Forms Completed")
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class