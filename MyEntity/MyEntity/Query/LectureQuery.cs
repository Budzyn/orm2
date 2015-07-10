using System.Collections.Generic;
using MyEntity.Entity;


namespace MyEntity.Query
{
    public class LectureQuery
    {
        private static ICollection<Teacher> tc;

        public static void Show()
        {
            using (var db = new Context())
            {
                var lc = new Lecture
                {
                    Name = "Beginen C#",
                    Category = ".Net",
                    Discriptions = "first lesson",
                    Teacher = tc
                };
                db.lect.Add(lc);
                db.SaveChanges();
            }
        }
    }
}
