// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LijsDev.CrystalReportsRunner.Core;
using PayrollReportConsole;

using var engine = new CrystalReportsEngine();
engine.ViewerSettings.AllowedExportFormats = ReportViewerExportFormats.PdfFormat | ReportViewerExportFormats.ExcelFormat;
engine.ViewerSettings.SetUICulture(Thread.CurrentThread.CurrentUICulture);

var cobaDataSet = new Coba();
var cobaTable = cobaDataSet.Tables["Coba"];

for(int x = 0; x <= 10; x++) {
   var r = cobaTable!.NewRow();
   r["NIK"] = $"000{x}";
   r["Nama"] = $"Nama{x}";
   r["GrupKerja"] = "Grup Kerja";
   cobaTable.Rows.Add(r);
}

var report = new Report("Coba.rpt", "Percobaan") {
   DataSets = new List<System.Data.DataSet> { cobaDataSet }
};
await engine.ShowReport(report);
Console.ReadKey();
