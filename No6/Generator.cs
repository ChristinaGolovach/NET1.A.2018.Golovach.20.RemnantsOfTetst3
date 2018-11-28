using System;
using System.Collections.Generic;

namespace No6
{
    public static class Generator
    {
        public static IEnumerable<T> GenerateSequence<T>(int count, Func<T, T, T> ruleGeneration, T firstItem, T secondItem)
        {
            if (ruleGeneration == null)
            {
                throw new ArgumentNullException($"The {nameof(ruleGeneration)} can not be null");
            }

            if (count < 2)
            {
                throw new ArgumentException($"The {nameof(count)} must be more than one.");
            }

            if (count == 2)
            {
                return new T[] { firstItem, secondItem };
            }

            return GenerateSequenceCore(count, ruleGeneration, firstItem, secondItem);
        }

        private static IEnumerable<T> GenerateSequenceCore<T>(int count, Func<T, T, T> ruleGeneration, T firstItem, T secondItem)
        {
            for (int i = 0; i < count; i++)
            {
                yield return firstItem;

                T temp = secondItem;
                secondItem = ruleGeneration(firstItem, secondItem);
                firstItem = temp;
            }
        }
    }
}
