//[!] 리포지토리(Repository) 패턴(저장소 패턴): 저장소를 쉽게 관리 
using System;

namespace RepositoryPatternDemo
{
    public interface ITableRepository
    {
        string GetAll();
    }
    public class TableInMemoryRepository : ITableRepository
    {
        public string GetAll()
        {
            return "인-메모리 데이터베이스 사용"; 
        }
    }
    public class TableSqlRepository : ITableRepository
    {
        public string GetAll()
        {
            return "SQL Server 데이터베이스 사용";
        }
    }
    public class TableXmlRepository : ITableRepository
    {
        public string GetAll()
        {
            return "XML 데이터베이스 사용";
        }
    }
    class RepositoryPatternDemo
    {
        static void Main(string[] args)
        {
            // SQL, InMemoy, XML 등 넘어오는 값에 따른 인스턴스 생성(저장소 결정)
            string repo = "SQL"; 

            ITableRepository repository;
            if (repo == "InMemoy")
            {
                repository = new TableInMemoryRepository();
            }
            else if (repo == "XML")
            {
                repository = new TableXmlRepository();
            }
            else
            {
                repository = new TableSqlRepository();
            }

            Console.WriteLine(repository.GetAll());
        }
    }
}
