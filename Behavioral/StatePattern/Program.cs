﻿using System;
using System.Linq.Expressions;

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Del((a, b) => DateTime.Now);
            //Exp((a, b) => DateTime.Now);
            var initState = new HomeState();
            var context = new Context(initState);
            context.Move(new DateTime(2019, 1, 1, 7, 0, 0));
            context.Move(new DateTime(2019, 1, 1, 10, 0, 0));
            context.Move(new DateTime(2019, 1, 1, 12, 0, 0));
            context.Move(new DateTime(2019, 1, 1, 20, 0, 0));
            context.Move(new DateTime(2019, 1, 4, 5, 0, 0));
            context.Move(new DateTime(2019, 1, 4, 12, 0, 0));

            Console.ReadKey();
        }

        private static void Exp(Expression<Func<int, string, DateTime>> data)
        {
        }

        private static void Del(Func<int, string, DateTime> data)
        {
        }

    }
}

public class Memento
{
    public readonly string Name;
    public readonly int Value;

    public Memento(string name, int value)
    {
        Name = name;
        Value = value;
    }
}

public class OriginalObject
{
    private Memento _mememto;

    public string Name { get; set; }
    public int Value { get; set; }
    public OriginalObject(string name, int value)
    {
        Name = name;
        Value = value;
        this._mememto = new Memento(name, value);
    }

    public void Revert()
    {
        Name = this._mememto.Name;
       Value = this._mememto.Value;
    }
}