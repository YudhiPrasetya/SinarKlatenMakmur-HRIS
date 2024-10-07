using HRIS.AktivitasAbsensi.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using zkemkeeper;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.Remoting.Messaging;
using HRIS.AktivitasAbsensi.Properties;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices.ComTypes;
using SKM.Shared.Dtos;

namespace HRIS.AktivitasAbsensi.Classes {
	public enum VerifyMode {
		Password,
		Finger_Print
	}

	public class FingerPrintDevice {
		private readonly string _iPAddress;
		private readonly int _port;
		private readonly int _machineNumber;

      public const string localServer = "https://localhost:7023";
      //public const string remoteServer = "http://192.168.90.10:9023";
		public const string remoteServer = "http://192.168.2.121:9023";

		public string NIK { get; set; }
		public string Nama { get; set; }
		public string GrupKerja { get; set; }
		public string Tanggal { get; set; }
		public string IpMesin { get; set; }

      //#if DEBUG
      //		public const string baseUrl = "https://localhost:7023";
      //#else
      //		public const string baseUrl = "http://192.168.90.10:9023";
      //#endif

      List<LogKehadiran> logKehadirans = new List<LogKehadiran>();
		//List<LogMesinAbsen> logMesinAbsens = new List<LogMesinAbsen>();
		List<LogMesinAbsen> logMesinAbsens = new List<LogMesinAbsen>();

		ContentLogMesinAbsen contentLogMesinAbsen = new ContentLogMesinAbsen();
		//private bool IsConnected = false;
		private zkemkeeper.CZKEM FDevice;

      public bool Connected { get; set; }
      public FingerPrintDevice(string IPAddress, int Port, int MachineNumber)
      {
			_iPAddress = IPAddress;
			_port = Port;
			_machineNumber = MachineNumber;
		}
		public void ConnectNet() {
			FDevice = new CZKEM();
			bool connected = FDevice.Connect_Net(this._iPAddress, this._port);
			if (connected) {
				if(FDevice.RegEvent(this._machineNumber, 65535)) {
					FDevice.OnAttTransactionEx += new _IZKEMEvents_OnAttTransactionExEventHandler(MesinAbsen_OnAttTransactionEx);
					Connected = true;
				}
			}
			else {
				Connected = false;
			}
		}

		private async void MesinAbsen_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {

			string nik = sEnrollNumber.ToString();
			int year = DateTime.Now.Year;
			int month = DateTime.Now.Month;
			int day = DateTime.Now.Day;
			string strDate = year.ToString() + "/" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "/" + (day < 10 ? "0" + day.ToString() : day.ToString());

			//await CekJadwalKerja(nik, strDate);
			string strTime = (iHour < 10 ? "0" + iHour.ToString() : iHour.ToString()) + ":" + (iMinute < 10 ? "0" + iMinute.ToString() : iMinute.ToString()) + ":" + (iSecond < 10 ? "0" + iSecond.ToString() : iSecond.ToString());
			string strDateTime = strDate + " " + strTime;

			Console.WriteLine($"NIK: {nik}, DateTime: {strDateTime}, IpAddress: {_iPAddress}");

			//MesinRTFinger(sEnrollNumber, strDateTime, _iPAddress);
			await SaveAddAbsenRT(nik, _iPAddress, _port, _machineNumber);

			//await RealTimeTest(_iPAddress, _port, _machineNumber);
		}

