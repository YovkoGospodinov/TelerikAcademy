using System.Collections.Generic;

namespace DataManipulator.Interfaces
{
    public interface IManipulator<T>
    {
        IEnumerable<T> GetAll();

        void Create(T entry);

        void Delete(int Id);

        void Modidy(T entry);
    }
}
