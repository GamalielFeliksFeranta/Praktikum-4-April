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
            string indexHuruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int selisih = indexHuruf.IndexOf(Char.ToUpper(TbHurufKedua.Text[0])) - indexHuruf.IndexOf(Char.ToUpper(TbHurufPertama.Text[0]));
            //string TabelInput = TbInputan.Text.ToUpper();
            //string TbHuruf1 = TbHurufPertama.Text.ToUpper();
            //string TbHuruf2 = TbHurufKedua.Text. ToUpper();
            LbOutput.Text = "";

            foreach (var huruf in TbInputan.Text)
            {

                if (indexHuruf.IndexOf(Char.ToUpper(huruf)) + selisih >= 26)
                {
                    LbOutput.Text += indexHuruf[indexHuruf.IndexOf(Char.ToUpper(huruf)) + selisih - 26]; 
                }
                else if (indexHuruf.IndexOf(Char.ToUpper(huruf)) + selisih < 0)
                {
                    LbOutput.Text += indexHuruf[indexHuruf.IndexOf(Char.ToUpper(huruf)) + selisih + 26];
                }
                else
                {
                    LbOutput.Text += indexHuruf[indexHuruf.IndexOf(Char.ToUpper(huruf)) + selisih];
                }

            }
            
            
            



            //int JumlahSelisih;
            //string Tulisanku = TbInputan.Text;
            //LbOutput.Text = Tulisanku;

            //foreach (var huruf in Tulisanku)
            //{



            //   // // Mencari Valuenya
            //   // //MessageBox.Show(Convert.ToInt16(huruf).ToString());

            //   // // Menambah selisih

            //   // int indeks;
            //   // int selisih = Convert.ToInt32(TbHurufKedua.Text) - Convert.ToInt32(TbHurufPertama.Text);
            //   // //selisih

            //   //string[] hurufAbjad = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                
            //   // //b indeks ke berapa ?
            //   // //b = 1
            //   // //selisih = 2
            //   // //array[1 + 2] = d


            //   // //MessageBox.Show(Convert.ToChar(Convert.ToInt16(huruf) + selisih).ToString());
            //   // //LbOutput.Text = (Convert.ToChar(Convert.ToInt16(huruf) + selisih).ToString());
            //   // LbOutput.Text =


            //}


        }

        private void TbHurufPertama_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbHurufKedua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}