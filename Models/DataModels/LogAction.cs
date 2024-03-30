using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable All

namespace Models.DataModels;

/// <summary>
/// 액션 로그 
/// </summary>
[Table("LogAction")]
public class LogAction
{
    /// <summary>
    /// 아이디 값 
    /// </summary>
    [Key]
    public Guid Id { get; init;}

    /// <summary>
    /// 등록일
    /// </summary>
    [Required]
    public DateTime RegDate { get; init;}

    /// <summary>
    /// 등록자 아이디 
    /// </summary>
    [Required]
    [ForeignKey("User")]
    public Guid RegId { get; init;}

    /// <summary>
    /// 등록자명 
    /// </summary>
    [Required]
    [MaxLength(255)]
    public required string RegName { get; init;}

    /// <summary>
    /// 내용 
    /// </summary>
    [Required]
    [MaxLength(3000)]
    public required string Contents { get; init;}
    
    /// <summary>
    /// 사용자 정보
    /// </summary>
    public virtual required User User { get; init;} 
}