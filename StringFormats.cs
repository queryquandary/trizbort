/*
    Copyright (c) 2010 by Genstein

    This file is (or was originally) part of Trizbort, the Interactive Fiction Mapper.

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/

using System;
using System.Drawing;

namespace Trizbort
{
    internal class StringFormats
    {
        static StringFormats()
        {
            Center = new StringFormat();
            Center.Alignment = StringAlignment.Center;
            Center.LineAlignment = StringAlignment.Center;
            Center.Trimming = StringTrimming.EllipsisCharacter;
            Center.FormatFlags = StringFormatFlags.LineLimit;

            Left = new StringFormat();
            Left.Alignment = StringAlignment.Near;
            Left.LineAlignment = StringAlignment.Center;
            Left.Trimming = StringTrimming.EllipsisCharacter;
            Left.FormatFlags = StringFormatFlags.LineLimit;
        }

        public static StringFormat Center
        {
            get;
            private set;
        }

        public static StringFormat Left
        {
            get;
            private set;
        }
    }
}
