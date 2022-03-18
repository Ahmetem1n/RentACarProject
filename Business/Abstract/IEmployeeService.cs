using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();
        IDataResult<Employee> GetById(long employeeId);
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);


    }
}
