using AspNetCore.Reporting;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using PayrollAPI.Conversions;
using PayrollAPI.Services;
using SKM.Shared.Dtos;
using System.Data;
using System.Text;

namespace PayrollAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class PayrollController : ControllerBase {
      private readonly IPayrollService payrollService;
      private readonly IWebHostEnvironment webHostEnvironment;

      public PayrollController(IPayrollService payrollService, IWebHostEnvironment webHostEnvironment) {
         this.payrollService = payrollService;
         this.webHostEnvironment = webHostEnvironment;
         System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      }

      [HttpPost]
      public async Task<ActionResult<PayrollDTO>> AddPayroll([FromBody] PayrollDTO payrollDTO) {
         try {
            var payroll = await this.payrollService.AddPayroll(payrollDTO.ConvertToModel());

            return Ok(payroll.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      //[HttpGet("ExportToExcel/{group}/{startDate}/{endDate}")]
      [HttpPost("ExportToExcel")]
      //public async Task<ActionResult<List<PayrollPreviewDTO>>> ExportToExcel(string group, string? startDate, string? endDate) {
      public async Task<ActionResult<List<PayrollPreviewDTO>>> ExportToExcel([FromBody] List<PayrollPreviewDTO> payrollPreviewDTOs) {
         try {

            using (var wb = new XLWorkbook()) {
               var ws = wb.Worksheets.Add("Data Payroll");

               ws.Range("A1:AC1").Row(1).Merge();
               ws.Cell("A1").Style.Font.SetBold(true).Font.FontSize = 14;
               ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("A1").Value = $"Laporan Payrol Periode {payrollPreviewDTOs[0].Periode}";

               ws.Range("A2:A3").Column(1).Merge();
               ws.Range("A2:A3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("A2:A3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("A2:A3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("A2").Value = "Group Kerja";

               ws.Range("B2:B3").Column(1).Merge();
               ws.Range("B2:B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("B2:B3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("B2:B3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("B2").Value = "NIK";

               ws.Range("C2:C3").Column(1).Merge();
               ws.Range("C2:C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("C2:C3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("C2:C3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("C2").Value = "Nama";

               ws.Range("D2:D3").Column(1).Merge();
               ws.Range("D2:D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("D2:D3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("D2:D3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("D2").Value = "No.KTP";

               ws.Range("E2:E3").Column(1).Merge();
               ws.Range("E2:E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("E2:E3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("E2:E3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("E2").Value = "No.BPJSTK";

               ws.Range("F2:F3").Column(1).Merge();
               ws.Range("F2:F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:F3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("F2:F3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("F2:F3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("F2").Value = "No.BPJSKS";

               ws.Range("G2:G3").Column(1).Merge();
               ws.Range("G2:G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("G2:G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("G2:G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("G2:G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("G2:G3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("G2:G3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("G2:G3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("G2").Value = "Alamat";

               ws.Range("H2:H3").Column(1).Merge();
               ws.Range("H2:H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("H2:H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("H2:H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("H2:H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("H2:H3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("H2:H3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("H2:H3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("H2").Value = "Gender";

               ws.Range("I2:I3").Column(1).Merge();
               ws.Range("I2:I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("I2:I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("I2:I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("I2:I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("I2:I3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("I2:I3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("I2:I3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("I2").Value = "No.Rek";

               ws.Range("J2:J3").Column(1).Merge();
               ws.Range("J2:J3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("J2:J3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("J2:J3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("J2:J3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("J2:J3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("J2:J3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("J2:J3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("J2").Value = "Jml Hadir";

               ws.Range("K2:K3").Column(1).Merge();
               ws.Range("K2:K3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("K2:K3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("K2:K3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("K2:K3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("K2:K3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("K2:K3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("K2:K3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("K2").Value = "Jml Absen";

               ws.Range("L2:L3").Column(1).Merge();
               ws.Range("L2:L3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("L2:L3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("L2:L3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("L2:L3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("L2:L3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("L2:L3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("L2:L3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("L2").Value = "Nominal Absen";

               ws.Range("M2:P2").Row(1).Merge();
               ws.Range("M2:P2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("M2:P2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("M2:P2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("M2:P2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("M2:P2").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("M2:P2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("M2:P2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("M2").Value = "Tunjangan";

               ws.Cell("M3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("M3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("M3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("M3").Value = "Keterampilan";

               ws.Cell("N3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("N3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("N3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("N3").Value = "Jabatan";

               ws.Cell("O3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("O3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("O3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("O3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("O3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("O3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("O3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("O3").Value = "Masa Kerja";

               ws.Cell("P3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("P3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("P3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("P3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("P3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("P3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("P3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("P3").Value = "Lain-lain";

               ws.Range("Q2:Q3").Column(1).Merge();
               ws.Range("Q2:Q3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("Q2:Q3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("Q2:Q3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("Q2:Q3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("Q2:Q3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("Q2:Q3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("Q2:Q3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("Q2").Value = "Jml Upah";

               ws.Range("R2:S2").Row(1).Merge();
               ws.Range("R2:S2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("R2:S2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("R2:S2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("R2:S2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("R2:S2").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("R2:S2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("R2:S2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("R2").Value = "OT1";

               ws.Cell("R3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("R3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("R3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("R3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("R3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("R3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("R3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("R3").Value = "Jml Jam";

               ws.Cell("S3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("S3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("S3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("S3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("S3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("S3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("S3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("S3").Value = "Nominal";

               ws.Range("T2:U2").Row(1).Merge();
               ws.Range("T2:U2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("T2:U2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("T2:U2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("T2:U2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("T2:U2").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("T2:U2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("T2:U2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("T2").Value = "OT2";

               ws.Cell("T3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("T3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("T3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("T3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("T3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("T3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("T3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("T3").Value = "Jml Jam";

               ws.Cell("U3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("U3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("U3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("U3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("U3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("U3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("U3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("U3").Value = "Nominal";

               ws.Range("V2:W2").Row(1).Merge();
               ws.Range("V2:W2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("V2:W2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("V2:W2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("V2:W2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("V2:W2").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("V2:W2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("V2:W2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("V2").Value = "OT3";

               ws.Cell("V3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("V3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("V3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("V3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("V3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("V3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("V3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("V3").Value = "Jml Jam";

               ws.Cell("W3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("W3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("W3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("W3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("W3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("W3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("W3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("W3").Value = "Nominal";

               ws.Range("X2:Y2").Row(1).Merge();
               ws.Range("X2:Y2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("X2:Y2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("X2:Y2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("X2:Y2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("X2:Y2").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("X2:Y2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("X2:Y2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("X2").Value = "OT4";

               ws.Cell("X3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("X3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("X3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("X3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("X3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("X3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("X3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("X3").Value = "Jml Jam";

               ws.Cell("Y3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("Y3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("Y3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("Y3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("Y3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("Y3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("Y3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("Y3").Value = "Nominal";

               ws.Range("Z2:AB2").Row(1).Merge();
               ws.Range("Z2:AB2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("Z2:AB2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("Z2:AB2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("Z2:AB2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("Z2:AB2").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("Z2:AB2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("Z2:AB2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("Z2").Value = "Potongan";

               ws.Cell("Z3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("Z3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("Z3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("Z3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("Z3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("Z3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("Z3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("Z3").Value = "BPJS TK";

               ws.Cell("AA3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("AA3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("AA3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("AA3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("AA3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("AA3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("AA3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("AA3").Value = "BPJS Kes";

               ws.Cell("AB3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("AB3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("AB3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("AB3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("AB3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Cell("AB3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("AB3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("AB3").Value = "Lain-lain";

               ws.Range("AC2:AC3").Column(1).Merge();
               ws.Range("AC2:AC3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("AC2:AC3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("AC2:AC3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("AC2:AC3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("AC2:AC3").Style.Fill.BackgroundColor = XLColor.DarkGray;
               ws.Range("AC2:AC3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Range("AC2:AC3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("AC2").Value = "Total";

               for (int r = 0; r <= payrollPreviewDTOs.Count - 1; r++) {
                  ws.Cell(r + 4, 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Value = payrollPreviewDTOs[r].GrupKerja;

                  ws.Cell(r + 4, 2).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Value = payrollPreviewDTOs[r].NIK;

                  ws.Cell(r + 4, 3).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Value = payrollPreviewDTOs[r].Nama;

                  ws.Cell(r + 4, 4).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Value = payrollPreviewDTOs[r].NoKTP;

                  ws.Cell(r + 4, 5).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Value = payrollPreviewDTOs[r].NoBPJSTK;

                  ws.Cell(r + 4, 6).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Value = payrollPreviewDTOs[r].NoBPJSKS;

                  ws.Cell(r + 4, 7).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Value = payrollPreviewDTOs[r].Alamat;

                  ws.Cell(r + 4, 8).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Value = payrollPreviewDTOs[r].Gender;

                  ws.Cell(r + 4, 9).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Value = payrollPreviewDTOs[r].NoRek;

                  ws.Cell(r + 4, 10).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Value = payrollPreviewDTOs[r].Hadir;

                  ws.Cell(r + 4, 11).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Value = payrollPreviewDTOs[r].TidakHadir;

                  ws.Cell(r + 4, 12).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Value = payrollPreviewDTOs[r].TidakHadirNominal;

                  ws.Cell(r + 4, 13).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Value = payrollPreviewDTOs[r].TunjKeterampilan;

                  ws.Cell(r + 4, 14).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Value = payrollPreviewDTOs[r].TunjJabatan;

                  ws.Cell(r + 4, 15).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 15).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 15).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 15).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 15).Value = payrollPreviewDTOs[r].TunjMasaKerja;

                  ws.Cell(r + 4, 16).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 16).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 16).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 16).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 16).Value = payrollPreviewDTOs[r].TunjLain2;

                  ws.Cell(r + 4, 17).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 17).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 17).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 17).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 17).Value = payrollPreviewDTOs[r].JmlUpah;

                  ws.Cell(r + 4, 18).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 18).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 18).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 18).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 18).Value = payrollPreviewDTOs[r].SUMOTP1;

                  ws.Cell(r + 4, 19).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 19).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 19).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 19).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 19).Value = payrollPreviewDTOs[r].SUMNominalOTP1;

                  ws.Cell(r + 4, 20).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 20).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 20).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 20).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 20).Value = payrollPreviewDTOs[r].SUMOTP2;

                  ws.Cell(r + 4, 21).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 21).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 21).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 21).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 21).Value = payrollPreviewDTOs[r].SUMNominalOTP2; ;

                  ws.Cell(r + 4, 22).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 22).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 22).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 22).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 22).Value = 0;

                  ws.Cell(r + 4, 23).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 23).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 23).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 23).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 23).Value = 0;

                  ws.Cell(r + 4, 24).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 24).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 24).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 24).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 24).Value = 0;

                  ws.Cell(r + 4, 25).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 25).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 25).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 25).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 25).Value = 0;

                  ws.Cell(r + 4, 26).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 26).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 26).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 26).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 26).Value = payrollPreviewDTOs[r].PotBPJSTK;

                  ws.Cell(r + 4, 27).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 27).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 27).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 27).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 27).Value = payrollPreviewDTOs[r].PotBPJSKes;

                  ws.Cell(r + 4, 28).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 28).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 28).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 28).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 28).Value = payrollPreviewDTOs[r].PotLain2;

                  ws.Cell(r + 4, 29).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 29).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 29).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 29).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 29).Value = payrollPreviewDTOs[r].TotalPendapatan;

               }

               // MemoryStream XLSStream = new();
               // wb.SaveAs(XLSStream);

               using (var stream = new MemoryStream()) {
                  wb.SaveAs(stream);
                  var content = stream.ToArray();
                  return File(
                     content,
                     "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                     $"Laporan Payroll Periode  {payrollPreviewDTOs[0].Periode}.xlsx"
                  );
               }

            }
            //return Ok(listAbsenMasuk);
         }
         catch (System.Exception) {
            throw;
         }
      }

      [HttpPost("SlipGaji")]
      public async Task<IActionResult> SlipGaji([FromBody] List<PayrollPreviewDTO> payrollPreviewDTOs) {
         string mimetype = "";
         var path = $"{this.webHostEnvironment.WebRootPath}\\Reports\\SlipGaji.rdlc";
         Dictionary<string, string> parameters = new();

         var slipGajiDT = new DataTable();
         slipGajiDT.Columns.Add("Periode");
         slipGajiDT.Columns.Add("TglCetak");
         slipGajiDT.Columns.Add("NIK");
         slipGajiDT.Columns.Add("Nama");
         slipGajiDT.Columns.Add("GrupKerja");
         slipGajiDT.Columns.Add("Upah");
         slipGajiDT.Columns.Add("JmlUpah");
         slipGajiDT.Columns.Add("Hadir");
         slipGajiDT.Columns.Add("TidakHadir");
         slipGajiDT.Columns.Add("TidakHadirNominal");
         slipGajiDT.Columns.Add("TunjKeterampilan");
         slipGajiDT.Columns.Add("TunjJabatan");
         slipGajiDT.Columns.Add("TunjMasaKerja");
         slipGajiDT.Columns.Add("TunjLain2");
         //slipGajiDT.Columns.Add("JamLemburKe1");
         //slipGajiDT.Columns.Add("JamLemburKe2");
         //slipGajiDT.Columns.Add("JamLemburKe3");
         //slipGajiDT.Columns.Add("JamLemburKe4");
         //slipGajiDT.Columns.Add("NominalLemburKe1");
         //slipGajiDT.Columns.Add("NominalLemburKe2");
         //slipGajiDT.Columns.Add("NominalLemburKe3");
         //slipGajiDT.Columns.Add("NominalLemburKe4");
         slipGajiDT.Columns.Add("SUMOTP1");
         slipGajiDT.Columns.Add("SUMOTP2");
         slipGajiDT.Columns.Add("SUMOTP3");
         slipGajiDT.Columns.Add("SUMOTP4");
         slipGajiDT.Columns.Add("OTPNominal1");
         slipGajiDT.Columns.Add("OTPNominal2");
         slipGajiDT.Columns.Add("OTPNominal3");
         slipGajiDT.Columns.Add("OTPNominal4");
         slipGajiDT.Columns.Add("SUMNominalOTP1");
         slipGajiDT.Columns.Add("SUMNominalOTP2");
         slipGajiDT.Columns.Add("SUMNominalOTP3");
         slipGajiDT.Columns.Add("SUMNominalOTP4");
         slipGajiDT.Columns.Add("PotBPJSTK");
         slipGajiDT.Columns.Add("PotBPJSKes");
         slipGajiDT.Columns.Add("PotLain2");
         slipGajiDT.Columns.Add("TotalPotongan");
         slipGajiDT.Columns.Add("TotalPenerimaan");
         slipGajiDT.Columns.Add("TotalPendapatan");

         DataRow dr;
         foreach (var dl in payrollPreviewDTOs) {
            dr = slipGajiDT.NewRow();

            dr["Periode"] = dl.Periode;
            dr["TglCetak"] = dl.TglCetak;
            dr["NIK"] = dl.NIK;
            dr["Nama"] = dl.Nama;
            dr["GrupKerja"] = dl.GrupKerja;
            dr["Upah"] = string.Format("{0:0,0.00}", dl?.Upah);
            //dr["Upah"] = Convert.ToDouble(dl?.Upah).ToString("N");
            dr["JmlUpah"] = string.Format("{0:0,0.00}", dl?.JmlUpah);
            dr["Hadir"] = dl.Hadir.ToString();
            dr["TidakHadir"] = dl.TidakHadir.ToString();
            //dr["TidakHadirNominal"] = string.Format("#,##0.00", dl?.TidakHadirNominal);
            dr["TidakHadirNominal"] = string.Format("{0:0,0.00}", dl?.TidakHadirNominal);
            dr["TunjKeterampilan"] = string.Format("{0:0,0.00}", dl?.TunjKeterampilan);
            //dr["TunjKeterampilan"] = Convert.ToDouble(dl?.TunjKeterampilan).ToString("N");
            //dr["TunjJabatan"] = string.Format("#,##0.00", dl?.TunjJabatan);
            dr["TunjJabatan"] = string.Format("{0:0,0.00}", dl?.TunjJabatan);
            //dr["TunjMasaKerja"] = string.Format("#,##0.00", dl?.TunjMasaKerja);
            dr["TunjMasaKerja"] = string.Format("{0:0,0.00}", dl?.TunjMasaKerja);
            //dr["TunjLain2"] = string.Format("#,##0.00", dl?.TunjLain2);
            dr["TunjLain2"] = string.Format("{0:0,0.00}", dl?.TunjLain2);
            //dr["JamLemburKe1"] = dl.JamLemburKe1.ToString();
            //dr["JamLemburKe2"] = dl.JamLemburKe2.ToString();
            //dr["JamLemburKe3"] = dl.JamLemburKe3.ToString();
            //dr["JamLemburKe4"] = dl.JamLemburKe4.ToString();
            //dr["NominalLemburKe1"] = dl.NominalLemburKe1.Value.ToString("#,##0.00");
            //dr["NominalLemburKe2"] = dl.NominalLemburKe2.Value.ToString("#,##0.00");
            //dr["NominalLemburKe3"] = dl.NominalLemburKe3.Value.ToString("#,##0.00");
            //dr["NominalLemburKe4"] = dl.NominalLemburKe4.Value.ToString("#,##0.00");
            dr["SUMOTP1"] = dl?.SUMOTP1.ToString();
            dr["SUMOTP2"] = dl?.SUMOTP2.ToString();
            dr["SUMOTP3"] = dl?.SUMOTP3.ToString();
            dr["SUMOTP4"] = dl?.SUMOTP4.ToString();
            //dr["SUMNominalOTP1"] = string.Format("#,##0.00", dl?.SUMNominalOTP1);
            dr["SUMNominalOTP1"] = string.Format("{0:0,0.00}", dl?.SUMNominalOTP1);
            //dr["SUMNominalOTP2"] = string.Format("#,##0.00", dl?.SUMNominalOTP2);
            dr["SUMNominalOTP2"] = string.Format("{0:0,0.00}", dl?.SUMNominalOTP2);
            //dr["SUMNominalOTP3"] = string.Format("#,##0.00", dl?.SUMNominalOTP3);
            dr["SUMNominalOTP3"] = string.Format("{0:0,0.00}", dl?.SUMNominalOTP3);
            //dr["SUMNominalOTP4"] = string.Format("#,##0.00", dl?.SUMNominalOTP4);
            dr["SUMNominalOTP4"] = string.Format("{0:0,0.00}", dl?.SUMNominalOTP4);
            //dr["OTPNominal1"] = string.Format("#,##0.00", dl?.OTPNominal1);
            dr["OTPNominal1"] = string.Format("{0:0,0.00}", dl?.OTPNominal1);
            //dr["OTPNominal2"] = string.Format("#,##0.00", dl?.OTPNominal2);
            dr["OTPNominal2"] = string.Format("{0:0,0.00}", dl?.OTPNominal2);
            //dr["OTPNominal3"] = string.Format("#,##0.00", dl?.OTPNominal3);
            dr["OTPNominal3"] = string.Format("{0:0,0.00}", dl?.OTPNominal3);
            //dr["OTPNominal4"] = string.Format("#,##0.00", dl?.OTPNominal4);
            dr["OTPNominal4"] = string.Format("{0:0,0.00}", dl?.OTPNominal4);

            //dr["PotBPJSKes"] = string.Format("#,##0.00", dl?.PotBPJSKes);
            dr["PotBPJSKes"] = string.Format("{0:0,0.00}", dl?.PotBPJSKes);
            //dr["PotBPJSTK"] = string.Format("#,##0.00", dl?.PotBPJSTK);
            dr["PotBPJSTK"] = string.Format("{0:0,0.00}", dl?.PotBPJSTK);
            //dr["PotLain2"] = string.Format("#,##0.00", dl?.PotLain2);
            dr["PotLain2"] = string.Format("{0:0,0.00}", dl?.PotLain2);
            //dr["TotalPotongan"] = string.Format("#,##0.00", dl?.TotalPotongan);
            dr["TotalPotongan"] = string.Format("{0:0,0.00}", dl?.TotalPotongan);
            //dr["TotalPenerimaan"] = dl?.TotalPenerimaan.ToString("#,##0.00");
            dr["TotalPenerimaan"] = string.Format("{0:0,0.00}", dl?.TotalPenerimaan);
            //dr["TotalPendapatan"] = dl?.TotalPendapatan.Value.ToString("#,##0.00");
            dr["TotalPendapatan"] = string.Format("{0:0,0.00}", dl?.TotalPendapatan);

            Console.WriteLine($"dr[Periode]= {dr["Periode"]}");
            Console.WriteLine($"dl.Periode= {dl?.Periode}");

            Console.WriteLine($"dr[TglCetak]= {dr["TglCetak"]}");
            Console.WriteLine($"dl.TglCetak= {dl?.TglCetak}");
            Console.WriteLine($"payrollController_NIK: {dl.NIK}, payrollController_Nama: {dl.Nama}, payrollController_SUMNominalOTP2: {dl?.SUMNominalOTP2}");

            slipGajiDT.Rows.Add(dr);
         }

         //parameters.Add("Periode", periode);
         //parameters.Add("TglCetak", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
         LocalReport localReport = new(path);

         localReport.AddDataSource("dsSlipGaji", slipGajiDT);
         var result = localReport.Execute(RenderType.Pdf, 1, null, mimetype);
         return File(result.MainStream, "application/pdf");
      }

      [HttpPost("PostPayrollRange")]
      public async Task<IActionResult> PostPayrollRange([FromBody] List<PayrollDTO> listPayrolls) {
         var rst = await payrollService.PostPayrollRange(listPayrolls);
         return Ok(rst);
      }

   }
}
