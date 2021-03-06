namespace Application.Interfaces.Database;

public interface ISqlDataService
{
    public void EnsureDatabaseStructure(string connectionId = "DefaultConnection");
    
    public Task<IEnumerable<TDataClass>> LoadData<TDataClass, TParameters>(
        string storedProcedure,
        TParameters parameters,
        string connectionId = "DefaultConnection");
    
    public Task<int> LoadDataCount<TParameters>(
        string storedProcedure,
        TParameters parameters,
        string connectionId = "DefaultConnection");

    public Task<int> SaveData<TParameters>(
        string storedProcedure,
        TParameters parameters,
        string connectionId = "DefaultConnection");
}