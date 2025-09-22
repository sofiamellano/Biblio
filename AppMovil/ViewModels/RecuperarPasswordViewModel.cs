using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppMovil.ViewModels
{
    public partial class RecuperarPasswordViewModel : ObservableObject
    {
        [ObservableProperty]
        private string mail = string.Empty;

        [ObservableProperty]
        private bool isBusy = false;

        [ObservableProperty]
        private string errorMessage = string.Empty;

        [ObservableProperty]
        private string successMessage = string.Empty;

        public IRelayCommand EnviarCommand { get; }
        public IRelayCommand VolverCommand { get; }

        public RecuperarPasswordViewModel()
        {
            EnviarCommand = new AsyncRelayCommand(OnEnviar, CanEnviar);
            VolverCommand = new AsyncRelayCommand(OnVolver);
        }

        private bool CanEnviar()
        {
            return !IsBusy && !string.IsNullOrWhiteSpace(mail);
        }

        private async Task OnEnviar()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                ErrorMessage = string.Empty;
                SuccessMessage = string.Empty;

                // Validaci�n b�sica de email
                if (!Mail.Contains("@") || !Mail.Contains("."))
                {
                    ErrorMessage = "Por favor, ingrese un correo electr�nico v�lido";
                    return;
                }

                // TODO: Implementar l�gica de recuperaci�n de contrase�a
                await Task.Delay(2000); // Simular llamada al servidor

                SuccessMessage = "Se han enviado las instrucciones a tu correo electr�nico";
                
                // Opcional: Volver al login despu�s de unos segundos
                await Task.Delay(2000);
                await OnVolver();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error al enviar las instrucciones: {ex.Message}";
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task OnVolver()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        // Notificar cambios para revalidar el comando
        partial void OnEmailChanged(string value) => EnviarCommand.NotifyCanExecuteChanged();
    }
}