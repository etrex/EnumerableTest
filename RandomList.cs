using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumerableTest
{
    class RandomList : IEnumerable<double>, IEnumerator<double>
    {
        Random rand = new Random();
        double current = 1;
        double min = 0.2;



        public IEnumerator<double> GetEnumerator()
        {
            return this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public double Current
        {
            get
            {
                return current;
            }
        }

        public void Dispose()
        {
            
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            if ( current > min ) {
                current = rand.NextDouble();
                return true;
            } else {
                return false;
            }
        }

        public void Reset()
        {
            current = 1;
        }
    }
}
