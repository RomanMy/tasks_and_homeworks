using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organs
{
    class MedicalCard : IEnumerable
    {
        public string Heart { get; set; }
        public string Kidneys { get; set; }
        public string Liver { get; set; }
        /*public IEnumerator GetEnumerator()
        {
            yield return Heart;
            yield return Kidneys;
            yield return Liver;
        }*/
        /*public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }*/
        public IEnumerator<string> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    /*class Enumerator : IEnumerator
    {
        public int index;
        MedicalCard my_card;
        public Enumerator(MedicalCard obj)
        {
            my_card = obj;
        }
        public object Current
        {
            get
            {
                if (index == 1 ) { return my_card.Heart; }
                else if (index == 2) { return my_card.Kidneys; }
                else if (index == 3) { return my_card.Liver; }
                else return null;
            }
        }
        public bool MoveNext()
        {
            if (index > 2 || index < 0) { return false; }
            index++;
            return true;
        }
        public void Reset()
        {
            index = 0;
        }
    }*/
    class Enumerator : IEnumerator<string>
    {
        public int index;
        public MedicalCard my_card;
        public Enumerator(MedicalCard obj)
        {
            my_card = obj;
        }
        public string Current
        {
            get
            {
                if (index == 1) { return my_card.Heart; }
                else if (index == 2) { return my_card.Kidneys; }
                else if (index == 3) { return my_card.Liver; }
                else return null;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose() { }
        public bool MoveNext()
        {
            if (index > 2 || index < 0) { return false; }
            index++;
            return true;
        }
        public void Reset()
        {
            index = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MedicalCard m1 = new MedicalCard { Heart = "fine", Kidneys = "fine", Liver = "fine" };
            foreach(string i in m1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
