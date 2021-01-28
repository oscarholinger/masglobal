using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Employees.Core.Entities;

namespace Employees.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
