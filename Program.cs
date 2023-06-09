using System;
using DesafioFundamentosCelular.Models;

namespace DesafioFundamentosCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Realizar os testes com as classes Nokia e Iphone
            System.Console.WriteLine("------------Testes Nokia--------------");
            Nokia nokia = new Nokia("90909090", "Nokia", "123456", 128);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            System.Console.WriteLine("---------------------------------------");

            System.Console.WriteLine("------------Testes Iphone--------------");
            Iphone iphone = new Iphone("80808080", "Iphone", "654321", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
            System.Console.WriteLine("---------------------------------------");
        }
    }
}
