// ---------------------------------------------------------------------------------------
// <copyright file="ColoreProviderTests.cs" company="Corale">
//     Copyright © 2015-2019 by Adam Hellberg and Brandon Scott.
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

namespace Colore.Tests
{
    using System.Threading.Tasks;

    using Colore.Api;
    using Colore.Data;

    using Moq;

    using NUnit.Framework;

    [TestFixture]
    public class ColoreProviderTests
    {
        private static readonly AppInfo TestAppInfo = new AppInfo(
            "Colore TestApp",
            "Mock app for running Colore tests",
            "chroma-sdk",
            "colore@sharparam.com",
            Category.Application);

        [Test]
        public async Task ShouldCallUninitializeOnClear()
        {
            var apiMock = new Mock<IChromaApi>();
            await ColoreProvider.CreateAsync(TestAppInfo, apiMock.Object);
            await ColoreProvider.CreateAsync(TestAppInfo, apiMock.Object);

            apiMock.Verify(a => a.UninitializeAsync(), Times.Once);
        }
    }
}