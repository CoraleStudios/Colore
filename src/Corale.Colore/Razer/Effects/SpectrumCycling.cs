// <copyright file="SpectrumCycling.cs" company="Corale">
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

namespace Corale.Colore.Razer.Effects
{
    using System;
    using System.Runtime.InteropServices;

    using Corale.Colore.Annotations;

    /// <summary>
    /// Describes the spectrum cycling effect for system devices.
    /// </summary>
    [Obsolete("Use custom effects instead.")]
    [StructLayout(LayoutKind.Sequential)]
    public struct SpectrumCycling
    {
        /// <summary>
        /// The size of the struct.
        /// </summary>
        [PublicAPI]
        public readonly int Size;

        /// <summary>
        /// Additional effect parameter.
        /// </summary>
        [PublicAPI]
        public readonly int Parameter;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpectrumCycling" /> struct.
        /// </summary>
        /// <param name="parameter">Additional effect parameter to set.</param>
        public SpectrumCycling(int parameter)
        {
            Parameter = parameter;
            Size = Marshal.SizeOf(typeof(None));
        }

        /// <summary>
        /// Creates a new instance of the <see cref="SpectrumCycling" /> struct
        /// with default values.
        /// </summary>
        /// <returns>A new instance of the <see cref="SpectrumCycling" /> struct.</returns>
        public static SpectrumCycling Create()
        {
            return new SpectrumCycling(0);
        }
    }
}
