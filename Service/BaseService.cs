using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Repository;

namespace Poslasticarnica.Service
{
    public class BaseService<TEntity> where TEntity:class
    {
        protected readonly ProjectConfiguration _configuration;
        protected readonly ILogger _logger;

        public BaseService()
        {


        }
        public BaseService(ProjectConfiguration configuraton)
        {
            _configuration = configuraton;
        }

        public BaseService(ProjectConfiguration configuration, ILogger<BaseService<TEntity>> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public virtual IEnumerable<TEntity> GetAll() 
        {
            try
            {
                using UnitOfWork unitOfWork = new(new ApplicationContext());
               
                return unitOfWork.GetRepository<TEntity>().GetAll();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public virtual TEntity Get(long Id)
        {
            try
            {
                using UnitOfWork unitOfWork = new(new ApplicationContext());
                TEntity entity = unitOfWork.GetRepository<TEntity>().Get(Id);

                return entity;
            }
            catch(Exception e)
            {
                _logger.LogError($"Error in BaseService in Get Method {e.Message} in {e.StackTrace}");
                return null;
            }
        }

        public virtual TEntity Add(TEntity entity)
        {
            try
            {
                using UnitOfWork unitOfWork = new(new ApplicationContext());

                unitOfWork.GetRepository<TEntity>().Add(entity);
                _ = unitOfWork.Complete();

                return entity;
            }
            catch(Exception e)
            {
                _logger.LogError($"Error in BaseService in Add Method{e.Message} in {e.StackTrace}");
                return null;
            }
        }

        public virtual bool Update(long Id, TEntity ent)
        {
            try
            {
                using UnitOfWork unitOfWork = new(new ApplicationContext());
                TEntity entity = Get(Id);

                if (entity == null)
                {
                    unitOfWork.GetRepository<TEntity>().Add(ent);
                }
                unitOfWork.GetRepository<TEntity>().Update(ent);
                _ = unitOfWork.Complete();

                return true;
            }
            catch(Exception e)
            {
                _logger.LogError($"Error in BaseService in Update Method {e.Message} in {e.StackTrace}");
                return false;
            }
        }

        public virtual bool Delete(long Id)
        {
            try
            {
                using UnitOfWork unitOfWork = new(new ApplicationContext());
                TEntity entity = unitOfWork.GetRepository<TEntity>().Get(Id);

                (entity as Entity).Deleted = true;

                unitOfWork.GetRepository<TEntity>().Update(entity);
                _ = unitOfWork.Complete();

                return true;
            }
            catch(Exception e)
            {
                _logger.LogError($"Error in BaseService in Delete Method {e.Message} in {e.StackTrace}");
                return false;
            }
        }
    }
}
