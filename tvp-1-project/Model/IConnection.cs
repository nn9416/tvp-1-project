namespace tvp_1_project.Model
{
    interface IConnection<T>
    {
        void Create();
        T Read();
        void Update(T data);
        void Delete();
    }
}
