using System.Globalization;

Console.WriteLine("Hello, World!");

//int k;
//int n = 10;
//string kota = "Jakarta";
//float total = 2.56f;
//double pi = 3.14d;
//int bil1 = 100;
//float bil2 = 25.55f;
//string pesan = "Selamat datang di pemrograman C#";

//k = 100;

//Console.WriteLine("=========================================================");
//Console.WriteLine(bil1);
//Console.WriteLine("bil1:{0}", bil1);
//Console.WriteLine("bil1: {0}, bil2: {1}, pesan: {2}", bil1, bil2, pesan);
//Console.WriteLine($"bil1: {bil1}, bil2: {bil2}, pesan: {pesan}");
//Console.WriteLine();

//Console.WriteLine("=========================================================");
//Console.WriteLine("Ini hari jum'at");
//Console.WriteLine("Ingat tanda \"*\" menunjukan kali");
//Console.WriteLine();

//Console.WriteLine("=========================================================");
//Console.Write("*");
//Console.Write("*");
//Console.Write("*");
//Console.Write("*");
//Console.WriteLine("*");
//Console.WriteLine("*****");
//Console.WriteLine();

//Console.WriteLine("=========================================================");
//Console.WriteLine("n = {0}", n);
//Console.WriteLine("kota = {0}", kota);
//Console.WriteLine("total = {0}", total);
//Console.WriteLine("pi = {0}", pi);
//Console.WriteLine("k = {0}", k);
//Console.WriteLine();

//Console.WriteLine("=========================================================");
////4. Output format dan string interpolation
//int totalHasil = 12;
//double hasil1 = 25.123456789d;
//float hasil2 = 7.0f / 3.0f;
//double jumlahUang = 1500000;

//Console.WriteLine("Total hasil : {0:D3}", totalHasil);
//Console.WriteLine("Total hasil : {0:D4}", totalHasil);

//Console.WriteLine("hasil1: {0}", hasil1);
//Console.WriteLine("hasil1: {0:N2}", hasil1);
//Console.WriteLine("hasil1: {0:N3}", hasil1);

//Console.WriteLine("hasil2: {0}", hasil2);
//Console.WriteLine("hasil2: {0:N2}", hasil2);

//Console.WriteLine("jumlah uang: {0}", jumlahUang);
//Console.WriteLine("jumlah uang: {0:C}", jumlahUang); // mengikuti setting regional

//CultureInfo culture = new CultureInfo("id-ID");
//Console.WriteLine("jumlah uang: {0}", jumlahUang.ToString("C", culture));

//Console.WriteLine("=========================================================");
////5. Membaca input dari pengguna
//Console.Write("Masukkan nama Anda: ");
//string? userName = Console.ReadLine();
//Console.WriteLine($"Hallo, {userName}");

//Console.Write("Masukkan bilangan 1: ");
//string num1 = Console.ReadLine() ?? "0";
//Console.Write("Masukkan bilangan 2: ");
//string num2 = Console.ReadLine() ?? "0";

//int jumlahBil = Convert.ToInt32(num1) + Convert.ToInt32(num2);
//Console.WriteLine($"{num1} + {num2} = {jumlahBil}");

//Console.WriteLine("=========================================================");
////12. Array (Traditional array)
//int[] numbers = { 10, 20, 30, 40, 50 };
//string[] pulau = { "Sumatra", "Jawa", "Kalimantan", "Sulawesi", "Papua" };

//Console.WriteLine("Isi array");
//foreach (var num in numbers)
//    Console.WriteLine(num);

//Console.WriteLine(pulau);

//Console.WriteLine("=========================================================");
////13. List dan Dictionary
//List<string> namaKota = new List<string> { "Jakarta", "Bandung", "Semarang", "Surabaya" };

//Dictionary<string, string> capitals = new Dictionary<string, string>
//{
//    {"Indonesia", "Jakarta"},
//    {"Malaysia", "Kuala Lumpur"},
//    {"Singapore", "Singapore"},
//    {"Thailand", "Bangkok"}
//};

