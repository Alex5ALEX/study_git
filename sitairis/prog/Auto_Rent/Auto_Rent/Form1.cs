namespace Auto_Rent
{
    


    public partial class Form1 : Form
    {
        



        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;



            button1.Click += enterance;
            button2.Click += registration;


            label4.Click += openRegisrationBox;
            label14.Click += openEnteranceBox;

        }

        //проверка на наличие клиента/админа в бд
        private void enterance(object sender, EventArgs e)
        {
            
            this.Close();
        }


        private void registration(object sender, EventArgs e)
        {
    
            this.Close();
        }


        private void openRegisrationBox(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void openEnteranceBox(object sender, EventArgs e)
        {
            groupBox2.Visible=false;
            groupBox1.Visible=true;
        }

    }
}
