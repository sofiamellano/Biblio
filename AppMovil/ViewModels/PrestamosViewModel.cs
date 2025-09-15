using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Service.Models;
using Service.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace AppMovil.ViewModels
{
    public partial class PrestamosViewModel : ObservableObject
    {
        PrestamoService _prestamoService = new();

        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private string mensajeVacio = "No tienes pr�stamos activos";

        public bool TienePrestamos => Prestamos.Count > 0;

        [ObservableProperty]
        private ObservableCollection<Prestamo> prestamos = new();
        public IRelayCommand GetAllCommand { get; }

        private int _idUserLogin;

        public PrestamosViewModel()
        {
            GetAllCommand = new RelayCommand(OnGetAll);
            _idUserLogin = Preferences.Get("UserLoginId", 0);
            _ = InicializeAsync();
        }

        private async Task InicializeAsync()
        {
            OnGetAll();
        }

        private async void OnGetAll()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var prestamos = await _prestamoService.GetByUsuarioAsync(_idUserLogin);
                Prestamos = new ObservableCollection<Prestamo>(prestamos ?? new List<Prestamo>());
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
