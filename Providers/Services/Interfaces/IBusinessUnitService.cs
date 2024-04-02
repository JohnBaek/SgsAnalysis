using Models.Requests.Budgets;
using Models.Requests.Query;
using Models.Responses;
using Models.Responses.Budgets;

namespace Providers.Services.Interfaces;

/// <summary>
/// 비지니스유닛 (BU) 서비스 인터페이스
/// </summary>
public interface IBusinessUnitService
{
    /// <summary>
    /// 리스트를 가져온다.
    /// </summary>
    /// <param name="requestQuery">쿼리 정보</param>
    /// <returns></returns>
    Task<ResponseList<ResponseBusinessUnit>> GetListAsync(RequestQuery requestQuery);

    /// <summary>
    /// 데이터를 가져온다.
    /// </summary>
    /// <param name="id">아이디</param>
    /// <returns></returns>
    Task<ResponseData<ResponseBusinessUnit>> GetAsync(string id);

    /// <summary>
    /// 데이터를 업데이트한다.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<Response> UpdateAsync(RequestBusinessUnit request);
    
    /// <summary>
    /// 데이터를 추가한다.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<Response> AddAsync(RequestBusinessUnit request);
    
    /// <summary>
    /// 데이터를 삭제한다.
    /// </summary>
    /// <param name="id">대상 아이디값</param>
    /// <returns></returns>
    Task<Response> DeleteAsync(string id);
}