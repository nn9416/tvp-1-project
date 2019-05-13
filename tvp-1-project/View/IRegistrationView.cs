﻿using System;
using tvp_1_project.Presenter;

namespace tvp_1_project.View
{
    public interface IRegistrationView
    {
        PRegistration Presenter { get; set; }
        string FirstName { get; }
        string LastName { get; }
        string Ssn { get; }
        DateTime BirthDate { get; }
        string PhoneNumber { get; }
        string Username { get; }
        string Password { get; }
        void RegistrationProcessInfo(bool success);
    } 
}
