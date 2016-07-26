﻿// <copyright file="StarlightTests.cs" company="Corale">
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

namespace Corale.Colore.Tests.Razer.Effects
{
    using Corale.Colore.Core;
    using Corale.Colore.Razer.Effects;

    using NUnit.Framework;

    [TestFixture]
    public class StarlightTests
    {
        [Test]
        public void ShouldConstructWithCorrectType()
        {
            Assert.That(
                new Starlight(StarlightType.Two, Duration.Short, Color.Black, Color.Black).Type,
                Is.EqualTo(StarlightType.Two));
        }

        [Test]
        public void ShouldConstructWithCorrectDuration()
        {
            Assert.That(
                new Starlight(StarlightType.Two, Duration.Medium, Color.Black, Color.Black).Duration,
                Is.EqualTo(Duration.Medium));
        }

        [Test]
        public void ShouldConstructWithCorrectFirstColor()
        {
            Assert.That(
                new Starlight(StarlightType.Two, Duration.Short, Color.Red, Color.Blue).First,
                Is.EqualTo(Color.Red));
        }

        [Test]
        public void ShouldConstructWithCorrectSecondColor()
        {
            Assert.That(
                new Starlight(StarlightType.Two, Duration.Short, Color.Red, Color.Blue).Second,
                Is.EqualTo(Color.Blue));
        }

        [Test]
        public void ShouldConstructWithCorrectParameter()
        {
            Assert.That(
                new Starlight(StarlightType.Two, Duration.Short, Color.Black, Color.Black, 42).Parameter,
                Is.EqualTo(42));
        }

        [Test]
        public void ShouldSetTwoTypeWithTwoColors()
        {
            Assert.That(new Starlight(Duration.Short, Color.Red, Color.Blue).Type, Is.EqualTo(StarlightType.Two));
        }

        [Test]
        public void ShouldSetRandomTypeWithNoColors()
        {
            Assert.That(new Starlight(Duration.Short).Type, Is.EqualTo(StarlightType.Random));
        }
    }
}
