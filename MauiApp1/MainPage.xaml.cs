namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)

        {

            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string marca = marcaEntry.Text;
                string modelo = modeloEntry.Text;

                string combustivelCompensando = "";

                if (etanol <= (gasolina * 0.7))
                {
                    combustivelCompensando = "O etanol está compensando";
                }
                else
                {
                    combustivelCompensando = "A gasolina está compensando";
                }

                string mensagemFinal = $"{combustivelCompensando} para o seu {marca} {modelo}.";

                await DisplayAlert("Resultado", mensagemFinal, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Fechar");
            }
        }
        //FECHA METODO
    } //FECHA CLASS

} //FECHA NAMESPACE
