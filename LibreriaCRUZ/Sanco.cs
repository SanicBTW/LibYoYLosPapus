namespace LibYoYLosPapus
{
    public class Sanco
    {
        string LibVers = "1.0";

        //improve the whole log thingy or something lol
        //it looks really stupid
        public enum LogLevels
        {
            Info,
            Debug,
            Warn,
            Error,
            Fatal,
            None
        }
        string[] theFunny = new string[] { "[ INFO ] ", "[ DEBUG ] ", "[ WARN ] ", "[ ERROR ] ", "[ FATAL ] ", "" };

        public int GenerateRandomNumber(int minVal, int maxVal)
        {
            Random random = new Random();
            return random.Next(minVal, maxVal);
        }

        public void Log(dynamic value, LogLevels LogLvL)
        {
            string FormtdVal = theFunny[(int)LogLvL] + value;
            Console.WriteLine(FormtdVal);
        }
    }
}
