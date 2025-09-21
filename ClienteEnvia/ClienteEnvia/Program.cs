using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace ClienteEnvia
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socketenviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            IPEndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);

            Console.ReadKey();
            socketenviar.SendTo(Encoding.ASCII.GetBytes("Mensagem de Teste: 123 testando!"), endereco);
            Console.ReadKey();
            socketenviar.SendTo(Encoding.ASCII.GetBytes("...outra mensagem de teste!"), endereco);
            socketenviar.Close();
         }
    }
}
