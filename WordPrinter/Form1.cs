﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace WordPrinter
{
    public partial class Form1 : Form
    {
        private List<string> _fileNames = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "Word Documents|*.doc;*.docx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _fileNames = dialog.FileNames.ToList();
                lbFiles.Items.Clear();
                foreach (string fileName in _fileNames)
                {
                    lbFiles.Items.Add(fileName);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_fileNames.Count == 0)
            {
                MessageBox.Show("Please select at leastone file to print.");
                return;
            }

            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Initialize progress bar
                progressBar.Maximum = _fileNames.Count;
                progressBar.Value = 0;
                foreach (string fileName in _fileNames)
                {
                    try
                    {
                        Application wordApp = new Application();
                        Document wordDoc = wordApp.Documents.Open(fileName);

                        // Set printer and page range
                        wordDoc.PrintOut(
                            Background: false,
                            Range: WdPrintOutRange.wdPrintAllDocument,
                            OutputFileName: "",
                            Item: WdPrintOutItem.wdPrintDocumentContent,
                            PrintToFile: false,
                            Collate: true,
                            ActivePrinterMacGX: printDialog.PrinterSettings.PrinterName,
                            Pages: $"{printDialog.PrinterSettings.FromPage}-{printDialog.PrinterSettings.ToPage}",
                            PageType: WdPrintOutPages.wdPrintAllPages,
                            PrintZoomColumn: 1,
                            PrintZoomRow: 1,
                            PrintZoomPaperWidth: 0,
                            PrintZoomPaperHeight: 0
                            );

                        // Close the document and Word application
                        wordDoc.Close();
                        wordApp.Quit();

                        // Increment progress bar
                        progressBar.Value++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while printing {fileName}: {ex.Message}");
                    }
                }

                MessageBox.Show("Printing complete.");
            }
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (lbFiles.SelectedItems.Count > 0)
        //    {
        //        DialogResult result = MessageBox.Show("Are you sure you want to delete the selected files?", "Confirm Deletion", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            foreach (string fileName in lbFiles.SelectedItems)
        //            {
        //                try
        //                {
        //                    File.Delete(fileName);
        //                    lbFiles.Items.Remove(fileName);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show($"Error deleting file {fileName}: {ex.Message}");
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select at least one file to delete.");
        //    }
        //}

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
        }
    }
}