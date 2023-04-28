Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Module DatagridModule
    Public Sub exportToExcel(mydg As DataGridView, directory As String, type As String)
        Try
            Dim exlFile = New Excel.Application
            Dim columnIndex As Integer = 0
            Dim rowIndex As Integer = 0
            Dim exlBook = exlFile.Workbooks.Open(directory)

            With exlFile
                .Cells(2, 1) = "As of " & FormatDateTime(Now(), DateFormat.LongDate)
                For Each column As DataGridViewColumn In mydg.Columns
                    columnIndex += 1
                    rowIndex = 4
                    For Each row As DataGridViewRow In mydg.Rows
                        rowIndex += 1
                        .Cells(rowIndex, columnIndex) = row.Cells(column.Name).Value
                    Next
                Next

            End With

            Dim saveFileDiaglog As New SaveFileDialog()
            saveFileDiaglog.InitialDirectory = "D:\Programming\VB.NET\School Stuff\EDP\week3\Shop\Shop\export"
            saveFileDiaglog.Filter = "Excel Files(*.xlsx)|*.xlsx"
            saveFileDiaglog.FileName = type & " " & DateTime.Today.ToString("MM-dd-yyyy")

            If saveFileDiaglog.ShowDialog() = DialogResult.OK Then
                exlBook.SaveAs(saveFileDiaglog.FileName)
                MsgBox("Data Exported Successfully!")
            Else
                exlBook.Close()
            End If

            releaseObject(exlFile)
            exlBook.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Function convertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If

        Return result

    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
