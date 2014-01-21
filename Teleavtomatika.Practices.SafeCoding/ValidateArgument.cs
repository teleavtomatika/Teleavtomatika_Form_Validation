// Copyrigth (c) Teleavtomatika Ltd. All rights reserved.
// Author: Fomin Dmitry
// Date: 2014/01

using System;

namespace Teleavtomatika.Practices.SafeCoding
{
    /// <summary>
    /// Содержит набор статических членов для проверки необходимых условий налагаемых на аргументы функций.
    /// </summary>
    public static class ValidateArgument
    {
        #region IsNull

        /// <summary>
        /// Генерирует исключение ArgumentException, если передаваемый аргумент не равен Null.
        /// </summary>
        /// <param name="obj">Проверяемое значение</param>
        public static void IsNull(object obj)
        {
            if (obj != null)
            {
                throw new ArgumentException("Значение должно быть равно Null");
            }
        }

        /// <summary>
        /// Генерирует исключение ArgumentException, если передаваемый аргумент не равен Null.
        /// </summary>
        /// <param name="obj">Проверяемое значение</param>
        /// <param name="paramName">Имя проверяемого аргумента.</param>
        public static void IsNull(object obj, string paramName)
        {
            if (obj != null)
            {
                var message = string.Format("Значение аргумента '{0}' должно быть равно Null.", paramName);
                throw new ArgumentException(message);
            }
        }

        #endregion

        #region IsNotNull

