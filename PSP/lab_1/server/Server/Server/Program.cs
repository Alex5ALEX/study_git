using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main()
    {
        // Создаем TcpListener, чтобы слушать входящие соединения
        TcpListener listener = new TcpListener(IPAddress.Any, 5000);
        listener.Start();
        Console.WriteLine("Сервер запущен. Ожидание соединений...");

        while (true)
        {
            // Принимаем входящее соединение
            TcpClient client = listener.AcceptTcpClient();
            Console.WriteLine("Клиент подключен.");

            // Получаем поток для чтения и записи
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[256];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Получено сообщение: " + message);

            // Отправляем ответ
            string response = "Сообщение получено.";
            byte[] responseData = Encoding.UTF8.GetBytes(response);
            stream.Write(responseData, 0, responseData.Length);

            // Закрываем соединение
            client.Close();
        }
    }
}