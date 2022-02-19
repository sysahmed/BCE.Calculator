using BCE.Business.Abstract;
using BCE.Business.Concrete;
using BCE.DataAccess.Abstract;
using BCE.Entities.Concrete;
using Moq;
using NUnit.Framework;

namespace BCE.UnitTest
{
    public class Tests
    {
        Mock<IEmployeeDal> _mockEmployeeDal;
        Employees _employee;

        IEmployeeService _iemployeeService;
        public Tests()
        {
            _mockEmployeeDal = new Mock<IEmployeeDal>();
            _employee = new Employees { GrossIncome = 5000 };
            _iemployeeService = new EmployeeManager(_mockEmployeeDal.Object);
        }
        [SetUp]
        public void Setup()
        {
            _mockEmployeeDal.Setup(m => m.  Add(_employee));
        }
        [Test]
        public void TestMethod_AddEmployeee()
        {
            bool result = _iemployeeService.Add(new Employees { GrossIncome = 1010 }).Success;
            Assert.IsTrue(result);
        }
        [Test]
        public void TestMethod_EstimateVat()
        {
            bool result = _iemployeeService.GetEstimateVat(new Employees { GrossIncome = 1010 }).Success;
            Assert.IsTrue(result);
        }
        [Test]
        public void TestMethod_GetSocialContributions()
        {
            bool result = _iemployeeService.GetSocialContributions(new Employees { GrossIncome = 980 }).Success;
            Assert.IsTrue(result);
        }
        [Test]
        public void TestMethod_CharitySpent()
        {
            bool result = _iemployeeService.CharitySpent(new Employees { GrossIncome = 3600 }).Success;
            Assert.IsTrue(result);
        }
       
    }
}