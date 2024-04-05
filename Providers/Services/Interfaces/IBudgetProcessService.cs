using Models.Responses;
using Models.Responses.Process.ProcessApproved;
using Models.Responses.Process.ProcessBusinessUnit;
using Models.Responses.Process.ProcessOwner;

namespace Providers.Services.Interfaces;

/// <summary>
/// 예산 계획 결과 서비스 
/// </summary>
public interface IBudgetProcessService
{
    /// <summary>
    /// 오너별 예산 편성 진행상황을 가져온다.
    /// 단, process-result-view 의 Claim 만 소유한 경우 로그인한 사용자의 CountryManagerId 가 일치하는
    /// 정보만 나와야한다. 
    /// </summary>
    /// <returns></returns>
    Task<ResponseData<ResponseProcessOwnerSummary>> GetOwnerBudgetSummaryAsync();
    
    /// <summary>
    /// 비지니스유닛별 예산 편성 진행상황을 가져온다.
    /// 단, process-result-view 의 Claim 만 소유한 경우 로그인한 사용자의 부서가 일치하는
    /// 정보만 나와야한다. 
    /// </summary>
    /// <returns></returns>
    Task<ResponseData<ResponseProcessBusinessUnitSummary>> GetBusinessUnitBudgetSummaryAsync();
    
    
    /// <summary>
    /// 승인된 금액 편성 진행상황을 가져온다.
    /// 단, process-result-view 의 Claim 만 소유한 경우 로그인한 사용자의 부서가 일치하는
    /// 정보만 나와야한다. 
    /// </summary>
    /// <returns></returns>
    Task<ResponseData<ResponseProcessApprovedSummary>> GetApprovedAmountSummaryAsync();
}