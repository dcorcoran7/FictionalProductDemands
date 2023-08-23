Public Class frmUserProductDemand

    Dim productList As List(Of String)
    Dim yearsList As List(Of Integer)
    Dim demandList As SortedList(Of String, Integer)
    Dim demandValues(2, 3) As Integer

    Private Function GetDemand() As Integer(,)
        Return {{2065, 2230, 2415, 2340},
                   {1630, 1744, 1522, 1434},
                   {4840, 4264, 3096, 4506}}
    End Function

    Private Function GetProductNames()
        Dim validProductNames As New List(Of String)
        validProductNames.Add("ProductA")
        validProductNames.Add("ProductB")
        validProductNames.Add("ProductC")
        Return validProductNames
    End Function

    Private Function GetYearValues()
        Dim validYears As New List(Of Integer)
        validYears.Add(2017)
        validYears.Add(2018)
        validYears.Add(2019)
        validYears.Add(2020)
        Return validYears
    End Function

    Private Function GetDemandTable()
        Dim demandTable As New SortedList(Of String, Integer)
        For i As Integer = 0 To productList.Count - 1
            For j As Integer = 0 To yearsList.Count - 1
                demandTable.Add(productList(i) & yearsList(j).ToString, GetDemand(i, j))
            Next
        Next

        Return demandTable
    End Function

    Private Sub frmUserProductDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        demandValues = GetDemand()
        productList = GetProductNames()
        yearsList = GetYearValues()
        demandList = GetDemandTable()

    End Sub

    Private Sub btnShowDemand_Click(sender As Object, e As EventArgs) Handles btnShowDemand.Click

        If CheckProductName() AndAlso CheckYear() Then
            MessageBox.Show("Demand for " & txtProduct.Text & " in year " & txtYear.Text & " is " & demandList(txtProduct.Text & txtYear.Text), "Demand")
        End If

    End Sub

    Private Function CheckProductName()
        Dim productCounter As Integer
        For i As Integer = 0 To productList.Count - 1
            If txtProduct.Text = productList(i) Then
                productCounter += 1
            End If
        Next

        Try
            If txtProduct.Text = "" Then
                Throw New Exception("Product field is blank.")
            ElseIf productCounter = 0 Then
                Throw New Exception("Product does not exist.")
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Input Error")
            txtProduct.Focus()
            Return False
        End Try
    End Function

    Private Function CheckYear()
        Dim yearCounter As Integer
        For i As Integer = 0 To yearsList.Count - 1
            If txtYear.Text = yearsList(i).ToString Then
                yearCounter += 1
            End If
        Next

        Try
            If txtYear.Text = "" Then
                Throw New Exception("Year field is blank.")
            ElseIf yearCounter = 0 Then
                Throw New Exception("Year does not exist.")
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Input Error")
            txtYear.Focus()
            Return False
        End Try
    End Function

    Private Sub btnShowAllDemand_Click(sender As Object, e As EventArgs) Handles btnShowAllDemand.Click
        Dim demandTableString As String = ""
        For i As Integer = 0 To yearsList.Count - 1
            demandTableString += vbTab & yearsList(i).ToString
        Next

        demandTableString += vbCrLf

        For i As Integer = 0 To productList.Count - 1
            demandTableString += productList(i) & vbTab
            For j As Integer = 0 To yearsList.Count - 1
                demandTableString += demandValues(i, j).ToString & vbTab
            Next
            demandTableString += vbCrLf
        Next

        MessageBox.Show(demandTableString, "All Demand")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
