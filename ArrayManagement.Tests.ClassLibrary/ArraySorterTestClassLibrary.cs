using ArrayManagementClassLibrary;

namespace ArrayManagement.Tests.ClassLibrary
{
    public class ArraySorterTestClassLibrary
    {
        [Fact]
        public void TestFindIndexOfMin()
        {
            // Arrange
            int[] array = { 5, 3, 9, 2, 7 };
            int fromIndex = 0;
            int toIndex = array.Length - 1;

            // Act
            int result = ArraySorterClassLibrary.FindIndexOfMin(array, fromIndex, toIndex);

            // Assert
            Assert.Equal(3, result); // Esperamos que el �ndice del valor m�nimo sea 3 (el valor 2)
        }

        [Fact]

        public void TestSwapElements()
        {
            // Arrange
            int[] array = { 5, 3, 9, 2, 7 };
            int valorPosicion0 = 3;
            int valorPosicion1 = 5;
            // Act 
            ArraySorterClassLibrary.SwapElements(array, 0, 1);

            // Assert
            Assert.Equal(valorPosicion0, array[0]);
            Assert.Equal(valorPosicion1, array[1]);

        }

        [Fact]

        public void TestSortArray()
        {
            // Arrange
            int[] array = { 5, 3, 9, 2, 7 };
            int[] array_esperado = { 2, 3, 5, 7, 9 };

            // Act 
            ArraySorterClassLibrary.SortArray(array);


            // Assert
            Assert.Equal(array_esperado, array);


        }
    }

}