﻿namespace BookLibrary.Data.Repository
{
    using System.Data.Entity;
    using System.Linq;

    class GenericRepository<T> : IRepository<T> where T : class
    {
        private BookLibraryDbContext context;
        private IDbSet<T> set;

        public GenericRepository()
            : this(new BookLibraryDbContext())
        {

        }

        public GenericRepository(BookLibraryDbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public IQueryable<T> All()
        {
            return this.set;
        }

        public void Add(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Added);
        }

        public void Delete(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Deleted);
        }

        public void Detach(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Detached);
        }

        public void Update(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Modified);
        }

        private void ChangeEntityState(T entity, EntityState state)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }
            entry.State = state;
        }
    }
}
