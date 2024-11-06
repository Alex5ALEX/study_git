using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class ChatClient
{
    private static TcpClient client;
    private static NetworkStream stream;

    static void Main(string[] args)
    {
        client = new TcpClient("127.0.0.1", 5000);
        stream = client.GetStream();

        Thread receiveThread = new Thread(ReceiveMessages);
        receiveThread.Start();

        Console.WriteLine("Введите сообщения для отправки (или 'exit' для выхода):");
        while (true)
        {
            string message = Console.ReadLine();
            if (message.ToLower() == "exit") break;
            SendMessage(message);
        }

        client.Close();
    }

    private static void SendMessage(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        stream.Write(data, 0, data.Length);
    }

    private static void ReceiveMessages()
    {
        byte[] buffer = new byte[1024];
        while (true)
        {
            try
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine(message);
            }
            catch
            {
                break; // Выйти при ошибке (например, когда сервер отключается)
            }
        }
    }
}