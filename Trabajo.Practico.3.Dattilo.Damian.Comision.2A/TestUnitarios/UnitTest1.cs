using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IgualdadMicroondas_Ok()
        {
            Microondas m1 = new Microondas(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETamanio.Grande, 55637);
            Microondas m2 = new Microondas(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETamanio.Grande, 55637);

            bool res = m1 == m2;

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IgualdadMicroondas_False()
        {
            Microondas m1 = new Microondas(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETamanio.Grande, 55637);
            Microondas m2 = new Microondas(4444, EMarca.Samsung, EficienciaEnergetica.B, 45, ETamanio.Grande, 55637);

            bool res = m1 == m2;

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void IgualdadAireAcondicionado_Ok()
        {
            AireAcondicionado ac1 = new AireAcondicionado (3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETipo.Calor, 55637);
            AireAcondicionado ac2 = new AireAcondicionado(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETipo.Calor, 55637);

            bool res = (ac1 == ac2);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IgualdadAireAcondicionado_False()
        {
            AireAcondicionado ac1 = new AireAcondicionado(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETipo.Calor, 55637);
            AireAcondicionado ac2 = new AireAcondicionado(3774, EMarca.Philco, EficienciaEnergetica.C, 45, ETipo.Calor, 55637);

            bool res = (ac1 == ac2);

            Assert.IsFalse(res);
        }

        
        [TestMethod]
        public void CalidadAireAcondicionado_Lleno()
        {
            int maximo = 2;
            Calidad<AireAcondicionado> ca = new Calidad<AireAcondicionado>(maximo);

            AireAcondicionado ac1 = new AireAcondicionado(3777, EMarca.Samsung, EficienciaEnergetica.B, 45, ETipo.Calor, 55637);
            AireAcondicionado ac2 = new AireAcondicionado(3555, EMarca.Philco, EficienciaEnergetica.C, 45, ETipo.Calor, 55637);
            AireAcondicionado ac3 = new AireAcondicionado(4444, EMarca.Philco, EficienciaEnergetica.C, 45, ETipo.Calor, 55637);


            Assert.IsTrue(ca.Agregar(ac1));
            Assert.IsTrue(ca.Agregar(ac2));
            Assert.IsFalse(ca.Agregar(ac3));

            Assert.AreEqual(maximo, ca.lista.Count);
        }
        
        [TestMethod]
        public void CalidadMicroondas_Lleno()
        {
            int maximo = 2;
            Calidad<Microondas> c = new Calidad<Microondas>(maximo);

            Microondas m1 = new Microondas(3774, EMarca.Samsung, EficienciaEnergetica.B, 45, ETamanio.Grande, 55637);
            Microondas m2 = new Microondas(4444, EMarca.Philco, EficienciaEnergetica.D, 12, ETamanio.Grande, 25411);
            Microondas m3 = new Microondas(7777, EMarca.LG, EficienciaEnergetica.A, 12, ETamanio.Grande, 55637);

            Assert.IsTrue(c.Agregar(m1));
            Assert.IsTrue(c.Agregar(m2));
            Assert.IsFalse(c.Agregar(m3));

            Assert.AreEqual(maximo, c.lista.Count);
        }
        

    }
}
