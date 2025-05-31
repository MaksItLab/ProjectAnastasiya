using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public interface ISQL
    {
        void CreateServer();
    }

    public interface IMongoDb
    {
        void RunDb();
    }

    public interface ISQLite
    {
        void InstallPackage();
    }

    public abstract class Database
    {
        public string connectionString;

        public virtual void Connection()
        {
            Console.WriteLine("Подключение к базе данных");
        }

        public abstract void CreateQuery();
    }


    public class SqlContext : Database, ISQL
    {
        public override void CreateQuery()
        {
            throw new NotImplementedException();
        }

        public void CreateServer()
        {
            throw new NotImplementedException();
        }

        override 
    }
}
