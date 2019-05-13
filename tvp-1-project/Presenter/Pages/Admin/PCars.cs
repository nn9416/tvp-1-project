using System.Collections.Generic;
using System.Linq;
using tvp_1_project.Model;
using tvp_1_project.View.Pages.Admin;

namespace tvp_1_project.Presenter.Pages.Admin
{
    public class PCars
    {
        private readonly ICarsView _view;
        private readonly IDataRepository _repository;
        private List<CarMakes> carMakes;
        private List<CarModels> carModels;        

        public PCars(ICarsView view, IDataRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
        }

        internal void UpdateData() => _view.UpdateDataViewer(_repository.GetCars());

        internal void GetCars() => _view.PopulateDataViewer(_repository.GetCars());

        internal List<string> GetYears() => _repository.GetYears();

        #region Setters for input controls
        internal List<string> SetMakes(string year)
        {
            carMakes = _repository.GetAllMakesForYear(year).CarMakes;
            return carMakes.Select(i => i.Make).ToList();
        }

        internal List<string> SetModels(string make)
        {
            carModels = _repository.GetAllModelsForMake(make, carMakes);
            return carModels.Select(i => i.Model).ToList();
        }

        internal List<string> SetDisplacement(string model) => _repository.GetDisplacementForModel(model, carModels);

        internal List<string> SetFuel(string model) => _repository.GetFuelForModel(model, carModels);

        internal List<string> SetDrive(string model) => _repository.GetDriveForModel(model, carModels);

        internal List<string> SetTransmission(string model) => _repository.GetTransmissionForModel(model, carModels);

        internal List<string> SetBody(string model) => _repository.GetBodyTypesForModel(model, carModels);

        internal List<string> SetNumberOfDoors(string model) => _repository.GetNumberOfDoorsForModel(model, carModels);
        #endregion
    }
}
