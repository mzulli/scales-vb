' Name:         Songwriting Assistant Project
' Purpose:      Generate scales and chord progressions
' Programmer:   Michelle Zulli on 2015.04.28

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Dim strBase As String = String.Empty
        Dim strAccidental As String = String.Empty
        Dim strKey As String = String.Empty
        Dim strNotes(6) As String
        Dim strChords(1, 5) As String
        Dim intScaleIndex As Integer
        Dim intChordRowIndex As Integer
        Dim intChordColIndex As Integer

        ' clear the form
        lblKey.Text = String.Empty
        txtMajorScale.Text = String.Empty
        txtMajorProgs.Text = String.Empty

        ' assign the selected base note to a variable
        Select Case True
            Case radA.Checked
                strBase = "A"
            Case radB.Checked
                strBase = "B"
            Case radC.Checked
                strBase = "C"
            Case radD.Checked
                strBase = "D"
            Case radE.Checked
                strBase = "E"
            Case radF.Checked
                strBase = "F"
            Case radG.Checked
                strBase = "G"
            Case Else
                MessageBox.Show("Select a base note.",
                                "Songwriter's Assistant",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        End Select

        ' decide if the note is flat or sharp
        Select Case True
            Case radFlat.Checked
                strAccidental = "b"
            Case radSharp.Checked
                strAccidental = "#"
            Case Else
                strAccidental = String.Empty
        End Select

        ' display the selected key and clear the selections
        strKey = strBase & strAccidental
        lblKey.Text = strKey
        radA.Checked = False
        radB.Checked = False
        radC.Checked = False
        radD.Checked = False
        radE.Checked = False
        radF.Checked = False
        radG.Checked = False
        radNatural.Checked = False
        radFlat.Checked = False
        radSharp.Checked = False

        ' populate the array of notes
        If strKey = "A" Then
            strNotes(0) = "A"
            strNotes(1) = "B"
            strNotes(2) = "C#"
            strNotes(3) = "D"
            strNotes(4) = "E"
            strNotes(5) = "F#"
            strNotes(6) = "G#"

        ElseIf strKey = "Ab" Then
            strNotes(0) = "Ab"
            strNotes(1) = "Bb"
            strNotes(2) = "C"
            strNotes(3) = "Db"
            strNotes(4) = "Eb"
            strNotes(5) = "F"
            strNotes(6) = "G"

        ElseIf strKey = "B" Then
            strNotes(0) = "B"
            strNotes(1) = "C#"
            strNotes(2) = "D#"
            strNotes(3) = "E"
            strNotes(4) = "F#"
            strNotes(5) = "G#"
            strNotes(6) = "A#"

        ElseIf strKey = "Bb" Then
            strNotes(0) = "Bb"
            strNotes(1) = "C"
            strNotes(2) = "D"
            strNotes(3) = "Eb"
            strNotes(4) = "F"
            strNotes(5) = "G"
            strNotes(6) = "A"

        ElseIf strKey = "C" Then
            strNotes(0) = "C"
            strNotes(1) = "D"
            strNotes(2) = "E"
            strNotes(3) = "F"
            strNotes(4) = "G"
            strNotes(5) = "A"
            strNotes(6) = "B"

        ElseIf strKey = "Cb" Then
            strNotes(0) = "Cb"
            strNotes(1) = "Db"
            strNotes(2) = "Eb"
            strNotes(3) = "Fb"
            strNotes(4) = "Gb"
            strNotes(5) = "Ab"
            strNotes(6) = "Bb"

        ElseIf strKey = "C#" Then
            strNotes(0) = "C#"
            strNotes(1) = "D#"
            strNotes(2) = "E#"
            strNotes(3) = "F#"
            strNotes(4) = "G#"
            strNotes(5) = "A#"
            strNotes(6) = "B#"

        ElseIf strKey = "D" Then
            strNotes(0) = "D"
            strNotes(1) = "E"
            strNotes(2) = "F#"
            strNotes(3) = "G"
            strNotes(4) = "A"
            strNotes(5) = "B"
            strNotes(6) = "C#"

        ElseIf strKey = "Db" Then
            strNotes(0) = "Db"
            strNotes(1) = "Eb"
            strNotes(2) = "F"
            strNotes(3) = "Gb"
            strNotes(4) = "Ab"
            strNotes(5) = "Bb"
            strNotes(6) = "C"

        ElseIf strKey = "E" Then
            strNotes(0) = "E"
            strNotes(1) = "F#"
            strNotes(2) = "G#"
            strNotes(3) = "A"
            strNotes(4) = "B"
            strNotes(5) = "C#"
            strNotes(6) = "D#"

        ElseIf strKey = "Eb" Then
            strNotes(0) = "Eb"
            strNotes(1) = "F"
            strNotes(2) = "G"
            strNotes(3) = "Ab"
            strNotes(4) = "Bb"
            strNotes(5) = "C"
            strNotes(6) = "D"

        ElseIf strKey = "F" Then
            strNotes(0) = "F"
            strNotes(1) = "G"
            strNotes(2) = "A"
            strNotes(3) = "Bb"
            strNotes(4) = "C"
            strNotes(5) = "D"
            strNotes(6) = "E"

        ElseIf strKey = "Fb" Then
            strNotes(0) = "Fb"
            strNotes(1) = "Gb"
            strNotes(2) = "Ab"
            strNotes(3) = "Bbb"
            strNotes(4) = "Cb"
            strNotes(5) = "Db"
            strNotes(6) = "Eb"

        ElseIf strKey = "F#" Then
            strNotes(0) = "F#"
            strNotes(1) = "G#"
            strNotes(2) = "A#"
            strNotes(3) = "B"
            strNotes(4) = "C#"
            strNotes(5) = "D#"
            strNotes(6) = "E#"

        ElseIf strKey = "G" Then
            strNotes(0) = "G"
            strNotes(1) = "A"
            strNotes(2) = "B"
            strNotes(3) = "C"
            strNotes(4) = "D"
            strNotes(5) = "E"
            strNotes(6) = "F#"

        ElseIf strKey = "Gb" Then
            strNotes(0) = "Gb"
            strNotes(1) = "Ab"
            strNotes(2) = "Bb"
            strNotes(3) = "Cb"
            strNotes(4) = "Db"
            strNotes(5) = "Eb"
            strNotes(6) = "F"

        ElseIf strKey = "G#" Then
            strNotes(0) = "G#"
            strNotes(1) = "A#"
            strNotes(2) = "B#"
            strNotes(3) = "C#"
            strNotes(4) = "D#"
            strNotes(5) = "E#"
            strNotes(6) = "F##"

        Else
            MessageBox.Show("Invalid key. Try again.",
                                "Songwriter's Assistant",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        End If

        ' populate the array of chords
        strChords(0, 0) = "1950s"
        strChords(0, 1) = strNotes(0)
        strChords(0, 2) = strNotes(5) & "-minor"
        strChords(0, 3) = strNotes(4)
        strChords(0, 4) = strNotes(3)

        strChords(1, 0) = "Blues, Pop, Punk"
        strChords(1, 1) = strNotes(0)
        strChords(1, 2) = strNotes(3)
        strChords(1, 3) = strNotes(4)

        ' display the scale
        intScaleIndex = 0
        Do Until intScaleIndex > 6
            txtMajorScale.Text = txtMajorScale.Text.Trim & "   " & strNotes(intScaleIndex)
            intScaleIndex += 1
        Loop

        ' display the chord progressions
        intChordRowIndex = 0
        Do Until intChordRowIndex > 1
            txtMajorProgs.Text = txtMajorProgs.Text & strChords(intChordRowIndex, 0) & ":" &
                ControlChars.NewLine
            intChordColIndex = 1
            Do Until intChordColIndex > 5
                txtMajorProgs.Text = txtMajorProgs.Text & " " &
                    strChords(intChordRowIndex, intChordColIndex)
                intChordColIndex += 1
            Loop
            txtMajorProgs.Text = txtMajorProgs.Text & ControlChars.NewLine & ControlChars.NewLine
            intChordRowIndex += 1
        Loop
    End Sub
End Class