namespace List_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            list.Add(new Pessoa(1, "Jose"));
            list.Add(new Pessoa(3, "Fabio"));
            list.Add(new Pessoa(2, "Mario"));

            if(list.Exists((p => p.Id == 3)))
            {
                Console.WriteLine("Achou 1!");
            }
            else
            {
                Console.WriteLine("Não achou!");
            }

            string aux = "Jose";
            foreach(Pessoa p in list)
            {
                if(p.Nome == aux)
                {
                    Console.WriteLine("Achou 2!");
                }
            }
        }
    }
}
