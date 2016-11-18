using System;

namespace SuperHeroesUniverse.Common
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
