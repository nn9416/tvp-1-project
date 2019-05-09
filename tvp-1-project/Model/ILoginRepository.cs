using System.Collections.Generic;

namespace tvp_1_project.Model
{
    public interface ILoginRepository
    {
        Admin GetAdmin();
        List<Customer> GetCustomers();
    }
}