		public async Task RealTimeTest(string ipAddress, int port, int mNumber) {
			//string[] arrNIK = { "240410015", "240410020", "240410021", "240410022", "240410027", "240410433" };
         //string[] arrNIK = { "240410433" };
         string stryear = DateTime.Now.Year.ToString();
			string strmonth = (DateTime.Now.Month < 10 ? $"0{DateTime.Now.Month}" : $"{DateTime.Now.Month}");
			string strday = (DateTime.Now.Day < 10 ? $"){DateTime.Now.Day}" : $"{DateTime.Now.Month}");
			string strTodayDate = stryear + "-" + strmonth + "-" + strday;

         //for (int x = 0; x <= arrNIK.Length; x++) {
         //	await Task.Delay(100);
         //	await SaveAddAbsenRT(arrNIK[x].ToString(), ipAddress, port, mNumber);
         //	//await CekJadwalKerja(arrNIK[x].ToString(), strTodayDate);
         //}

         await SaveAddAbsenRT("240410433", ipAddress, port, mNumber);
         //await CekJadwalKerja("240410015", strTodayDate);

         //await SaveAddAbsenRT("240410020", ipAddress, port, mNumber);
         //await CekJadwalKerja("240410020", strTodayDate);

         //await SaveAddAbsenRT("240410021", ipAddress, port, mNumber);
         //await CekJadwalKerja("240410021", strTodayDate);

         //await SaveAddAbsenRT("240410022", ipAddress, port, mNumber);
         //await CekJadwalKerja("240410022", strTodayDate);

         //await SaveAddAbsenRT("240410027", ipAddress, port, mNumber);
         //await CekJadwalKerja("240410027", strTodayDate);
      }

		public string MesinRTFinger(string nik, string tgl, string ipMesin) {
			return $"{nik}-{tgl}-{ipMesin}";
		}

		public async Task SaveAddAbsenRT(string nik, string ip, int port, int noMesin) {
         //cek data karyawan berdasar NIK
         string token = Settings.Default.AuthToken;
         using (HttpClient client = new HttpClient()) {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync($"{remoteServer}/Employees/NIKForRTFingerPrint/{nik}");
            if (response.StatusCode == HttpStatusCode.OK) {
               var result = await response.Content.ReadAsStringAsync();
               EmployeeTempDTO empTempDTO = JsonConvert.DeserializeObject<EmployeeTempDTO>(result);
               AbsenRealTimeDTO absenRealTimeDTO = new AbsenRealTimeDTO {
                  NIK = empTempDTO.NIK,
                  Nama = empTempDTO.Name,
                  Gender = empTempDTO.Gender,
                  GroupKerja = empTempDTO.GroupName,
                  Tanggal = DateTime.Now,
                  IpMesin = ip,
                  Port = port,
                  NoMesin = noMesin
               };
               Console.WriteLine($"empTempDTO.NIK: {empTempDTO.NIK}");
               var content = JsonConvert.SerializeObject(absenRealTimeDTO);
               var buffer = System.Text.Encoding.UTF8.GetBytes(content);
               var byteContent = new ByteArrayContent(buffer);
               await GetWhenAll(byteContent, nik);

      //         byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
      //         using (HttpClient client2 = new HttpClient()) {
      //            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
      //            var response1 = await client2.PostAsync($"{remoteServer}/AbsenRealTime/AddAbsenRealTime", byteContent);
      //            Console.WriteLine($"response1: {response1.StatusCode}");
						//if(response1.StatusCode == HttpStatusCode.OK) {
						//	this.NIK = nik;
						//	this.Nama = absenRealTimeDTO.Nama;
						//	this.GrupKerja = absenRealTimeDTO.GroupKerja;
						//	this.Tanggal = absenRealTimeDTO.Tanggal.ToString("dd-MM-yyyy HH:mm:ss");
						//	this.IpMesin = absenRealTimeDTO.IpMesin.ToString();
      //            }
      //         }
            }
         }


      }

      async Task GetWhenAll(ByteArrayContent bc, string nik) {
         var absenRTTask = PostAbsenRealTime(bc);
         var absenRTTaskForPayroll = PostAbsenRealTimeForPayroll(nik);
         await Task.WhenAll(absenRTTask, absenRTTaskForPayroll);
      }

		async Task<AbsenRealTime> PostAbsenRealTime(ByteArrayContent bc) {
         bc.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
         using (HttpClient client = new HttpClient()) {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.PostAsync($"{remoteServer}/AbsenRealTime/AddAbsenRealTime", bc);
            await Task.Delay(50);
            var result = await response.Content.ReadAsStringAsync();
            AbsenRealTime absenRealTime = JsonConvert.DeserializeObject<AbsenRealTime>(result);

            return absenRealTime;
         }
      }

