using AdapterPattern;
using NUnit.Framework;

namespace AdapterTests
{
    public class Tests
    {
        [Test]
        public void EmployeeManager_AddEmployee_ReturnsCount5()
        {
            // Arrange
            var employee1 = new Employee(1000);
            var employee2 = new Employee(1000);
            var employee3 = new Employee(1000);
            var employee4 = new Employee(1000);
            var employee5 = new Employee(1000);
            var manager = new EmployeeManager();
            
            // Action
            manager.Add(employee1);
            manager.Add(employee2);
            manager.Add(employee3);
            manager.Add(employee4);
            manager.Add(employee5);

            // Assert
            const int expectedResult = 5;
            Assert.That(expectedResult,  Is.EqualTo(manager.CountEmployees()));
        }
        [Test]
        public void EmployeeManager_RemoveOneEmployee_ReturnsCount4()
        {
            // Arrange
            var employee1 = new Employee(1000);
            var employee2 = new Employee(1000);
            var employee3 = new Employee(1000);
            var employee4 = new Employee(1000);
            var employee5 = new Employee(1000);
            var manager = new EmployeeManager();
            manager.Add(employee1);
            manager.Add(employee2);
            manager.Add(employee3);
            manager.Add(employee4);
            manager.Add(employee5);

            // Action
            manager.Remove();

            // Assert
            const int expectedResult = 4;
            Assert.That(expectedResult, Is.EqualTo(manager.CountEmployees()));
        }
        [Test]
        public void EmployeeManager_PaySaleries_ReturnsTotalAmountOfSaleries()
        {
            // Arrange
            var employee1 = new Employee(1000);
            var employee2 = new Employee(1000);
            var employee3 = new Employee(1000);
            var employee4 = new Employee(1000);
            var employee5 = new Employee(1000);
            var manager = new EmployeeManager();
            manager.Add(employee1);
            manager.Add(employee2);
            manager.Add(employee3);
            manager.Add(employee4);
            manager.Add(employee5);

            // Action
            var totalAmountSalery = manager.PaySaleries(new SaleryAdaptor(new PresidentOfTheBoard(5000)));

            // Assert
            const int expectedResult = 10000;
            Assert.That(expectedResult, Is.EqualTo(totalAmountSalery));
        }
        [Test]
        public void EmployeeManager_PaySaleriesClassAdapter_ReturnsTotalAmountOfSaleries()
        {
            // Arrange
            var employee1 = new Employee(1000);
            var employee2 = new Employee(1000);
            var employee3 = new Employee(1000);
            var employee4 = new Employee(1000);
            var employee5 = new Employee(1000);
            var manager = new EmployeeManager();
            manager.Add(employee1);
            manager.Add(employee2);
            manager.Add(employee3);
            manager.Add(employee4);
            manager.Add(employee5);

            // Action
            var totalAmountSalery = manager.PaySaleries(new PresidentClassAdaptor(5000));

            // Assert
            const int expectedResult = 10000;
            Assert.That(expectedResult, Is.EqualTo(totalAmountSalery));
        }
    }
}