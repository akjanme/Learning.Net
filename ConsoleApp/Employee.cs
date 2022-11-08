using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //types of classes 
    //Base on access modifiers
    public partial class Employee
    {
        public int ID { get; set; }
        public int Name { get; set; }
    }
    public partial class Employee
    {
        public int EmpID { get; set; }
    }
    public static class EmployeeDetails
    {
        public static int EmpID { get; set; }
    }
    public abstract class Phone
    {
        public abstract void Calling(); 
        public void SMS()
        {

        }
    }
    public class KeyPadPhone : Phone
    {
        public override void Calling()
        {
            throw new NotImplementedException();
        }
    }
    public interface IEmployee
    {
        List<Employee> Get(); 
        void Insert(Employee employee);
    }
    public interface IEmployeeDetail
    {
        List<Employee> GetDetail(); 
    }
    public partial class Employee : IEmployee, IEmployeeDetail
    {
        public List<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetDetail()
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
