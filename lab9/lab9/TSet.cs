using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9
{
    public class TSet<T>
    {
        public HashSet<T> hashset;
        public TSet()
        {
            hashset = new HashSet<T>();
        }
        public void Clear()
        {
            hashset.Clear();
        }
        public void Add(T item)
        {
            hashset.Add(item);
        }
        public void Remove(T item)
        {
            hashset.Remove(item);
        }
        public bool IsClear()
        {
            try { hashset.Last(); }
            catch (InvalidOperationException) { return true; }
            return false;
        }
        public bool Contains(T item)
        {
            return hashset.Contains(item);
        }
        public TSet<T> Union(TSet<T> ts)
        {
            TSet<T> newtset = new TSet<T>();
            foreach (T t in this.hashset)
            {
                newtset.Add(t);
            }
            foreach (T t in ts.hashset)
            {
                newtset.Add(t);
            }
            return newtset;
        }
        public TSet<T> Except(TSet<T> ts)
        {
            TSet<T> newtset = new TSet<T>();
            foreach (T t in this.hashset)
            {
                newtset.Add(t);
            }
            foreach (T t in ts.hashset)
            {
                newtset.Remove(t);
            }
            return newtset;
        }
        public TSet<T> Intersect(TSet<T> ts)
        {
            TSet<T> newtset = new TSet<T>();
            foreach (T t in this.hashset)
            {
                if (ts.Contains(t))
                    newtset.Add(t);
            }
            return newtset;
        }
        public int Count()
        {
            return this.hashset.Count();
        }
        public T ElementAt(int i)
        {
            object ret = this.hashset.ElementAt(i);
            return (T)ret;
        }
        public String Show()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T t in this.hashset)
            {
                sb.Append($"{t.GetType().GetMethod("Show")?.Invoke(t, null) ?? t} ");
            }
            //sb.Append("\n");
            return sb.ToString();
            //Console.WriteLine();
        }
        public override bool Equals(object obj)
        {
            if (this.hashset.Count == ((TSet<T>)obj).hashset.Count)
            {
                for (int i = 0; i < hashset.Count; i++)
                {
                    if (!(this.hashset.ElementAt(i).Equals(((TSet<T>)obj).hashset.ElementAt(i))))
                        return false;
                }
            }
            return true;
        }
    }
}