      async Task<Payroll> PostAbsenRealTimeForPayroll(string nik) {
         string token = Settings.Default.AuthToken;
         Payroll payroll2 = new Payroll();
         using (HttpClient client = new HttpClient()) {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync($"{remoteServer}/Gaji/NIK/{nik}");
            await Task.Delay(50);
            if (response.IsSuccessStatusCode) {
               var result = await response.Content.ReadAsStringAsync();
               GajiDanTunjangan gajiDanTunjangan = JsonConvert.DeserializeObject<GajiDanTunjangan>(result);
               if(gajiDanTunjangan != null) {
                  decimal upahHarian = Math.Round((decimal)gajiDanTunjangan.Upah / 21, 2);

                  Payroll payroll = new Payroll {
                     NIK = nik,
                     IdEmployee = (int)gajiDanTunjangan.EmployeeId,
                     EmployeeName = gajiDanTunjangan.NamaKaryawan,
                     GroupName = gajiDanTunjangan.GrupKerja,
                     DepartmentName = gajiDanTunjangan.DepartmentName,
                     Upah = gajiDanTunjangan.Upah,
                     TotalMasuk = 1,
                     Bulan = DateTime.Now.Month,
                     Tahun = DateTime.Now.Year,
                     Tgl = DateTime.Now,
                     Gaji = upahHarian,
                     CreatedBy = 1,
                     UpdatedBy = 1,
                     UpdatedAt = DateTime.Today,
                     CreatedAt = DateTime.Today,
                  };
                  //var content = JsonConvert.SerializeObject(payroll);
                  //var buffer = Encoding.UTF8.GetBytes(content);
                  //var byteContent = new ByteArrayContent(buffer);
                  var strContent = new StringContent(JsonConvert.SerializeObject(payroll), Encoding.UTF8, "application/json");
                  //using (HttpClient client2 = new HttpClient()) {
                  //   client2.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                  //   var response2 = await client2.PostAsync($"{remoteServer}/AbsenRealTime/AddAbsenRealTimeForPayroll", strContent);
                  //   if (response2.IsSuccessStatusCode) {
                  //      var result2 = await response2.Content.ReadAsStringAsync();
                  //      payroll2 = JsonConvert.DeserializeObject<Payroll>(result2);
                  //   }
                  //}

                  var response2 = await client.PostAsync($"{remoteServer}/AbsenRealTime/AddAbsenRealTimeForPayroll", strContent);
                  await Task.Delay(50);
                  if (response2.IsSuccessStatusCode) {
                     var result2 = await response2.Content.ReadAsStringAsync();
                     payroll2 = JsonConvert.DeserializeObject<Payroll>(result2);
                  }

               }
            }
            
         }
         return payroll2;
      }


      //public async Task CekJadwalKerja(string nik, string tgl) {
      //	var jadwalKerjaKaryawanTask = CariJadwalKerjaKaryawan(nik, tgl);
      //	var jadwalKerjaSecurityTask = CariJadwalKerjaSecurity(nik, tgl);

      //	await Task.WhenAll(jadwalKerjaKaryawanTask, jadwalKerjaSecurityTask);

      //	var jadwalKerjaKaryawanTaskResult = await jadwalKerjaKaryawanTask;
      //	var jadwalKerjaSecurityTaskResult = await jadwalKerjaSecurityTask;

      //	//if (jadwalKerjaKaryawanTask == null && jadwalKerjaSecurityTask == null) {
      //	//	//return null;
      //	//}

