using System.ComponentModel;

namespace Domain.Enums;

public enum MaritalStatusEnum
{
    [Description("نا مشخص")]
    None = 0,
    [Description("متاهل")]
    Married,
    [Description("مجرد")]
    Single
}