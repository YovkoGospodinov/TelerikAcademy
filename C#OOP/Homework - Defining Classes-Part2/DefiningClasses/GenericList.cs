namespace DefiningClasses
{
    using System;

    public class GenericList<T>
    {
        #region Fields
        private T[] elements;
        private int size;
        private int index;
        #endregion

        #region Constructors
        public GenericList(int size)
        {
            this.elements = new T[size];
            this.Size = size;
        }
        #endregion

        #region Properties
        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        #endregion

        #region Methods
        //Indexer
        public T this[int index]
        {
            get
            {
                if (this.index < 0 || this.index >= this.elements.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.elements[index];
            }
            private set
            {
                if (this.index < 0 || this.index >= this.elements.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.elements[index] = value;
            }
        }


        public void AddElement(T element)
        {
            this.elements[index] = element;
            this.index++;
            
            //Double increasing the lenght of the array
            if (this.index == this.elements.Length)
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
            this.index = 0;
        }

        public void RemoveElement(int index)
        {
            for (int i = index; (i < this.index) && (i < this.elements.Length - 1); i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.index--;
        }

        public void InsertElement(int index, T element)
        {
            if (this.index == this.elements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = this.index + 1; i >= index ; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            this.index++;
        }

        public T GetElement(int index)
        {
            return elements[index];
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements);
        }

        #endregion
    }
}
