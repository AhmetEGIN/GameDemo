using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IBaseService<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
    }
}
