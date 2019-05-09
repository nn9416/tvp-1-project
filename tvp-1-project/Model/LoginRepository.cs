using System.Collections.Generic;

namespace tvp_1_project.Model
{
    public class LoginRepository: ILoginRepository
    {
        public LoginRepository() { }

        #region ILoginRepository
        public Admin GetAdmin() => Admin.Read();

        public List<Customer> GetCustomers() => Customer.ReadAll();
        #endregion
    }
}
