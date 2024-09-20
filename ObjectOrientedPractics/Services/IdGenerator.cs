

namespace ObjectOrientedPractics
{
    internal class Idgenerator
    {
        private static int _id=0;
        public static int GetNextId()
        { 
            return _id++;
        }
    }
}
