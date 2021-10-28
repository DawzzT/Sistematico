using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Inventarios
{
    public class BaseRepository<T> : IModel<T>
    {
        protected T[] data;
        public void Create(T t)
        {
            Add(t, ref data);
        }

        public T[] FindAll()
        {
            return data;
        }


        public void Add(T t, ref T[] data)
        {
            if (data == null)
            {
                data = new T[1];
                data[0] = t;
                return;
            }

            T[] tmp = new T[data.Length + 1];
            Array.Copy(data, tmp, data.Length);
            tmp[tmp.Length - 1] = t;
            data = tmp;
        }
    }
}
