﻿// ---------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Corale">
//     Copyright © 2015-2016 by Adam Hellberg and Brandon Scott.
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy of
//     this software and associated documentation files (the "Software"), to deal in
//     the Software without restriction, including without limitation the rights to
//     use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//     of the Software, and to permit persons to whom the Software is furnished to do
//     so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//     CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//     "Razer" is a trademark of Razer USA Ltd.
// </copyright>
// ---------------------------------------------------------------------------------------

namespace Corale.Colore.Razer.Mouse
{
    /// <summary>
    /// Mouse constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Maximum number of custom LEDs.
        /// </summary>
        public const int MaxLeds = 30;

        /// <summary>
        /// Maximum number of LED rows.
        /// </summary>
        public const int MaxRows = 9;

        /// <summary>
        /// Maximum number of LED columns.
        /// </summary>
        public const int MaxColumns = 7;

        /// <summary>
        /// Maximum number of LEDs on the grid layout.
        /// </summary>
        public const int MaxGridLeds = MaxRows * MaxColumns;
    }
}
