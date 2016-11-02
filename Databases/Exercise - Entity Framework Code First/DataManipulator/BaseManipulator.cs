using StudentSystem.Data;

namespace DataManipulator
{
    public abstract class BaseManipulator
    {
        protected StudentSystemEntities database;
        protected BaseManipulator()
        {
            database = new StudentSystemEntities();
        }
    }
}
