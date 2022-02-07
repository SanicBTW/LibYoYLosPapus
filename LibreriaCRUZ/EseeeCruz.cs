namespace LibreriaCRUZ
{
    public class EseeeCruz
    {
        //mejorar la vaina esta
        public void PreguntaCruz(string question)
        {
            //ver 1.1
            int randNum = 0;
            string Response = string.Empty;
            bool matched = false;

            string[] decisiones = new string[] { "Si", "No", "A lo mejor", "Seguramente", "Seguramente no", "Maricon total" };
            Random random = new Random();
            randNum = random.Next(0, decisiones.Length);
            Response = question + "\n" + decisiones[randNum];
            
            string questToLower = question.ToLower();
            if(questToLower == "¿es cruz maricon?" || questToLower == "¿es cruz un maricon?") 
            {
                matched = true;
                Response = question + "\n" + decisiones[decisiones.Length - 1];
                Console.WriteLine(Response);
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