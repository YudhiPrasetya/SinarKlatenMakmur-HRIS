using RuleAPI.Model;
using SKM.Shared.Dtos;

namespace RuleAPI.Conversions {
   public static class ScopeConversions {
      public static IEnumerable<ScopeDTO> ConvertToDTO(this IEnumerable<Scopes> scopes) {
         return (from s in scopes select new ScopeDTO {
            ScopeId = s.ScopeId,
            GroupIcon = s.GroupIcon,
            GroupTitle = s.GroupTitle,
            MenuIcon = s.MenuIcon,
            MenuTitle = s.MenuTitle,
            Route = s.Route,
            Scope = s.Scope,
         }).ToList();
      }

      public static ScopeDTO ConvertToDTO(this Scopes s) {
         return new ScopeDTO {
            ScopeId = s.ScopeId,
            GroupIcon = s.GroupIcon,
            GroupTitle = s.GroupTitle,
            MenuIcon = s.MenuIcon,
            MenuTitle = s.MenuTitle,
            Route = s.Route,
            Scope = s.Scope,
         };
      }
   }
}
