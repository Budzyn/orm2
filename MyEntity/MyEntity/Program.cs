using MyEntity.Entity;
using MyEntity.Query;



namespace MyEntity
{
    class Program
    {

        static void Main(string[] args)
        {
            UsersQuery.ShowUsers();
            TestsQuery.ShowTests();
            DoTestQuery.ShowDoTest();
        }
    }
}
