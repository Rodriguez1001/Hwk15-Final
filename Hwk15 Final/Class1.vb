Public Class Person
    'Parent
    Public m_FirstName As String
    Public m_LastName As String
    Public m_EM As String
    Function FN() As String
        Return m_FirstName
    End Function
    Function LN() As String
        Return m_LastName
    End Function
    Function EM() As String
        Return m_EM
    End Function
End Class
