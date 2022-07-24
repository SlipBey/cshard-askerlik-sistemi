using System;
using System.Collections.Generic;
using System.Text;

namespace Askerlik
{
    public class Process
    {
        public List<Users> Islem(int id)
        {
            List<Users> users = new List<Users>();
            for (int i = 1; i <= id; i++)
            {

                string name, surname, gender, askerlik = "";
                int years = 0, old;

                Console.WriteLine("Adınızı Giriniz.");
                name = Console.ReadLine();
                Console.WriteLine("Soyadınızı Giriniz.");
                surname = Console.ReadLine();
                Console.WriteLine("Yaşınızı Giriniz.");
                old = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cinsiyetinizi Giriniz.");
                gender = Console.ReadLine();

                if(old >= 20 && gender == "Erkek")
                {
                    Console.WriteLine("Askerlik durumunu giriniz.");
                    askerlik = Console.ReadLine();
                    if(askerlik == "Tecilli")
                    {
                        Console.WriteLine("Hangi yıla kadar tecilli?");
                        years = Convert.ToInt32(Console.ReadLine());
                    }
                }

                users.Add(new Users() { Id = i, Name = name, Surname = surname, Old = old, Gender = gender, Years = years, Askerlik = askerlik });
                System.Threading.Thread.Sleep(200);
                Console.Clear();
            }

            return users;

        }
    }
}
