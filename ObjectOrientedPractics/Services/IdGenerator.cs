

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Возвращает уникальный идентификатор.
    /// </summary>
    internal class Idgenerator
    {
        private static int _id=0;
        /// <summary>
        /// Создаёт новый идентификатор
        /// </summary>
        /// <returns>
        /// int id
        /// </returns>
        public static int GetNextId()
        { 
            return _id++;
        }
    }
}
