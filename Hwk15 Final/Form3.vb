Public Class Form3
    Dim InstInfo As Instructor
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        InstInfo = New Instructor

        InstInfo.m_FirstName = InstName.Text
        InstInfo.m_LastName = InstLName.Text
        InstInfo.m_EM = InstEmail.Text
        InstInfo.m_OfficNum = InstOfficeNum.Text

    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        'Display
        ListBox1.Items.Add("- - - - - - - Instructor Info - - - - -  - - - -") 'title
        ListBox1.Items.Add("First Name: " & InstName.Text)
        ListBox1.Items.Add("Last Name: " & InstLName.Text)
        ListBox1.Items.Add("Instructor Email: " & InstEmail.Text)
        ListBox1.Items.Add("Office Number: " & InstOfficeNum.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Download
        Dim Download As IO.StreamWriter = IO.File.CreateText("C:\Users\ACC\OneDrive - Rancho Santiago Community College District\Desktop\CE_Instructor.CSV")

        Download.WriteLine(InstName.Text & "," & InstLName.Text & "," & InstEmail.Text & "," & InstOfficeNum.Text & ",")
        Download.Close()

        MessageBox.Show("Dowload Completed, (2/3) Forms Completed")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class