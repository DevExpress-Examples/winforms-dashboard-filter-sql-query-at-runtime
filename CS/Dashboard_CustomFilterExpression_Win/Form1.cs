using DevExpress.DataAccess;
using DevExpress.Data.Filtering;

namespace Dashboard_CustomFilterExpression_Win {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();

            dashboardViewer1.LoadDashboard(@"..\..\Data\Dashboard.xml");
        }

        private void dashboardViewer1_CustomFilterExpression(object sender, CustomFilterExpressionEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1" && e.TableName == "Invoices") {
                e.FilterExpression = new BinaryOperator("CustomerID","AROUT",BinaryOperatorType.Equal);
            }
        }
    }
}
