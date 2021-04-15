using System;
using System.Collections.Generic;
using System.Linq;

namespace ImutableData
{
    public abstract class List<TA>
    {
        public static List<TA> Init(params TA[] a)
        {
            if (a.Length < 1)
            {
                return new Nil<TA>();
            }
            else
            {
                return new Cons<TA>(a[0],Init(a.Skip(1).ToArray()));
            }
        }

        public List<TA> SetHead(TA element, List<TA> kurt)
        {
            return new Cons<TA>(element, kurt);
        }

        public static List<TA> Drop(List<TA> l, int antal)
        {
            if (antal == 1)
            {
                 return ((Cons<TA>) l).Tail;//not finished
            }
            else
            {
                return Drop(l, antal--);//not finished
            }
        }
    }

    public sealed class Nil<TA> : List<TA>
    {

    }

    public sealed class Cons<TA> : List<TA>
    {
        public readonly TA X;
        public readonly List<TA> Tail;

        public Cons(TA x, List<TA> tail)
        {
            X = x;
            Tail = tail;
        }
    }
}
