namespace DefiningClasses
{
    using System;

    public class GenericList<T> where T: IComparable<T>
    {
        #region Fields
        private T[] elements;
        //private int size;
        private int position;
        #endregion

        #region Constructors
        public GenericList(int size)
        {
            this.elements = new T[size];
            //this.Size = size;
        }
        #endregion

        #region Properties
        //public int Size
        //{
        //    get
        //    {
        //        return this.size;
        //    }
        //    set
        //    {
        //        this.size = value;
        //    }
        //}
        #endregion

        #region Methods
        //Indexer
        public T this[int index]
        {
            get
            {
                if (this.position < 0 || this.position >= this.elements.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.elements[index];
            }
            private set
            {
                if (this.position < 0 || this.position >= this.elements.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.elements[index] = value;
            }
        }


        public void AddElement(T element)
        {
            this.elements[position] = element;
            this.position++;
            
            //Double increasing the lenght of the array
            if (this.position == this.elements.Length)
            {
                var newElements = new T[2 * this.elements.Length];

                for (int i = 0; i < this.elements.Length; i++)
                {
                    newElements[i] = this.elements[i];
                }

                this.elements = newElements;
            }
        }

        public void ClearElements()
        {
            this.elements = new T[this.elements.Length];
            this.position = 0;
        }

        public void RemoveElement(int index)
        {
            for (int i = index; (i < this.position) && (i < this.elements.Length - 1); i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.position--;
            this.elements[position] = default(T);
        }

        public void InsertElement(int index, T element)
        {
            if (this.position == this.elements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = this.position + 1; i >= index ; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            this.position++;
        }

        public T GetElement(int index)
        {
            return elements[index];
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements);
        }

        public T GetMinEl()
        {
            var min = this.elements[0];

            if (this.elements.Length == 0)
            {
                throw new ArgumentException("The GenericList does not contains elements!");
            }

            for (int i = 1; i < this.elements.Length; i++)
            {
                var temp = this.elements[i];
                if (min.CompareTo(temp) > 0)
                {
                    min = temp;
                }
            }

            return min;
        }

        public T GetMaxEl()
        {
            var max = this.elements[0];

            if (this.elements.Length == 0)
            {
                throw new ArgumentException("The GenericList does not contains elements!");
            }

            for (int i = 1; i < this.elements.Length; i++)
            {
                var temp = this.elements[i];
                if (max.CompareTo(temp) < 0)
                {
                    max = temp;
                }
            }

            return max;
        }
        #endregion
    }
}
