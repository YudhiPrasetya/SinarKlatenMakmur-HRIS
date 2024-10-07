using HRIS.Components.CustomErrors;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Net;
using Toolbelt.Blazor;

namespace HRIS {
   public class HttpInterceptorService {
      private readonly HttpClientInterceptor _interceptor;
      private readonly NavigationManager _navigationManager;
      private readonly IDialogService _dialogService;

      //private readonly IDialogService _dialogService;
      DialogParameters _dialogParameters;

      public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navigationManager, IDialogService dialogService)
        {
         this._interceptor = interceptor;
         this._navigationManager = navigationManager;
         this._dialogService = dialogService;
         _dialogParameters = new DialogParameters();
         //this._dialogService = dialogService;
      }

      public void RegisterEvent() => _interceptor.AfterSend += InterceptResponseAsync;

      private void InterceptResponseAsync(object sender, HttpClientInterceptorEventArgs e) {
         if (!e.Response.IsSuccessStatusCode) {
            var statusCode = e.Response.StatusCode;
            string msg;
            var options = new DialogOptions {
               Position = DialogPosition.Center,
               ClassBackground = "backdrop-filter: blur(10px);",
               CloseButton = false,
               CloseOnEscapeKey = false,
               FullWidth = true,
               MaxWidth = MaxWidth.Small
            };
            
            switch (statusCode) {
               case HttpStatusCode.NotFound:
               //_navigationManager.NavigateTo("/NotFound");
               msg = "Halaman yang diminta tidak ada!";
               _dialogParameters.Add("Message", msg);
               _dialogService.ShowAsync<CustomError>("Forbidden", _dialogParameters, options);
               break;

               case HttpStatusCode.Unauthorized:
               //_navigationManager.NavigateTo("/unauthorized");
               msg = "User dilarang mengakses halaman ini!";

               break;

               case HttpStatusCode.Forbidden:
               msg = "User dilarang mengakses halaman ini!";
               _dialogParameters.Add("Message", msg);
               _dialogService.ShowAsync<CustomError>("Forbidden", _dialogParameters, options);
               break;

               default:
               _navigationManager.NavigateTo("/500");
               msg = "Something went wrong, please contact the administrator or programmer.";
               _dialogService.ShowAsync<CustomError>("Forbidden", _dialogParameters, options);
               break;
            }
            throw new HttpResponseException(msg);
         }
      }

      public void DisposeEvent() => _interceptor.AfterSend -= InterceptResponseAsync;
    }
}
