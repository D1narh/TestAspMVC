namespace WebApplication3.Class
{
    public class Server
    {
        public static int Count { get; set; }

        //Позволяет прочитать
        public static int GetCount()
        {
            return Count;
        }

        //Позволяет добавить значение
        public static void AddToCount(int value)
        {
            Count += value;
        }
    }
}
