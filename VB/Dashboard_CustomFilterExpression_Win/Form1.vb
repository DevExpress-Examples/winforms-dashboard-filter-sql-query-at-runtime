Imports DevExpress.DataAccess
Imports DevExpress.Data.Filtering

Namespace Dashboard_CustomFilterExpression_Win
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()

            dashboardViewer1.LoadDashboard("..\..\Data\Dashboard.xml")
        End Sub

        Private Sub dashboardViewer1_CustomFilterExpression(ByVal sender As Object,
                                                            ByVal e As CustomFilterExpressionEventArgs) _
                                                        Handles dashboardViewer1.CustomFilterExpression
            If e.DataSourceName = "SQL Data Source 1" AndAlso e.TableName = "Invoices" Then
                e.FilterExpression = New BinaryOperator("CustomerID", "AROUT", BinaryOperatorType.Equal)
            End If
        End Sub
    End Class
End Namespace
