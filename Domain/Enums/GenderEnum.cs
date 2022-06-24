using System.ComponentModel;

namespace Domain.Enums;

public enum GenderEnum
{
    [Description("هیچکدام")]
    None = 0,
    [Description("مرد")]
    Man,
    [Description("زن")]
    Woman
}