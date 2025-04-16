using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab_10_Form
{
    public partial class Form1 : Form
    {
        private int[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            int rows, cols;

            if (!int.TryParse(txtRows.Text, out rows) || rows <= 0 || rows > 10 ||
                !int.TryParse(txtCols.Text, out cols) || cols <= 0 || cols > 10)
            {
                MessageBox.Show("Введіть коректні розміри (1-10).");
                return;
            }

            matrix = new int[rows, cols];
            Random rand = new Random();
            dgvMatrix.ColumnCount = cols;
            dgvMatrix.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dgvMatrix.Rows[i].HeaderCell.Value = i + 1;
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                    dgvMatrix[j, i].Value = matrix[i, j];
                }
            }
            AnalyzeMatrix(rows, cols);
        }

        private void AnalyzeMatrix(int rows, int cols)
        {
            int totalNegatives = 0;
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                bool hasZero = false;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }

                if (hasZero)
                {
                    int negativeCount = 0;
                    for (int j = 0; j < cols; j++)
                        if (matrix[i, j] < 0) negativeCount++;

                    totalNegatives += negativeCount;
                    result += $"Рядок {i + 1}: {negativeCount} від’ємних \n";
                }
            }

            result += $"Всього {totalNegatives} від'ємних елементів";
            lblOutput.Text = result;

            dgvSaddlePoints.Rows.Clear();
            dgvSaddlePoints.Columns.Clear();
            dgvSaddlePoints.Columns.Add("Row", "Рядок");
            dgvSaddlePoints.Columns.Add("Col", "Стовпець");
            dgvSaddlePoints.Columns.Add("Value", "Значення");

            for (int i = 0; i < rows; i++)
            {
                int minInRow = matrix[i, 0];
                int minColIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < minInRow)
                    {
                        minInRow = matrix[i, j];
                        minColIndex = j;
                    }
                }

                bool isSaddlePoint = true;
                for (int k = 0; k < rows; k++)
                {
                    if (matrix[k, minColIndex] > minInRow)
                    {
                        isSaddlePoint = false;
                        break;
                    }
                }

                if (isSaddlePoint)
                {
                    dgvSaddlePoints.Rows.Add(i + 1, minColIndex + 1, minInRow);
                }
            }
        }
    }
}