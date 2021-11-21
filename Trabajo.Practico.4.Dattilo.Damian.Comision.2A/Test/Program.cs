using System;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AireAcondicionado ac1 = new AireAcondicionado(1234, EMarca.Philco, EficienciaEnergetica.A, 38, ETipo.FrioCalor, 98555);
            AireAcondicionado ac2 = new AireAcondicionado(2555, EMarca.LG, EficienciaEnergetica.D, 12, ETipo.Calor, 75482);
            AireAcondicionado ac3 = new AireAcondicionado(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETipo.Frio, 55637);
            AireAcondicionado ac4 = new AireAcondicionado(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETipo.Frio, 55637);
            AireAcondicionado ac5 = new AireAcondicionado(5778, EMarca.LG, EficienciaEnergetica.D, 10, ETipo.Frio, 72482);
            AireAcondicionado ac6 = new AireAcondicionado(6978, EMarca.Whirlpool, EficienciaEnergetica.D, 72, ETipo.Deshumidificador, 14233);
            AireAcondicionado ac7 = new AireAcondicionado(7111, EMarca.Sony, EficienciaEnergetica.C, 55, ETipo.FrioCalor, 18523);


            Microondas m1 = new Microondas(1234, EMarca.Philco, EficienciaEnergetica.A, 38, ETamanio.Chico, 98555);
            Microondas m2 = new Microondas(2555, EMarca.LG, EficienciaEnergetica.D, 12, ETamanio.Mediano, 75482);
            Microondas m3 = new Microondas(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETamanio.Grande, 55637);
            Microondas m4 = new Microondas(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETamanio.Grande, 55637);
            Microondas m5 = new Microondas(5778, EMarca.LG, EficienciaEnergetica.D, 10, ETamanio.Mediano, 72482);
            Microondas m6 = new Microondas(6978, EMarca.Whirlpool, EficienciaEnergetica.D, 72, ETamanio.Mediano, 14233);
            Microondas m7 = new Microondas(7111, EMarca.Sony, EficienciaEnergetica.C, 55, ETamanio.Chico, 18523);

            Taller<AireAcondicionado> ca = new Taller<AireAcondicionado>(4);
            Taller<Microondas> cm = new Taller<Microondas>(4);

            // Se agregan los objetos a la lista
            try
            {
                ca.Agregar(ac1);
                ca.Remover(ac6); // No esta
                ca.Agregar(ac2);
                ca.Agregar(ac3);
                ca.Agregar(ac4);// igual a ac3
                ca.Agregar(ac2); // Ya se encuentra
                ca.Agregar(ac6);
                ca.Remover(ac2);
                ca.Agregar(ac5);
                ca.Agregar(ac7); // No entra


                cm.Agregar(m1);
                cm.Remover(m6); // No esta
                cm.Agregar(m2);
                cm.Agregar(m3);
                cm.Agregar(m4);// igual a ac3
                cm.Agregar(m2); // Ya se encuentra
                cm.Agregar(m6);
                cm.Remover(m2);
                cm.Agregar(m5);
                cm.Agregar(m7); // No entra
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(ca);
            Console.WriteLine(cm);

            Console.WriteLine(ca.AnalisisDeDatos(EMarca.Philco));


            /*try
            {
                using (StreamWriter sw = new StreamWriter("text2.txt"))  // SE GRABA EN EL ARCHIVO DE TEXTO
                {
                    sw.WriteLine("Archivo de texto\n");
                    sw.WriteLine(ca);
                    sw.WriteLine(cm);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                using (StreamReader sr = new StreamReader("text2.txt"))  // SE LEE DESDE EL ARCHIVO DE TEXTO Y SE MUESTRA POR PANTALLA
                {
                    String linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/


            
        }
    }
}
