namespace ExemploConstrutores.Models
{
    public class Matemática
    {
        public int x { get; set; }
        public int y { get; set; }

        public Matemática(int x, int y)
        {
            x = x;
            y =y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(x, y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Método executado");
        }
    }
}