using System;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace SP.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(WhatsappEcxeption))]
        public void TestMethod1()
        {
            EmisorDeWhatsapp emisor = new EmisorDeWhatsapp();
            emisor.NumeroTelefono = -1;
        }
        
    }
}
