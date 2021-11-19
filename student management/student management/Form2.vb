Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudDataSet.student)

    End Sub
End Class