
namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public List<Employee> employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "24",
                Name = "Anders Jensen",
                Email = "anje@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "25",
                Name = "Sofie Nielsen",
                Email = "soni@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "26",
                Name = "Thomas Pedersen",
                Email = "tope@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "27",
                Name = "Lise Hansen",
                Email = "liha@ibas.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantinen"
                }
            },
            new Employee() {
                Id = "28",
                Name = "Kim Larsen",
                Email = "kila@ibas.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantinen"
                }
            }
        };

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        [HttpGet("GetEmployees/department/{departmentId}")]
        public IEnumerable<Employee> GetByDepartment(int departmentId)
        {
            var employeesDepartment = employees.Where(e => e.Department.Id == departmentId).ToList();
            return employeesDepartment;
        }
    }
}
