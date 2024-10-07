using KehadiranAPI.Classes;
using KehadiranAPI.Data;
using KehadiranAPI.Model;
using KehadiranAPI.RabbitMQ;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SKM.Shared.Dtos;
using System.Text;

namespace KehadiranAPI.Services {
	public class LogMesinAbsenConsumerBackgroundService : BackgroundService {
		private readonly IServiceScopeFactory _factory;
		private readonly LogMesinAbsenConsumer _consumer;

		public LogMesinAbsenConsumerBackgroundService(IServiceScopeFactory factory, LogMesinAbsenConsumer consumer) {
			_factory = factory;
			_consumer = consumer;
		}

		protected override Task ExecuteAsync(CancellationToken stoppingToken) {
			_consumer.AddListener("logMesinAbsen", async (_, args) => {
				using (var scope = _factory.CreateScope()) {
					var dbContextKehadiran = scope.ServiceProvider.GetService<DbContextKehadiran>();
					var body = args.Body.ToArray();
					var json = Encoding.UTF8.GetString(body);
					var data = JsonConvert.DeserializeObject<ContentLogMesinAbsen>(json);

					List<LogMesinAbsen> listLogMesinAbsen = data?.ListLogMesinAbsen!;

					foreach(LogMesinAbsen log in listLogMesinAbsen) {
						JadwalKehadiran? jadwalMasuk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == log.NIK && j.JadwalMasuk!.Value.Date == log.Tgl.Date && j.LockedMasuk == false).FirstOrDefaultAsync();
						if(jadwalMasuk != null) {
							if(jadwalMasuk.JadwalMasuk!.Value.TimeOfDay > log.Tgl.TimeOfDay || log.Tgl.TimeOfDay.Subtract(jadwalMasuk.JadwalMasuk!.Value.TimeOfDay).TotalMinutes <= 4 * 60) {
								jadwalMasuk.JamMasuk = log.Tgl;
								jadwalMasuk.LockedMasuk = true;
								jadwalMasuk.Keterangan = jadwalMasuk.JadwalMasuk!.Value.TimeOfDay >= log.Tgl.TimeOfDay ? "Tepat Waktu" : "Terlambat";
								jadwalMasuk.Terlambat = jadwalMasuk.JadwalMasuk!.Value.TimeOfDay >= log.Tgl.TimeOfDay ? TimeSpan.Parse("00:00:00") : log.Tgl.TimeOfDay.Subtract(jadwalMasuk.JadwalMasuk!.Value.TimeOfDay);
								jadwalMasuk.Up = true;

								dbContextKehadiran.JadwalKehadirans.Update(jadwalMasuk);
								await dbContextKehadiran.SaveChangesAsync();
							}else if (log.Tgl.TimeOfDay.Subtract(jadwalMasuk.JadwalMasuk!.Value.TimeOfDay).TotalMinutes >= 8 * 60) {
                        jadwalMasuk!.JamPulang = log.Tgl;
                        jadwalMasuk!.LockedPulang = true;
                        dbContextKehadiran.JadwalKehadirans.Update(jadwalMasuk);
                        await dbContextKehadiran.SaveChangesAsync();
                     }
                  }
                  else {
							JadwalKehadiran? jadwalPulang = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == log.NIK && j.JadwalPulang!.Value.Date == log.Tgl.Date && j.LockedPulang == false).FirstOrDefaultAsync();
							if(jadwalPulang != null) {
								jadwalPulang!.JamPulang = log.Tgl;
								jadwalPulang!.LockedPulang = true;
                        dbContextKehadiran.JadwalKehadirans.Update(jadwalPulang);
                        await dbContextKehadiran.SaveChangesAsync();
                     }
                  }
					}

					//for(int x = 1; x < listLogMesinAbsen.Count; x++) {
					//	LogMesinAbsen currentRow = listLogMesinAbsen[x];
					//	LogMesinAbsen previousRow = listLogMesinAbsen[x - 1];
					//	bool NIKSama = currentRow.NIK == previousRow.NIK;
					//}


					//for(int x = 1; x < listLogMesinAbsen.Count; x++) {
					//	//if(x > 0) {
					//		if (listLogMesinAbsen[x].NIK == listLogMesinAbsen[x - 1].NIK) {
					//			if (listLogMesinAbsen[x].Tgl.Date == listLogMesinAbsen[x - 1].Tgl.Date) {
					//				string nik = listLogMesinAbsen[x - 1].NIK!;
					//				DateTime jamMasuk = listLogMesinAbsen[x - 1].Tgl;
					//				DateTime jamPulang = listLogMesinAbsen[x].Tgl;

					//				JadwalKehadiran? jk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == jamMasuk.Date).SingleOrDefaultAsync();
					//				if (jk != null) {
					//					jk!.JamMasuk = jamMasuk;
					//					jk!.LockedMasuk = true;
					//					jk!.Status = (jk.JadwalMasuk!.Value.TimeOfDay < jamMasuk.TimeOfDay ? "Terlambat" : "Tepat Waktu");
					//					jk!.Terlambat = (jamMasuk.TimeOfDay > jk.JadwalMasuk.Value.TimeOfDay ? jamMasuk.TimeOfDay.Subtract(jk.JadwalMasuk.Value.TimeOfDay) : TimeSpan.Parse("00:00:00"));
					//					jk!.JamPulang = jamPulang;
					//					jk!.LockedPulang = true;
					//					jk!.Up = true;
					//					dbContextKehadiran.JadwalKehadirans.Update(jk);
					//					await dbContextKehadiran.SaveChangesAsync();
					//				}
					//			}
					//			else if(listLogMesinAbsen[x].Tgl.Subtract(listLogMesinAbsen[x - 1].Tgl).TotalMinutes >= 60 * 12) {
					//				string nik = listLogMesinAbsen[x].NIK!;
					//				DateTime jamMasuk = listLogMesinAbsen[x - 1].Tgl;

					//				JadwalKehadiran? jk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == listLogMesinAbsen[x].Tgl.Date).SingleOrDefaultAsync();
					//				if (jk != null) {
					//					jk!.JamMasuk = jamMasuk;
					//					jk!.LockedMasuk = true;
					//					jk!.Status = (jk.JadwalMasuk!.Value.TimeOfDay < listLogMesinAbsen[x].Tgl.TimeOfDay ? "Terlambat" : "Tepat Waktu");
					//					jk!.Terlambat = (jamMasuk.TimeOfDay > jk.JadwalMasuk.Value.TimeOfDay ? jamMasuk.TimeOfDay.Subtract(jk.JadwalMasuk.Value.TimeOfDay) : TimeSpan.Parse("00:00:00"));
					//					jk!.Up = true;
					//					dbContextKehadiran.JadwalKehadirans.Update(jk);
					//					await dbContextKehadiran.SaveChangesAsync();
					//				}
					//			}else if (listLogMesinAbsen[x].Tgl.Subtract(listLogMesinAbsen[x - 1].Tgl).TotalMinutes >= 60 * 8) {
					//				string nik = listLogMesinAbsen[x].NIK!;
					//				DateTime jamPulang = listLogMesinAbsen[x].Tgl;

					//				JadwalKehadiran? jk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == listLogMesinAbsen[x - 1].Tgl.Date).SingleOrDefaultAsync();
					//				if (jk != null) {
					//					jk!.JamPulang = jamPulang;
					//					jk!.LockedPulang = true;
					//					dbContextKehadiran.JadwalKehadirans.Update(jk);
					//					await dbContextKehadiran.SaveChangesAsync();
					//				}
					//			}
					//		}
					//		else {
					//			string nik = listLogMesinAbsen[x].NIK!;
					//			DateTime tgl = listLogMesinAbsen[x].Tgl!.Date;

					//			JadwalKehadiran? jk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == tgl.Date).SingleOrDefaultAsync();

					//			if(jk != null) {
					//				if(tgl.Subtract(jk.JadwalMasuk!.Value).TotalMinutes <= 4 * 60) {
					//					jk!.JamMasuk = tgl;
					//					jk!.LockedMasuk = true;
					//					jk!.Status = (jk.JadwalMasuk!.Value.TimeOfDay < tgl.TimeOfDay ? "Terlambat" : "Tepat Waktu");
					//					jk!.Terlambat = (tgl.TimeOfDay > jk.JadwalMasuk.Value.TimeOfDay ? tgl.TimeOfDay.Subtract(jk.JadwalMasuk.Value.TimeOfDay) : TimeSpan.Parse("00:00:00"));
					//					jk!.Up = true;
					//					dbContextKehadiran.JadwalKehadirans.Update(jk);
					//					await dbContextKehadiran.SaveChangesAsync();
					//				}
					//				else {
					//					jk!.JamPulang = tgl;
					//					jk!.LockedPulang = true;
					//					dbContextKehadiran.JadwalKehadirans.Update(jk);
					//					await dbContextKehadiran.SaveChangesAsync();
					//				}
					//			}

					//		}
					//	//}

					//	//if (listLogMesinAbsen[x].NIK == listLogMesinAbsen[x-1].NIK && listLogMesinAbsen[x].Tgl.Date == listLogMesinAbsen[x-1].Tgl.Date) {
					//	//	string nik = listLogMesinAbsen[x].NIK!;
					//	//	DateTime jamMasuk = listLogMesinAbsen[x-1].Tgl;
					//	//	DateTime jamPulang = listLogMesinAbsen[x].Tgl;

					//	//	JadwalKehadiran? jk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == listLogMesinAbsen[x - 1].Tgl.Date).SingleOrDefaultAsync();
					//	//	if(jk != null) {
					//	//		jk!.JamMasuk = jamMasuk;
					//	//		jk!.LockedMasuk = true;
					//	//		jk!.Status = (jk.JadwalMasuk!.Value.TimeOfDay < listLogMesinAbsen[x - 1].Tgl.TimeOfDay ? "Terlambat" : "Tepat Waktu");
					//	//		jk!.Terlambat = (jamMasuk.TimeOfDay > jk.JadwalMasuk.Value.TimeOfDay ? jamMasuk.TimeOfDay.Subtract(jk.JadwalMasuk.Value.TimeOfDay) : TimeSpan.Parse("00:00:00"));
					//	//		jk!.JamPulang = jamPulang;
					//	//		jk!.LockedPulang = true;
					//	//		jk!.Up = true;
					//	//		dbContextKehadiran.JadwalKehadirans.Update(jk);
					//	//		await dbContextKehadiran.SaveChangesAsync();
					//	//	}
					//	//}
					//	//else {
					//	//	if (listLogMesinAbsen[x].Tgl.Subtract(listLogMesinAbsen[x-1].Tgl).TotalMinutes >= 60 * 12) {
					//	//		string nik = listLogMesinAbsen[x].NIK!;
					//	//		DateTime jamMasuk = listLogMesinAbsen[x].Tgl;

					//	//		JadwalKehadiran? jk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == listLogMesinAbsen[x].Tgl.Date).SingleOrDefaultAsync();
					//	//		if(jk != null) {
					//	//			jk!.JamMasuk = jamMasuk;
					//	//			jk!.LockedMasuk = true;
					//	//			jk!.Status = (jk.JadwalMasuk!.Value.TimeOfDay < listLogMesinAbsen[x].Tgl.TimeOfDay ? "Terlambat" : "Tepat Waktu");
					//	//			jk!.Terlambat = (jamMasuk.TimeOfDay > jk.JadwalMasuk.Value.TimeOfDay ? jamMasuk.TimeOfDay.Subtract(jk.JadwalMasuk.Value.TimeOfDay) : TimeSpan.Parse("00:00:00"));
					//	//			jk!.Up = true;
					//	//			dbContextKehadiran.JadwalKehadirans.Update(jk);
					//	//			await dbContextKehadiran.SaveChangesAsync();
					//	//		}
					//	//	}
					//	//	else {
					//	//		if (listLogMesinAbsen[x].Tgl.Subtract(listLogMesinAbsen[x - 1].Tgl).TotalMinutes >= 60 * 8) {
					//	//			string nik = listLogMesinAbsen[x-1].NIK!;
					//	//			DateTime jamPulang = listLogMesinAbsen[x-1].Tgl;

					//	//			JadwalKehadiran? jk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == listLogMesinAbsen[x-1].Tgl.Date).SingleOrDefaultAsync();
					//	//			if(jk != null) {
					//	//				jk!.JamPulang = jamPulang;
					//	//				jk!.LockedPulang = true;
					//	//				jk!.Up = true;
					//	//				dbContextKehadiran.JadwalKehadirans.Update(jk);
					//	//				await dbContextKehadiran.SaveChangesAsync();
					//	//			}
					//	//		}
					//	//	}
					//	//}
					//}

					//foreach (LogMesinAbsen dataLogMesinAbsen in listLogMesinAbsen!) {
					//	JadwalKehadiran? cariJadwalKemarin = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == dataLogMesinAbsen!.NIK && j.JadwalMasuk!.Value.Date == dataLogMesinAbsen.Tgl.Date.AddDays(-1) && j.JamMasuk != null && j.JamPulang == null && j.LockedPulang == false).FirstOrDefaultAsync();
					//	if (cariJadwalKemarin != null) {
					//		cariJadwalKemarin.JamPulang = dataLogMesinAbsen!.Tgl;
					//		cariJadwalKemarin.LockedPulang = true;
					//		dbContextKehadiran.JadwalKehadirans.Update(cariJadwalKemarin);
					//		await dbContextKehadiran.SaveChangesAsync();
					//	}
					//	else {
					//		JadwalKehadiran? cariJadwalHariIni = await dbContextKehadiran.JadwalKehadirans.Where(j => j.NIK == dataLogMesinAbsen!.NIK && j.JadwalMasuk!.Value.Date == dataLogMesinAbsen.Tgl.Date && j.LockedPulang == false).FirstOrDefaultAsync();
					//		if (cariJadwalHariIni != null) {
					//			TimeSpan selisih = dataLogMesinAbsen!.Tgl.TimeOfDay.Subtract(cariJadwalHariIni.JadwalMasuk!.Value.TimeOfDay);
					//			if (cariJadwalHariIni.JamMasuk != null && dataLogMesinAbsen!.Tgl.TimeOfDay.Subtract(cariJadwalHariIni.JadwalMasuk!.Value.TimeOfDay).TotalMinutes >= 480 && cariJadwalHariIni.LockedPulang == false) {
					//				cariJadwalHariIni.JamPulang = dataLogMesinAbsen!.Tgl;
					//				cariJadwalHariIni.LockedPulang = true;
					//				dbContextKehadiran.JadwalKehadirans.Update(cariJadwalHariIni);
					//				await dbContextKehadiran.SaveChangesAsync();
					//			}
					//			else {
					//				if (cariJadwalHariIni.JadwalMasuk!.Value.Subtract(dataLogMesinAbsen!.Tgl).TotalMinutes <= 90 && cariJadwalHariIni.LockedMasuk == false) {
					//					cariJadwalHariIni.JamMasuk = dataLogMesinAbsen!.Tgl;
					//					cariJadwalHariIni.Status = (cariJadwalHariIni.JadwalMasuk!.Value.TimeOfDay < dataLogMesinAbsen.Tgl.TimeOfDay ? "Terlambat" : "Tepat Waktu");
					//					cariJadwalHariIni.Terlambat = (dataLogMesinAbsen.Tgl.TimeOfDay > cariJadwalHariIni.JadwalMasuk.Value.TimeOfDay ? dataLogMesinAbsen.Tgl.TimeOfDay.Subtract(cariJadwalHariIni.JadwalMasuk.Value.TimeOfDay) : TimeSpan.Parse("00:00:00"));
					//					cariJadwalHariIni.LockedMasuk = true;
					//					cariJadwalHariIni.LockedPulang = false;
					//					cariJadwalHariIni.Up = true;
					//					dbContextKehadiran.JadwalKehadirans.Update(cariJadwalHariIni);
					//					await dbContextKehadiran.SaveChangesAsync();
					//				}
					//			}
					//		}
					//	}

					//}

				}
			});
			return Task.CompletedTask;
		}
	}
}
