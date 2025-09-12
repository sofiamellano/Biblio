using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using Microsoft.Extensions.Configuration;
using Service.Interfaces;
using Service.Services;
using Service.DTOs;

namespace AppMovil.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        AuthService _authService;
        UsuarioService _usuarioService;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string username = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string password = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private bool isBusy;

        [ObservableProperty]
        private string errorMessage = string.Empty;

        public IRelayCommand LoginCommand { get; }


        public LoginViewModel()
        {
            _authService = new AuthService();
            _usuarioService = new UsuarioService();
            LoginCommand = new RelayCommand(OnLogin, CanLogin);
        }
        
        private bool CanLogin()
        {
            return !IsBusy &&
                   !string.IsNullOrWhiteSpace(Username) &&
                   !string.IsNullOrWhiteSpace(Password);
        }

        private async void OnLogin()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                ErrorMessage = string.Empty;

                var response = await _authService.Login(new LoginDTO
                {
                    Username = Username,
                    Password = Password
                });

                if (!response)
                {
                    ErrorMessage = "Usuario o Contrase�a incorrecto";
                    return;
                }

                var usuario = await _usuarioService.GetByEmailAsync(username);
                if ( usuario == null)
                {
                    ErrorMessage = "No se pudo obtener la informaci�n del usuario.";
                    return;
                }

                // PERMITE CUALQUIER USUARIO/CONTRASE�A durante desarrollo
                // Solo requiere que no est�n vac�os
                if (Application.Current?.MainPage is AppShell shell)
                {
                    shell.SetLoginState(true);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error al iniciar sesi�n: {ex.Message}";
            }
            finally
            {
                IsBusy = false;
            }
        }

        partial void OnErrorMessageChanged(string? oldValue, string newValue)
        {
            if (!string.IsNullOrEmpty(newValue))
            {
                // Mostrar una alerta cuando ErrorMessage cambie a un valor no vac�o
                Application.Current?.MainPage?.DisplayAlert("Error de Login", newValue, "OK");
            }
        }
    }
}