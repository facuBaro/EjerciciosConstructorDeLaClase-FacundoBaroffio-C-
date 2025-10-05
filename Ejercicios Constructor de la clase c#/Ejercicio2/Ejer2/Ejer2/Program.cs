internal class Program
{

    class operaciones
    {
        private int numero1, numero2, resultadoSuma, resultadoResta, resultadoMultiplicar;
        float resultadoDividir;
        bool divisionValida;
        public operaciones()
        {
            int leer;
            Console.WriteLine("Ingrese el primer numero entero");
            leer = Convert.ToInt32(Console.ReadLine());
            numero1 = leer;
            Console.WriteLine("Ingrese el segundo numero entero");
            leer = Convert.ToInt32(Console.ReadLine());
            numero2 = leer;
        }
        public void calculoSuma()
        {
            resultadoSuma = numero1 + numero2;
        }
        public void calculoResta()
        {
            resultadoResta = numero1 - numero2;
        }
        public void calculoMultiplicación()
        {
            resultadoMultiplicar = numero1 * numero2;
        }
        public void calculoDivisión()
        {
            if (numero2 != 0)
            {
                resultadoDividir = (Convert.ToSingle(numero1) / Convert.ToSingle(numero2));
                divisionValida = true;
            }
            else
            {

                divisionValida = false;
            }

        }
        public void MostrarResultados()
        {
            Console.WriteLine("Resultado de la suma: " + resultadoSuma);
            Console.WriteLine("Resultado de la resta: " + resultadoResta);
            Console.WriteLine("Resultado de la multiplicación: " + resultadoMultiplicar);
            if (divisionValida == true)
            {
                Console.WriteLine("Resultado de la división: " + resultadoDividir);
            }
            else
            {
                Console.WriteLine("Resultado de la división: No se pudo efectuar debido a que se divide por 0.");
            }

        }
    }
    private static void Main(string[] args)
    {
        /*2)Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor,
calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos
resultados.*/
        operaciones operaciones = new operaciones();
        operaciones.calculoSuma();
        operaciones.calculoResta();
        operaciones.calculoMultiplicación();
        operaciones.calculoDivisión();
        operaciones.MostrarResultados();
        Console.ReadKey();

    }
}