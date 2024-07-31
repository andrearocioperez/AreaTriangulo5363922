using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace AreaTriangulo5363922.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        public double l1;

        [ObservableProperty]
        public double l2;

        [ObservableProperty]
        public double l3;

        [ObservableProperty]
        public double s;

        [ObservableProperty]
        public string resultado;

        [RelayCommand]
        public void Area()
        {
            if (double.TryParse(L1.ToString(),out double lado1) && double.TryParse(L2.ToString(), out double lado2) && double.TryParse(L3.ToString(), out double lado3))
            {
                double S = (L1 + L2 + L3) / 2;

                double A =  (S*(S - L1) * (S - L2) * (S - L3));

                double total = Math.Sqrt(A);

                Resultado = $"Área: {total:F2} metros cuadrados";

            }
            else
            {
                
            }

        }
    }
}
