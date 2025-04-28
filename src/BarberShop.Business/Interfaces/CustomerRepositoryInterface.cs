using System;
using BarberShop.Business.Models;
using Microsoft.VisualBasic.FileIO;

namespace BarberShop.Business.Interfaces;

interface CustomerRepositoryInterface
{
    List<Customer> findAll();
    Customer findById(Guid idCustomer);
    Customer delete(Customer customer);
    Customer update(Customer customer);
}
