using GroupAPI.Model;
using SKM.Shared.Dtos;

namespace GroupAPI.Conversions {
	public static class GroupConversions {
		public static IEnumerable<GroupDTO> ConvertToDtO(this IEnumerable<Group> groups) {
			return (from g in groups 
					  select new GroupDTO {
							GroupID= g.GroupID,
							GroupDesc= g.GroupDesc,
							IsActive= g.IsActive,
							CreatedAt= g.CreatedAt,
							CreatedBy= g.CreatedBy
						}).ToList<GroupDTO>();
		}

		public static GroupDTO ConvertToDTO(this Group g) {
			return new GroupDTO {
				GroupID=g.GroupID,
				GroupDesc=g.GroupDesc,
				IsActive= g.IsActive,
				CreatedAt= g.CreatedAt,
				CreatedBy= g.CreatedBy
			};
		}

		public static IEnumerable<Group> ConvertToModel(this IEnumerable<GroupDTO> groupDTOs) {
			return (from groupDTO in groupDTOs
					  select new Group {
						  GroupID= groupDTO.GroupID,
						  GroupDesc= groupDTO.GroupDesc,
						  IsActive= groupDTO.IsActive,
						  CreatedBy= groupDTO.CreatedBy,
						  CreatedAt = groupDTO.CreatedAt
					  }).ToList();
		}

		public static Group ConvertToModel(this GroupDTO groupDTO) {
			return new Group {
				GroupID= groupDTO.GroupID,
				GroupDesc= groupDTO.GroupDesc,
				IsActive= groupDTO.IsActive,
				CreatedBy= groupDTO.CreatedBy,
				CreatedAt= groupDTO.CreatedAt
			};
		}

	}
}
