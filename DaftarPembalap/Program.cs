using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UASpaw
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class Pembalap dapat memuat data data dari seorang pembalap</remarks>
    public class Pembalap
    {
        /// <summary>
        /// kelas pembalap untuk mengisi data 
        /// </summary>
        public string Nama;
        public string BirthPlace;
        public string BirthDate;
        public string CurrentTeam;
        public int Number;
        public string Bio;

        /// <summary>
        /// method string data
        /// </summary>
        /// <returns> mengubah variabel sb ke data string</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Nama Lengkap       : {Nama} \n");
            sb.Append($"Tempat & Tgl Lahir : {BirthPlace}, {BirthDate} \n");
            sb.Append($"Tim saat ini       : {CurrentTeam} \n");
            sb.Append($"No. Motor          : {Number} \n");
            sb.Append($"Biografi Singkat   : {Bio} \n");

            return sb.ToString();
        }

        /// <summary>
        /// method Deskripsi
        /// </summary>
        /// <returns> berupa value dari sebuah string</returns>

        public string Deskripsi()
        {
            return $"{Nama,-25} [{Number,2}] [{CurrentTeam,20}]";
        }

    }
    
    /// <summary>
    /// Class daftar pembalap
    /// </summary>
    public class DaftarPembalap
    {
        /// <summary>
        /// Dictinonary dari array 
        /// </summary>

        Dictionary<string, Pembalap> Daftar;

        /// <summary>
        /// Method Isi Daftar
        /// </summary>
        /// <remarks>Menggunakan Dictionary untuk mengisi data dari pembalap</remarks>
        public void IsiDaftar()
        {
            
            Daftar = new Dictionary<string, Pembalap> {
                {"1" , new Pembalap{ Nama        = "Valentino Rossi",
                                    BirthPlace  = "Italia",
                                    BirthDate   = "16 Februari 1979",
                                    CurrentTeam = "Monster Energy Yamaha MotoGP",
                                    Number      = 46,
                                    Bio         = "Valentino adalah seorang pembalap di kejuaraan grandprix motor dunia setelah era Michael Doohan, dengan titel juara dunia di empat kelas yang berbeda yang diraihnya dalam waktu tujuh tahun berkarier. Ia adalah salah seorang pembalap tersukses sepanjang masa, dengan 7 gelar juara dunia di kelas puncak (500cc/MotoGP) dan dua gelar di kelas 250cc dan 125cc. Menurut majalah olahraga terbitan Amerika, Sports Ilustrated, Rossi adalah salah satu olahragawan bergaji terbesar di duunia, ia diperkirakan digaji $34 juta pada 2007. Putra dari mantan pembalap GP 250 cc Graziano Rossi dan Stefania Palma ini memegang banyak rekor dan prestasi yang diraihnya melampaui banyak seniornya. Total pembalap eksentrik ini membukukan 9 gelar juara dunia, sekali di kelas 125cc pada tahun 1997, sekali di kelas 250cc (1999), dan tujuh kali juara dunia di kelas puncak 500cc/MotoGP (2001, 2002, 2003, 2004, 2005, 2008 dan 2009)"}
                },
                {"2" , new Pembalap{ Nama        = "Marc Márquez Alenta",
                                    BirthPlace  = "Spanyol",
                                    BirthDate   = "17 Februari 1993",
                                    CurrentTeam = "Repsol Honda",
                                    Number      = 93,
                                    Bio         = "Marquez adalah pembalap motor berkebangsaan Spanyol yang memiliki gelar juara dunia kelas 125cc pada tahun 2010, kelas Moto2 pada tahun 2012, dan kelas MotoGP tahun 2013, 2014, 2016, 2017, 2018, dan 2019. Dia adalah juara dunia termuda sepanjang sejarah MotoGP. Dan ia menjadi rider termuda yang meraih 6 titel juara dunia di semua kelas memecahkan rekor Valentino Rossi."}
                },
                {"3" , new Pembalap{ Nama        = "Andrea Dovisiozo",
                                    BirthPlace  = "Italia",
                                    BirthDate   = "23 Maret 1986",
                                    CurrentTeam = "Ducati Team",
                                    Number      = 04,
                                    Bio         = "Dovi merupakan seorang pembalap MotoGP asal Italia. Saat ini ia bergabung dengan tim Ducati dan ia merupakan juara dunia kelas 125cc tahun 2004. Bakat membalap Davizioso mulai terlihat kilaunya saat baru berusia 15 tahun, kala itu dia menjuarai European Championship 125cc serta menjalani Kejuaraan Dunia pertamanya Mugello, yang sayangnya berakhir dengan DNF."}
                },
                {"4" , new Pembalap{ Nama      = "Maverick Viñales Ruiz",
                                    BirthPlace  = "Spanyol",
                                    BirthDate   = "12 Januari 1995",
                                    CurrentTeam = "Monster Energy Yamaha MotoGP",
                                    Number      = 12,
                                    Bio         = "Vinales adalah pembalap asal Spanyol. Saat usia 12 tahun ia menjuarai seri 125 cc Catalan Champion untuk pertama kalinya dan mampu dipertahankannya setahun kemudian. Di tahun 2009 ia menempati posisi runner-up kejuaraan CEV Buckler National 125GP championship dengan hanya defisit empat poin. Atas pencapaiannya tersebut ia mendapatkan gelar Rookie of the Year."}
                },
                {"5" , new Pembalap{ Nama      = "Fabio Quartararo",
                                    BirthPlace  = "Perancis",
                                    BirthDate   = "20 April 1999",
                                    CurrentTeam = "Petronas Yamaha SRT",
                                    Number      = 20,
                                    Bio         = "pembalap sepeda motor Grand Prix Prancis. Sebelum karier Grand Prix-nya, Quartararo memenangkan enam gelar juara Spanyol, termasuk gelar CEV Moto3 berturut-turut pada tahun 2013 dan 2014 . Karena keberhasilannya di usia muda."}
                },
                {"6" , new Pembalap{ Nama        = "Pol Espargaró",
                                    BirthPlace  = "Spanyol",
                                    BirthDate   = "10 Juni 1991",
                                    CurrentTeam = "KTM Monster Energy",
                                    Number      = 44,
                                    Bio         = "Pol merupakan rider Moto2 asal Spanyol yang musim ini membela tim Pons 40 HP Tuenti. Pol adalah adik dari Aleix Espargaró."}
                },
                {"7" , new Pembalap{ Nama       = "Álex Rins Navarro",
                                    BirthPlace  =  "Spanyol",
                                    BirthDate   =  "8 Desember 1995",
                                    CurrentTeam =  "Suzuki Ecstar Team",
                                    Number      =  40,
                                    Bio         =  "Rins adalah pebalap Grand Prix sepeda motor asal Spanyol. Mulai musim 2017 dia berkompetisi di kelas MotoGP setelah Team SUZUKI ECSTAR merekrutnya untuk membela tim tersebut selama dua tahun"}
                },
                {"8" , new Pembalap{ Nama       =  "Jack Peter Miller",
                                    BirthPlace  =   "Australia",
                                    BirthDate   =   "18 Januari 1995",
                                    CurrentTeam =   "Mission Winnow Ducati",
                                    Number      =   43,
                                    Bio         =   "Jack seorang pembalap motor yang berasal dari AustraliaLahir di Townsville, Queensland, Australia, Miller dibesarkan di sebuah properti di luar kota. Sebuah kota tropis di mana ia membuat menyenangkan sendiri, mengendarai sepeda motor dan sepeda quad, ski air dan pinjaman tangan dengan pagar dan ternak"}
                },
                {"9" , new Pembalap{ Nama       =            "Aleix Espargaró Villà",
                                    BirthPlace  =           "Sapnyol",
                                    BirthDate   =           "30 Juli 1989",
                                    CurrentTeam =           "Aprillia Gresini",
                                    Number      =           41,
                                    Bio         =           "Aleix adalah pembalap motor berkewarganegaraan Spanyol. Saat ini dia berkompetisi di kejuraan MotoGP bersama tim Aprilia."}
                },
            };
        }

        /// <summary>
        /// Method menu pembalap
        /// </summary>
        public void MenuPembalap()
        {
            string pilih;
            bool lanjut = true;
            while (lanjut)
            {
                Console.Clear();
                Console.WriteLine("??????????????????????????????");
                Console.WriteLine("?   Kumpulan Pebalap MotoGP  ?");
                Console.WriteLine("??????????????????????????????");
                int i = 1;
                foreach (var item in Daftar)
                {
                    Pembalap p = item.Value;
                    Console.WriteLine($"{i++,2}. [{p.Number,2}] {p.Nama}");
                }

                Console.WriteLine("\n 0. Keluar\n");

                Console.Write($"Pilihan [1 - {Daftar.Count}] [0 - Keluar] : ");
                pilih = Console.ReadLine();

                Pembalap pilihan = new Pembalap();
                int nPilih = Convert.ToInt32(pilih);

                if (nPilih > Daftar.Count)
                {
                    Console.WriteLine("Pilihan Salah!");
                    Console.ReadKey();
                    continue;
                }

                if (nPilih == 0)
                {
                    lanjut = false;
                }
                else
                {
                    pilihan = Daftar[pilih];
                    Console.Clear();
                    Console.WriteLine("???????????????????????");
                    Console.WriteLine("?   Biodata Pembalap  ?");
                    Console.WriteLine("???????????????????????");
                    Console.WriteLine(pilihan.ToString());
                    Console.ReadKey();
                }

            }
        }
        /*
            private void CariPembalap()
            {
                Console.Write("Masukkan kata kunci :");
                var search = Console.ReadLine();

                var d = Daftar.Values.Where(t => 
                                     t.Nama.Contains(search) || 
                                     t.CurrentTeam.Contains(search) || 
                                     t.BirthPlace.StartsWith(search))
                                    .ToList();
                foreach (var pembalap in d)
                {
                    Console.WriteLine(pembalap.Deskripsi());
                }
            }
        */
    }

    class Program
    {
        /// <summary>
        /// Class program 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.Title = "Database Pembalap MotoGP";
            Console.SetWindowSize(60, 20);

            var np = new DaftarPembalap();

            np.IsiDaftar(); // Mengisi daftar pembalap.

            var lanjut = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Mau tahu sejarah pebalap Motogp yang mana?");
                Console.WriteLine("==========================================");
                Console.WriteLine("=============SILAHKAN PILIH!==============");

                Console.ResetColor(); // Mengembalikan ke asli

                Console.WriteLine("   1. Daftar pembalap");
                Console.WriteLine("   2. Tentang Aplikasi");
                // Console.WriteLine("   2. Cari pembalap");
                Console.WriteLine("   0. Keluar");
                Console.Write("\n Pilihan :");
                var pilih = Console.ReadLine();

                switch (pilih.Trim())
                {
                    case "1":
                        np.MenuPembalap();
                        break;
                    case "2":
                        CetakTentang();

                        break;
                    case "0":
                        lanjut = false;
                        break;
                    default:
                        break;
                }
            } while (lanjut);

            Console.WriteLine("Program Selesai... sampai jumpa");
            Console.ReadKey();
        }
        static void CetakTentang()
        {
            Console.Clear();
            Console.WriteLine(@"    __  ___      __        __________ ");
            Console.WriteLine(@"   /  |/  /___  / /_____  / ____/ __ \");
            Console.WriteLine(@"  / /|_/ / __ \/ __/ __ \/ / __/ /_/ /");
            Console.WriteLine(@" / /  / / /_/ / /_/ /_/ / /_/ / ____/ ");
            Console.WriteLine(@"/_/  /_/\____/\__/\____/\____/_/      ");

            Console.WriteLine("\nAplikasi buatan bang satria 20190140131");
            Console.ReadKey();
        }
    }
}