      //	KehadiranTempDTO hadir = new KehadiranTempDTO();
      //	if (jadwalKerjaKaryawanTaskResult != null && jadwalKerjaSecurityTaskResult == null) {
      //		//var jadwalKerjaKaryawan = await jadwalKerjaKaryawanTask;
      //		hadir.GrupKerja = jadwalKerjaKaryawanTaskResult.GroupName;
      //		hadir.NIK = jadwalKerjaKaryawanTaskResult.NIK;
      //		hadir.Nama = jadwalKerjaKaryawanTaskResult.NamaKaryawan;
      //		hadir.Gender = jadwalKerjaKaryawanTaskResult.Gender;
      //		hadir.Tanggal = DateTime.Now.Date;
      //		hadir.JadwalMasuk = jadwalKerjaKaryawanTaskResult.JamMasuk;
      //		hadir.JamMasuk = DateTime.Now.TimeOfDay;
      //		hadir.JadwalPulang = jadwalKerjaKaryawanTaskResult.JamPulang;
      //	}else if (jadwalKerjaKaryawanTaskResult == null && jadwalKerjaSecurityTaskResult != null) {
      //		//var jadwalKerjaSecurity = await jadwalKerjaKaryawanTask;
      //		//hadir.GrupKerja = jadwalKerjaSecurityTaskResult.GroupName;
      //		hadir.NIK = jadwalKerjaSecurityTaskResult.NIK;
      //		hadir.Nama = jadwalKerjaSecurityTaskResult.Nama;
      //		hadir.Gender = jadwalKerjaSecurityTaskResult.Gender;
      //		hadir.Tanggal = DateTime.Now.Date;
      //		hadir.JadwalMasuk = jadwalKerjaSecurityTaskResult.JadwalMasuk;
      //		hadir.JamMasuk = DateTime.Now.TimeOfDay;
      //		hadir.JadwalPulang = jadwalKerjaSecurityTaskResult.JadwalPulang;
      //	}
      //	await AddAbsen(hadir);
      //}

      //public async Task<string> AddAbsen(KehadiranTempDTO newHadir) {
      //	var content = new StringContent(JsonConvert.SerializeObject(newHadir), Encoding.UTF8, "application/json");
      //	string token = Settings.Default.AuthToken;
      //	using (HttpClient client = new HttpClient()) {
      //          client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
      //          HttpResponseMessage response = await client.PostAsync($"{remoteServer}/Kehadiran/Absen", content);
      //          var result = await response.Content.ReadAsStringAsync();
      //          var hadir = JsonConvert.DeserializeObject<KehadiranTempDTO>(result);
      //          if (hadir != null && hadir.JamPulang == null) {
      //             return $"NIK: {hadir.NIK}, Nama: {hadir.Nama}, Grup: {hadir.GrupKerja} berhasil absen masuk pada: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}";
      //          }
      //          return $"NIK: {newHadir.NIK}, Nama: {newHadir.Nama}, Grup: {newHadir.GrupKerja} berhasil absen pulang pada: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}";
      //       };

      //}

      //private async Task<JadwalKerjaKaryawanDTO> CariJadwalKerjaKaryawan(string nik, string tgl) {
      //       string token = Settings.Default.AuthToken;
      //	using (HttpClient client = new HttpClient()) {
      //          client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
      //          HttpResponseMessage response = await client.GetAsync($"{remoteServer}/JadwalKerjaKaryawan/NIKAndDate/{nik}/{tgl}");
      //          var result = await response.Content.ReadAsStringAsync();
      //          if (result == null) {
      //             return null;
      //		}
      //		else {
      //             return JsonConvert.DeserializeObject<JadwalKerjaKaryawanDTO>(result);
      //          }
      //          //JadwalKerjaKaryawanDTO jadwalKerjaKaryawanDTO = JsonConvert.DeserializeObject<JadwalKerjaKaryawanDTO>(result);
      //       }

      //}

      //private async Task<JadwalKerjaSecurityDTO> CariJadwalKerjaSecurity(string nik, string tgl) {
      //       string token = Settings.Default.AuthToken;
      //	using (HttpClient client = new HttpClient()) {
      //          client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
      //          HttpResponseMessage response = await client.GetAsync($"{localServer}/JadwalKerjaSecurity/NIKAndDate/{nik}/{tgl}");

      //          var result = await response.Content.ReadAsStringAsync();
      //          if (result == null) {
      //             return null;
      //		}
      //		else {
      //             return JsonConvert.DeserializeObject<JadwalKerjaSecurityDTO>(result);
      //          }

      //       }
      //}

