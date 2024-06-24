using Google.OrTools.LinearSolver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoLinearCut
{
    public partial class Form1 : Form
    {
        private class Part
        {
            public string PartName { get; set; }
            public int Quantity { get; set; }
            public int Length { get; set; }
        }

        private class Stock
        {
            public string Serial { get; set; }
            public int Quantity { get; set; }
            public int Length { get; set; }
        }

        private List<Part> parts = new List<Part>();
        private List<Stock> stocks = new List<Stock>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowRstl_Click(object sender, EventArgs e)
        {
            #region Dữ liệu từ grid
            foreach (DataGridViewRow row in dgvParts.Rows)
            {
                if (!row.IsNewRow)
                {
                    string partName = row.Cells["PartName"].Value?.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    int length = Convert.ToInt32(row.Cells["Length"].Value);

                    // Add new Part to the list
                    parts.Add(new Part
                    {
                        PartName = partName,
                        Quantity = quantity,
                        Length = length
                    });
                }
            }

            foreach (DataGridViewRow rowStck in dgvStocks.Rows)
            {
                if (!rowStck.IsNewRow)
                {
                    string serial = rowStck.Cells["Serial"].Value?.ToString();
                    int quantityStock = Convert.ToInt32(rowStck.Cells["QuantityStock"].Value);
                    int lengthStock = Convert.ToInt32(rowStck.Cells["LengthStock"].Value);

                    // Add new Part to the list
                    stocks.Add(new Stock
                    {
                        Serial = serial,
                        Quantity = quantityStock,
                        Length = lengthStock
                    });
                }
            }

            #endregion

            // Tạo solver
            Solver solver = Solver.CreateSolver("GLOP");

            // Các biến quyết định
            var x = new Variable[parts.Count, stocks.Count];
            var y = new Variable[stocks.Count];

            for (int i = 0; i < parts.Count; i++)
            {
                for (int j = 0; j < stocks.Count; j++)
                {
                    x[i, j] = solver.MakeIntVar(0, double.PositiveInfinity, $"x[{i},{j}]");
                }
            }

            for (int j = 0; j < stocks.Count; j++)
            {
                y[j] = solver.MakeIntVar(0, stocks[j].Quantity, $"y[{j}]");
            }

            // Hàm mục tiêu: Minimize waste
            var objective = solver.Objective();
            foreach (var stock in stocks)
            {
                objective.SetCoefficient(y[stocks.IndexOf(stock)], stock.Length);
            }
            objective.SetMinimization();

            // Ràng buộc: Đảm bảo rằng số lượng part cắt đủ nhu cầu
            for (int i = 0; i < parts.Count; i++)
            {
                var partConstraint = solver.MakeConstraint(parts[i].Quantity, double.PositiveInfinity, $"Demand_{i}");
                for (int j = 0; j < stocks.Count; j++)
                {
                    partConstraint.SetCoefficient(x[i, j], 1);
                }
            }

            // Ràng buộc: Không cắt quá chiều dài của thanh nguyên liệu
            for (int j = 0; j < stocks.Count; j++)
            {
                var stockConstraint = solver.MakeConstraint(0, stocks[j].Quantity * stocks[j].Length, $"Stock_{j}");
                for (int i = 0; i < parts.Count; i++)
                {
                    stockConstraint.SetCoefficient(x[i, j], parts[i].Length);
                }
                stockConstraint.SetCoefficient(y[j], -stocks[j].Length);
            }

            // Giải bài toán
            Solver.ResultStatus resultStatus = solver.Solve();

            // In kết quả
            StringBuilder result = new StringBuilder();
            if (resultStatus == Solver.ResultStatus.OPTIMAL)
            {
                result.AppendLine("Solution:");
                for (int i = 0; i < parts.Count; i++)
                {
                    for (int j = 0; j < stocks.Count; j++)
                    {
                        result.AppendLine($"Number of {parts[i].PartName} cut from {stocks[j].Serial}: {x[i, j].SolutionValue()}");
                    }
                }
            }

            txtRslt.Text = result.ToString();
        }

        private void btnImportInput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sau khi thuật toán OK, cho phép import excel làm đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvParts.Columns.Clear();
            dgvParts.Rows.Clear();
            dgvStocks.Columns.Clear();
            dgvStocks.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


