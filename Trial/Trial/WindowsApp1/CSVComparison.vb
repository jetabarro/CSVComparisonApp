Imports System.IO
Imports System.Text


Public Class CSVComparison

    Public DataTableFile1 As DataTable
    Public DataTableFile2 As DataTable
    Public DataTable1Diff As DataTable
    Public DataTable2Diff As DataTable

    Private Sub OpenFile1_Click(sender As Object, e As EventArgs) Handles OpenFile1.Click
        File1.Filter = "CSV files (*.csv)|*.CSV"
        File1.FilterIndex = 2
        File1.RestoreDirectory = True
        Dim result As DialogResult = File1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = File1.FileName
            Try
                ' For debugging.
                Path1.Text = path

                DataTableFile1 = Me.ConvertCSVToDataTable(path)

                DataFile1.DataSource = DataTableFile1

            Catch ex As Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub

    Private Sub OpenFile2_Click(sender As Object, e As EventArgs) Handles OpenFile2.Click
        File2.Filter = "CSV files (*.csv)|*.CSV"
        File2.FilterIndex = 2
        File2.RestoreDirectory = True
        Dim result As DialogResult = File2.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = File2.FileName
            Try
                ' For debugging.
                Path2.Text = path

                DataTableFile2 = Me.ConvertCSVToDataTable(path)

                DataFile2.DataSource = DataTableFile2

            Catch ex As Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub

    Private Function ConvertCSVToDataTable(ByVal path As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Dim dt2 As DataTable = New DataTable()
        Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection()
            Try
                con.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties=""Text;HDR=NO;FMT=Delimited""", "Microsoft.Jet.OLEDB.4.0", IO.Path.GetDirectoryName(path))
                Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM " & IO.Path.GetFileName(path), con)
                    Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dt)
                        con.Close()
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            Finally
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End Using
        dt2 = dt.AsEnumerable().Skip(7).CopyToDataTable()
        Return dt2
    End Function

    Private Sub Compare_Click(sender As Object, e As EventArgs) Handles Compare.Click

        DataTable2Diff = DataTableFile2.Copy()
        DataTable1Diff = DataTableFile1.Copy()

        If DataTableFile1 IsNot Nothing And DataTableFile2 IsNot Nothing Then
            Me.Text = "Comparing"
            For rw1 As Integer = (DataTableFile1.Rows.Count - 1) To 0 Step -1

                For rw2 As Integer = (DataTableFile2.Rows.Count - 1) To 0 Step -1
                    If DataTableFile1.Rows(rw1).ItemArray.Length > 0 And DataTableFile2.Rows(rw2).ItemArray.Length > 0 Then
                        Dim array1 As Object() = DataTableFile1.Rows(rw1).ItemArray
                        Dim array2 As Object() = DataTableFile2.Rows(rw2).ItemArray

                        If array1.SequenceEqual(array2) Then
                            DataTable1Diff.Rows.Remove(DataTable1Diff.Rows(rw1))
                            DataTable2Diff.Rows.Remove(DataTable2Diff.Rows(rw2))
                        End If
                    End If
                Next

            Next
            DataFile2.DataSource = DataTable1Diff
            DataFile1.DataSource = DataTable2Diff
            Me.Text = "Done Comparing"
        End If

    End Sub
End Class