      public async Task<string> GetLog(string IP, int Port, int noMesin, DateTime startDate, DateTime endDate) {
			string sdwEnrollNumber = "";
			int idwTMachineNumber = 0;
			int idwEMachineNumber = 0;
			int idwVerifyMode = 0;
			int idwInOutMode = 0;
			int idwYear = 0;
			int idwMonth = 0;
			int idwDay = 0;
			int idwHour = 0;
			int idwMinute = 0;
			int idwSecond = 0;
			int idwWorkcode = 0;

			int idwErrorCode = 0;
			int iGLCount = 0;
			int iIndex = 0;
			string msg = "";

			try {
            FDevice.EnableDevice(noMesin, false);
				contentLogMesinAbsen = new ContentLogMesinAbsen();
            if (FDevice.ReadGeneralLogData(noMesin)) {
					logMesinAbsens.Clear();
					logKehadirans.Clear();

					while (FDevice.SSR_GetGeneralLogData(noMesin, out sdwEnrollNumber, out idwVerifyMode, out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode)) {
						iGLCount++;
						string strTgl = idwYear.ToString() + "-" + (idwMonth < 10 ? "0" + idwMonth.ToString() : idwMonth.ToString()) + "-" + (idwDay < 10 ? "0" + idwDay.ToString() : idwDay.ToString());
						string strTime = (idwHour < 10 ? "0" + idwHour.ToString() : idwHour.ToString()) + ":" + (idwMinute < 10 ? "0" + idwMinute.ToString() : idwMinute.ToString()) + ":" + (idwSecond < 10 ? "0" + idwSecond.ToString() : idwSecond.ToString());

						LogKehadiran kehadiran = new LogKehadiran {
							VerifyMode = (VerifyMode)Enum.ToObject(typeof(VerifyMode), idwVerifyMode),
							NIK = sdwEnrollNumber.ToString(),
							Tgl = DateTime.ParseExact(strTgl + " " + strTime, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
							InOutMode = (InOutMode)Enum.ToObject(typeof(InOutMode), idwInOutMode)
						};
						logKehadirans.Add(kehadiran);
					}

					List<LogKehadiran> rangeHadir = logKehadirans.Where(h => h.Tgl.Date >= startDate.Date && h.Tgl.Date <= endDate.Date).OrderBy(h => h.NIK).ThenBy(h => h.Tgl).ToList();

					for(int x = 0; x <= rangeHadir.Count-1; x++) {
						if(x == 0) {
							AddLogMesin(IP, Port, noMesin, rangeHadir[x].NIK, rangeHadir[x].Tgl);
							continue;
						}
						if (rangeHadir[x].NIK == rangeHadir[x-1].NIK && rangeHadir[x].Tgl.Date == rangeHadir[x - 1].Tgl.Date) {
							TimeSpan tSpan = rangeHadir[x].Tgl.Subtract(rangeHadir[x - 1].Tgl);
							if(tSpan.TotalMinutes >= 480) {
								AddLogMesin(IP, Port, noMesin, rangeHadir[x].NIK, rangeHadir[x].Tgl);
							}
							else {
								continue;
							}
						}
						else {
							AddLogMesin(IP, Port, noMesin, rangeHadir[x].NIK, rangeHadir[x].Tgl);
						}
					}

					contentLogMesinAbsen.IpAddress = _iPAddress;
					contentLogMesinAbsen.Port = _port;
					contentLogMesinAbsen.NoMesin = _machineNumber;
					contentLogMesinAbsen.StartDate = startDate;
					contentLogMesinAbsen.EndDate = endDate;
               contentLogMesinAbsen.ListLogMesinAbsen.Clear();
               contentLogMesinAbsen.ListLogMesinAbsen.AddRange(logMesinAbsens);

               //string token = Settings.Default.AuthToken;
               //HttpClient client = new HttpClient();
               //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
               //var content = new StringContent(JsonConvert.SerializeObject(contentLogMesinAbsen), Encoding.UTF8, "application/json");
               //var contentResult = await content.ReadAsStringAsync();


               //var response = await client.PostAsync($"{localServer}/MesinAbsens/AddLogMesinAbsen", content);

               var postAbsenLog = await PostAbsenLog(contentLogMesinAbsen);
               var postAbsenLogForPayroll = await PostAbsenLogForPayroll(contentLogMesinAbsen);

               contentLogMesinAbsen.ListLogMesinAbsen.Clear();

               FDevice.EnableDevice(noMesin, true);

               //return (response.StatusCode == HttpStatusCode.OK ? msg = "Download data kehadiran berhasil." : msg = "Download data kehadiran gagal!");
               return (postAbsenLog == true && postAbsenLogForPayroll == true ? msg = "Download data kehadiran berhasil." : msg = "Download data kehadiran gagal!");
            }
				
				FDevice.EnableDevice(noMesin, true);

				return msg;
			}
			catch (Exception er) {
				msg = er.Message;
            FDevice.EnableDevice(noMesin, true);
				return msg;
			}
		}

		public async Task<string> GetLogTest(DateTime startDate, DateTime endDate) {
			string msg = "";
			List<LogKehadiran> listLogKehadiran = new List<LogKehadiran>();

			//listLogKehadiran.Add(new LogKehadiran {
			//	VerifyMode = VerifyMode.Finger_Print,
			//	InOutMode = InOutMode.Check_In,
			//	NIK = "240410018",
			//	Tgl = DateTime.ParseExact("2024-07-29 06:37:51", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
			//});
         //      listLogKehadiran.Add(new LogKehadiran {
         //         VerifyMode = VerifyMode.Finger_Print,
         //         InOutMode = InOutMode.Check_Out,
         //         NIK = "240410018",
         //         Tgl = DateTime.ParseExact("2024-07-29 15:37:51", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
         //      });

         //      listLogKehadiran.Add(new LogKehadiran {
         //         VerifyMode = VerifyMode.Finger_Print,
         //         InOutMode = InOutMode.Check_In,
         //         NIK = "240410019",
         //         Tgl = DateTime.ParseExact("2024-07-29 06:37:51", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
         //      });
         //      listLogKehadiran.Add(new LogKehadiran {
         //         VerifyMode = VerifyMode.Finger_Print,
         //         InOutMode = InOutMode.Check_Out,
         //         NIK = "240410019",
         //         Tgl = DateTime.ParseExact("2024-07-29 15:37:51", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
         //      });

         //      listLogKehadiran.Add(new LogKehadiran {
         //         VerifyMode = VerifyMode.Finger_Print,
         //         InOutMode = InOutMode.Check_In,
         //         NIK = "240410020",
         //         Tgl = DateTime.ParseExact("2024-07-29 06:37:51", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
         //      });
         //      listLogKehadiran.Add(new LogKehadiran {
         //         VerifyMode = VerifyMode.Finger_Print,
         //         InOutMode = InOutMode.Check_Out,
         //         NIK = "240410020",
         //         Tgl = DateTime.ParseExact("2024-07-29 15:37:51", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
         //      });

         for(int y = 1; y <= 26; y++) {
            string strDay = y < 10 ? $"0{y}" : $"{y}";
            string strDate = $"2024-09-{strDay}";

            listLogKehadiran.Add(new LogKehadiran {
               VerifyMode = VerifyMode.Finger_Print,
               InOutMode = InOutMode.Check_Out,
               NIK = "240410433",
               Tgl = DateTime.ParseExact($"{strDate} 07:26:51", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
            }) ;
         }

         List<LogKehadiran> rangeHadir = listLogKehadiran.Where(h => h.Tgl.Date >= startDate.Date && h.Tgl.Date <= endDate.Date).OrderBy(h => h.NIK).ThenBy(h => h.Tgl).ToList();

         for (int x = 0; x <= rangeHadir.Count - 1; x++) {
            if (x == 0) {
               AddLogMesin("192.168.94.94", 4037, 3, rangeHadir[x].NIK, rangeHadir[x].Tgl);
               continue;
            }
            if (rangeHadir[x].NIK == rangeHadir[x - 1].NIK && rangeHadir[x].Tgl.Date == rangeHadir[x - 1].Tgl.Date) {
               TimeSpan tSpan = rangeHadir[x].Tgl.Subtract(rangeHadir[x - 1].Tgl);
               if (tSpan.TotalMinutes >= 480) {
                  AddLogMesin("192.168.94.94", 4037, 3, rangeHadir[x].NIK, rangeHadir[x].Tgl);
               }
               else {
                  continue;
               }
            }
            else {
               AddLogMesin("192.168.94.94", 4037, 3, rangeHadir[x].NIK, rangeHadir[x].Tgl);
            }
         }
         contentLogMesinAbsen.StartDate = startDate;
         contentLogMesinAbsen.EndDate = endDate;
         contentLogMesinAbsen.ListLogMesinAbsen.AddRange(logMesinAbsens);

         //string token = Settings.Default.AuthToken;
         //HttpClient client = new HttpClient();
         //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

         //var content = new StringContent(JsonConvert.SerializeObject(contentLogMesinAbsen), Encoding.UTF8, "application/json");
         //var contentResult = await content.ReadAsStringAsync();

         //bool[] getWhenAll2Result = await GetWhenAll2(contentLogMesinAbsen);

         var postAbsenLog = await PostAbsenLog(contentLogMesinAbsen);
         var postAbsenLogForPayroll = await PostAbsenLogForPayroll(contentLogMesinAbsen);

         //var response = await client.PostAsync($"{localServer}/MesinAbsens/AddLogMesinAbsen", content);

         contentLogMesinAbsen.ListLogMesinAbsen.Clear();
         //return (getWhenAll2Result.All(x => x == true) == true ? msg = "Download data kehadiran berhasil." : msg = "Download data kehadiran gagal!");
         return (postAbsenLog == true && postAbsenLogForPayroll == true ? msg = "Download data kehadiran berhasil." : msg = "Download data kehadiran gagal!");
      }

      //async Task<bool[]> GetWhenAll2(ContentLogMesinAbsen cLogMesinAbsen) {
      //   var postAbsenLog = PostAbsenLog(cLogMesinAbsen);
      //   var postAbsenLogForPayroll = PostAbsenLogForPayroll(cLogMesinAbsen);
      //   var result = await Task.WhenAll(postAbsenLog, postAbsenLogForPayroll);
      //   return result;
      //}

      async Task<bool> PostAbsenLog(ContentLogMesinAbsen cma) {
         string token = Settings.Default.AuthToken;
         HttpClient client = new HttpClient();
         client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

         var content = new StringContent(JsonConvert.SerializeObject(cma), Encoding.UTF8, "application/json");
         //var contentResult = await content.ReadAsStringAsync();
         var response = await client.PostAsync($"{remoteServer}/MesinAbsens/AddLogMesinAbsen", content);
         if (response.IsSuccessStatusCode) {
            return true;
         }
         else {
            return false;
         }
         
      }

      async Task<bool> PostAbsenLogForPayroll(ContentLogMesinAbsen cma) {
         //List<LogMesinAbsen> listLogMesinAbsen = cma.ListLogMesinAbsen;
         string token = Settings.Default.AuthToken;
         List<Payroll> listPayrolls = new List<Payroll>();

         HttpClient client = new HttpClient();
         client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

         foreach (LogMesinAbsen lma in cma.ListLogMesinAbsen) {
            string tgl = lma.Tgl.ToString("yyyy-MM-dd");
            var responseJadwal = await client.GetAsync($"{remoteServer}/JadwalKehadiran/GetByNIKAndDate/{lma.NIK}/{tgl}");
            await Task.Delay(10);

            if (responseJadwal.IsSuccessStatusCode) {
               var strResultJadwal = await responseJadwal.Content.ReadAsStringAsync();
               var jadwal = JsonConvert.DeserializeObject<JadwalKehadiran>(strResultJadwal);
               if (jadwal != null && jadwal.LockedMasuk == true && jadwal.Up == true) {
                  string nik = jadwal.NIK;
                  var responseGaji = await client.GetAsync($"{remoteServer}/Gaji/NIK/{nik}");
                  await Task.Delay(10);
                  if (responseGaji.IsSuccessStatusCode) {
                     var resultGaji = await responseGaji.Content.ReadAsStringAsync();
                     var gajiDanTunjangan = JsonConvert.DeserializeObject<GajiDanTunjangan>(resultGaji);
                     decimal upahHarian = Math.Round((decimal)gajiDanTunjangan.Upah / 21, 2);
                     Payroll payroll = new Payroll {
                        NIK = nik,
                        IdEmployee = (int)gajiDanTunjangan.EmployeeId,
                        EmployeeName = gajiDanTunjangan.NamaKaryawan,
                        GroupName = gajiDanTunjangan.GrupKerja,
                        DepartmentName = gajiDanTunjangan.DepartmentName,
                        Upah = gajiDanTunjangan.Upah,
                        TotalMasuk = 1,
                        Bulan = lma.Tgl.Month,
                        Tahun = lma.Tgl.Year,
                        Gaji = upahHarian,
                        CreatedBy = 1,
                        UpdatedBy = 1,
                        UpdatedAt = DateTime.Today,
                        CreatedAt = DateTime.Today,
                     };
                     listPayrolls.Add(payroll);
                  }
               }
            }
            
         }

         var strContentPayroll = new StringContent(JsonConvert.SerializeObject(listPayrolls), Encoding.UTF8, "application/json");
         await client.PostAsync($"{remoteServer}/Payroll/PostPayrollRange", strContentPayroll);
         await Task.Delay(10);
         return true;
      }

      public async Task SaveAddAbsenRTTest() {
			string nik = "240410015";
         string token = Settings.Default.AuthToken;
			using (HttpClient client = new HttpClient()) {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync($"{remoteServer}/Employees/NIK/{nik}");
            Console.WriteLine($"response: {response.StatusCode}");
            if (response.StatusCode == HttpStatusCode.OK) {
               var result = await response.Content.ReadAsStringAsync();
               EmployeeTempDTO empTempDTO = JsonConvert.DeserializeObject<EmployeeTempDTO>(result);
					AbsenRealTimeDTO absenRealTimeDTO = new AbsenRealTimeDTO {
						Id = 0,
						NIK = empTempDTO.NIK,
						Nama = empTempDTO.Name,
						Gender = empTempDTO.Gender,
						GroupKerja = empTempDTO.GroupName,
						Tanggal = DateTime.Now,
						IpMesin = "192.168.94.94",
						Port = 4037,
						NoMesin = 3
					};
               var content = JsonConvert.SerializeObject(absenRealTimeDTO);
               var buffer = System.Text.Encoding.UTF8.GetBytes(content);
               var byteContent = new ByteArrayContent(buffer);
               byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
					using (HttpClient client2 = new HttpClient()) {
						client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
						var response1 = await client.PostAsync($"{remoteServer}/AbsenRealTime/AddAbsenRealTime", byteContent);
						if (response1.StatusCode == HttpStatusCode.OK) {
							this.NIK = nik;
							this.Nama = absenRealTimeDTO.Nama;
							this.GrupKerja = absenRealTimeDTO.GroupKerja;
							this.Tanggal = absenRealTimeDTO.Tanggal.ToString("dd-MM-yyyy HH:mm:ss");
							this.IpMesin = absenRealTimeDTO.IpMesin.ToString();
						}
					}
            }
         }
      }

		private void AddLogMesin(string ip, int port, int noMesin, string nik, DateTime tgl) {
			LogMesinAbsen lMesinAbsen = new LogMesinAbsen {
				IPMesin = ip,
				PortMesin = port,
				NoMesin = noMesin,
				NIK = nik,
				Tgl = tgl
			};
			logMesinAbsens.Add(lMesinAbsen);
		}

		public void DisconnectNet() {
			FDevice.Disconnect();
			FDevice.OnAttTransactionEx -= new _IZKEMEvents_OnAttTransactionExEventHandler(MesinAbsen_OnAttTransactionEx);
		}

   }

}
