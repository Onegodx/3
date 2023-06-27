
using ConsoleApp18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp18
{
    public class Money : IPairMoney
    {
        private long _rubles;
        private byte _kopecks;

        public Money(long rubles, byte kopecks)
        {
            _rubles = rubles;
            _kopecks = kopecks;
        }

        public IPairMoney Add(IPairMoney value)
        {
            if (value is Money)
            {
                Money moneyValue = (Money)value;
                long rubles = _rubles + moneyValue._rubles;
                byte kopecks = (byte)(_kopecks + moneyValue._kopecks);
                if (kopecks >= 100)
                {
                    rubles++;
                    kopecks -= 100;
                }
                return new Money(rubles, kopecks);
            }
            else
            {
                throw new ArgumentException("арг моней");
            }
        }

        public IPairMoney Subtract(IPairMoney value)
        {
            if (value is Money)
            {
                Money moneyValue = (Money)value;
                long rubles = _rubles - moneyValue._rubles;
                byte kopecks = (byte)(_kopecks - moneyValue._kopecks);
                if (kopecks < 0)
                {
                    rubles--;
                    kopecks += 100;
                }
                if (rubles < 0)
                {
                    throw new ArgumentOutOfRangeException("не отрц");
                }
                return new Money(rubles, kopecks);
            }
            else
            {
                throw new ArgumentException("арг моней");
            }
        }

        public IPairMoney Multiply(double value)
        {
            long totalKopecks = (long)(_rubles * 100 + _kopecks);
            totalKopecks = (long)(totalKopecks * value);
            long rubles = totalKopecks / 100;
            byte kopecks = (byte)(totalKopecks % 100);
            return new Money(rubles, kopecks);
        }

        public IPairMoney Divide(double value)
        {
            long totalKopecks = (long)(_rubles * 100 + _kopecks);
            totalKopecks = (long)(totalKopecks / value);
            long rubles = totalKopecks / 100;
            byte kopecks = (byte)(totalKopecks % 100);
            return new Money(rubles, kopecks);
        }

        public int CompareTo(object obj)
        {
            if (obj is Money)
            {
                Money moneyValue = (Money)obj;
                if (_rubles > moneyValue._rubles)
                {
                    return 1;
                }
                else if (_rubles < moneyValue._rubles)
                {
                    return -1;
                }
                else if (_kopecks > moneyValue._kopecks)
                {
                    return 1;
                }
                else if (_kopecks < moneyValue._kopecks)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException("арг моней");
            }
        }

        public override string ToString()
        {
            return $"{_rubles},{_kopecks:00} rub.";
        }
    }
}