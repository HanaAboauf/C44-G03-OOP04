using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop04.assignment
{
    public class Complex
    {

        #region Properties

        public int Real { get; set; }

        public int Imag { get; set; }
        #endregion

        #region Constructors
        public Complex()
        {
            Real = 0;
            Imag = 0;
        }

        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }
        #endregion



        #region Methods

        public static Complex operator +(Complex? c1, Complex? c2)
        {
            return new Complex
            {
                Real = (c1?.Real ?? 0) + (c2?.Real ?? 0),
                Imag = (c1?.Imag ?? 0) + (c2?.Imag ?? 0)
            };

        }

        public static Complex operator -(Complex? c1, Complex? c2)
        {
            return new Complex
            {
                Real = (c1?.Real ?? 0) - (c2?.Real ?? 0),
                Imag = (c1?.Imag ?? 0) - (c2?.Imag ?? 0)
            };
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }


        #endregion
    }
}
