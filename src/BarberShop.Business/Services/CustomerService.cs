using System;
using BarberShop.Data.Repository;

namespace BarberShop.Business.Services;

public class CustomerService
{
    private readonly CustomerRepository _customerRepository;
    public CustomerService(CustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
}
