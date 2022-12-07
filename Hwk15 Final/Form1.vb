Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnInstructor.Visible = False
        BtnStudent.Visible = False
        Me.CenterToScreen()

    End Sub

    Private Sub BtnCourse_Click(sender As Object, e As EventArgs) Handles BtnCourse.Click
        BtnInstructor.Visible = True
        Form2.ShowDialog()

    End Sub

    Private Sub BtnInstructor_Click(sender As Object, e As EventArgs) Handles BtnInstructor.Click
        BtnStudent.Visible = True
        Form3.ShowDialog()

    End Sub

    Private Sub BtnStudent_Click(sender As Object, e As EventArgs) Handles BtnStudent.Click
        Form4.ShowDialog()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        'Save = goes into text file csv 


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'exit
        Me.Close()

    End Sub
End Class
