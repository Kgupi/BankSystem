﻿namespace BankSystem.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.BankAccount;

    public interface IBankAccountService
    {
        Task<IEnumerable<T>> GetAllAccountsByUserIdAsync<T>(string userId)
            where T : BankAccountBaseServiceModel;

        Task<string> CreateAsync(BankAccountCreateServiceModel model);

        Task<T> GetByUniqueIdAsync<T>(string uniqueId)
            where T : BankAccountBaseServiceModel;

        Task<T> GetByIdAsync<T>(string id)
            where T : BankAccountBaseServiceModel;

        Task<bool> ChangeAccountNameAsync(string accountId, string newName);
    }
}
