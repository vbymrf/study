using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson3
{
    class Fractions
    {
        private int numerator;
        private int denominator;

        public Fractions(int numerator, int denominator)
        {
             
            this.numerator = numerator;
            if (denominator > 0)
                this.denominator = denominator;
            else if (denominator < 0)
            {
                this.denominator = -1*denominator;
                this.numerator *= -1;
            }
            else denominator = 1;

        }
        public Fractions()
        {
            this.numerator = 1;
            this.denominator = 2;
        }
        public int Numerator
        {
            get { return this.numerator;}
            set { this.numerator = value; }            
        }
        public int Denominator
        {
            get { return this.denominator; }
            set{
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                else if (value > 0)
                    this.denominator = value;
                else if (value < 0)
                {
                    this.denominator = -1 * value;
                    this.numerator *= -1;
                }
            }
        }
        public int Nod(int y1, int y2)
        {
            int n, kon = Math.Max(y1, y2);
            ArrayList sum=new ArrayList();
            for (int i = 2; i <= kon; i++)
            {
                if (y1 % i == 0 && y2 % i == 0)  {
                n = i;
                kon =kon/i;
                sum.Add(n);
            }
            }
            n = 1;
            foreach (int d in sum)
            {
                n = n * d;
            }
             return (y1*y2)/n;
            
        }
        public Fractions Plus(Fractions tu)
        {
            Fractions one = new Fractions();
            int x1, x2, y1, y2,nod;
            x1 = this.numerator;
            x2 = tu.numerator;
            y1 = this.denominator;
            y2 = tu.denominator;
            nod=Nod(y1,y2);

            one.numerator = (x1 * nod / y1) + (x2*nod / y2);
            one.denominator = nod;
            
            int nod2=Nod(one.numerator,one.denominator);
            one.numerator = one.numerator/nod2;
            one.denominator = one.denominator/nod2;

            return one; 
        }

        
        public Fractions Minus(Fractions tu)
        {
            Fractions one = new Fractions();
            int x1, x2, y1, y2;
            x1 = this.numerator;
            x2 = tu.numerator;
            y1 = this.denominator;
            y2 = tu.denominator;
            int nod = Nod(y1, y2);
            one.numerator = (x1 * nod / y1) - (x2 * nod / y2);
            one.denominator = nod;

            int nod2 = Nod(one.numerator, one.denominator);
            one.numerator = one.numerator / nod2;
            one.denominator = one.denominator / nod2;

            return one;
        }
        public Fractions Multi(Fractions tu)
        {
            Fractions one = new Fractions();
            int x1, x2, y1, y2;
            x1 = this.numerator;
            x2 = tu.numerator;
            y1 = this.denominator;
            y2 = tu.denominator;
            int nod = Nod(y1, y2);
            one.numerator = (x1 * nod / y1) * (x2 * nod / y2);
            one.denominator = nod;

            int nod2 = Nod(one.numerator, one.denominator);
            one.numerator = one.numerator / nod2;
            one.denominator = one.denominator / nod2;

            return one;
        }
        public Fractions Del(Fractions tu)
        {
            Fractions one = new Fractions();
            int x1, x2, y1, y2;
            x1 = this.numerator;
            x2 = tu.numerator;
            y1 = this.denominator;
            y2 = tu.denominator;
            int nod = Nod(y1, y2);
            one.numerator = (x1 * nod / y1) / (x2 * nod / y2);
            one.denominator = nod;

            int nod2 = Nod(one.numerator, one.denominator);
            one.numerator = one.numerator / nod2;
            one.denominator = one.denominator / nod2;

            return one;
        }
        public double DoubleFractions()
        {
            return (double)this.numerator / (double)this.denominator;
        }

        public override string ToString()
        {
            return this.numerator+"/"+this.denominator;
        }

    
    }
}
