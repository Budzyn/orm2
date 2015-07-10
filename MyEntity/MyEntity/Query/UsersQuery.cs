using MyEntity.Entity;
using System;
using System.Collections.Generic;


namespace MyEntity.Query
{
    public class UsersQuery
    {
        private static ICollection<DoTest> dts;

        public static void ShowUsers()
        {
            using (var db = new Context())
            {
                var us = new Users
                {
                    Name = "Yaroslav",
                    Age = 26,
                    City = "Lviv",
                    University = "LDFA",
                    Category = ".Net",
                    DoTest = dts
                };
                new Users
                {
                    Name = "Oleg",
                    Age = 23,
                    City = "Lviv",
                    University = "LP",
                    Category = ".Net",
                    DoTest = dts
                };
                new Users
                {
                    Name = "Taras",
                    Age = 21,
                    City = "Kiev",
                    University = "KNP",
                    Category = "JS",
                    DoTest = dts
                };
                new Users
                {
                    Name = "Igor",
                    Age = 22,
                    City = "Kiev",
                    University = "LP",
                    Category = "PHP",
                    DoTest = dts
                };
                new Users
                {
                    Name = "Oleg",
                    Age = 23,
                    City = "Donetsk",
                    University = "DNI",
                    Category = "JS",
                    DoTest = dts
                };
                new Users
                {
                    Name = "Dima",
                    Age = 21,
                    City = "Kiev",
                    University = "KPI",
                    Category = "DB",
                    DoTest = dts
                };
                db.user.Add(us);
                db.SaveChanges();


                var result = from Users in us
                             group Users by Users.City;
                foreach (var userGroup in result)
                {
                    Console.WriteLine(userGroup.Key);
                    foreach (Users customer in userGroup)
                    {
                        Console.WriteLine("    {0}", customer.Name);
                    }
                }
            }
        }
    }
}
