using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Models;
using Service.Services;

namespace FileCabinetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new DocumentRepository();
            
            for (int i = 1; i <= DocumentRepository.GetDocumentTypes().Count(); i++)
            {
                var byId = repo.GetById(i);
                Console.WriteLine(byId.GetType());
                Console.WriteLine(byId);
            }
        }
    }
}
