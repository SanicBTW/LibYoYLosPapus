namespace LibreriaCRUZ
{
    public class EseeeCruz
    {

        //Ideas para la libreria cruz jaja xd - ruleta rusa
        //mejorar la vaina esta
        public void PreguntaCruz(string question)
        {
            int randNum = 0;
            string Response = string.Empty;
            bool matched = false;

            string[] decisiones = new string[] { "Si", "No", "A lo mejor", "Seguramente", "Seguramente no", "Maricon total" };
            Random random = new Random();
            randNum = random.Next(0, decisiones.Length);
            Response = question + "\n" + decisiones[randNum];
            string[] xdd = new string[] { "¿Es Cruz Maricon?", "¿Es Cruz maricon?", "¿Es cruz maricon?", "¿es cruz maricon?", "¿Es Cruz Un Maricon?", "¿Es Cruz Un maricon?", "¿Es Cruz un maricon?", "¿Es cruz un maricon?", "¿es cruz un maricon?" };
            foreach (string maybe in xdd)
            {
                if (maybe == question) { Response = question + "\n" + decisiones[decisiones.Length - 1]; Console.WriteLine(Response); matched = true; }
            }
            if (question == null || !question.EndsWith("?") && !question.StartsWith("¿") && matched == false) { Console.WriteLine("Preguntame algo, no me dejes con la intriga tio "); }
            else if (matched == false) { Console.WriteLine(Response); }
        }

        //lets fucking gooooooo
        public void RuletaRusaMain(bool destructivo)
        {
            switch (destructivo)
            {
                case true:
                    bool Confirm = Confirmacion();
                    if(Confirm == true) { RuletaRusaDestructiva(); }
                    else { RuletaRusaNODestructiva(); }
                    break;

                default:
                    RuletaRusaNODestructiva();
                    break;
            }
        }

        private bool Confirmacion()
        {
            Console.WriteLine("¿Estas seguro de que quieres continuar? (Y/N) ");
            System.ConsoleKeyInfo opciones = Console.ReadKey(false);
            switch (opciones.Key)
            {
                case ConsoleKey.Y:
                    Console.Clear();
                    return true;
                case ConsoleKey.N:
                    Console.Clear();
                    return false;
                default:
                    Console.Clear();
                    return false;
            }
        }

        private void RuletaRusaNODestructiva()
        {
            int the = GenerateRandomNumber(1, 7);
            Console.WriteLine(the);

            Console.WriteLine("no destructiva");
        }

        private void RuletaRusaDestructiva()
        {
            int the = GenerateRandomNumber(1, 7);
            Console.WriteLine(the);

            Console.WriteLine("destructiva");
        }

        public int GenerateRandomNumber(int minVal, int maxVal)
        {
            Random random = new Random();
            return random.Next(minVal, maxVal);
        }
    }
}