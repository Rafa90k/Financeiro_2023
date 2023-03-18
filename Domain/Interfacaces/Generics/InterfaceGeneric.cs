namespace Domain.Interfacaces.Generics;

public interface InterfaceGeneric <T> where T : class
{
    Task Add(T Objeto);
    Task Upadate(T Objeto);
    Task Delete(T Objeto);
    Task<T> GetEntityById(int Id);
    Task<List<T>> List();
}