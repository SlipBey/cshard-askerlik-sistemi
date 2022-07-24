using System;

namespace Askerlik
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            Console.WriteLine("Kaç kişiyi sorgulamak istiyorsunuz?");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            var users = process.Islem(id);
            var line = "------------------------------------------------------------------------------------------------------------------------";

            foreach (Users userinfo in users)
            {
                Console.WriteLine(line);
                Console.WriteLine("İsim Soyisim: {0} {1} \nYaş: {2} \nCinsiyet: {3}", userinfo.Name, userinfo.Surname, userinfo.Old, userinfo.Gender);
                if(userinfo.Old < 20)
                {
                    Console.WriteLine("Askerlik: Zorunlu askerliği 20 yaş ve üzeri yapabilmektedir.");
                    Console.WriteLine(line);
                } else if(userinfo.Gender == "Erkek")
                {
                    if (userinfo.Askerlik == "Bedelli" || userinfo.Askerlik == "Tam" || userinfo.Askerlik == "Muaf")
                    {
                        Console.WriteLine("Askerlik: {0}", userinfo.Askerlik);
                        Console.WriteLine(line);
                    }
                    else if (userinfo.Askerlik == "Tecilli")
                    {
                        int year = userinfo.Years - 2022;
                        if (year == 0)
                        {
                            Console.WriteLine("Askerlik: {0}, Bu sene yapılacak.");
                            Console.WriteLine(line);
                        }
                        else
                        {
                            Console.WriteLine("Askerlik: {0}, {1} sene sonra yapılacak.", userinfo.Askerlik, year);
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Askerlik: Geçerli olmayan bir askerlik girildi.");
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("Askerlik: Zorunluğu askerliği sadece erkekler yapmaktadır.");
                    Console.WriteLine(line);
                }
                Console.ReadLine();
            }
        }
    }
}