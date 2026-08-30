using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__Assignment01
{
    #region Question020
    //Q20: Complete Exercise - Create a generic Cache<TKey, TValue>
    //with Add, Get, Remove, Contains, and expiration support.
    internal class Cache<TKey,TValue> where TKey : IComparable<TKey>
    {
        private TValue[] Value {  get; set ; }
        private TKey[] Key  { get; set; }
        private DateTime[] ExpirationDate {  get; set; }
        private int Index=0;

        public Cache(int size = 10)
        {
            Value = new TValue[size];
            Key = new TKey[size];
            ExpirationDate = new DateTime[size];
        }

        public void Add(TKey key, TValue value, DateTime expirationDate)
        {
            if (key is not null && Index < Value.Length)
            {
                Value[Index]  =  value;
                Key[Index] = key;
                ExpirationDate[Index] = expirationDate;
                Index++;
            }
        }

        public TValue Get(TKey key)
        {
            for(int i = 0; i < Index; i++)
            {
                if (Key[i].CompareTo(key) == 0)
                {
                    return Value[i];
                }
            }
            return default;
        }

        public void Remove(TKey key)
        {
            for (int i = 0; i < Index; i++)
            {
                if (Key[i].CompareTo(key) == 0)
                {
                    for(; i < Index-1; i++)
                    {
                        Value[i]=Value[i + 1];
                        Key[i] = Key[i + 1];
                        ExpirationDate[i] = ExpirationDate[i + 1];
                    }
                    Index--;
                    break;
                }
            }
        }

        public bool Contains(TKey key)
        {
            for (int i = 0; i < Index; i++)
            {
                if (Key[i].CompareTo(key) == 0)
                {
                    return true;
                }
            }
            return false ;
        }



    }

    #endregion
}
