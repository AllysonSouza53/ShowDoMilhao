namespace ShowDoMilhao.Models;

public class Pergunta : ContentPage
{
	public Pergunta()
	{
        public int ID { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }
    }
}