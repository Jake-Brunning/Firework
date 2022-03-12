Imports Microsoft.VisualBasic.PowerPacks
Public Class Form1
    Dim startLength As Integer = 100
    Dim Fireworks As New List(Of Firework)
    Private Sub Fire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fire.Click
        Fireworks.Add(New Firework(startLength, ColorPicker.SelectedIndex)) 'Adding a firework to the program
        Fireworks.Last.makeLines(Fireworks.Last)
    End Sub
    Private Sub Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Info.Click 'User info
        MsgBox(Title:="Help", Prompt:="Press the color you want on the color list (by FIRE ROCKET) to select color." + vbNewLine + "Press fire rocket to fire a new rocket!")
    End Sub
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        For i As Integer = 0 To (Fireworks.Count - 1) Step 1
            Fireworks(i).clearForm(Fireworks(i))
        Next
        Fireworks.Clear()
    End Sub
End Class

Class Firework 'each firework is an object of this class
    Public xCordinate As Integer 'x cordinate of where firework starts
    Public yCordinate As Integer 'Y cordinate of where firework starts
    Public colour As New Color 'Pen of firework
    Public Lines As New List(Of LineShape) 'lines array
    Public LineLength As Integer
    Public Sub New(ByVal startLength As String, ByVal SelectedColor As Integer) 'constructor for data about the rocket
        LineLength = startLength
        Select Case SelectedColor
            Case 0
                colour = Color.Red
            Case 1
                colour = Color.Purple
            Case 2
                colour = Color.Blue
            Case 3
                colour = Color.Green
            Case 4
                colour = Color.Yellow
            Case 5
                colour = Color.Orange
            Case 6
                colour = Color.White
            Case Else
                colour = Color.Blue
        End Select
        Randomize()
        xCordinate = Int(Form1.Width * Rnd())
        Randomize()
        yCordinate = Int(Form1.Height * Rnd())
    End Sub
    Public Sub makeLines(ByRef firework As Firework)
        Dim shapeCon As New ShapeContainer
        shapeCon.Parent = Form1
        Dim mygraphics As Graphics = Form1.CreateGraphics
        For i As Integer = 1 To 20
            firework.Lines.Add(New LineShape)
        Next
        For Each Line As LineShape In firework.Lines
            Line.BorderColor = firework.colour
            Line.Parent = shapeCon
            Line.StartPoint = New System.Drawing.Point(firework.xCordinate, firework.yCordinate)
            Dim temp As Point = generateEndpoint(firework)
            Line.EndPoint = New System.Drawing.Point(temp)
        Next
    End Sub
    Private Function generateEndpoint(ByRef firework As Firework)
        Randomize()
        Dim x As Decimal = Int((2 * firework.LineLength) * Rnd()) + (firework.xCordinate - firework.LineLength)
        Dim y As Decimal = Int((2 * firework.LineLength) * Rnd()) + (firework.yCordinate - firework.LineLength)
        Return New System.Drawing.Point(x, y)
    End Function
    Public Sub clearForm(ByRef firework As Firework)
        For Each line As LineShape In firework.Lines
            line.Dispose()
        Next
    End Sub
End Class