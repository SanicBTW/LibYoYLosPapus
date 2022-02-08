namespace LibYoYLosPapus
{
    public class Cruzando
    {
        Sanco EseSanco = new Sanco();
        string LibVers = "1.2";

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

        public void RuletaRusa()
        {
            int SelectedChamber = EseSanco.GenerateRandomNumber(1, 7);
            int DeathBullet = EseSanco.GenerateRandomNumber(1, 7);

            if (SelectedChamber == DeathBullet)
            {
                EseSanco.Log("Tas muerto bro", Sanco.LogLevels.None);
            }
            else
            {
                EseSanco.Log("Vives otro dia, que suerte, aprovecha", Sanco.LogLevels.None);
            }
        }
    }
}