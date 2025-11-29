using com.sun.tools.doclets.formats.html;
using System;

namespace Conversion.unidades2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowHome();
        }
        //formulas para convertir distancias
        static void Pause()
        {
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        static double CentimetrosMetros(double valor)
        {
            return valor / 100;
        }
        static double MetrosKilometros(double valor)
        {
            return valor / 1000;
        }
        static double KilometrosCentimetros(double valor)
        {
            return valor * 100000;
        }
        static double CentimetrosKilometros(double valor)
        {
            return valor / 100000;
        }
        static double MetrosCentimetros(double valor)
        {
            return valor * 100;
        }
        static double KilometrosMetros(double valor)
        {
            return valor * 1000;
        }
        //formulas para convertir temperatura
        static double CelciusFahrenheit(double valor)
        {
            return (valor * 9 / 5) + 32;
        }
        static double CelciusKelvin(double valor)
        {
            return valor + 273.15;
        }
        static double FahrenheitCelcius(double valor)
        {
            return (valor - 32) * 5 / 9;
        }
        static double FahrenheitKelvin(double valor)
        {
            return (valor - 32) * 5 / 9 + 273.15;
        }
        static double KelvinCelcius(double valor)
        {
            return valor - 273.15;
        }
        static double KelvinFahrenheit(double valor)
        {
            return (valor - 273.15) * 9 / 5 + 32;
        }
        //formulas para convertir potencia
        static int BinarioADecimal(string binario)
        {
            return Convert.ToInt32(binario, 2);
        }

        static string BinarioAOctal(string binario)
        {
            int decimal_ = Convert.ToInt32(binario, 2);
            return Convert.ToString(decimal_, 8);
        }

        static string DecimalABinario(int decimal_)
        {
            return Convert.ToString(decimal_, 2);
        }

        static string DecimalAOctal(int decimal_)
        {
            return Convert.ToString(decimal_, 8);
        }

        static string OctalABinario(string octal)
        {
            int decimal_ = Convert.ToInt32(octal, 8);
            return Convert.ToString(decimal_, 2);
        }

        static int OctalADecimal(string octal)
        {
            return Convert.ToInt32(octal, 8);
        }
        //Tercera pantalla (pedir valor y mostrar resultado)
        static void ConvertirDistancia(char opcion)
        {
            Console.Clear();
            string origen = "";
            string destino = "";
            double valor, resultado = 0;
            switch (opcion)
            {
                case '1':
                    origen = "centimetros";
                    destino = "metros";
                    break;
                case '2':
                    origen = "metros";
                    destino = "kilometros";
                    break;
                case '3':
                    origen = "kilometros";
                    destino = "centimetros";
                    break;
                case '4':
                    origen = "centimetros";
                    destino = "kilometros";
                    break;

                case '5':
                    origen = "metros";
                    destino = "centimetros";
                    break;
                case '6':
                    origen = "kilometros";
                    destino = "metros";
                    break;
            }
            Console.WriteLine($"\nConvertir {origen} a {destino}");
            Console.WriteLine("Introduzca el valor en " + origen);

            try
            {
                valor = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case '1': resultado = CentimetrosMetros(valor); break;
                    case '2': resultado = MetrosKilometros(valor); break;
                    case '3': resultado = KilometrosCentimetros(valor); break;
                    case '4': resultado = CentimetrosKilometros(valor); break;
                    case '5': resultado = MetrosCentimetros(valor); break;
                    case '6': resultado = KilometrosMetros(valor); break;
                }

                Console.WriteLine($"Resultado: {valor} {origen} = {resultado} {destino}");
            }
            catch
            {
                Console.WriteLine("valor ingresado inválido");
            }

            Console.WriteLine($"¿Desea realizar otra operación? digite: \n    y: volver a convertir {origen} a {destino}. \n    n: Volver al menu principal.");
            try
            {
                string regresar = Console.ReadLine();
                if (regresar == "y")
                {
                    ConvertirDistancia(opcion);
                }
                else
                {
                    Console.Clear();
                    ShowHome();
                }
            }
            catch
            {
                Console.WriteLine("tan dificil era pulsar y o n?");
                Pause();
            }
        }

        static void ConvertirTemperatura(char opcion)
        {
            Console.Clear();
            string origen = "";
            string destino = "";
            double valor, resultado = 0;

            switch (opcion)
            {
                case '1':
                    origen = "celcius";
                    destino = "fahrenheit";
                    break;
                case '2':
                    origen = "celcius";
                    destino = "kelvin";
                    break;
                case '3':
                    origen = "fahrenheit";
                    destino = "celcius";
                    break;
                case '4':
                    origen = "fahrenheit";
                    destino = "kelvin";
                    break;
                case '5':
                    origen = "kelvin";
                    destino = "celcius";
                    break;
                case '6':
                    origen = "kelvin";
                    destino = "fahrenheit";
                    break;
            }

            Console.WriteLine($"\nConvertir {origen} a {destino}");
            Console.WriteLine("Introduzca el valor en " + origen);

            try
            {
                valor = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case '1': resultado = CelciusFahrenheit(valor); break;
                    case '2': resultado = CelciusKelvin(valor); break;
                    case '3': resultado = FahrenheitCelcius(valor); break;
                    case '4': resultado = FahrenheitKelvin(valor); break;
                    case '5': resultado = KelvinCelcius(valor); break;
                    case '6': resultado = KelvinFahrenheit(valor); break;
                }

                Console.WriteLine($"Resultado: {valor} {origen} = {resultado} {destino}");
            }
            catch
            {
                Console.WriteLine("valor ingresado inválido");
            }

            Console.WriteLine($"¿Desea realizar otra operación? digite: \n    y: volver a convertir {origen} a {destino}. \n    n: Volver al menu principal.");
            try
            {
                string regresar = Console.ReadLine();
                if (regresar == "y")
                {
                    ConvertirTemperatura(opcion);
                }
                else
                {
                    Console.Clear();
                    ShowHome();
                }
            }
            catch
            {
                Console.WriteLine("tan dificil era pulsar y o n?");
                Pause();
            }
        }

        static void ConvertirPotencia(char opcion)
        {
            Console.Clear();
            string origen = "";
            string destino = "";
            string resultado = "";

            switch (opcion)
            {
                case '1':
                    origen = "binario";
                    destino = "decimal";
                    break;
                case '2':
                    origen = "binario";
                    destino = "octal";
                    break;
                case '3':
                    origen = "decimal";
                    destino = "binario";
                    break;
                case '4':
                    origen = "decimal";
                    destino = "octal";
                    break;
                case '5':
                    origen = "octal";
                    destino = "binario";
                    break;
                case '6':
                    origen = "octal";
                    destino = "decimal";
                    break;
            }

            Console.WriteLine($"\nConvertir {origen} a {destino}");
            Console.WriteLine("Introduzca el valor en " + origen);
            string valor = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case '1': resultado = BinarioADecimal(valor).ToString(); break;
                    case '2': resultado = BinarioAOctal(valor); break;
                    case '3': resultado = DecimalABinario(int.Parse(valor)); break;
                    case '4': resultado = DecimalAOctal(int.Parse(valor)); break;
                    case '5': resultado = OctalABinario(valor); break;
                    case '6': resultado = OctalADecimal(valor).ToString(); break;
                }

                Console.WriteLine($"Resultado: {valor} {origen} = {resultado} {destino}");
            }
            catch
            {
                Console.WriteLine("valor ingresado inválido");
            }

            Console.WriteLine($"¿Desea realizar otra operación? digite: \n    y: volver a convertir {origen} a {destino}. \n    n: Volver al menu principal.");
            try
            {
                string regresar = Console.ReadLine();
                if (regresar == "y")
                {
                    ConvertirPotencia(opcion);
                }
                else
                {
                    Console.Clear();
                    ShowHome();
                }
            }
            catch
            {
                Console.WriteLine("tan dificil era pulsar y o n?");
                Pause();
            }
        }
        //Primera pantalla (menu principal)

        static void ShowHome()
        {
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("..........................");
                Console.WriteLine("...CONVERSOR DE UNIDADES..");
                Console.WriteLine("..........................");
                Console.WriteLine(".SELECCIONE LA CONVERSION.");
                Console.WriteLine("..........................");
                Console.WriteLine(".... 1. Distancia      ...");
                Console.WriteLine(".... 2. Temperatura    ...");
                Console.WriteLine(".... 3. Potencia       ...");
                Console.WriteLine(".... 0. Salir          ...");
                Console.WriteLine("..........................");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1': DistanceMenu(); break;
                    case '2': Temperaturemenu(); break;
                    case '3': Potencymenu(); break;
                    case '0': salir = true; break;
                }
            }
        }
        //Segunda pantalla (menu de conversiones)

        static void DistanceMenu()
        {
            Console.Clear();
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("..........................");
                Console.WriteLine("........DISTANCIA.........");
                Console.WriteLine("..........................");
                Console.WriteLine(".SELECCIONE LA CONVERSION.");
                Console.WriteLine("..........................");
                Console.WriteLine(".... 1. cm -> m...........");
                Console.WriteLine(".... 2. m -> km...........");
                Console.WriteLine(".... 3. km -> cm..........");
                Console.WriteLine(".... 4. cm -> km..........");
                Console.WriteLine(".... 5. m -> cm...........");
                Console.WriteLine(".... 6. km -> m...........");
                Console.WriteLine(".... 0. ATRAS.............");
                Console.WriteLine("..........................");

                char opcion = Console.ReadKey().KeyChar;

                if (opcion == '1' || opcion == '2' || opcion == '3' || opcion == '4' || opcion == '5' || opcion == '6')
                {
                    ConvertirDistancia(opcion);
                }
                else if (opcion == '0')
                {
                    salir = true;
                }
            }
        }

        static void Temperaturemenu()
        {
            Console.Clear();
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("..........................");
                Console.WriteLine("....... TEMPERATURA.......");
                Console.WriteLine("..........................");
                Console.WriteLine(".SELECCIONE LA CONVERSION.");
                Console.WriteLine("..........................");
                Console.WriteLine(". 1. celcius -> fahrenheit");
                Console.WriteLine(". 2. celcius -> kelvin....");
                Console.WriteLine(". 3. fahrenheit -> celcius");
                Console.WriteLine(". 4. fahrenheit -> kelvin.");
                Console.WriteLine(". 5. kelvin -> celcius....");
                Console.WriteLine(". 6. kelvin -> fahrenheit.");
                Console.WriteLine(". 0. ATRAS................");
                Console.WriteLine("..........................");

                char opcion = Console.ReadKey().KeyChar;

                if (opcion == '1' || opcion == '2' || opcion == '3' || opcion == '4' || opcion == '5' || opcion == '6')
                {
                    ConvertirTemperatura(opcion);
                }
                else if (opcion == '0')
                {
                    salir = true;
                }
            }
        }

        static void Potencymenu()
        {
            Console.Clear();
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("..........................");
                Console.WriteLine(".........POTENCIAS........");
                Console.WriteLine("..........................");
                Console.WriteLine(".SELECCIONE LA CONVERSION.");
                Console.WriteLine("..........................");
                Console.WriteLine(". 1. binario -> decimal...");
                Console.WriteLine(". 2. binario -> octal.....");
                Console.WriteLine(". 3. decimal -> binario...");
                Console.WriteLine(". 4. decimal -> octal.....");
                Console.WriteLine(". 5. octal -> binario.....");
                Console.WriteLine(". 6. octal -> decimal.....");
                Console.WriteLine(". 0. ATRAS................");
                Console.WriteLine("..........................");

                char opcion = Console.ReadKey().KeyChar;

                if (opcion == '1' || opcion == '2' || opcion == '3' || opcion == '4' || opcion == '5' || opcion == '6')
                {
                    ConvertirPotencia(opcion);
                }
                else if (opcion == '0')
                {
                    salir = true;
                }
            }
        }
    }
}