        /// <summary>
        /// Генерирует исключение ArgumentException, если передаваемый аргумент равен Null.
        /// </summary>
        /// <param name="obj">Проверяемое значение</param>
        public static void IsNotNull(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Генерирует исключение ArgumentNullException, если передаваемый аргумент равен Null.
        /// </summary>
        /// <param name="obj">Проверяемое значение</param>
        /// <param name="paramName">Имя проверяемого аргумента.</param>
        public static void IsNotNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        #endregion

        #region IsTrue

        /// <summary>
        /// Проверяет, что условие выполняется. Если условие не выполняется, генерирует исключение ArgumentException.
        /// </summary>
        /// <param name="condition">Условие, выполнение которого необходимо проверить</param>
        public static void IsTrue(bool condition)
        {
            if (!condition)
                throw new ArgumentException();
        }

        /// <summary>
        /// Проверяет, что условие выполняется. Если условие не выполняется, генерирует исключение ArgumentException.
        /// </summary>
        /// <param name="condition">Условие, выполнение которого необходимо проверить</param>
        /// <param name="message">Текст сообщения в исключении, которое будет сгенерировано, если условие не выполняется</param>
        public static void IsTrue(bool condition, string message)
        {
            if (!condition)
                throw new ArgumentException(message);
        }

        #endregion

        #region IsFalse

        /// <summary>
        /// Проверяет, что условие невыполняется. Если условие выполняется, генерирует исключение ArgumentException.
        /// </summary>
        /// <param name="condition">Условие, невыполнение которого необходимо проверить</param>
        public static void IsFalse(bool condition)
        {
            if (condition)
                throw new ArgumentException();
        }

        /// <summary>
        /// Проверяет, что условие невыполняется. Если условие выполняется, генерирует исключение ArgumentException.
        /// </summary>
        /// <param name="condition">Условие, невыполнение которого необходимо проверить</param>
        /// <param name="message">Текст сообщения в исключении, которое будет сгенерировано, если условие выполняется</param>
        public static void IsFalse(bool condition, string message)
        {
            if (condition)
                throw new ArgumentException(message);
        }

        #endregion

        #region InRange

        /// <summary>
        /// Осуществляет проверку значения на вхождение в заданный диапазон значений. Если 
        /// значение лежит вне диапазона, генерирует исключение ArgumentException.
        /// Диапазон проверяемых значений включает указанные минимум и максимум, т.е. вызовы:
        /// InRange(100, 0, 100) и InRange(0, 0, 100) - не вызовут исключений, а вызовы:
        /// InRange(101, 0, 100) и InRange(-1, 0, 100) - вызовут исключения.
        /// </summary>
        /// <typeparam name="T">Тип проверяемого значения.</typeparam>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="minValueInclusive">Нижняя граница проверяемого диапазона (Включительно).</param>
        /// <param name="maxValueInclusive">Верхняя граница проверяемого диапазона (Включительно).</param>
        public static void InRange<T>(T value, T minValueInclusive, T maxValueInclusive) where T : IComparable
        {
            if ((value.CompareTo(minValueInclusive) < 0) || (value.CompareTo(maxValueInclusive) > 0))
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Осуществляет проверку значения на вхождение в заданный диапазон значений. Если
        /// значение лежит вне диапазона, генерирует исключение ArgumentException.
        /// Диапазон проверяемых значений включает указанные минимум и максимум, т.е. вызовы:
        /// InRange(100, 0, 100) и InRange(0, 0, 100) - не вызовут исключений, а вызовы:
        /// InRange(101, 0, 100) и InRange(-1, 0, 100) - вызовут исключения.
        /// </summary>
        /// <typeparam name="T">Тип проверяемого значения.</typeparam>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="minValueInclusive">Нижняя граница проверяемого диапазона (Включительно).</param>
        /// <param name="maxValueInclusive">Верхняя граница проверяемого диапазона (Включительно).</param>
        /// <param name="paramName">Название параметра, который проверяется</param>
        public static void InRange<T>(T value, T minValueInclusive, T maxValueInclusive, string paramName) where T : IComparable
        {
            if ((value.CompareTo(minValueInclusive) < 0) || (value.CompareTo(maxValueInclusive) > 0))
            {
                var message = string.Format("Параметр '{0}' должен быть больше либо равен {1} и меньше либо равен {2}, а он равен {3}.",
                                paramName, minValueInclusive, maxValueInclusive, value);
                throw new ArgumentException(message);
            }
        }

        #endregion

        #region NotInRange

        /// <summary>
        /// Осуществляет проверку значения на невхождение в заданный диапазон значений. Если 
        /// значение лежит в диапазоне, то генерирует исключение ArgumentException.
        /// Диапазон проверяемых значений включает указанные минимум и максимум, т.е. вызовы:
        /// InRange(100, 0, 100) и InRange(0, 0, 100) - вызовут исключение, а вызовы:
        /// InRange(101, 0, 100) и InRange(-1, 0, 100) - не вызовут исключения.
        /// </summary>
        /// <typeparam name="T">Тип проверяемого значения.</typeparam>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="minValueInclusive">Нижняя граница проверяемого диапазона (Включительно).</param>
        /// <param name="maxValueInclusive">Верхняя граница проверяемого диапазона (Включительно).</param>
        public static void NotInRange<T>(T value, T minValueInclusive, T maxValueInclusive) where T : IComparable
        {
            if ((value.CompareTo(minValueInclusive) >= 0) && (value.CompareTo(maxValueInclusive) <= 0))
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Осуществляет проверку значения на невхождение в заданный диапазон значений. Если 
        /// значение лежит в диапазоне, то генерирует исключение ArgumentException.
        /// Диапазон проверяемых значений включает указанные минимум и максимум, т.е. вызовы:
        /// InRange(100, 0, 100) и InRange(0, 0, 100) - вызовут исключение, а вызовы:
        /// InRange(101, 0, 100) и InRange(-1, 0, 100) - не вызовут исключения.
        /// </summary>
        /// <typeparam name="T">Тип проверяемого значения.</typeparam>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="minValueInclusive">Нижняя граница проверяемого диапазона (Включительно).</param>
        /// <param name="maxValueInclusive">Верхняя граница проверяемого диапазона (Включительно).</param>
        /// <param name="paramName">Название параметра, который проверяется</param>
        public static void NotInRange<T>(T value, T minValueInclusive, T maxValueInclusive, string paramName) where T : IComparable
        {
            if ((value.CompareTo(minValueInclusive) >= 0) && (value.CompareTo(maxValueInclusive) <= 0))
            {
                var message = string.Format("Параметр '{0}' не должен находится в диапазоне от {1} до {2} включительно, а он равен {3}.",
                                paramName, minValueInclusive, maxValueInclusive, value);
                throw new ArgumentException(message);
            }
        }

        #endregion

        #region IsNotNullOrEmpty

        /// <summary>
        /// Осуществляет проверку аргумента, что он не равен Null и пустой строке. Если это не так - генерирует исключение.
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        public static void IsNotNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                var message = string.Format("Значение аргумента не должно быть равно Null или быть пустым.");
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Осуществляет проверку аргумента, что он не равен Null и пустой строке. Если это не так - генерирует исключение.
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="paramName">Имя проверяемого параметра</param>
        public static void IsNotNullOrEmpty(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                var message = string.Format("Значение аргумента '{0}' не должно быть равно Null или быть пустым", paramName);
                throw new ArgumentException(message);
            }
        }

        #endregion

        #region IsNotNullOrWhitespace

        /// <summary>
        /// Осуществляет проверку аргумента, что он не равен Null, пустой строке или невидимым символам. Если это не так - генерирует исключение.
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        public static void IsNotNullOrWhitespace(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                var message = string.Format("Значение аргумента не должно быть равно Null, быть пустым или состоять только из невидимых символов.");
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Осуществляет проверку аргумента, что он не равен Null, пустой строке или невидимым символам. Если это не так - генерирует исключение.
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="paramName">Имя проверяемого параметра</param>
        public static void IsNotNullOrWhitespace(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                var message = string.Format("Значение аргумента '{0}' не должно быть равно Null, быть пустым или состоять только из невидимых символов.", paramName);
                throw new ArgumentException(message);
            }
        }

        #endregion

        #region IsValidEMailAddress

        /// <summary>
        /// Возвращает Истина, если переданный строковый аргумент является корректным E-Mail адресом.
        /// </summary>
        /// <param name="addr">Адреся проверяемый на корректность.</param>
        public static bool IsValidEmailAddress(this string addr)
        {
            if (addr == null)
                return false;

            var regex = new System.Text.RegularExpressions.Regex(@"[\w-]+([\.]?[\w-])*\@[\w-]+([\.][\w-]+)+");
            return regex.IsMatch(addr);
        }

        #endregion
    }
}
