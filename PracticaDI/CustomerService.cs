
using ItlaProyec.PracticaDI.Models;
using ItlaProyec.PracticaDI.Repository;

namespace ItlaProyec.PracticaDI;

public class CustomerService
{
    private readonly CustomerRepository _customerRepository;

    public CustomerService()
    {
        _customerRepository = new CustomerRepository();
    }

    public Customer GetCustomer()
    {
        return _customerRepository.GetCustomers();
    }
}
