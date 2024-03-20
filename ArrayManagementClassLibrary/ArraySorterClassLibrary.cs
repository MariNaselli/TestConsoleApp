namespace ArrayManagementClassLibrary
{
    public class ArraySorterClassLibrary
    {
        public static int FindIndexOfMin(int[] array, int fromIndex, int toIndex)
        {
            int result = -1;
            //Validamos que el array no està vacio
            if (array.Length != 0)
            {
                if (fromIndex >= 0)
                {
                    if (toIndex < array.Length)
                    {
                        if (fromIndex <= toIndex)
                        {
                            //se cumple todo
                            int valorMinimo = array[fromIndex];
                            int posicionValorMinimo = fromIndex;
                            for (int i = fromIndex; i <= toIndex; i++)
                            {
                                int valorActual = array[i];
                                if (valorActual < valorMinimo)
                                {
                                    valorMinimo = valorActual;
                                    posicionValorMinimo = i;
                                }
                            }
                            result = posicionValorMinimo;

                            Console.WriteLine("El valor minimo del array: [" + string.Join(", ", array) + "] es " + valorMinimo);
                            Console.WriteLine("La posiciòn del valor minimo en el array es " + posicionValorMinimo);

                        }
                        else
                        {
                            Console.WriteLine("is not fromIndex ≤ toIndex");
                        }
                    }
                    else
                    {
                        Console.WriteLine("is not toIndex < n");
                    }

                }
                else
                {
                    Console.WriteLine("is not fromIndex ≥ 0");
                }
            }
            else
            {
                ///el array esta vacio
                Console.WriteLine("El array está vacio");
            }
            return result;
        }

        public static void SwapElements(int[] array, int i, int j)
        {
            Console.WriteLine("Array antes de invertir los elementos: [" + string.Join(", ", array) + "]");

            int valorPosicionI = array[i];
            int valorPosicionJ = array[j];

            array[i] = valorPosicionJ;
            array[j] = valorPosicionI;

            Console.WriteLine("Array despues de invertir los elementos: [" + string.Join(", ", array) + "]");

        }

        public static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int toIndex = array.Length - 1;
                int miIndex = FindIndexOfMin(array, i, toIndex);
                SwapElements(array, i, miIndex);
            }

            Console.WriteLine("Array ordenado de forma creciente: [" + string.Join(", ", array) + "]");
        }

        //public static void SortArray(int[] array)
        //{
        //    Console.WriteLine("Array: [" + string.Join(", ", array) + "]");

        //    Array.Sort(array);

        //    Console.WriteLine("Array ordenado de forma creciente: [" + string.Join(", ", array) + "]");
        //}

    }
}
