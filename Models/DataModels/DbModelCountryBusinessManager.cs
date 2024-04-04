using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models.DataModels;

/// <summary>
/// CBM 관리 데이터베이스 모델
/// </summary>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global
[Table("CountryBusinessManagers")]
[Index(nameof(Name), IsUnique = true)]
public class DbModelCountryBusinessManager : DbModelDefault
{
    /// <summary>
    /// 아이디 
    /// </summary>
    [Key]
    public Guid Id { get; init; }
    
    /// <summary>
    /// 오너명
    /// </summary>
    [MaxLength(255)]
    [Required]
    public required string Name { get; set; } 
}