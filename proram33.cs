Console.WriteLine(" Kullanıcı adını giriniz: ");
string isim = Console.ReadLine();
Console.WriteLine();
Console.WriteLine(" Şifre giriniz: ");
string sifre = Console.ReadLine();

if (isim == "admin" && sifre == "Admin_32453@")

        Console.WriteLine("Giriş başarılı");
else Console.WriteLine ("Kullanıcı adı veya şifre hatalı");
Console.ReadKey();