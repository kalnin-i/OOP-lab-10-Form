namespace OOP_lab_10_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRowsQuantity = new System.Windows.Forms.Label();
            this.lblColsQuantity = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.lblSaddlePoints = new System.Windows.Forms.Label();
            this.dgvSaddlePoints = new System.Windows.Forms.DataGridView();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaddlePoints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRowsQuantity
            // 
            this.lblRowsQuantity.AutoSize = true;
            this.lblRowsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRowsQuantity.Location = new System.Drawing.Point(13, 13);
            this.lblRowsQuantity.Name = "lblRowsQuantity";
            this.lblRowsQuantity.Size = new System.Drawing.Size(289, 16);
            this.lblRowsQuantity.TabIndex = 0;
            this.lblRowsQuantity.Text = "Введіть кількість рядків (не більше 10)";
            // 
            // lblColsQuantity
            // 
            this.lblColsQuantity.AutoSize = true;
            this.lblColsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColsQuantity.Location = new System.Drawing.Point(391, 13);
            this.lblColsQuantity.Name = "lblColsQuantity";
            this.lblColsQuantity.Size = new System.Drawing.Size(307, 16);
            this.lblColsQuantity.TabIndex = 1;
            this.lblColsQuantity.Text = "Введіть кількість стовпців (не більше 10)";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(16, 33);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 22);
            this.txtRows.TabIndex = 2;
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(394, 33);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(100, 22);
            this.txtCols.TabIndex = 3;
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.AllowUserToResizeColumns = false;
            this.dgvMatrix.AllowUserToResizeRows = false;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.ColumnHeadersVisible = false;
            this.dgvMatrix.Location = new System.Drawing.Point(16, 62);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.ReadOnly = true;
            this.dgvMatrix.RowHeadersVisible = false;
            this.dgvMatrix.RowHeadersWidth = 51;
            this.dgvMatrix.RowTemplate.Height = 24;
            this.dgvMatrix.Size = new System.Drawing.Size(954, 467);
            this.dgvMatrix.TabIndex = 4;
            // 
            // lblSaddlePoints
            // 
            this.lblSaddlePoints.AutoSize = true;
            this.lblSaddlePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSaddlePoints.Location = new System.Drawing.Point(16, 536);
            this.lblSaddlePoints.Name = "lblSaddlePoints";
            this.lblSaddlePoints.Size = new System.Drawing.Size(84, 16);
            this.lblSaddlePoints.TabIndex = 5;
            this.lblSaddlePoints.Text = "Сідловини";
            // 
            // dgvSaddlePoints
            // 
            this.dgvSaddlePoints.AllowUserToResizeColumns = false;
            this.dgvSaddlePoints.ColumnHeadersHeight = 29;
            this.dgvSaddlePoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSaddlePoints.Location = new System.Drawing.Point(16, 556);
            this.dgvSaddlePoints.Name = "dgvSaddlePoints";
            this.dgvSaddlePoints.ReadOnly = true;
            this.dgvSaddlePoints.RowHeadersWidth = 51;
            this.dgvSaddlePoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSaddlePoints.RowTemplate.Height = 24;
            this.dgvSaddlePoints.Size = new System.Drawing.Size(478, 85);
            this.dgvSaddlePoints.TabIndex = 6;
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateMatrix.Location = new System.Drawing.Point(807, 14);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(163, 42);
            this.btnGenerateMatrix.TabIndex = 7;
            this.btnGenerateMatrix.Text = "Згенерувати матрицю";
            this.btnGenerateMatrix.UseVisualStyleBackColor = true;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(498, 537);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(224, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Загалом від\'ємних елементів";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(501, 557);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 16);
            this.lblOutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGenerateMatrix);
            this.Controls.Add(this.dgvSaddlePoints);
            this.Controls.Add(this.lblSaddlePoints);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblColsQuantity);
            this.Controls.Add(this.lblRowsQuantity);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaddlePoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRowsQuantity;
        private System.Windows.Forms.Label lblColsQuantity;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Label lblSaddlePoints;
        private System.Windows.Forms.DataGridView dgvSaddlePoints;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOutput;
    }
}

