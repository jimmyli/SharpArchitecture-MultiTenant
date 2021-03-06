﻿using MvcContrib.Pagination;
using SharpArch.Core.PersistenceSupport;
using SharpArchitecture.MultiTenant.Framework.Contracts;

namespace SharpArchitecture.MultiTenant.Core.RepositoryInterfaces
{
  public interface ICustomerRepository : IRepository<Customer>, IMultiTenantRepository
  {
    IPagination<Customer> GetPagedList(int pageIndex, int pageSize);
  }
}