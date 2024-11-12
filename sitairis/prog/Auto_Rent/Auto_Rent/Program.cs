using Auto_Rent.Data;


namespace Auto_Rent;



internal static class Program
{

    static void Main(string[] args)
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.




        //ПОДКЛЮЧЕНИЕ БД
        //var connectionString = "server=localhost;port=3306;database=AutoRent;user id=root;password=BuildSQLData;";

        //var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        //optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        using (var context = new ApplicationDbContext())
        {
            // Используйте контекст для работы с базой данных



            ApplicationConfiguration.Initialize();

            //Форма для регистрации/авторизации
            //Form form = new Form1();
            //Application.Run(form);



            Form form1 = new Form2();
            Application.Run(form1);


        }













    }
}