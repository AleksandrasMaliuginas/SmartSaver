﻿using System;
using System.IO;
using System.Windows.Forms;
using SmartSaver.Data;

namespace SmartSaver.Controllers
{
    internal class FileWriter
    {
        public void Export()
        {
            var saveFileDialog = new SaveFileDialog();
            var filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog.Filter = filter;
            const string header = "\"Id\",\"Date\",\"Counter Party\",\"Details\",\"Amount\",";

            var db = new Database();
            var transactions = db.GetTransactions();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var writer = new StreamWriter(saveFileDialog.FileName);

                writer.WriteLine(header);
                foreach (var transaction in transactions)
                {
                    var d = (DateTime)transaction.TrTime;
                    writer.WriteLine("\"" + transaction.Id + "\",\"" + d.ToString("yyyy-MM-dd") + "\",\"" +
                                     transaction.CounterParty + "\",\"" +
                                     transaction.Details + "\",\"" + transaction.Amount + "\",");
                }

                writer.Close();
            }
        }
    }
}