Public Class FrmBillOfMaterial
#Region "Declaration"
    Public conditionBOM As String
    Public Shared bomHeaderID As Long = 0
    Dim intBaris As Integer
    Dim intPost As Integer
    Dim buyerCode As String = ""
    Dim statusBOM As Int16
#End Region

#Region "ComboBox"
    Sub ComboBoxBuyer()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim status As String = "C"
        Try
            vendorBFC.ComboBoxVendor(cmbBuyer, status)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub ComboBoxFabric()
        Dim fabricBFC As ClsFabric = New ClsFabric
        Try
            fabricBFC.ComboBoxFabric(cmbFabric)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub ComboBoxStyle()
        Dim styleBFC As ClsStyle = New ClsStyle
        Try
            styleBFC.ComboBoxStyle(cmbStyle)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub ComboBoxColor()
        Dim colorBFC As ClsColor = New ClsColor
        Try
            colorBFC.ComboBoxColor(cmbColor)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub ComboBoxRawMaterial()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Try
            rawBFC.ComboBoxRawMaterial(cmbRaw)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub ComboBoxUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        Try
            unitBFC.ComboBoxUnit(cmbUnit)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Grid Detail"

#End Region

#Region "Clear Data"

#End Region

#Region "Validation Number"

#End Region

#Region "Add Grid Detail"

#End Region

#Region "Delete Grid"

#End Region

#Region "Check Empty"

#End Region

#Region "Check Available In List"

#End Region

#Region "Set Data"

#End Region

#Region "Function"

#End Region

#Region "Button"

#End Region

#Region "KeyPress"

#End Region

#Region "Row State Change"

#End Region
End Class