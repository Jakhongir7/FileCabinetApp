using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IRepository<T>
    {
        void Write(IEnumerable<T> documents);

        IEnumerable<T> Read();

        T GetById(int id);
    }
}
