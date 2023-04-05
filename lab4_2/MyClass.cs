using System;

namespace lab4_2
{
    public abstract class MyCalcBase
    {
        protected double _result;

        public abstract double Calculate();

        public double Result
        {
            get { return _result; }
        }
    }

    public class MyCalc1 : MyCalcBase
    {
        private int _a = 0;
        private double _b;

        public int A
        {
            get => _a;
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Значение b не может быть равно нулю");
                }
                _b = value;
            }
        }

        public override double Calculate()
        {
            _result = (_a - _b) / (_a - 2);
            return _result;
        }
    }

    public class MyCalc2 : MyCalcBase
    {
        private double _a, _b, _d;

        public int A
        {
            set { _a = value; }
        }
        public double B
        {
            set { _b = value; }
            get { return _b; }
        }
        public double D
        {
            set { _d = value; }
        }

        public override double Calculate()
        {
            _result = (_a - _d) / (_a + _d);
            return _result;
        }
    }

}