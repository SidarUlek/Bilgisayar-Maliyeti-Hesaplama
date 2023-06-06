using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, decimal> fiyatlar = new Dictionary<string, decimal>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            string secilenYazi = listBox1.Text;
            

            if (secilenYazi == "ASUS Dual RTX3050  (8GB)")
            {
                listBox2.Items.Add(9999);
            }
            else if (secilenYazi == "ASUS GTX1050TI  (4GB)")
            {
                listBox2.Items.Add(5349);
            }
            else if (secilenYazi == "MSI V809-2825R  (2GB)")
            {
                listBox2.Items.Add(2779);
            }
            else if (secilenYazi == "MSI VGA GeForce GTX 1660  (6GB)")
            {
                listBox2.Items.Add(8669);
            }
            else if (secilenYazi == "MSI Geforce RTX 3060 Ti  (8GB)")
            {
                listBox2.Items.Add(13599);
            }
            else if (secilenYazi == "ASUS GeForce Dual RTX3060  (12GB)")
            {
                listBox2.Items.Add(11399);
            }
            else if (secilenYazi == "ASUS Tuf Gaming RTX 4090  (24GB)")
            {
                listBox2.Items.Add(59999);
            }
            else if (secilenYazi == "MSI Geforce RTX 3060  (8GB)")
            {
                listBox2.Items.Add(10849);
            }
            else if (secilenYazi == "MSI Geforce RTX 3050  (8GB)")
            {
                listBox2.Items.Add(8979);
            }
            else if (secilenYazi == "MSI GeForce RTX 3060 TI  (8GB)")
            {
                listBox2.Items.Add(15049);
            }
            else if (secilenYazi == "MSI GeForce RTX 3060 Aero  (12GB)")
            {
                listBox2.Items.Add(10799);
            }
            else if (secilenYazi == "MSI Radeon RX 6750 XT  (12GB)")
            {
                listBox2.Items.Add(17499);
            }


            if (secilenYazi == "AMD Ryzen 9 7950X 4.50GHz 16 Çekirdek")
            {
                listBox2.Items.Add(15849);
            }
            else if (secilenYazi == "AMD Ryzen 9 7900 3.70GHz 12 Çekirdek")
            {
                listBox2.Items.Add(12034);
            }
            else if (secilenYazi == "AMD Ryzen 7 7800X3D 4.20GHz 8 Çekirdek")
            {
                listBox2.Items.Add(12295);
            }
            else if (secilenYazi == "AMD Ryzen 7 5700X 3.40GHz 8 Çekirdek")
            {
                listBox2.Items.Add(4993);
            }
            else if (secilenYazi == "AMD Ryzen 5 Pro 5650G 3.90GHz 6 Çekirdek")
            {
                listBox2.Items.Add(5889);
            }
            else if (secilenYazi == "AMD Ryzen 5 5600X MPK 3.7GHz-4.6GHz 6 Çekirdek")
            {
                listBox2.Items.Add(4148);
            }
            else if (secilenYazi == "AMD Ryzen 5 5600 3.50GHz 6 Çekirdek")
            {
                listBox2.Items.Add(3456);
            }
            else if (secilenYazi == "AMD Ryzen 5 5600G 3.90GHz 6 Çekirdek")
            {
                listBox2.Items.Add(3456);
            }
            else if (secilenYazi == "AMD Ryzen 3 1200 3.10GHz 4 Çekirdek")
            {
                listBox2.Items.Add(1241);
            }
            else if (secilenYazi == "AMD Ryzen 3 3200G 3.60GHz Fanlı İşlemci")
            {
                listBox2.Items.Add(2432);
            }
            else if (secilenYazi == "Intel Core i9-12900F 2.40GHz 16 Çekirdek")
            {
                listBox2.Items.Add(16125);
            }
            else if (secilenYazi == "Intel Core i9-13900F 2.00GHz 24 Çekirdek")
            {
                listBox2.Items.Add(14595);
            }
            else if (secilenYazi == "Intel Core i9-13900KF 3.00GHz 24 Çekirdek")
            {
                listBox2.Items.Add(14569);
            }
            else if (secilenYazi == "Intel Core i9-12900K 3.20GHz 16 Çekirdek")
            {
                listBox2.Items.Add(13315);
            }
            else if (secilenYazi == "Intel Core i9-12900 2.40GHz 16 Çekirdek")
            {
                listBox2.Items.Add(12546);
            }
            else if (secilenYazi == "Intel Core i7-13700KF 3.40GHz 16 Çekirdek")
            {
                listBox2.Items.Add(10626);
            }
            else if (secilenYazi == "Intel Core i7-10700K 3.80Ghz 8 Çekirdek")
            {
                listBox2.Items.Add(8962);
            }
            else if (secilenYazi == "Intel Core i7-12700K 3.60GHz 12 Çekirdek")
            {
                listBox2.Items.Add(8834);
            }
            else if (secilenYazi == "Intel Core i7-10700KF 3.80Ghz 8 Çekirdek")
            {
                listBox2.Items.Add(8321);
            }
            else if (secilenYazi == "Intel Core i7-11700F 2.50GHz 8 Çekirdek")
            {
                listBox2.Items.Add(6529);
            }
            else if (secilenYazi == "Intel Core i5-12600K 3.70GHz 10 Çekirdek")
            {
                listBox2.Items.Add(7144);
            }
            else if (secilenYazi == "Intel Core i5-12600KF 3.70GHz 10 Çekirdek")
            {
                listBox2.Items.Add(6888);
            }
            else if (secilenYazi == "Intel Core i5-11600KF 3.90GHz 6 Çekirdek")
            {
                listBox2.Items.Add(6145);
            }
            else if (secilenYazi == "Intel Core i5-10600K 4.10Ghz 6 Çekirdek")
            {
                listBox2.Items.Add(5991);
            }
            else if (secilenYazi == "Intel Core i5-11400 2.60GHz 6 Çekirdek")
            {
                listBox2.Items.Add(5677);
            }
            else if (secilenYazi == "Intel Core i3-12100 3.30GHz 4 Çekirdek")
            {
                listBox2.Items.Add(4276);
            }
            else if (secilenYazi == "Intel Core i3-13100 3.40GHz 4 Çekirdek")
            {
                listBox2.Items.Add(3584);
            }
            else if (secilenYazi == "Intel Core i3-13100F 3.40GHz 4 Çekirdek")
            {
                listBox2.Items.Add(3449);
            }
            else if (secilenYazi == "Intel Core i3-12100F 3.30GHz 4 Çekirdek")
            {
                listBox2.Items.Add(1997);
            }
            else if (secilenYazi == "Intel Core i3-10100F 3.60Ghz 4 Çekirdek")
            {
                listBox2.Items.Add(1664);
            }

            if (secilenYazi == "Gigabyte A520M-DS3H AMD A520 Soket AM4 Gaming")
            {
                listBox2.Items.Add(1818);
            }
            else if (secilenYazi == "Gigabyte B550 Gaming X V2 AMD B550 Soket AM4")
            {
                listBox2.Items.Add(2983);
            }
            else if (secilenYazi == "Asus ProArt B550-Creator AMD B550 Soket AM4")
            {
                listBox2.Items.Add(6529);
            }
            else if (secilenYazi == "Asus ROG STRIX B550-F Gaming WIFI II AMD")
            {
                listBox2.Items.Add(5325);
            }
            else if (secilenYazi == "Asus TUF Gaming B550-Plus AMD B550")
            {
                listBox2.Items.Add(4224);
            }
            else if (secilenYazi == "Asus Pro B550M-C/CSM AMD B550")
            {
                listBox2.Items.Add(3482);
            }
            else if (secilenYazi == "Asus TUF Gaming A520M-Plus AMD A520M")
            {
                listBox2.Items.Add(2247);
            }
            else if (secilenYazi == "MSI MEG X570S UNIFY-X MAX AMD X570 Soket AM4")
            {
                listBox2.Items.Add(9653);
            }
            else if (secilenYazi == "MSI MPG X570S CARBON MAX WIFI AMD X570 Soket AM4")
            {
                listBox2.Items.Add(8834);
            }
            else if (secilenYazi == "MSI MAG X570S TORPEDO MAX AMD X570 Soket AM4")
            {
                listBox2.Items.Add(6145);
            }
            else if (secilenYazi == "MSI MPG B550 Gaming Plus AMD B550 Soket AM4")
            {
                listBox2.Items.Add(4495);
            }
            else if (secilenYazi == "MSI B550M PRO-VDH WIFI AMD B550 Soket AM4")
            {
                listBox2.Items.Add(3584);
            }
            else if (secilenYazi == "MSI B450M PRO-VDH MAX AMD B450 Soket AM4")
            {
                listBox2.Items.Add(2227);
            }
            else if (secilenYazi == "MSI A320M-A Pro AMD A320 Soket AM4")
            {
                listBox2.Items.Add(1818);
            }

            if (secilenYazi == "Apacer Panther Black-Gold 8GB (1x8GB) 3200MHz CL16 DDR4")
            {
                listBox2.Items.Add(473);
            }
            else if (secilenYazi == "Apacer Panther Black-Gold 16GB (1x16GB) 3200MHz CL16 DDR4")
            {
                listBox2.Items.Add(870);
            }
            else if (secilenYazi == "Apacer Panther Black-Gold 16GB (2x8GB) 3600MHz CL18 DDR4")
            {
                listBox2.Items.Add(1024);
            }
            else if (secilenYazi == "Kingston Fury Beast 8 8GB (1x8GB) 3200MHz CL16 DDR4")
            {
                listBox2.Items.Add(537);
            }
            else if (secilenYazi == "Kingston Fury Beast 16 16GB (1x16GB) 3200MHz CL16 DDR4")
            {
                listBox2.Items.Add(973);
            }
            else if (secilenYazi == "Kingston Fury Beast RGB 16 16GB (2x8GB 3600MHz CL17 DDR4")
            {
                listBox2.Items.Add(1408);
            }
            else if (secilenYazi == "Kingston Fury Beast RGB 16 16GB (1x16GB) 3600MHz CL18 DDR4")
            {
                listBox2.Items.Add(1177);
            }
            else if (secilenYazi == "Kingston Fury Beast 32 32GB (2x16GB) 3600MHz CL18 DDR4")
            {
                listBox2.Items.Add(2176);
            }
            else if (secilenYazi == "Kingston Fury Beast 32 32GB (1x32GB) 3200MHz CL16 DDR4")
            {
                listBox2.Items.Add(1843);
            }
            else if (secilenYazi == "XPG Gammix D30 8GB (1x8GB) DDR4 3600MHz CL18")
            {
                listBox2.Items.Add(524);
            }
            else if (secilenYazi == "XPG Gammix D30 16GB (2x8GB) DDR4 3200MHz CL16")
            {
                listBox2.Items.Add(998);
            }
            else if (secilenYazi == "XPG Gammix D30 16GB (1x16GB) DDR4 3200MHz CL16")
            {
                listBox2.Items.Add(896);
            }


            if (secilenYazi == "Toshiba P300 High Performance 1TB 3.5\" Sata3 7200RPM Sabit Disk")
            {
                listBox2.Items.Add(921);
            }
            else if (secilenYazi == "Toshiba P300 6TB 5400Rpm 128MB 3.5” SATA 3 Harddisk")
            {
                listBox2.Items.Add(2765);
            }


            if (secilenYazi == "Samsung 870 QVO 8TB 560/530MB/s 2.5\"")
            {
                listBox2.Items.Add(11241);
            }
            else if (secilenYazi == "Samsung 870 EVO 4TB 560/530MB/s 2.5\"")
            {
                listBox2.Items.Add(6171);
            }
            else if (secilenYazi == "Samsung 980 1TB 3500/3000MB/s")
            {
                listBox2.Items.Add(1894);
            }
            else if (secilenYazi == "Samsung 870 EVO 500GB 560/530MB/s 2.5\"")
            {
                listBox2.Items.Add(1152);
            }
            else if (secilenYazi == "Samsung 870 EVO 250GB 560/530MB/s 2.5\"")
            {
                listBox2.Items.Add(973);
            }
            else if (secilenYazi == "Kioxia Exceria G2 2TB 2100/1700MB/s")
            {
                listBox2.Items.Add(4071);
            }
            else if (secilenYazi == "Kingston KC3000 4TB 7000/7000MB/s")
            {
                listBox2.Items.Add(9761);
            }
            else if (secilenYazi == "Kingston NV2 2TB 3500/2800MB/s")
            {
                listBox2.Items.Add(2304);
            }
            else if (secilenYazi == "Kingston NV2 1TB 3500/2100MB/s")
            {
                listBox2.Items.Add(1126);
            }
            else if (secilenYazi == "Kingston NV2 500GB 3500/2100MB/s")
            {
                listBox2.Items.Add(750);
            }
            else if (secilenYazi == "Kingston A400 240GB 500MB/350MB/s 2.5\"")
            {
                listBox2.Items.Add(435);
            }
            else if (secilenYazi == "James Donkey JD480 Master 480GB 2.5\" 3D Nand 500MB/480MB/s")
            {
                listBox2.Items.Add(649);
            }
            else if (secilenYazi == "James Donkey JD240 Master 240GB 2.5\" 3D Nand 500MB/480MB/s")
            {
                listBox2.Items.Add(349);
            }


            if (secilenYazi == "Cougar CRATUS CGR-5LMSB E-ATX Mid Tower Gaming Kasa")
            {
                listBox2.Items.Add(11727);
            }
            else if (secilenYazi == "Cougar MX670 CGR-5UM6B-RGB RGB Mid Tower Gaming Kasa")
            {
                listBox2.Items.Add(3840);
            }
            else if (secilenYazi == "FSP CMT211 750W 80+ ATX Mid-Tower Gaming (Oyuncu) Kasa")
            {
                listBox2.Items.Add(2944);
            }
            else if (secilenYazi == "FSP CMT211 650W 80+ ATX Mid-Tower Gaming (Oyuncu) Kasa")
            {
                listBox2.Items.Add(2714);
            }
            else if (secilenYazi == "Frisby FC-2910B 300W 120mm Midi Tower Siyah Kasa")
            {
                listBox2.Items.Add(1051);
            }
            else if (secilenYazi == "Frisby FC-2940B 350W 1x120mm Fan USB 3.0 ATX Mid-Tower Kasa")
            {
                listBox2.Items.Add(998);
            }
            else if (secilenYazi == "MSI MEG PROSPECT 700R Tempered Glass-Tower Gaming (Oyuncu) Kasa")
            {
                listBox2.Items.Add(11138);
            }
            else if (secilenYazi == "MSI MAG Forge 112R Temperli Cam-Tower Gaming (Oyuncu) Kasa")
            {
                listBox2.Items.Add(2327);
            }
            else if (secilenYazi == "Zalman S4-PLUS(BL) RGB Fan Siyah ATX Mid-Tower Gaming Kasa")
            {
                listBox2.Items.Add(2256);
            }


            if (secilenYazi == "Asus ROG THOR 1600W 80+ Titanium Tam Modüler Power Supply")
            {
                listBox2.Items.Add(19306);
            }
            else if (secilenYazi == "Corsair HX1500i CP-9020215-EU 1500W 80+ Platinum Tam Modüler")
            {
                listBox2.Items.Add(10051);
            }
            else if (secilenYazi == "Asus ROG-THOR-1000P2-GAMING V2 1000W 80+ Platinum Full Modüler")
            {
                listBox2.Items.Add(9899);
            }
            else if (secilenYazi == "MSI MPG A1000G PCIE5 1000W 80+ Gold Full Modüler")
            {
                listBox2.Items.Add(5699);
            }
            else if (secilenYazi == "Antec HCG1000 1000W 80+ Gold Full Modüler")
            {
                listBox2.Items.Add(5505);
            }
            else if (secilenYazi == "Corsair CX550F RGB CP-9020216-EU 550W 80 Plus Bronze RGB")
            {
                listBox2.Items.Add(2427);
            }
            else if (secilenYazi == "Asus TUF-GAMING-450B 450W 80 Plus Bronze")
            {
                listBox2.Items.Add(2150);
            }
            else if (secilenYazi == "Everest EPS-600A 600W Aktif PFC 12cm Fanlı")
            {
                listBox2.Items.Add(768);
            }
            else if (secilenYazi == "Xigmatek EN40704 500W X-Power X-Calibre 500 80+")
            {
                listBox2.Items.Add(955);
            }


            if (secilenYazi == "Asus DRW-24D5MT M-Disc Desteği ile 24X DVD Yazıcı")
            {
                listBox2.Items.Add(426);
            }
            else if (secilenYazi == "Asus DRW-24D5MT 24X SATA DVD RW Optik Sürücü")
            {
                listBox2.Items.Add(426);
            }


            if (secilenYazi == "Asus ROG Ryuo III 360 ARGB 360mm İşlemci Sıvı Soğutucu")
            {
                listBox2.Items.Add(8699);
            }
            else if (secilenYazi == "Asus ROG Strix LC 240 RGB White Edition Sıvı Soğutucu")
            {
                listBox2.Items.Add(4149);
            }
            else if (secilenYazi == "Corsair iCUE H150i Elite LCD XT Siyah İşlemci Sıvı Soğutucu")
            {
                listBox2.Items.Add(8432);
            }
            else if (secilenYazi == "Frisby FCL-F1318C CPU Soğutucu")
            {
                listBox2.Items.Add(144);
            }
            else if (secilenYazi == "MSI MAG CoreLiquid P360 360mm İşlemci Sıvı Soğutucu")
            {
                listBox2.Items.Add(4131);
            }
            else if (secilenYazi == "Lian Li Galahad AIO 360 RGB Siyah İşlemci Sıvı Soğutucu")
            {
                listBox2.Items.Add(5249);
            }
            else if (secilenYazi == "Lian Li Galahad AIO 360 RGB Beyaz İşlemci Sıvı Soğutucu")
            {
                listBox2.Items.Add(5249);
            }
            else if (secilenYazi == "Zalman CNPS80G Ultra Sessiz Cpu Soğutucu")
            {
                listBox2.Items.Add(217);
            }

           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal toplam = 0;

            foreach (var item in listBox2.Items)
            {
                decimal fiyat = decimal.Parse(item.ToString());
                toplam += fiyat;
            }

            MessageBox.Show("Toplam: " + toplam.ToString() + " TL");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox2.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox4.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox5.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox6.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox7.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox8.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox9.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox10.Text);

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
            if (listBox2.Items.Count > 0)
            {
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
            }
        }
    }
}
