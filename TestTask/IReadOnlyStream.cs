﻿using System;

namespace TestTask
{
    /// <summary>
    /// Интерфейс для работы с файлом.
    /// </summary>
    internal interface IReadOnlyStream : IDisposable
    {
        // TODO : Необходимо доработать данный интерфейс для обеспечения гарантированного закрытия файла, по окончанию работы с таковым!
        /// <summary>
        /// Ф-ция чтения следующего символа из потока.
        /// Если произведена попытка прочитать символ после достижения конца файла, метод 
        /// должен бросать соответствующее исключение.
        /// </summary>
        /// <returns>Считанный символ.</returns>
        char ReadNextChar();

        /// <summary>
        /// Ф-ция получения следующего символа из потока без перевода позиции. 
        /// Если следующий символ отсутствует - возвращает значение по умолчанию.
        /// </summary>
        /// <returns>Считанный символ.</returns>
        char GetNextChar();

        /// <summary>
        /// Сбрасывает текущую позицию потока на начало.
        /// </summary>
        void ResetPositionToStart();

        /// <summary>
        /// Флаг окончания файла.
        /// </summary>
        bool IsEof { get; }
    }
}
