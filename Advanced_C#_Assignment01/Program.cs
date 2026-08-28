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
            #region Question07
            /*Q7: What is the 'struct' constraint? Write an example.
                    ==>> This means that no one can use it except struct data types.
                
            public static void print<T> (T thing) where T : struct
            {
                Console.WriteLine($"Thing : {thing}");
            }
            */
            #endregion
            #region Question08
            /*Q8: What is the 'class' constraint? Write an example.
                   ==>> This means that no one can use it except class data types
             
            public static void print<T> (T thing) where T : class
            {
                Console.WriteLine($"Thing : {thing}");
            }
            */
            #endregion
            #region Question09
            /*Q9: What is the 'new()' constraint? Write an example
                   ==>> Anyone who uses me must have parameterless constructor
                
            public static void print<T> (T thing) where T : new()
            {
                Console.WriteLine($"Thing : {thing}");
            }
             
            */
            #endregion
            #region Question010
            /*Q10:  What is the interface constraint? Write an example.
                      ==>>that means I don't care whether T is a specific class
                          what is important is that it implements a specific interface
                          so that I can use its methods and properties

             //Here all that matters to me is find CompareTo
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
            #region Question011
            /* Q11: What is the base class constraint? Write an example.
                     ==>> that means No one can use me except a specific class and which class inherits from it
            public class Animal
            {
                public string name;
                public override string ToString()
                {
                    return $" Animal Name : {name}";
                }
            }

            public class dog : Animal
            {
                public override string ToString()
                {
                    return $"Dog Name : {name}";
                }
            }

            public static void printAnimal<T>(T animal) where T : Animal
            {
                Console.WriteLine(animal.ToString());
            }
            */
            #endregion
            #region Question012
            /*Q12: How do you apply multiple constraints? Write an example.
                    ==>> Multiple constraints are specified after where T : and separated by commas
                         and it must keep this arrangement class or struct -> Interfaces -> new() 
                         and also we can make it without class or struct, or without any one of them 

            public static void print<T> (T thing) where T : class, IPrintable, new()
            {
                Console.WriteLine($"Thing : {thing}");
            }             
            */
            #endregion
            #region Question013
            /*Q13: What does the 'default' keyword do in generics?
                    ==>> It returns the default value of a generic type
            */
            #endregion
            #region Question014
            /*Q14: Write a SafeList<T> that returns default when the index is invalid.
  
                    internal class SafeList<T>
                    {
                        List<T> list;

                        public T GetIndexValue(int index)
                        {
                            if (index >= 0 && index < list.Count )
                            {
                                return list[index];
                            }
                            return default;
                        }
                    }
             
            */
            #endregion
            #region Question015
            /*Q15: What is covariance? Explain the 'out' keyword.
                    ==>> covariance means that type we use it as output only
                   'out' means we use the type as return type or out type only
            */
            #endregion
        }

    }
}
