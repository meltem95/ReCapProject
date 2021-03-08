using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public Result Add(Customer customer)
        {
         
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
            
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);  
        }

        public IDataResult<List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 03)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customer>>( _customerDal.GetAll(),Messages.CustomerListed);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.UserId==customerId));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
