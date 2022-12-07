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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCourse = New System.Windows.Forms.Button()
        Me.BtnInstructor = New System.Windows.Forms.Button()
        Me.BtnStudent = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(192, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Menu"
        '
        'BtnCourse
        '
        Me.BtnCourse.BackColor = System.Drawing.Color.LightBlue
        Me.BtnCourse.Location = New System.Drawing.Point(79, 113)
        Me.BtnCourse.Name = "BtnCourse"
        Me.BtnCourse.Size = New System.Drawing.Size(129, 55)
        Me.BtnCourse.TabIndex = 1
        Me.BtnCourse.Text = "Course"
        Me.BtnCourse.UseVisualStyleBackColor = False
        '
        'BtnInstructor
        '
        Me.BtnInstructor.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnInstructor.Location = New System.Drawing.Point(79, 191)
        Me.BtnInstructor.Name = "BtnInstructor"
        Me.BtnInstructor.Size = New System.Drawing.Size(129, 55)
        Me.BtnInstructor.TabIndex = 2
        Me.BtnInstructor.Text = "Instructor"
        Me.BtnInstructor.UseVisualStyleBackColor = False
        '
        'BtnStudent
        '
        Me.BtnStudent.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnStudent.Location = New System.Drawing.Point(79, 269)
        Me.BtnStudent.Name = "BtnStudent"
        Me.BtnStudent.Size = New System.Drawing.Size(129, 55)
        Me.BtnStudent.TabIndex = 3
        Me.BtnStudent.Text = "Student"
        Me.BtnStudent.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Azure
        Me.BtnExit.Location = New System.Drawing.Point(274, 113)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(129, 55)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(477, 422)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnStudent)
        Me.Controls.Add(Me.BtnInstructor)
        Me.Controls.Add(Me.BtnCourse)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCourse As Button
    Friend WithEvents BtnInstructor As Button
    Friend WithEvents BtnStudent As Button
    Friend WithEvents BtnExit As Button
End Class
