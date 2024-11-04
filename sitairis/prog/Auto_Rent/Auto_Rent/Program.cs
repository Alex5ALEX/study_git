namespace Auto_Rent
{


    public enum PersonStatus
    {
        Uncnown,
        Client,
        Admin
    }




    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            PersonStatus status = PersonStatus.Uncnown;


            ApplicationConfiguration.Initialize();

            Form form = new Form1(status);

            Application.Run(form);

            if(status == PersonStatus.Admin)
            {
                Form form1 = new Form2();
                Application.Run(form1);
            }





        }
    }
}