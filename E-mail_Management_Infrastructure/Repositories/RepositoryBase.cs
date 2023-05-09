using E_mail_Management_Domain.Interfaces;
using E_mail_Management_Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_Management_Infrastructure.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected Email_Management_Context _context;
        public bool _saveChangues = true;
        public RepositoryBase( bool saveChangues = true)
        {
            _saveChangues = saveChangues;
            _context = new Email_Management_Context();
        }
        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
