namespace Praktikum_4_April
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKonversi_Click(object sender, EventArgs e)
        {
            

            string Tulisanku = TbInputan.Text;

            LbOutput.Text = Tulisanku; 

        }

        private void TbHurufPertama_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbHurufKedua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}