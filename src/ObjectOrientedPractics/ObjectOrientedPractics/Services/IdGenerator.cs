namespace ObjectOrientedPractics
{
    internal static class IdGenerator
    {
        private static int _id;
        public static int GetNextId()
        {
            return _id++;
        }
    }
}
