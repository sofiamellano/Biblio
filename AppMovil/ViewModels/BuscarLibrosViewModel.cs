using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Service.Models;
using Service.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppMovil.ViewModels
{
    public partial class BuscarLibrosViewModel : ObservableObject
    {
        GenericService<Libro> _libroService = new GenericService<Libro>();

        [ObservableProperty]
        //[NotifyCanExecuteChangedFor(nameof(BuscarCommand))]
        private string searchText = string.Empty;

        [ObservableProperty]
        private bool isBusy;
        private readonly List<string> _todosLosLibros;

        [ObservableProperty]
        private ObservableCollection<Libro> libros = new();
        public IRelayCommand BuscarCommand { get; }
        public IRelayCommand LimpiarCommand { get; }

        public BuscarLibrosViewModel()
        {
            BuscarCommand = new RelayCommand(OnBuscar);
            _= InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            OnBuscar();
        }

        partial void OnSearchTextChanged(string value)
        {
            if (string.IsNullOrEmpty(value)) OnBuscar();
        }

        private async void OnBuscar()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var libro = await _libroService.GetAllAsync(SearchText);
                Libros = new ObservableCollection<Libro>(libro ?? new List<Libro>());
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
