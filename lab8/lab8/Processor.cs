﻿using System;

namespace lab8
{
    public class Processor<T> where T : new()
    {
        public enum EOperation
        {
            None,
            Add,
            Sub,
            Mul,
            Div
        }

        public enum EFunction
        {
            None,
            Rev,
            Sqr
        }

        public EOperation Operation;
        public EFunction Function;
        public T Lop_Res, Rop;

        public Processor()
        {
            Operation = EOperation.None;
            Function = EFunction.None;
            Lop_Res = new T();
            Rop = new T();
        }
        public Processor(T lop_res, T rop)
        {
            Operation = EOperation.None;
            Function = EFunction.None;
            Lop_Res = lop_res;
            Rop = rop;
        }

        public void OperationClear()
        {
            Operation = EOperation.None;
        }

        public void OperationRun()
        {
            switch (Operation)
            {
                case EOperation.Add:
                    {
                        Lop_Res = (dynamic)Lop_Res + (dynamic)Rop;
                        break;
                    }
                case EOperation.Sub:
                    {
                        Lop_Res = (dynamic)Lop_Res - (dynamic)Rop;
                        break;
                    }
                case EOperation.Mul:
                    {
                        Lop_Res = (dynamic)Lop_Res * (dynamic)Rop;
                        break;
                    }
                case EOperation.Div:
                    {
                        Lop_Res = (dynamic)Lop_Res / (dynamic)Rop;
                        break;
                    }
            }
        }

        public void OperationSet(int newop)
        {
            if (Enum.IsDefined(typeof(EOperation), newop))
                Operation = (EOperation)newop;
            else throw new ArgumentException();
        }

        public EOperation OperationGet()
        {
            return this.Operation;
        }

        public void FunctionClear()
        {
            Function = EFunction.None;
        }

        public void FunctionRun()
        {
            switch (Function)
            {
                case EFunction.Rev:
                    {
                        if (Rop.GetType().GetMethod("Rev")?.Invoke(Rop, null) == null)
                        {
                            Rop = 1 / (dynamic)Rop;
                        }
                        else Rop = (T)Rop.GetType().GetMethod("Rev")?.Invoke(Rop, null);
                        break;
                    }
                case EFunction.Sqr:
                    {
                        if (Rop.GetType().GetMethod("Sqr")?.Invoke(Rop, null) == null)
                        {
                            Rop = (T)Math.Pow((dynamic)Rop, 2);
                        }
                        else Rop = (T)Rop.GetType().GetMethod("Sqr")?.Invoke(Rop, null);
                        break;
                    }
            }
        }

        public void FunctionSet(int newfunc)
        {
            if (Enum.IsDefined(typeof(EFunction), newfunc))
                Function = (EFunction)newfunc;
            else throw new ArgumentException();
        }

        public EFunction FunctionGet()
        {
            return this.Function;
        }

        public void Lop_Res_Set(T newlopres)
        {
            Lop_Res = newlopres;
        }

        public void Rop_Set(T newrop)
        {
            Rop = newrop;
        }

        public void ReSet()
        {
            Lop_Res = new T();
            Rop = new T();
        }

        public string RetLop_Res()
        {
            object str = Lop_Res.GetType().GetMethod("Show")?.Invoke(Lop_Res, null) ?? Lop_Res;
            return str.ToString();
        }

        public T RetTLop_Res()
        {
            object str = Lop_Res.GetType().GetMethod("Copy")?.Invoke(null, new object[] { Lop_Res }) ?? Lop_Res;
            return (T)str;
        }

        public string RetRop()
        {
            object str = Rop.GetType().GetMethod("Show")?.Invoke(Rop, null) ?? Rop;
            return str.ToString();
        }

        public T RetTRop()
        {
            object str = Rop.GetType().GetMethod("Copy")?.Invoke(null, new object[] { Rop }) ?? Rop;
            return (T)str;
        }

        public override bool Equals(object obj)
        {
            if (((this.Lop_Res.Equals(((Processor<T>)obj).Lop_Res))) && (this.Rop.Equals(((Processor<T>)obj).Rop)))
            {
                return true;
            }
            else return false;
        }
    }
}