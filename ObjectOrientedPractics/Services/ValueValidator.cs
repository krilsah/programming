
namespace ObjectOrientedPractics
{
    internal class ValueValidator
    {
        /// <summary>
        /// Проверяет строку на длину.
        /// </summary>
        /// <param name="value">
        /// Проверяемая строка.
        /// </param>
        /// <param name="maxLength">
        /// Максимальная длина строки.
        /// </param>
        /// <param name="propertyName">
        /// Название строки которая будет выведена, если в ней есть ошибка.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Вывод ошибки при несоответствии.
        /// </exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                MessageBox.Show($"{propertyName} должен быть меньше {maxLength} символов", "Ты чево наделол", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}
