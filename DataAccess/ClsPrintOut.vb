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
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_PIHeader")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetProformaInvoicePrintOut(ByVal piNo As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIPrintOut where PINo = @piNo"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("PINo", piNo)
                myCommand.Parameters.Add(parameter)
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_PIPrintOut")
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
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_PIBankDetail")
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
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_PIRemarks")
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
        Dim path As String = My.Settings.reportPath
        localReport = frm.rptView.LocalReport
        localReport.ReportPath = path + "ProformaInvoice\rptProformaInvoice.rdlc"

        Try
            Dim dataset As New DataSet("Proforma Invoice")
            GetProformaInvoiceHeader(piNo, dataset)
            Dim dsProformaInvoiceHeader As New ReportDataSource
            With dsProformaInvoiceHeader
                .Name = "piHeaderDT"
                .Value = dataset.Tables("v_PIHeader")
            End With

            Dim dsPIPrintOut As New DataSet("PI PrintOut")
            GetProformaInvoicePrintOut(piNo, dsPIPrintOut)
            Dim dsProformaInvoicePrintOut As New ReportDataSource
            With dsProformaInvoicePrintOut
                .Name = "piPrintOutDT"
                .Value = dsPIPrintOut.Tables("v_PIPrintOut")
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
                .Add(dsProformaInvoicePrintOut)
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

