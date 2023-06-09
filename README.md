# Uygulamamız Ne İşe Yarar?
Projemiz, kullanıcının istediği bilgisayar sistemini oluşturabilmesi ve toplam maliyetini hesaplayabilmesi için bir uygulama geliştirdik. Bu uygulama, kullanıcının seçtiği her bir sistem parçasının (örneğin, ekran kartı, anakart, RAM vb.) fiyatını belirler ve bunları toplam maliyete ekler. Kullanıcı, istediği sistem parçalarını seçtiğinde, hesapla butonuna bastığında sistem, kullanıcı için toplam maliyeti hesaplar.

Bu proje, kullanıcıların hayal ettikleri bilgisayar sistemine sahip olmak için ne kadar para harcamaları gerektiği konusunda bilgi sağlar. Kullanıcılar, sistem parçalarını seçerek ve toplam maliyeti hesaplayarak bütçelerine uygun bir bilgisayar sistemini oluşturabilirler.

Projenin kapsamı, C# programlama dilinde geliştirilen bir uygulama olup, kullanıcıları hayal ettikleri bilgisayar sistemine dair bilgilendirir ve maliyet konusunda rehberlik sağlar. Kullanıcılar, uygulama aracılığıyla farklı sistem parçalarını keşfedebilir, fiyatlarını öğrenebilir ve istedikleri sistem için toplam maliyeti görebilirler.

Bu proje, kullanıcılara bilgisayar sistemleriyle ilgili daha bilinçli kararlar vermelerine yardımcı olmayı hedefler ve bütçelerine uygun bir bilgisayar sistemine sahip olmalarını sağlar.
 
## ↓↓ Uygulamamızın Görünümü Aşağıdaki gibidir ↓↓


![Ekran Alıntısı](https://github.com/SidarUlek/Bilgisayar-Maliyeti-Hesaplama/assets/103840652/48ab3864-44f8-4e60-9beb-70016549c1d1)




# Uygulama Nasıl Kullanılır?
- Bilgisayarımız için istediğim öğeleri ilgili bölümdeki combobox seçenekleri içerisinden seçiyoruz ve "Öğeleri Ekle" butonuna basarak "Seçilen Öğeler" listemize yazdırıyoruz listeye eklediğimiz öğelerin fiyatları da yeşil bir yazıyla "Fiyat" listemize ekleniyor:


![Öğeleri-ekle](https://github.com/SidarUlek/Bilgisayar-Maliyeti-Hesaplama/assets/103840652/843d8e04-3b1a-4e19-a85e-15e7fec6d67d)


- Eğer öğe seçiminde bir hata yaptıysak veya seçtiğimiz öğeyi değiştirmek istersek "Geri Al" butonu ile bir önce seçilen öğeyi listemizden kaldırabiliyoruz:


![geri-al](https://github.com/SidarUlek/Bilgisayar-Maliyeti-Hesaplama/assets/103840652/15241dff-585d-4ad8-8cff-90230f500f26)


- Öğelerimizi seçtikten sonra hesapla butonuna bastığımızda uygulama istediğimiz sisteme sahip bilgisayarın maliyetini bize gösteriyor :


![hesapla](https://github.com/SidarUlek/Bilgisayar-Maliyeti-Hesaplama/assets/103840652/d4834956-9a47-46e0-b557-ffc1a4c6d6b6)


- Eğer seçtiğimiz tüm seçenekleri sıfırlamak istersek "Sıfırla" butonu ile tüm uygulamayı sıfırlayıp yeni bir bilgisayar kurmaya başlayabiliriz:


![sıfırla](https://github.com/SidarUlek/Bilgisayar-Maliyeti-Hesaplama/assets/103840652/955a2f86-a1ca-434d-80b2-b7d34e123422)



# Uygulamanın Kod Yapısı

- ↓Form1.cs bölümünden uygulamamın görünümünü ayarladım↓
  * PictureBox'lar ekleyerek öğelerin  temsili resimlerini ekledim
  * Label ile bölüm isimleri ekledim
  * comboBoxlara öğeleri düzenle bölümünden uygun seçenekleri ekledim
  * "Öğeleri Ekle" butonlarını ekledim
  * Biri "Seçilen Öğeler listesi" diğeri "Fiyat listesi" olmak üzere 2 liste ekledim
  * "Hesapla", "Geri Al" ve "Sıfırla" butonlarını ekledim
  * Butonların dizaynını ayarladım
  * Uygulama arka planını uygun bir resim olacak şekilde ayarladım


![Ekran Alıntısı1](https://github.com/SidarUlek/Bilgisayar-Maliyeti-Hesaplama/assets/103840652/04e5468d-65f5-468e-b628-209a5b962715)



### "Öğeleri Ekle" butonumuzun kodlamasını yaparken;
  * comboBoxda seçili textimizin listbox1(Seçilen Öğeler listesi)'e item olarak eklenmesine yarıyacak bir kod
  * listbox1(Seçilen Öğeler listesi)'ndeki son itemi seçen bir kod

```c#
private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            

            int sonIndis = listBox1.Items.Count - 1;
            listBox1.SetSelected(sonIndis, true);

        }


```



### "listbox1" yani "Seçilen Öğeler" listemizin kodlamasını yaparken;
  * Seçili olan öğenin metin değerini secilenYazi adlı bir string değişkene atayan bir kod
    - ("Öğeleri ekle" butonunun listbox1 deki son itemı seçmesinin sebebi buydu.) 
  * secilenYazi eşlenebileceği değerler if komutuyla ekleniyor ve bu değerlerin eşleşmesi halinde listbox2(Fiyat Listesi)'ye eklenecek fiyatlar
    - (listbox2'ye eklenecek fiyatlar seçilen öğelerin fiyatlarıdır.) 

```c#



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
            
        // Seçilebilecek tüm itemler için bu şekilde devam ediyor...

```

### "Geri Al" butonumuzun kodlamasını yaparken;
  * listbox1(Seçilen Öğeler listesi)'ndeki son itemı silen bir kod
  * listbox2(Fiyat listesi)'ndeki son itemi silen bir kod

```c#
private void button1_Click(object sender, EventArgs e)
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


```



### "Sıfırla" butonumuzun kodlamasını yaparken;
  * listbox1(Seçilen Öğeler listesi)'ndeki tüm itemleri silen bir kod
  * listbox2(Fiyat listesi)'ndeki tüm itemleri silen bir kod
  * Tüm comboBox'ların seçili olan öğesini temizler veya seçim yapmamış duruma getirir. 
    - ("-1" Indexin seçim yapılmamış değeridir.)

```c#

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

```



### "Hesapla" butonumuzun kodlamasını yaparken;
  * toplam adında bir decimal değişkeni tanımlayan ve başlangıç değeri olarak 0 atayan bir kod
  * listBox2.Items koleksiyonu üzerinde bir döngü oluşturulur. Her bir item için aşağıdaki adımlar gerçekleştirilir:
      - item.ToString() metoduyla öğenin string temsilini alırız.
      - Bu string değeri decimal.Parse() metoduyla bir decimal değere dönüştürürüz.
      - Elde edilen fiyat değeri, toplam değişkenine eklenir.
  * bir MessageBox ile toplam değişkeninin değeri gösterilir. ToString() metodu, toplam değişkenini string olarak dönüştürür.

```c#
decimal toplam = 0;

            foreach (var item in listBox2.Items)
            {
                decimal fiyat = decimal.Parse(item.ToString());
                toplam += fiyat;
            }

            MessageBox.Show("Toplam: " + toplam.ToString() + " TL");

```

