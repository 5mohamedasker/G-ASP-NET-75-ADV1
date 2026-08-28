using System.ComponentModel;

namespace Advanced_C__Assignment01
{
    internal class Program
    {
        static void Main()
        {
            #region Question01
            /* What is a generic class? Why use generics?
                ==>> Class that can work with different data types
                     and the data type is specified when we create an object of the clas
                ==>>We use it because it can work with different data types
                    when we have the same behavior or implementation
                    but need to work with different data types
                    which improves code reusability and type safety
            */
            #endregion
            #region Question02
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //internal class Container<T>
            //{
            //    private T Value { get; set; }
            //    public void Add(T item)
            //    {
            //        Value = item;
            //    }
            //    public T Get()
            //    {
            //        return Value;
            //    }
            //}
            #endregion
            #region Question03
            /*Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
                   ==>>It mean that a generic class can work with more than one data type at the same time
                       instead of using only one type paramete
                   ==>> internal class Pair<TKey, TValue>{.....}
            */
            #endregion
            #region Question04
            /*Q4: What is a generic method? Write Swap<T> method.
                   ==>> Method that can work with different data types
                        and the data type is specified when we call it
                
            public static void Swap<T>(ref T x,ref T y)
                {
                    T z = x;
                    x = y;
                    y = z;
                }       
            */
            #endregion
            #region Question05
            /*Q5: Write a generic method FindMax<T> that finds maximum value
                   
             public static T FindMax<T>(T[] values) where T : IComparable<T>
             {
                if (values is not null && values.Length > 0)
                    {
                        T max = values[0];
                        foreach (T value in values)
                        {
                            if (value.CompareTo(max)>0)
                                max= value;
                        }
                        return max;
                    }
                return default;
             }
            */
            #endregion
            #region Question06
            /* Q6: What is a generic interface? Write IRepository<T>.
                    ==>> Interface that can work with different data types
                         and the data type is specified when we implement it

            internal interface IRepository<T>
            {
                T Get(T entity);
                T[] GetAll();
                void Add(T entity);
                void Update(T entity);
                void Delete(T entity);
            }                
            */
            #endregion
        }
    }
}
