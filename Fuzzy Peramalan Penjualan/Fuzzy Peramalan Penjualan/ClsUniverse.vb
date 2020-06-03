Public Class ClsUniverse
    Public id As Integer
    Public xMax As Int32
    Public xMin As Int32
    Public FuzzyName As String
    Sub New(ByVal _id As Integer, _
            ByVal _xMax As Int32 _
            , ByVal _xMin As Int32)
        id = _id
        xMax = _xMax
        xMin = _xMin
        FuzzyName = "A" & (_id + 1)

    End Sub
    Sub printData()
        Debug.WriteLine("U" & id & " : " & "[" & xMin & "," & xMax & "]")
    End Sub
End Class
