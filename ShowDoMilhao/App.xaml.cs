namespace ShowDoMilhao
{
    public partial class App : Application
    { 
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é nome ao estado dá água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa {Correta = false, Descricao = "GASOSO" },
                    new Alternativa {Correta = false, Descricao = "SÓLIDO" },
                    new Alternativa {Correta = false, Descricao = "VAPOROSO" },
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é nome ao estado dá água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa {Correta = false, Descricao = "GASOSO" },
                    new Alternativa {Correta = false, Descricao = "SÓLIDO" },
                    new Alternativa {Correta = false, Descricao = "VAPOROSO" },
            },
        },

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

       
    }
}
