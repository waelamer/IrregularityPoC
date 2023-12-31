﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DealStoreweb.Backend.Provider
{
    
    public interface IProviderAPI
    {

        Task<(bool IsSuccess, IEnumerable<Provider> Providers, string ErrorMessage)> GetAll();

        Task<(bool IsSuccess, IEnumerable<Provider> Providers, string ErrorMessage)> Search(SearchParam Param);

        Task<(bool IsSuccess, Provider, string ErrorMessage)> GetDetails(int id);

        Task<(bool IsSuccess, Provider, string ErrorMessage)> ADD(Provider provider);

        Task<(bool IsSuccess, Provider, string ErrorMessage)> Update(Provider provider);

        Task<(bool IsSuccess, Provider, string ErrorMessage)> Delete(int id);

    }
}
