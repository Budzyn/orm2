using MyEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntity.Query
{
    public class DoTestQuery
    {
        private static Tests ts;

        public static void ShowDoTest()
        {
            using (var db = new Context())
            {
                var dts = new List<DoTest>
                {
                    new DoTest
                    {
                        Name = ".Net",
                        Result = 25,
                        Time = 25,
                        Tests = ts,
                    },
                    new DoTest
                    {
                        Name = "JS",
                        Result = 12,
                        Time = 50,
                        Tests = ts,
                    },
                    new DoTest
                    {
                        Name = "PHP",
                        Result = 22,
                        Time = 15,
                        Tests = ts,
                    }
                };
                db.SaveChanges();
                var some = db.testdo.Select(item => item).ToList();
            }
        }
    }
}
