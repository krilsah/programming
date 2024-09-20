
namespace ObjectOrientedPractics
{
    internal class ValueValidator
    {
        private static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}
