using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickAccount.Service.Services
{
    public class CompanyService : Service.CompanyService.CompanyServiceBase
    {
        public override Task<RegisterCompanyResponse> RegisterNewCompany(RegisterCompanyRequest request, ServerCallContext context)
        {
            RegisterCompanyResponse response = new RegisterCompanyResponse { Error = "Api Not Implemented Yet" };

            return Task.FromResult(response);
        }
    }
}