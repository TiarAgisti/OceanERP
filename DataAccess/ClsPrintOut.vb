Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class ClsPrintOut

#Region "Proforma Invoice"
    Protected Sub GetProformaInvoiceHeader(ByVal piNo As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIHeader where PINo = @piNo"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("PINo", piNo)
                myCommand.Parameters.Add(parameter)
                Dim purchaseOrderAdapter As New SqlDataAdapter(myCommand)
                purchaseOrderAdapter.Fill(dsProformaInvoice, "v_PIHeader")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetPIBankDetails(ByVal piNo As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIBankDetail where PINo = @piNo"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("PINo", piNo)
                myCommand.Parameters.Add(parameter)
                Dim purchaseOrderAdapter As New SqlDataAdapter(myCommand)
                purchaseOrderAdapter.Fill(dsProformaInvoice, "v_PIBankDetail")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetPIRemarksByPINo(ByVal piNo As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIRemarks where PINo = @piNo"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("PINo", piNo)
                myCommand.Parameters.Add(parameter)
                Dim purchaseOrderAdapter As New SqlDataAdapter(myCommand)
                purchaseOrderAdapter.Fill(dsProformaInvoice, "v_PIRemarks")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PrintOutProformaInvoice(ByVal piNo As String) As Boolean
        Dim status As Boolean
        Dim frm As New FrmPrintPreview
        frm.rptView.ProcessingMode = ProcessingMode.Local
        Dim localReport As LocalReport
        localReport = frm.rptView.LocalReport
        localReport.ReportPath = My.Settings.reportPath + "ProformaInvoice\rptProformaInvoice.rdlc"

        Try
            Dim dataset As New DataSet("Proforma Invoice")
            GetProformaInvoiceHeader(piNo, dataset)
            Dim dsProformaInvoiceHeader As New ReportDataSource
            With dsProformaInvoiceHeader
                .Name = "piHeaderDT"
                .Value = dataset.Tables("v_PIHeader")
            End With

            Dim dsPIRemarks As New DataSet("PI Remarks")
            GetPIRemarksByPINo(piNo, dsPIRemarks)
            Dim dsProformaInvoiceRemarks As New ReportDataSource
            With dsProformaInvoiceRemarks
                .Name = "piRemarksDT"
                .Value = dsPIRemarks.Tables("v_PIRemarks")
            End With

            Dim dsPIBank As New DataSet("PI Bank")
            GetPIBankDetails(piNo, dsPIBank)
            Dim dsProformaInvoiceBank As New ReportDataSource
            With dsProformaInvoiceBank
                .Name = "piBankDT"
                .Value = dsPIBank.Tables("v_PIBankDetail")
            End With


            With localReport.DataSources
                .Add(dsProformaInvoiceHeader)
                .Add(dsProformaInvoiceRemarks)
                .Add(dsProformaInvoiceBank)
            End With

            frm.ShowDialog()
            frm.rptView.RefreshReport()
            status = True
        Catch ex As Exception
            status = False
            Throw ex
        End Try
        Return status
    End Function
#End Region

End Class
