using BankingAppU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppU.Data
{
      public class DbSet<T> where T : Entity
        {
        private readonly List<T> _list;
        public DbSet()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }
        public void Remove(T item)
        {
            _list.Remove(item);
        }
        public void Update(T item)
        {
            var oldItem = _list.Find(x => x.Id == item.Id);
            _list.Remove(oldItem);
            _list.Add(item);
        }

        public bool Any(Func<T, bool> predicate)
        {
            bool any = false;
            foreach (var item in _list)
{            
                if (predicate(item))
                {
                    any = true;
                    break;
                }
            }
            return any;
        }


        public IEnumerable<T> GetAll()
        {
            foreach (var item in _list)
            {
                    yield return item;
                
            }

        }

            public IEnumerable<T> GetAll(Func<T, bool> predicate)
            {

            foreach (var item in _list)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
             }

        public T Get(Func<T, bool> predicate)
        {

            T _item = default;
            foreach (var item in _list)
            {
                if (predicate(item))
                {
                    _item = item;
                    break;
                }
            }
            return _item;
        }
    }
}
