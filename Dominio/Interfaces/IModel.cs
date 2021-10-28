using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IModel <T>
    {
        void Create(T t);

        T[] FindAll();

        void Add(T t, ref T[] data);
    }
}
