using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo10195594.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double lado1;

        [ObservableProperty]
        private double lado2;

        [ObservableProperty]
        private double lado3;

        [ObservableProperty]
        private double multiplicacion;

        [ObservableProperty]
        private double superficie;

        [ObservableProperty]
        private double areaTot;

        [RelayCommand]
        private void TrianguloArea()
        {
            Superficie = (Lado1 + Lado2 + Lado3) / 2;

            Multiplicacion = Superficie * (Superficie - Lado1) * (Superficie - Lado2) * (Superficie - Lado3);

            AreaTot = Math.Sqrt(Multiplicacion);
        }
    }
}
