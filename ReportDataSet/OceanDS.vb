

Partial Public Class OceanDS


    Partial Public Class BonOrderHeaderDTDataTable




    End Class

    Partial Public Class PIDetailDTDataTable
        Private Sub PIDetailDTDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.WidthMinColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class PIPrintOutDTDataTable
        Private Sub PIPrintOutDTDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AmountColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class



