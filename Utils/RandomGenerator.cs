using System.Text;

namespace UserinterfaceTest.Utils
{
    public static class RandomGenerator
    {
        private static string lowerCaseEnglishPool = "abcdefghijklmnopqrstuvwxyz";
        private static string upperCaseEnglishPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string cyrillicPool = "абвгдеёжзийклмнопрстуфхцчшщъьэюя";
        private static string numbersPool = "0123456789";
        private static Random random = new((int)DateTime.Now.Ticks);

        public static int RandomNumberFromRange(int first, int last) => random.Next(first, last);
        public static string RandomStringLowerCase(int length)
        {
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = lowerCaseEnglishPool[random.Next(lowerCaseEnglishPool.Length)];
                builder.Append(c);
            }
            return builder.ToString();
        }
        public static string RandomPassword(string email)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(email);
            var upperLetter = upperCaseEnglishPool[random.Next(upperCaseEnglishPool.Length)];
            stringBuilder.Append(upperLetter);
            var cyrillicLetter = cyrillicPool[random.Next(cyrillicPool.Length)];
            stringBuilder.Append(cyrillicLetter);
            var number = numbersPool[random.Next(numbersPool.Length)];
            stringBuilder.Append(number);
            return stringBuilder.ToString();
        }
        public static int[] GetArrayUniqueRandomNumbers(int arrayLength, int randomListCount)
        {
            int[] numbers = new int[arrayLength];
            do
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    numbers[i] = random.Next(randomListCount);
                }
            } while (numbers.Distinct().Count() < arrayLength);
            return numbers;
        }
    }
}

