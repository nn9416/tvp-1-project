namespace tvp_1_project.View
{
    public interface ILoginView
    {
        Presenter.PLogin Presenter { get; set; }
        string Username { get; }
        string Password { get; }
    }
}
