using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Application.Repository.Infrastructure
{

    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Retrieve a single item by it's primary key or return null if not found
        /// </summary>
        T SingleOrDefault(Expression<Func<T, bool>> whereCondition);

        /// <summary>
        /// Returns all the rows for type T
        /// </summary>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Returns all the rows for type T on basis of filter condition
        /// </summary>
        IEnumerable<T> GetAll(Expression<Func<T, bool>> whereCondition);

        /// <summary>
        /// Inserts the data into the table
        /// </summary>
        T Insert(T entity);

        /// <summary>
        /// Updates this entity in the database using it's primary key
        /// </summary>
        void Update(T entity);

        /// <summary>
        /// Updates all the passed entities in the database 
        /// </summary>
        void UpdateAll(IList<T> entities);

        /// <summary>
        /// Deletes this entry fro the database       
        /// </summary>

        void Delete(Expression<Func<T, bool>> whereCondition);

        /// <summary>
        /// Does this item exist by it's primary key
        /// </summary>
        bool Exists(Expression<Func<T, bool>> whereCondition);
    }
}