//Console.WriteLine("Kota: ");
//namaKota.ForEach(kota => Console.WriteLine(kota));

//Console.WriteLine();

//Console.WriteLine("Ibu kota negara: ");
//foreach (var item in capitals)
//    Console.WriteLine($"{item.Key}: {item.Value}");

//Console.WriteLine("=========================================================");
////15. Queue dan Stack
//Queue<string> queue = new Queue<string>();
//queue.Enqueue("apple");
//queue.Enqueue("banana");
//queue.Enqueue("cherry");

//Console.WriteLine("Queue: ");
//while (queue.Count > 0)
//    Console.WriteLine(queue.Dequeue());

//Stack<string> stack = new Stack<string>();
//stack.Push("apple");
//stack.Push("banana");
//stack.Push("cherry");

//Console.WriteLine("\nStack: ");
//while (stack.Count > 0)
//    Console.WriteLine(stack.Pop());

//Console.WriteLine("=========================================================");
//// percabangan if, else
//Console.Write("Masukkan umur: ");
//string hasilUmur = Console.ReadLine();

//if (int.TryParse(hasilUmur, out int umur))
//{
//    if (umur >= 17)
//        Console.WriteLine("Kamu sudah dewasa");
//    else
//        Console.WriteLine("Kamu belum dewasa");
//}
//else
//{
//    Console.WriteLine("Input harus angka!");
//}

//Console.WriteLine("=========================================================");
//// percabangan switch
//Console.Write("Masukkan nama hari: ");
//string hari = Console.ReadLine();

//switch (hari.ToLower())
//{
//    case "senin":
//        Console.WriteLine("Hari pertama dalam minggu kerja");
//        break;
//    case "sabtu":
//    case "minggu":
//        Console.WriteLine("Hari akhir pekan");
//        break;
//    default:
//        Console.WriteLine("Hari biasa");
//        break;
//}

//Console.WriteLine("=========================================================");
//// perulangan for
//for (int i = 0; i < 5; i++)
//    Console.WriteLine($"Nilai ke: {i}");

//for (int i = 0; i < 3; i++)
//    for (int j = 5; j < 8; j++)
//        Console.WriteLine($"nilai ke i = {i}, j = {j}");

//Console.WriteLine("=========================================================");
//// perulangan while, do while
//int count = 0;

//Console.WriteLine("\nPerulangan while:");
//while (count < 3)
//{
//    Console.WriteLine($"Nilai count: {count}");
//    count++;
//}

//Console.WriteLine("\nPerulangan do-while:");
//do
//{
//    Console.WriteLine($"Nilai count: {count}");
//    count--;
//}
//while (count > 0);

//Console.WriteLine("=========================================================");
//// perulangan foreach

//List<string> fruits = new List<string> { "apple", "banana", "cherry" };
//Console.WriteLine("Perulangan foreach:");

//fruits.ForEach(fruit => Console.WriteLine(fruit));

//Console.WriteLine();

//foreach (var fruit in fruits)
//    Console.WriteLine(fruit);

//Console.WriteLine("=========================================================");
//// perulangan continue, break
//Console.WriteLine("Perulangan dengan continue dan break");

//for (int i = 0; i < 10; i++)
//{
//    if (i % 2 == 0)
//        continue; // lewati bilangan genap
//    if (i > 5)
//        break; // hentikan perulangan jika i > 5
//    Console.WriteLine($"Nilai i: {i}");
//}

Console.WriteLine("=========================================================");
// fungsi dan method

void Hello()
{
    Console.WriteLine("Hello c#");
}

void Salam(string nama)
{
    Console.WriteLine($"Hello, {nama}. Selamat pagi!");
}

int Tambah(int bil1, int bil2)
{
    return bil1 + bil2;
}

Hello();
Salam("Andi");

int hasilTambah = Tambah(5, 8);
Console.WriteLine($"Total tambah: {hasilTambah}");
