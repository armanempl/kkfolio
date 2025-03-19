using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MoqPls
{
    public static class ConsoleHelper
    {
        private static TextReader _consoleIn;
        public static void SetConsoleIn(TextReader consoleIn)
        {
            _consoleIn = consoleIn;
        }
        public static string ReadLine()
        {
            return _consoleIn.ReadLine();
        }
    }
    public class ProductLoaderTests
    {
        [Fact]
        public void LoadProductsFromFile_ShouldHandleEmptyFile()
        {
            // Arrange
            var filePath = "C:\\Users\\Konrad\\source\\repos\\Mocking\\MoqPls\\MoqPls\\Product.txt";
            var mockConsole = new Mock<TextWriter>();
            var exceptionMessage = "Brak produktów do dodania w pliku. Uzupe³nij plik Products.txt wartoœciami, aby je dodaæ";

            // Act & Assert
            var result = ProductLoader.LoadProductsFromFile(filePath, mockConsole.Object);

            // Assert
            Assert.Empty(result);
            mockConsole.Verify(x => x.WriteLine(exceptionMessage), Times.Once);
        }
    }
}