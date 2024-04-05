using Features.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Models.Responses.Process.Owner;
using Providers.Services.Interfaces;

namespace Apis.Controllers;


/// <summary>
/// 예산 결과 서비스 컨트롤러
/// </summary>
[ApiController]
[Route("api/v1/[controller]")]
[Authorize(Roles = "Admin,User")]
public class BudgetProcessController : Controller
{
    /// <summary>
    /// 비지니스 유닛 서비스 
    /// </summary>
    private readonly IBudgetProcessService _budgetProcessService;

    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="businessUnitService"></param>
    public BudgetProcessController(IBudgetProcessService businessUnitService)
    {
        _budgetProcessService = businessUnitService;
    }

    /// <summary>
    /// Owner 별 Budget 프로세스 정보를 가져온다.
    /// </summary>
    /// <returns></returns>
    [HttpGet("Owner")]
    [ClaimRequirement("Permission","process-result,process-result-view")]
    public async Task<ResponseData<ResponseProcessOwnerSummary>> GetOwnerBudgetAsync()
    {
        return await _budgetProcessService.GetOwnerBudgetAsync();
    }
}