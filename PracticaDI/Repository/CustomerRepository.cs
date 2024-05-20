
using ItlaProyec.PracticaDI.Models;

namespace ItlaProyec.PracticaDI.Repository;

public class CustomerRepository
{
    public Customer GetCustomers()
    {
        return new Customer { Id = 25, Name = "Alvaro" };
    }
}
