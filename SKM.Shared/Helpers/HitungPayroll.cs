using Microsoft.IdentityModel.Tokens;
using SKM.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Helpers {
   public static class HitungPayroll {
      public static List<PayrollPreviewDTO> Payroll(string periode, List<EmployeeDTO>? employeeDTOs, List<JadwalKehadiranDTO>? jadwalKehadiranDTOs, IEnumerable<SuratPerintahLemburDTO>? SPLDTOs, IEnumerable<GajiDanTunjanganDTO> gajiDTOs, JamKerjaDTO jamKerjaDTO) {

         List<PayrollPreviewDTO> payrollPreviewDTOs = new();
         List<JadwalKehadiranDTO>? hadir = new();
         List<JadwalKehadiranDTO>? tdkHadir = new();

         int? tdkHadirCount = 0, hadirCount = 0;
         decimal sumNominalOT1 = 0, sumNominalOT2 = 0, sumNominalOT3 = 0, sumNominalOT4 = 0, SUMOTP1 = 0, SUMOTP2 = 0, SUMOTP3 = 0, SUMOTP4 = 0, OTPNominal1 = 0, OTPNominal2 = 0, OTPNominal3 = 0, OTPNominal4 = 0, nominalTdkHadir = 0, upah = 0;

         int? tunjJabatan = 0, tunjKeterampilan = 0, tunjMasaKerja = 0, tunjLain = 0;

         // try {
         //hadir = jadwalKerjaKaryawanDTOs?.Where(jd => kehadiranDTOs.Any(kh => kh.NIK == jd.NIK && kh.Tanggal == jd.Tgl)).ToList();
         hadir = jadwalKehadiranDTOs!.Where(jd => jd.Up == true).ToList();
         // Console.WriteLine("hadir");
         // foreach(var h in hadir){
         //    Console.WriteLine($"NIK: {h.NIK}, Nama: {h.NamaKaryawan}, Tanggal: {h.Tgl.Value.Date}");
         // }

         tdkHadir = jadwalKehadiranDTOs?.Where(jd => jd.Up == false || jd.Up == null).ToList();
         // Console.WriteLine("tdkHadir");
         // foreach(var t in tdkHadir){
         //    Console.WriteLine($"NIK: {t.NIK}, Nama: {t.NamaKaryawan}, Tanggal: {t.Tgl.Value.Date}");
         // }
         // Console.WriteLine($"tdkHadir is null: {tdkHadir is null}");
         //var jadwalKerjaKaryawanDistinct = (from jd in jadwalKerjaKaryawanDTOs select jd).DistinctBy(x => x.NIK);
         //if (SPLDTOs is null) SPLDTOs = new List<SuratPerintahLemburDTO>();
         foreach (var j in jadwalKehadiranDTOs!) {
            PayrollPreviewDTO payroll = new();
            payroll.Nama = j.Nama;
            payroll.NIK = j.NIK;
            payroll.GrupKerja = j.GrupKerja;
            payroll.Periode = periode;

            EmployeeDTO? empl = employeeDTOs?.FirstOrDefault(e => e.NIK == j.NIK);

            payroll.NoKTP = empl?.KTP ?? "-";
            payroll.NoBPJSTK = empl?.NOBPJSTK ?? "-";
            payroll.NoBPJSKS = empl?.NOBPJSKS ?? "-";
            payroll.Alamat = empl?.Address ?? "-";
            payroll.Gender = (empl?.Gender == true ? "Laki-laki" : "Perempuan");
            payroll.NoRek = empl?.AccountBank ?? "-";

            payroll.TglCetak = DateTime.Now.Date.ToString("dd-MM-yyyy");

            // hadir = jadwalKerjaKaryawanDTOs.Where(jd => kehadiranDTOs.Any(kh => kh.NIK == jd.NIK));
            // tdkHadir = jadwalKerjaKaryawanDTOs.Where(jd => !kehadiranDTOs.Any(kh => kh.NIK == jd.NIK));

            if (hadir is null) {
               hadirCount = 0;
            }
            else {
               hadirCount = hadir.Where(h => h.NIK == j.NIK).Count();
            }
            payroll.Hadir = hadirCount;

            if (tdkHadir is null) {
               tdkHadirCount = 0;
            }
            else {
               tdkHadirCount = tdkHadir.Where(th => th.NIK == j.NIK).Count();
            }
            payroll.TidakHadir = tdkHadirCount;

            GajiDanTunjanganDTO? gaji = gajiDTOs?.FirstOrDefault(g => g.NIK == j.NIK);
            if (gaji is not null) {
               //upah = ((decimal)gaji?.Upah == null ? 0 : gaji.Upah.Value);
               upah = gaji.Upah;
               tunjJabatan = gaji?.TunjJabatan ?? 0;
               tunjKeterampilan = gaji?.TunjKeterampilan ?? 0;
               tunjMasaKerja = gaji?.TunjMasaKerja ?? 0;
               tunjLain = gaji?.TunjLain ?? 0;
            }
            else {
               upah = 0;
               tunjJabatan = 0;
               tunjKeterampilan = 0;
               tunjMasaKerja = 0;
               tunjLain = 0;
            }

            payroll.Upah = gaji?.Upah;
            if(tdkHadirCount > 0) {
               nominalTdkHadir = Math.Round((decimal)tdkHadirCount * (decimal)((upah + tunjKeterampilan + tunjJabatan + tunjMasaKerja + tunjLain) / jamKerjaDTO.PembagiPayroll), 2);
            }
            else {
               nominalTdkHadir = 0;
            }

            payroll.TidakHadirNominal = nominalTdkHadir;
            payroll.TunjKeterampilan = tunjKeterampilan;
            payroll.TunjJabatan = tunjJabatan;
            payroll.TunjMasaKerja = tunjMasaKerja;
            payroll.TunjLain2 = tunjLain;

            decimal? jmlUpah = (decimal)(upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain) - nominalTdkHadir;

            payroll.JmlUpah = jmlUpah;
            if (SPLDTOs!.Count() > 0) {
               List<SuratPerintahLemburDTO>? Arrlembur = SPLDTOs?.Where(l => l.NIK == j.NIK).ToList();

               // OTPNominal1 = (int)Arrlembur.FirstOrDefault(spl => spl.NIK == j.NIK).OTPNominal1;
               OTPNominal1 = (from spl in Arrlembur select spl.OTPNominal1 ?? 0).FirstOrDefault();
               //OTPNominal2 = 0;
               OTPNominal2 = (from spl in Arrlembur select spl.OTPNominal2 ?? 0).FirstOrDefault();
               //OTPNominal3 = 0;
               OTPNominal3 = (from spl in Arrlembur select spl.OTPNominal3 ?? 0).FirstOrDefault();
               OTPNominal4 = (from spl in Arrlembur select spl.OTPNominal4 ?? 0).FirstOrDefault();
               //OTPNominal4 = 0;

               SUMOTP1 = (from spl in Arrlembur select spl.OTP1 ?? 0).Sum();
               SUMOTP2 = (from spl in Arrlembur select spl.OTP2 ?? 0).Sum();
               SUMOTP3 = (from spl in Arrlembur select spl.OTP3 ?? 0).Sum();
               SUMOTP4 = (from spl in Arrlembur select spl.OTP4 ?? 0).Sum();

               //sumNominalOT1 = (int)Math.Round((decimal)(Arrlembur?[0].OTPNominal1 ?? 0)) * SUMOTP1;
               //sumNominalOT1 = OTPNominal1 * SUMOTP1;
               //sumNominalOT2 = OTPNominal2 * SUMOTP2;
               //sumNominalOT1 = (decimal)Math.Round((decimal)OTPNominal1) * SUMOTP1 ?? 0;
               sumNominalOT1 = (int)Math.Round((decimal)OTPNominal1) * SUMOTP1;

               //sumNominalOT2 = (int)Math.Round((decimal)OTPNominal2) * SUMOTP2 ?? 0;
               sumNominalOT2 = (int)Math.Round((decimal)OTPNominal2) * SUMOTP2;

               //sumNominalOT3 = (int)Math.Round((decimal)OTPNominal3) * SUMOTP3 ?? 0;
               sumNominalOT3 = (int)Math.Round((decimal)OTPNominal3) * SUMOTP3;

               //sumNominalOT3 = OTPNominal3 * SUMOTP3;
               //sumNominalOT4 = (int)Math.Round((decimal)OTPNominal4) * SUMOTP4 ?? 0;
               sumNominalOT4 = (int)Math.Round((decimal)OTPNominal4) * SUMOTP4;
               //sumNominalOT4 = OTPNominal4 * SUMOTP4;
            }
            else {
               OTPNominal1 = 0;
               OTPNominal2 = 0;
               OTPNominal3 = 0;
               OTPNominal4 = 0;

               SUMOTP1 = 0;
               SUMOTP2 = 0;
               SUMOTP3 = 0;
               SUMOTP4 = 0;

               sumNominalOT1 = 0;

               sumNominalOT2 = 0;

               sumNominalOT3 = 0;

               sumNominalOT4 = 0;
            }

            payroll.SUMOTP1 = (int)SUMOTP1;
            payroll.SUMOTP2 = (int)SUMOTP2;
            payroll.SUMOTP3 = (int)SUMOTP3;
            payroll.SUMOTP4 = (int)SUMOTP4;

            payroll.SUMNominalOTP1 = (int)sumNominalOT1;
            payroll.SUMNominalOTP2 = (int)sumNominalOT2;
            payroll.SUMNominalOTP3 = (int)sumNominalOT3;
            payroll.SUMNominalOTP4 = (int)sumNominalOT4;

            payroll.OTPNominal1 = (int)OTPNominal1;
            payroll.OTPNominal2 = (int)OTPNominal2;
            payroll.OTPNominal3 = (int)OTPNominal3;
            payroll.OTPNominal4 = (int)OTPNominal4;
            payroll.JamLemburKe1 = 0;
            payroll.JamLemburKe2 = 0;
            payroll.JamLemburKe3 = 0;
            payroll.JamLemburKe4 = 0;
            payroll.NominalLemburKe1 = 0;
            payroll.NominalLemburKe2 = 0;
            payroll.NominalLemburKe3 = 0;
            payroll.NominalLemburKe4 = 0;

            //payroll.TotalPenerimaan = gaji.Upah + nominalLemburKe1 + nominalLemburKe2 + nominalLemburKe3 + nominalLemburKe4 + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain2;

            payroll.TotalPenerimaan = (decimal)upah + (decimal)sumNominalOT1 + (decimal)sumNominalOT2 + (decimal)sumNominalOT3 + (decimal)sumNominalOT4 + (int)tunjJabatan + (int)tunjKeterampilan + (int)tunjMasaKerja + (int)tunjLain;

            decimal? potBPJSKes = 0.01m * (upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain);
            payroll.PotBPJSKes = potBPJSKes;

            decimal? pensiunanKaryawan = 0.01m * (upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain);
            decimal? JHT = 0.02m * (upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain);

            payroll.PotBPJSTK = pensiunanKaryawan + JHT;

            payroll.TotalPotongan = (pensiunanKaryawan + JHT) + potBPJSKes + nominalTdkHadir;
            payroll.PotLain2 = 0;

            //payroll.TotalPendapatan = Math.Round((jmlUpah + nominalLemburKe1 + nominalLemburKe2 + nominalLemburKe3 + nominalLemburKe4) - (potBPJSKes + pensiunanKaryawan + JHT), 2);

            payroll.TotalPendapatan = Math.Round(((decimal)jmlUpah + (decimal)sumNominalOT1 + (decimal)sumNominalOT2 + (decimal)sumNominalOT3 + (decimal)sumNominalOT4) - ((decimal)nominalTdkHadir + (decimal)potBPJSKes + (decimal)pensiunanKaryawan + (decimal)JHT), 2);

            if (!payrollPreviewDTOs.Any(x => x.NIK == payroll.NIK)) {
               // Console.WriteLine($"Nama: {payroll.Nama}, NIK: {payroll.NIK}, TotalPendapatan: {payroll.TotalPendapatan}");
               payrollPreviewDTOs.Add(payroll);
            }

            tdkHadirCount = 0;
            nominalTdkHadir = 0;
            hadirCount = 0;

            upah = 0;
            tunjJabatan = 0;
            tunjKeterampilan = 0;
            tunjMasaKerja = 0;
            tunjLain = 0;

            sumNominalOT1 = 0;
            sumNominalOT2 = 0;
            sumNominalOT3 = 0;
            sumNominalOT4 = 0;
            OTPNominal1 = 0;
            OTPNominal2 = 0;
            OTPNominal3 = 0;
            OTPNominal4 = 0;

            // Console.WriteLine($"payroll: {payroll}");
         }
         return payrollPreviewDTOs;
         // }
         // catch (Exception) {
         //    throw;
         // }
      }

      public static List<PayrollPreviewDTO> PayrollSecurity(string grp, string periode, List<EmployeeDTO> employeeDTOs, List<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs, IEnumerable<KehadiranDTO> kehadiranDTOs, List<SuratPerintahLemburDTO>? SPLDTOs, List<GajiDanTunjanganDTO> gajiDTOs, JamKerjaDTO jamKerjaDTO) {

         List<PayrollPreviewDTO> payrollPreviewDTOs = new();
         List<JadwalKerjaSecurityDTO>? hadir = new();
         List<JadwalKerjaSecurityDTO>? tdkHadir = new();

         Console.WriteLine($"employeeDTOs.Count: {employeeDTOs.Count}");

         int? tdkHadirCount = 0, hadirCount = 0;
         decimal sumNominalOT1 = 0, sumNominalOT2 = 0, sumNominalOT3 = 0, sumNominalOT4 = 0, SUMOTP1 = 0, SUMOTP2 = 0, SUMOTP3 = 0, SUMOTP4 = 0, OTPNominal1 = 0, OTPNominal2 = 0, OTPNominal3 = 0, OTPNominal4 = 0, nominalTdkHadir = 0, upah = 0;

         int? tunjJabatan = 0, tunjKeterampilan = 0, tunjMasaKerja = 0, tunjLain = 0;

         // try {
         hadir = jadwalKerjaSecurityDTOs?.Where(jd => kehadiranDTOs.Any(kh => kh.NIK == jd.NIK && kh.Tanggal == jd.Tgl)).ToList();
         // Console.WriteLine("hadir");
         // foreach(var h in hadir){
         //    Console.WriteLine($"NIK: {h.NIK}, Nama: {h.NamaKaryawan}, Tanggal: {h.Tgl.Value.Date}");
         // }

         tdkHadir = jadwalKerjaSecurityDTOs?.Where(jd => !kehadiranDTOs.Any(kh => kh.NIK == jd.NIK && kh.Tanggal == jd.Tgl)).ToList();
         // Console.WriteLine("tdkHadir");
         // foreach(var t in tdkHadir){
         //    Console.WriteLine($"NIK: {t.NIK}, Nama: {t.NamaKaryawan}, Tanggal: {t.Tgl.Value.Date}");
         // }
         // Console.WriteLine($"tdkHadir is null: {tdkHadir is null}");
         //var jadwalKerjaKaryawanDistinct = (from jd in jadwalKerjaKaryawanDTOs select jd).DistinctBy(x => x.NIK);
         //if (SPLDTOs is null) SPLDTOs = new List<SuratPerintahLemburDTO>();
         foreach (var j in jadwalKerjaSecurityDTOs) {
            PayrollPreviewDTO payroll = new();
            payroll.Nama = j.Nama;
            payroll.NIK = j.NIK;
            payroll.Periode = periode;

            Console.WriteLine($"employeeDTOs.Count: {employeeDTOs?.Count}");
            var empl = employeeDTOs?.Where(e => e.NIK == j.NIK).SingleOrDefault();
            Console.WriteLine($"empl?.GroupName: {empl?.GroupName}");

            Console.WriteLine($"j.NIK: {j.NIK}, e.NIK: {empl?.NIK}");
            Console.WriteLine(employeeDTOs?.FirstOrDefault(e => e.NIK == j.NIK));

            payroll.GrupKerja = grp;
            payroll.NoKTP = empl?.KTP ?? "-";
            payroll.NoBPJSTK = empl?.NOBPJSTK ?? "-";
            payroll.NoBPJSKS = empl?.NOBPJSKS ?? "-";
            payroll.Alamat = empl?.Address ?? "-";
            payroll.Gender = (empl?.Gender == true ? "Laki-laki" : "Perempuan");
            payroll.NoRek = empl?.AccountBank ?? "-";

            payroll.TglCetak = DateTime.Now.Date.ToString("dd-MM-yyyy");

            // hadir = jadwalKerjaKaryawanDTOs.Where(jd => kehadiranDTOs.Any(kh => kh.NIK == jd.NIK));
            // tdkHadir = jadwalKerjaKaryawanDTOs.Where(jd => !kehadiranDTOs.Any(kh => kh.NIK == jd.NIK));

            if (hadir is null) {
               hadirCount = 0;
            }
            else {
               hadirCount = hadir.Where(h => h.NIK == j.NIK).Count();
            }
            payroll.Hadir = hadirCount;

            if (tdkHadir is null) {
               tdkHadirCount = 0;
            }
            else {
               tdkHadirCount = tdkHadir.Where(th => th.NIK == j.NIK).Count();
            }
            payroll.TidakHadir = tdkHadirCount;

            GajiDanTunjanganDTO? gaji = gajiDTOs?.FirstOrDefault(g => g.NIK == j.NIK);
            if (gaji is not null) {
               //upah = ((decimal)gaji?.Upah == null ? 0 : gaji.Upah.Value);
               upah = gaji.Upah;
               tunjJabatan = gaji?.TunjJabatan ?? 0;
               tunjKeterampilan = gaji?.TunjKeterampilan ?? 0;
               tunjMasaKerja = gaji?.TunjMasaKerja ?? 0;
               tunjLain = gaji?.TunjLain ?? 0;
            }
            else {
               upah = 0;
               tunjJabatan = 0;
               tunjKeterampilan = 0;
               tunjMasaKerja = 0;
               tunjLain = 0;
            }

            payroll.Upah = gaji?.Upah;
            if (tdkHadirCount > 0) {
               nominalTdkHadir = Math.Round((decimal)tdkHadirCount * (decimal)((upah + tunjKeterampilan + tunjJabatan + tunjMasaKerja + tunjLain) / jamKerjaDTO.PembagiPayroll), 2);
            }
            else {
               nominalTdkHadir = 0;
            }


            payroll.TidakHadirNominal = nominalTdkHadir;
            payroll.TunjKeterampilan = tunjKeterampilan;
            payroll.TunjJabatan = tunjJabatan;
            payroll.TunjMasaKerja = tunjMasaKerja;
            payroll.TunjLain2 = tunjLain;

            decimal? jmlUpah = (decimal)(upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain) - nominalTdkHadir;

            payroll.JmlUpah = jmlUpah;
            if (SPLDTOs?.Count > 0 ) {
               List<SuratPerintahLemburDTO>? Arrlembur = SPLDTOs?.Where(l => l.NIK == j.NIK).ToList();

               // OTPNominal1 = (int)Arrlembur.FirstOrDefault(spl => spl.NIK == j.NIK).OTPNominal1;
               OTPNominal1 = (from spl in Arrlembur select spl.OTPNominal1 ?? 0).FirstOrDefault();
               //OTPNominal2 = 0;
               OTPNominal2 = (from spl in Arrlembur select spl.OTPNominal2 ?? 0).FirstOrDefault();
               //OTPNominal3 = 0;
               OTPNominal3 = (from spl in Arrlembur select spl.OTPNominal3 ?? 0).FirstOrDefault();
               OTPNominal4 = (from spl in Arrlembur select spl.OTPNominal4 ?? 0).FirstOrDefault();
               //OTPNominal4 = 0;

               SUMOTP1 = (from spl in Arrlembur select spl.OTP1 ?? 0).Sum();
               SUMOTP2 = (from spl in Arrlembur select spl.OTP2 ?? 0).Sum();
               SUMOTP3 = (from spl in Arrlembur select spl.OTP3 ?? 0).Sum();
               SUMOTP4 = (from spl in Arrlembur select spl.OTP4 ?? 0).Sum();

               //sumNominalOT1 = (int)Math.Round((decimal)(Arrlembur?[0].OTPNominal1 ?? 0)) * SUMOTP1;
               //sumNominalOT1 = OTPNominal1 * SUMOTP1;
               //sumNominalOT2 = OTPNominal2 * SUMOTP2;
               //sumNominalOT1 = (decimal)Math.Round((decimal)OTPNominal1) * SUMOTP1 ?? 0;
               sumNominalOT1 = (int)Math.Round((decimal)OTPNominal1) * SUMOTP1;

               //sumNominalOT2 = (int)Math.Round((decimal)OTPNominal2) * SUMOTP2 ?? 0;
               sumNominalOT2 = (int)Math.Round((decimal)OTPNominal2) * SUMOTP2;

               //sumNominalOT3 = (int)Math.Round((decimal)OTPNominal3) * SUMOTP3 ?? 0;
               sumNominalOT3 = (int)Math.Round((decimal)OTPNominal3) * SUMOTP3;

               //sumNominalOT3 = OTPNominal3 * SUMOTP3;
               //sumNominalOT4 = (int)Math.Round((decimal)OTPNominal4) * SUMOTP4 ?? 0;
               sumNominalOT4 = (int)Math.Round((decimal)OTPNominal4) * SUMOTP4;
               //sumNominalOT4 = OTPNominal4 * SUMOTP4;
            }
            else {
               OTPNominal1 = 0;
               OTPNominal2 = 0;
               OTPNominal3 = 0;
               OTPNominal4 = 0;

               SUMOTP1 = 0;
               SUMOTP2 = 0;
               SUMOTP3 = 0;
               SUMOTP4 = 0;

               sumNominalOT1 = 0;

               sumNominalOT2 = 0;

               sumNominalOT3 = 0;

               sumNominalOT4 = 0;
            }

            payroll.SUMOTP1 = (int)SUMOTP1;
            payroll.SUMOTP2 = (int)SUMOTP2;
            payroll.SUMOTP3 = (int)SUMOTP3;
            payroll.SUMOTP4 = (int)SUMOTP4;

            payroll.SUMNominalOTP1 = (int)sumNominalOT1;
            payroll.SUMNominalOTP2 = (int)sumNominalOT2;
            payroll.SUMNominalOTP3 = (int)sumNominalOT3;
            payroll.SUMNominalOTP4 = (int)sumNominalOT4;

            payroll.OTPNominal1 = (int)OTPNominal1;
            payroll.OTPNominal2 = (int)OTPNominal2;
            payroll.OTPNominal3 = (int)OTPNominal3;
            payroll.OTPNominal4 = (int)OTPNominal4;
            payroll.JamLemburKe1 = 0;
            payroll.JamLemburKe2 = 0;
            payroll.JamLemburKe3 = 0;
            payroll.JamLemburKe4 = 0;
            payroll.NominalLemburKe1 = 0;
            payroll.NominalLemburKe2 = 0;
            payroll.NominalLemburKe3 = 0;
            payroll.NominalLemburKe4 = 0;

            //payroll.TotalPenerimaan = gaji.Upah + nominalLemburKe1 + nominalLemburKe2 + nominalLemburKe3 + nominalLemburKe4 + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain2;

            payroll.TotalPenerimaan = (decimal)upah + (decimal)sumNominalOT1 + (decimal)sumNominalOT2 + (decimal)sumNominalOT3 + (decimal)sumNominalOT4 + (int)tunjJabatan + (int)tunjKeterampilan + (int)tunjMasaKerja + (int)tunjLain;

            decimal? potBPJSKes = 0.01m * (upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain);
            payroll.PotBPJSKes = potBPJSKes;

            decimal? pensiunanKaryawan = 0.01m * (upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain);
            decimal? JHT = 0.02m * (upah + tunjJabatan + tunjKeterampilan + tunjMasaKerja + tunjLain);

            payroll.PotBPJSTK = pensiunanKaryawan + JHT;

            payroll.TotalPotongan = (pensiunanKaryawan + JHT) + potBPJSKes + nominalTdkHadir;
            payroll.PotLain2 = 0;

            //payroll.TotalPendapatan = Math.Round((jmlUpah + nominalLemburKe1 + nominalLemburKe2 + nominalLemburKe3 + nominalLemburKe4) - (potBPJSKes + pensiunanKaryawan + JHT), 2);

            payroll.TotalPendapatan = Math.Round(((decimal)jmlUpah + (decimal)sumNominalOT1 + (decimal)sumNominalOT2 + (decimal)sumNominalOT3 + (decimal)sumNominalOT4) - ((decimal)nominalTdkHadir + (decimal)potBPJSKes + (decimal)pensiunanKaryawan + (decimal)JHT), 2);

            if (!payrollPreviewDTOs.Any(x => x.NIK == payroll.NIK)) {
               // Console.WriteLine($"Nama: {payroll.Nama}, NIK: {payroll.NIK}, TotalPendapatan: {payroll.TotalPendapatan}");
               payrollPreviewDTOs.Add(payroll);
            }

            tdkHadirCount = 0;
            nominalTdkHadir = 0;
            hadirCount = 0;

            upah = 0;
            tunjJabatan = 0;
            tunjKeterampilan = 0;
            tunjMasaKerja = 0;
            tunjLain = 0;

            sumNominalOT1 = 0;
            sumNominalOT2 = 0;
            sumNominalOT3 = 0;
            sumNominalOT4 = 0;
            OTPNominal1 = 0;
            OTPNominal2 = 0;
            OTPNominal3 = 0;
            OTPNominal4 = 0;

            // Console.WriteLine($"payroll: {payroll}");
         }
         return payrollPreviewDTOs;
         // }
         // catch (Exception) {
         //    throw;
         // }
      }


   }
}
