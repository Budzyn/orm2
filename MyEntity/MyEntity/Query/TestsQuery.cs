using MyEntity.Entity;

namespace MyEntity.Query
{
    public class TestsQuery
    {
        public static void ShowTests()
        {
            using (var db = new Context())
            {
                var ts = new Tests
                {
                    Name = "for .Net students",
                    Category = ".Net",
                    ListAsk = "What is a abstract class?",
                    TimeMax = 30,
                    Pass = 38
                };
                new Tests
                {
                    Name = "for JS students",
                    Category = "JS",
                    ListAsk = "What is a class?",
                    TimeMax = 30,
                    Pass = 50
                };
                new Tests
                {
                    Name = "for PHP students",
                    Category = "PHP",
                    ListAsk = "What is a HTML?",
                    TimeMax = 30,
                    Pass = 25
                };
                new Tests
                {
                    Name = "for DB students",
                    Category = "DB",
                    ListAsk = "What is a DataBase?",
                    TimeMax = 25,
                    Pass = 20
                };
                db.test.Add(ts);
                db.SaveChanges();
            }
        }
    }
}
