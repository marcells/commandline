﻿#region License
//
// Command Line Library: CommandLineParserException.cs
//
// Author:
//   Giacomo Stelluti Scala (gsscoder@gmail.com)
//
// Copyright (C) 2005 - 2013 Giacomo Stelluti Scala
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion
#region Using Directives
using System;
using System.Runtime.Serialization;
#endregion

namespace CommandLine
{
    /// <summary>
    /// This exception is thrown when a generic parsing error occurs.
    /// </summary>
    [Serializable]
    public class CommandLineParserException : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CommandLineParserException"/>. The exception is thrown
        /// when something unexpected occurs during the parsing process.
        /// </summary>
        public CommandLineParserException()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CommandLineParserException"/>. The exception is thrown
        /// when something unexpected occurs during the parsing process.
        /// </summary>
        /// <param name="message">Error message string.</param>
        public CommandLineParserException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CommandLineParserException"/>. The exception is thrown
        /// when something unexpected occurs during the parsing process.
        /// </summary>
        /// <param name="message">Error message string.</param>
        /// <param name="innerException">Inner exception reference.</param>
        public CommandLineParserException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CommandLineParserException"/> with serialized data. The exception is thrown
        /// when something unexpected occurs during the parsing process.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected CommandLineParserException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}