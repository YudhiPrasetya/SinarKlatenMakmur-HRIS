using MesinAbsenAPI.Models;
using SKM.Shared.Dtos;
using System.Runtime.Intrinsics.X86;

namespace MesinAbsenAPI.Conversions {
	public static class LogMesinAbsenConversion {
		public static IEnumerable<LogMesinAbsenDTO> ConvertToDTO(this IEnumerable<LogMesinAbsen> logMesinAbsens) {
			return (from lma in logMesinAbsens select new LogMesinAbsenDTO {
				//id = lma.id,
				IPMesin = lma.IPMesin,
				PortMesin = lma.PortMesin,
				NoMesin = lma.NoMesin,
				NIK = lma.NIK,
				Tgl = lma.Tgl
			}).ToList();
		}

		public static LogMesinAbsenDTO ConvertToDTO(this LogMesinAbsen lma){
			return new LogMesinAbsenDTO {
			//id = lma.id,
			IPMesin = lma.IPMesin,
			PortMesin = lma.PortMesin,
			NoMesin = lma.NoMesin,
			NIK = lma.NIK,
			Tgl = lma.Tgl
			};
		}

		public static IEnumerable<LogMesinAbsen> ConvertToModel(this IEnumerable<LogMesinAbsenDTO> logMesinAbsenDTOs) {
			return (from logMesinAbsenDTO in logMesinAbsenDTOs
					  select new LogMesinAbsen {
						  //id = logMesinAbsenDTO.id,
						  IPMesin = logMesinAbsenDTO.IPMesin,
						  PortMesin = logMesinAbsenDTO.PortMesin,
						  NoMesin = logMesinAbsenDTO.NoMesin,
						  NIK = logMesinAbsenDTO.NIK,
						  Tgl = logMesinAbsenDTO.Tgl
					  }).ToList();
		}

		public static LogMesinAbsen ConvertToModel(this LogMesinAbsenDTO logMesinAbsenDTO) {
			return new LogMesinAbsen {
				//id = logMesinAbsenDTO.id,
				IPMesin = logMesinAbsenDTO.IPMesin,
				PortMesin = logMesinAbsenDTO.PortMesin,
				NoMesin = logMesinAbsenDTO.NoMesin,
				NIK = logMesinAbsenDTO.NIK,
				Tgl = logMesinAbsenDTO.Tgl
			};
		}
	}
}
