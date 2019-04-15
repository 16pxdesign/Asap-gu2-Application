using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository.Infrastructure
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        internal DbSet<T> DbSet;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException("unitOfWork");
            this.DbSet = _unitOfWork.Db.Set<T>();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> whereCondition)
        {
            var dbResult = DbSet.Where(whereCondition).FirstOrDefault();
            return dbResult;
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> whereCondition)
        {
            return DbSet.Where(whereCondition).AsEnumerable();
        }

        public virtual T Insert(T entity)
        {
            dynamic obj = DbSet.Add(entity);
            this._unitOfWork.Db.SaveChanges();
            return obj;

        }

        public virtual void Update(T entity)
        {
            DbSet.Attach(entity);
            _unitOfWork.Db.Entry(entity).State = EntityState.Modified;
            this._unitOfWork.Db.SaveChanges();


        }

        public virtual void UpdateAll(IList<T> entities)
        {
            foreach (var entity in entities)
            {
                DbSet.Attach(entity);
                _unitOfWork.Db.Entry(entity).State = EntityState.Modified;
            }
            this._unitOfWork.Db.SaveChanges();
        }

        public void Delete(Expression<Func<T, bool>> whereCondition)
        {
            IEnumerable<T> entities = this.GetAll(whereCondition);
            foreach (T entity in entities)
            {
                if (_unitOfWork.Db.Entry(entity).State == EntityState.Detached)
                {
                    DbSet.Attach(entity);
                }
                DbSet.Remove(entity);
            }
            this._unitOfWork.Db.SaveChanges();
        }

        public bool Exists(Expression<Func<T, bool>> whereCondition)
        {
            return DbSet.Any(whereCondition);
        }

        //--------------Exra generic methods--------------------------------

        public T SingleOrDefaultOrderBy(Expression<Func<T, bool>> whereCondition, Expression<Func<T, int>> orderBy, string direction)
        {
            if (direction == "ASC")
            {
                return DbSet.Where(whereCondition).OrderBy(orderBy).FirstOrDefault();

            }
            else
            {
                return DbSet.Where(whereCondition).OrderByDescending(orderBy).FirstOrDefault();
            }
        }

        public int Count(Expression<Func<T, bool>> whereCondition)
        {
            return DbSet.Where(whereCondition).Count();
        }

        public IEnumerable<T> GetPagedRecords(Expression<Func<T, bool>> whereCondition, Expression<Func<T, string>> orderBy, int pageNo, int pageSize)
        {
            return (DbSet.Where(whereCondition).OrderBy(orderBy).Skip((pageNo - 1) * pageSize).Take(pageSize)).AsEnumerable();
        }

        public IEnumerable<T> GetAllWithPagedRecords(Expression<Func<T, string>> orderBy, int pageNo, int pageSize)
        {
            return (DbSet.OrderBy(orderBy).Skip((pageNo - 1) * pageSize).Take(pageSize)).AsEnumerable();
        }

        public IEnumerable<T> ExecWithStoreProcedure(string query, params object[] parameters)
        {
            return DbSet.FromSql(query, parameters);
        }
    }

}
