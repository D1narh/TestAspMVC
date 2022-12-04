namespace WebApplication3.Class
{
    public static class Server
    {

        //Позволяет прочитать
        public static int GetCount()
        {
            return CountDB.Count;
        }

        //Позволяет добавить значение
        public static void AddToCount(int value)
        {
            CountDB.Count += value;
        }
    }
}
