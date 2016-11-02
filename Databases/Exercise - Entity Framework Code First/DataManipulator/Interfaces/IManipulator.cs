using System.Collections.Generic;

namespace DataManipulator.Interfaces
{
    public interface IManipulator<T>
    {
        IEnumerable<T> GetAll();

        void Create(T entry);

        void Delete(int id);

        void Modidy(T entry);
    }
}
