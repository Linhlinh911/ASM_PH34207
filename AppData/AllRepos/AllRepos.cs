using AppData.IRepos;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.AllRepos
{

    public class AllRepos<T> : IRepos<T> where T : class
    {
        DBLaptopContext _context;
        DbSet<T> _dbSet;
        public AllRepos()
        {
            _context = new DBLaptopContext();
        }
        public AllRepos(DBLaptopContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }
        public bool CreateObj(T obj)
        {
            try
            {
                _dbSet.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteObj(T obj)
        {
            try
            {
                _dbSet.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(dynamic id)
        {
            return _dbSet.Find(id);
        }

        public bool UpdateObj(T obj)
        {
            try
            {
                _dbSet.Update(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
