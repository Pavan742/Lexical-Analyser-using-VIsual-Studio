using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace LexicalAnalyzer
{
    public partial class frmLexicalAnalyzer : Form
    {              
        public frmLexicalAnalyzer() 
        {            
            InitializeComponent();              
        }

        int count = 0;

        public void displayOutput() // for display output in DataGridView
        {
            try
            {
                AnalyzerBackWork.fileN = txtPath.Text; // reading file and store to array                
                AnalyzerBackWork.myMain();

                for (int i = 0; i < AnalyzerBackWork.librariesCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - 1].Cells["Libraries"].Value = AnalyzerBackWork.libraries[i].ToString();
                    count++;
                }

                for (int i = 0; i < AnalyzerBackWork.keywordsCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - count - 1].Cells["ReserveWords"].Value = AnalyzerBackWork.keywordsArray[i].ToString();                    
                }

                for (int i = 0; i < AnalyzerBackWork.operatorCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - count - AnalyzerBackWork.keywordsCount - 1].Cells["Operators"].Value = AnalyzerBackWork.operators[i].ToString();                    
                }

                for (int i = 0; i < AnalyzerBackWork.varCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - count - AnalyzerBackWork.operatorCount - AnalyzerBackWork.keywordsCount - 1].Cells["VariableNames"].Value = AnalyzerBackWork.originalVariables[i];
                }               
            }
            catch (Exception)
            {}
        }        

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.EndsWith(".cpp".ToUpper()))
                {
                    txtPath.Text = openFileDialog1.FileName;
                    rTextSource.Text = AnalyzerBackWork.readFullFile(txtPath.Text);                    
                }
                else
                {
                    MessageBox.Show("Must Open a .cpp file");
                }
            }
            else
            {
                return;
            }
        }        

        private void frmLexicalAnalyzer_Load(object sender, EventArgs e)
        {
            this.Size = new Size(532, 455);             
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int width = 1013;
            while (width >= 532)
            {
                this.Size = new Size(width, 455);
                this.Refresh();
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                Thread.Sleep(10);
                width -= 10;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // for spreading form           
            int width = 532;
            while (width <= 1013)
            {
                this.Size = new Size(width, 455);
                this.Refresh();
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                Thread.Sleep(10);
                width += 10;
            }

            displayOutput();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
