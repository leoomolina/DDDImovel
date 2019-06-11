using System;
using DDDImovel.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDImovel.Domain.Tests.ValueObjects
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void PodeCriarUmEnderecoVazio()
        {
            var address = new Address("", "", "", "", "", "", "", "", "");

            if (address.Valid)
            {
                foreach (var notification in address.Notifications)
                {
                    Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
            }
        }
    }
}
