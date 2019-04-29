using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class VectorSparse : IAgregate
    {
        Dictionary<int, double> fields;
        int Length;
        public VectorSparse(int length)
        {
            fields = new Dictionary<int, double>();
            this.Length = length;
        }

        public void AddValue(int index, double value)
        {
            this.fields[index] = value;
        }

        public Iterator GetIterator()
        {
            return new VectorSparseIterator(this.fields, this.Length);
        }
    }

    public class VectorSparseIterator : Iterator
    {
        double[] vector;
        int Lenght;
        int current;
        public VectorSparseIterator(Dictionary<int, double> dict, int len)
        {
            
            this.Lenght = len;
            this.current = 0;
            vector = new double[this.Lenght];
            for (int i = 0; i < this.Lenght; i++)
            {
                if (dict.ContainsKey(i))
                {
                    vector[i] = dict[i];
                }
                else
                {
                    vector[i] = 0;
                }
            }
        }
        public bool IsDone { get; private set; }
        public void Next()
        {
            current++;
            if (current == this.Lenght) IsDone = true;
            return;
        }
        public double GetValue { get { return vector[current]; } }
    }

    public class Node
    {
        public double Value { get; set; }
        public Node Next { get; set; }

        public Node(double value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }
    }

    class VectorList : IAgregate
    {
        

        private Node head = null;

        public VectorList(int[] values)
        {
            //head = new Node(values[0]);
            Node c, n;
            foreach(var val in values)
            {
                c = new Node(val, null);
                if(head != null)
                {
                    n = head;
                    while (n.Next != null)
                        n = n.Next;
                    n.Next = c;
                }
                else
                {
                    head = c;
                }
            }
        }
        public Iterator GetIterator()
        {
            return new VectorListIterator(head);
        }
    }

    public class VectorListIterator : Iterator
    {
        double[] vector;
        int Lenght;
        int current;
        public VectorListIterator(Node head)
        {
            this.current = 0;
            Node n = head;
            int count = 0;
            if (head != null)
            {
                while (n.Next != null) { count++; n = n.Next; }
                count++;

                this.Lenght = count;
                vector = new double[this.Lenght];
                n = head;
                for (int i = 0; i < this.Lenght; i++, n = n.Next)
                {
                    vector[i] = n.Value;
                }
            }
            else
            {
                this.Lenght = 0;
                IsDone = true;
            }
        }

        public bool IsDone { get; private set; }

        public void Next()
        {
            current++;
            if (current == this.Lenght) IsDone = true;
            return;
        }

        public double GetValue { get { return vector[current]; } }

    }

    class VectorOneElement : IAgregate
    {
        int index;
        int value;
        int length;

        public VectorOneElement(int length, int index, int value)
        {
            this.index = index;
            this.value = value;
            this.length = length;
        }

        public Iterator GetIterator()
        {
            return new VectorOneElementIterator(this.index, this.value,this.length);
        }
    }

    public class VectorOneElementIterator : Iterator
    {
        double[] vector;
        int Lenght;
        int current;
        public VectorOneElementIterator(int index, int value, int len)
        {
            this.Lenght = len;
            this.current = 0;
            vector = new double[this.Lenght];
            for (int i = 0; i < this.Lenght; i++)
            {
                if (i==index)
                {
                    vector[i] = value;
                }
                else
                {
                    vector[i] = 0;
                }
            }
        }

        public bool IsDone { get; private set; }

        public void Next()
        {
            current++;
            if (current == this.Lenght) IsDone = true;
            return;
        }
        public double GetValue { get { return vector[current]; } }

    }

}
