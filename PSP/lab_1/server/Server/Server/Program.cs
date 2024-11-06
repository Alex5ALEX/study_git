using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class ChatServer
{
    private static List<TcpClient> clients = new List<TcpClient>();
    private static TcpListener listener;

    static void Main(string[] args)
    {
        listener = new TcpListener(IPAddress.Any, 5000);
        listener.Start();
        Console.WriteLine("Сервер запущен на порту 5000...");

        while (true)
        {
            TcpClient client = listener.AcceptTcpClient();
            clients.Add(client);
            Console.WriteLine("Клиент подключен.");
            Thread clientThread = new Thread(() => HandleClient(client));
            clientThread.Start();
        }
    }

    private static void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        string clientEndPoint = client.Client.RemoteEndPoint.ToString();

        while (true)
        {
            try
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Сообщение от {clientEndPoint}: {message}");
                BroadcastMessage(message, clientEndPoint);
            }
            catch
            {
                break; // Выйти при ошибке (например, когда клиент отключается)
            }
        }

        clients.Remove(client);
        client.Close();
        Console.WriteLine($"Клиент {clientEndPoint} отключен.");
    }

    private static void BroadcastMessage(string message, string senderEndPoint)
    {
        byte[] data = Encoding.UTF8.GetBytes($"{senderEndPoint}: {message}");
        foreach (var client in clients)
        {
            if (client.Connected)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
            }
        }
    }
}