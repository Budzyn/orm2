using System.Collections.Generic;
using MyEntity.Entity;


namespace MyEntity.Query
{
    public class TeacherQuery
    {
        private static ICollection<Lecture> lc;

        public static void ShowTeacher()
        {
            using (var db = new Context())
            {
                var tc = new Teacher
                {
                    Name = "Ivan Filatov",
                    Lecture = lc
                };
                new Teacher
                {
                    Name = "Roman Sokolov",
                    Lecture = lc
                };
                new Teacher
                {
                    Name = "Roman Sergeev",
                    Lecture = lc
                };
                
                db.teachers.Add(tc);
                db.SaveChanges();
            }
        }
    }
}
