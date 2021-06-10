using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AireAcondicionado ac1 = new AireAcondicionado(1234, EficienciaEnergetica.A, ETipo.FrioCalor);
            AireAcondicionado ac2 = new AireAcondicionado(5555, EficienciaEnergetica.D, ETipo.Calor);
            AireAcondicionado ac3 = new AireAcondicionado(7777, EficienciaEnergetica.B, ETipo.Calor);
            AireAcondicionado ac4 = new AireAcondicionado(8888, EficienciaEnergetica.D, ETipo.Frio);

            Microondas m1 = new Microondas(2222, EficienciaEnergetica.B, ETamanio.Grande);
            Microondas m2 = new Microondas(3333, EficienciaEnergetica.C, ETamanio.Chico);
            Microondas m3 = new Microondas(4215, EficienciaEnergetica.A, ETamanio.Mediano);


            ControlSeguridad<AireAcondicionado> ca = new ControlSeguridad<AireAcondicionado>(3);
            ControlSeguridad<Microondas> cm = new ControlSeguridad<Microondas>(2);

            ca.Agregar(ac1);
            ca.Agregar(ac2);
            ca.Agregar(ac3);
            ca.Agregar(ac4);

            cm.Agregar(m1);
            cm.Agregar(m2);
            cm.Remover(m1);
            cm.Agregar(m3);

            //Console.WriteLine(ca);
            //Console.WriteLine(cm);
            
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\usu\Documents\Nueva\text.txt"))
                {
                    sw.WriteLine(ca);
                    sw.WriteLine(cm);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\usu\Documents\Nueva\text.txt"))
                {
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
