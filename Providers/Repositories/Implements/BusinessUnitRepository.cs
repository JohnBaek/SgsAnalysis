using Azure;
using Microsoft.Extensions.Logging;
using Models.DataModels;
using Models.Requests.Budgets;
using Models.Requests.Query;

namespace Providers.Repositories.Implements;

/// <summary>
/// 비지니스 유닛 Repository 구현체
/// </summary>
public class BusinessUnitRepository : IBusinessUnitRepository
{
    /// <summary>
    /// DB Context
    /// </summary>
    private readonly AnalysisDbContext _dbContext;

    /// <summary>
    /// 로거
    /// </summary>
    private readonly ILogger<BusinessUnitRepository> _logger;

    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="logger">로거</param>
    /// <param name="dbContext">디비컨텍스트</param>
    public BusinessUnitRepository(ILogger<BusinessUnitRepository> logger, AnalysisDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }


    /// <summary>
    /// 리스트를 가져온다.
    /// </summary>
    /// <param name="requestQuery">쿼리 정보</param>
    /// <returns></returns>
    public Task<List<DbModelBusinessUnit>> GetListAsync(RequestQuery requestQuery)
    {
        throw new NotImplementedException();   
    }

    /// <summary>
    /// 데이터를 업데이트한다.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<Response> UpdateAsync(RequestBusinessUnit request)
    {
        throw new NotImplementedException();   
    }
    
    /// <summary>
    /// 데이터를 추가한다.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<Response> AddAsync(RequestBusinessUnit request)
    {
        throw new NotImplementedException();   
    }
    
    /// <summary>
    /// 데이터를 삭제한다.
    /// </summary>
    /// <param name="id">대상 아이디값</param>
    /// <returns></returns>
    public Task<Response> DeleteAsync(string id)
    {
        throw new NotImplementedException();   
    }
}