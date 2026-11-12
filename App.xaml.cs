namespace appHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto { Descricao = "Suíte Super Luxo", ValorDiariaAdulto = 110.0, ValorDiariaCrianca = 55.0 },
            new Quarto { Descricao = "Suíte Luxo",       ValorDiariaAdulto = 80.0,  ValorDiariaCrianca = 40.0 },
            new Quarto { Descricao = "Suíte Single",     ValorDiariaAdulto = 50.0,  ValorDiariaCrianca = 25.0 },
            new Quarto { Descricao = "Suíte Crise",      ValorDiariaAdulto = 25.0,  ValorDiariaCrianca = 12.5 }
        };

        public App()
        {
            InitializeComponent();

            // O novo visual foi pensado para o tema claro
            UserAppTheme = AppTheme.Light;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // A tela inicial agora é a nova tela de boas-vindas
            var window = new Window(new NavigationPage(new Views.BemVindo()));

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }

    // Modelo do quarto (fica aqui para não precisar da pasta Models)
    public class Quarto
    {
        public string Descricao { get; set; } = string.Empty;
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
    }
}
