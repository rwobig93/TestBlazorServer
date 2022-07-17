﻿using Application.Extensibility.Extensions;
using Application.Interfaces.Database;
using Application.Interfaces.Example;
using Domain.Entities.Example;
using Shared.Requests.Example;
using static Application.Constants.Database.MsSqlConstants.StoredProcedures;

namespace Infrastructure.Features.Example;

public class ExampleUserRepository : IExampleUserRepository
{
    private readonly ISqlDataAccess _database;

    public ExampleUserRepository(ISqlDataAccess database)
    {
        _database = database;
    }

    public Task<IEnumerable<ExampleUser>> GetAllUsers() =>
        _database.LoadData<ExampleUser, dynamic>(ExampleUserGetAll.DboFullName(), new { });

    public async Task<ExampleUser?> GetUser(GetExampleUserRequest userRequest) =>
        (await _database.LoadData<ExampleUser, dynamic>(ExampleUserGet.DboFullName(), userRequest)).FirstOrDefault();

    public Task CreateUser(CreateExampleUserRequest userRequest) =>
        _database.SaveData(ExampleUserCreate.DboFullName(), userRequest);

    public Task UpdateUser(UpdateExampleUserRequest userRequest) =>
        _database.SaveData(ExampleUserUpdate.DboFullName(), userRequest);

    public Task DeleteUser(DeleteExampleUserRequest userRequest) =>
        _database.SaveData(ExampleUserDelete.DboFullName(), userRequest);
}