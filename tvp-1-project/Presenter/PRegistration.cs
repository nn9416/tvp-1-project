using System;
using System.Collections.Generic;
using System.Globalization;
using tvp_1_project.BussinesLogic;
using tvp_1_project.Model;
using tvp_1_project.View;

namespace tvp_1_project.Presenter
{
    public class PRegistration
    {
        private readonly IRegistrationView _view;
        private readonly ILoginRepository _repository;

        public PRegistration(IRegistrationView view, ILoginRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
        }

        internal bool TryCreateNew(Dictionary<string, string> values)
        {
            if (Validation.ValidateCustomer(values))
            {
                DateTime birthDate = DateTime.ParseExact(values["BirthDate"], "dd.MM.yyyy.", CultureInfo.InvariantCulture);
                Customer newCustomer = new Customer(
                    values["FirstName"],
                    values["LastName"],
                    values["Ssn"],
                    birthDate,
                    values["PhoneNumber"],
                    values["Username"],
                    values["Password"]);
                newCustomer.Create();
                return true;
            }
            else            
                return false;            
        }
    }
}