#Region "Proforma Invoice2"

    Protected Sub GetProformaInvoiceHeader2(ByVal noOrder As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoiceHeader where NoOrder = @noOrder"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("NoOrder", noOrder)
                myCommand.Parameters.Add(parameter)
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_ProInvoiceHeader")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetProformaInvoicePrintOut2(ByVal noOrder As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoicePrintOut where NoOrder = @noOrder"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("NoOrder", noOrder)
                myCommand.Parameters.Add(parameter)
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_ProInvoicePrintOut")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetPIBankDetails2(ByVal noOrder As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoiceBankDetail where NoOrder = @noOrder"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("NoOrder", noOrder)
                myCommand.Parameters.Add(parameter)
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_ProInvoiceBankDetail")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetPIRemarksByPINo2(ByVal noOrder As String, ByRef dsProformaInvoice As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoiceRemarkDetail where NoOrder = @noOrder"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("NoOrder", noOrder)
                myCommand.Parameters.Add(parameter)
                Dim proformaInvoiceAdapter As New SqlDataAdapter(myCommand)
                proformaInvoiceAdapter.Fill(dsProformaInvoice, "v_ProInvoiceRemarkDetail")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PrintOutProformaInvoice2(ByVal noOrder As String) As Boolean
        Dim status As Boolean
        Dim frm As New FrmPrintPreview
        frm.rptView.ProcessingMode = ProcessingMode.Local
        Dim localReport As LocalReport
        Dim path As String = My.Settings.reportPath
        localReport = frm.rptView.LocalReport
        localReport.ReportPath = path + "ProformaInvoice\PrintOutPI.rdlc"

        Try
            Dim dataset As New DataSet("Proforma Invoice")
            GetProformaInvoiceHeader2(noOrder, dataset)
            Dim dsProformaInvoiceHeader As New ReportDataSource
            With dsProformaInvoiceHeader
                .Name = "DataSet2"
                .Value = dataset.Tables("v_ProInvoiceHeader")
            End With

            Dim dsPIPrintOut As New DataSet("PI PrintOut")
            GetProformaInvoicePrintOut2(noOrder, dsPIPrintOut)
            Dim dsProformaInvoicePrintOut As New ReportDataSource
            With dsProformaInvoicePrintOut
                .Name = "DataSet1"
                .Value = dsPIPrintOut.Tables("v_ProInvoicePrintOut")
            End With

            Dim dsPIRemarks As New DataSet("PI Remarks")
            GetPIRemarksByPINo2(noOrder, dsPIRemarks)
            Dim dsProformaInvoiceRemarks As New ReportDataSource
            With dsProformaInvoiceRemarks
                .Name = "DataSet3"
                .Value = dsPIRemarks.Tables("v_ProInvoiceRemarkDetail")
            End With

            Dim dsPIBank As New DataSet("PI Bank")
            GetPIBankDetails2(noOrder, dsPIBank)
            Dim dsProformaInvoiceBank As New ReportDataSource
            With dsProformaInvoiceBank
                .Name = "DataSet4"
                .Value = dsPIBank.Tables("v_ProInvoiceBankDetail")
            End With


            With localReport.DataSources
                .Add(dsProformaInvoiceHeader)
                .Add(dsProformaInvoicePrintOut)
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

#Region "Purchase Order"
    Protected Sub GetPurchaseOrderHeader(ByVal poNo As String, ByRef dsPurchaseOrder As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_POHeader where PONo = @poNo"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("PONo", poNo)
                myCommand.Parameters.Add(parameter)
                Dim purchaseOrderAdapter As New SqlDataAdapter(myCommand)
                purchaseOrderAdapter.Fill(dsPurchaseOrder, "v_POHeader")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetPurchaseOrderPrintOut(ByVal poNo As String, ByRef dsPurchaseOrder As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_POPrintOut where PONo = @poNo"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("PONo", poNo)
                myCommand.Parameters.Add(parameter)
                Dim purchaseOrderAdapter As New SqlDataAdapter(myCommand)
                purchaseOrderAdapter.Fill(dsPurchaseOrder, "v_POPrintOut")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Protected Sub GetPORemarksByPONo(ByVal poNo As String, ByRef dsPurchaseOrder As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PORemarks where PONo = @poNo"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("PONo", poNo)
                myCommand.Parameters.Add(parameter)
                Dim purchaseOrderAdapter As New SqlDataAdapter(myCommand)
                purchaseOrderAdapter.Fill(dsPurchaseOrder, "v_PORemarks")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PrintOutPurchaseOrder(ByVal poNo As String) As Boolean
        Dim status As Boolean
        Dim frm As New FrmPrintPreview
        frm.rptView.ProcessingMode = ProcessingMode.Local
        Dim localReport As LocalReport
        localReport = frm.rptView.LocalReport
        localReport.ReportPath = My.Settings.reportPath + "PurchaseOrder\rptPurchaseOrder.rdlc"

        Try
            Dim dataset As New DataSet("Purchas Order")
            GetPurchaseOrderHeader(poNo, dataset)
            Dim dsPurchaseOrderHeader As New ReportDataSource
            With dsPurchaseOrderHeader
                .Name = "poHeaderDT"
                .Value = dataset.Tables("v_POHeader")
            End With

            Dim dsPOPrintOut As New DataSet("PO PrintOut")
            GetPurchaseOrderPrintOut(poNo, dsPOPrintOut)
            Dim dsPurchaseOrderPrintOut As New ReportDataSource
            With dsPurchaseOrderPrintOut
                .Name = "poPrintOutDT"
                .Value = dsPOPrintOut.Tables("v_POPrintOut")
            End With


            Dim dsPORemarks As New DataSet("PO Remarks")
            GetPORemarksByPONo(poNo, dsPORemarks)
            Dim dsPurchaseOrderRemarks As New ReportDataSource
            With dsPurchaseOrderRemarks
                .Name = "poRemarksDT"
                .Value = dsPORemarks.Tables("v_PORemarks")
            End With



            With localReport.DataSources
                .Add(dsPurchaseOrderHeader)
                .Add(dsPurchaseOrderPrintOut)
                .Add(dsPurchaseOrderRemarks)
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
#Region " BON ORDER PRINT"
    Protected Sub GetBonOrderHeader(ByVal noOrder As String, ByRef dsBonOrder As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BOHeader where NoOrder = @noOrder"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("NoOrder", noOrder)
                myCommand.Parameters.Add(parameter)
                Dim bonOrderAdapter As New SqlDataAdapter(myCommand)
                bonOrderAdapter.Fill(dsBonOrder, "v_BOHeader")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub GetBonOrderPrintOut(ByVal noOrder As String, ByRef dsBonOrder As DataSet)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BOPrintOut where NoOrder = @noOrder"
        Try
            Using myConnection As SqlConnection = dataAccess.SqlConnection
                Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Dim parameter As New SqlParameter("NoOrder", noOrder)
                myCommand.Parameters.Add(parameter)
                Dim bonOrderAdapter As New SqlDataAdapter(myCommand)
                bonOrderAdapter.Fill(dsBonOrder, "v_BOPrintOut")
                myCommand.Dispose()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PrintOutBonOrder(ByVal noOrder As String) As Boolean
        Dim status As Boolean
        Dim frm As New FrmPrintPreview
        frm.rptView.ProcessingMode = ProcessingMode.Local
        Dim localReport As LocalReport
        localReport = frm.rptView.LocalReport
        localReport.ReportPath = My.Settings.reportPath + "BonOrder\PrintOutBonOrder.rdlc"

        Try
            Dim dataset As New DataSet("Bon Order")
            GetBonOrderHeader(noOrder, dataset)
            Dim dsBonOrderHeader As New ReportDataSource
            With dsBonOrderHeader
                .Name = "DataSet2"
                .Value = dataset.Tables("v_BOHeader")
            End With

            Dim dsBonPrintOut As New DataSet("BON PrintOut")
            GetBonOrderPrintOut(noOrder, dsBonPrintOut)
            Dim dsBonOrderPrintOut As New ReportDataSource
            With dsBonOrderPrintOut
                .Name = "DataSet1"
                .Value = dsBonPrintOut.Tables("v_BOPrintOut")
            End With




            With localReport.DataSources
                .Add(dsBonOrderHeader)
                .Add(dsBonOrderPrintOut)

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
