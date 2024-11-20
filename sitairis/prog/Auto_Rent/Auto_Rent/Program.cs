using Auto_Rent.Data;
using Auto_Rent.Views;


namespace Auto_Rent;



internal static class Program
{

    static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();


        Form form = new MainForm();
        Application.Run(form);


    }
}