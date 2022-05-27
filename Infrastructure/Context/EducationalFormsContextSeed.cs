using Domain.Models;

namespace Infrastructure.Context;

public class EducationalFormsContextSeed
{
    public static async Task SeedAsync(EducationalFormsContext context)
    {
        if (!context.Skill.Any())
        {
            context.Skill.AddRange(GetSkillConfiguration());
            await context.SaveChangesAsync();
        }

        if (!context.FamiliarityMethod.Any())
        {
            context.FamiliarityMethod.AddRange(GetFamiliarityMethodConfiguration());
            await context.SaveChangesAsync();
        }

        if (!context.FailureReason.Any())
        {
            context.FailureReason.AddRange(GetFailureReasonsConfiguration());
            await context.SaveChangesAsync();
        }
    }

    private static List<Skill> GetSkillConfiguration()
    {
        var skills = new List<Skill>();
        skills.Add(new Skill
        {
            Name = "Polyethylene Welding"
        });
        skills.Add(new Skill
        {
            Name = "بازرس فنی جوش"
        });
        skills.Add(new Skill
        {
            Name = "بازرس قطعات جوشکاری شده به صورت چشمی TVTO VT LEVEL II"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار سازه های فولادی با فرایند SMAW"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار فولادهای زنگ نزن با فرایند TIG"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار قطعات فولادی (کربنی) با فرایند MAG"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار قطعات فولادی (کم کربن) با فرایند TIG"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار گاز درجه ۱"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار گاز درجه ۲"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار گاز محافظ CO2 (کاردانش)"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار لوله های فولادی با فرایند SMAW"
        });
        skills.Add(new Skill
        {
            Name = "جوشکار مخازن فولادی با فرایند SMAW"
        });
        skills.Add(new Skill
        {
            Name = "جوشکاری با فرایند قوس الکتریکی دستی SMAW (E3) (کاردانش)"
        });
        skills.Add(new Skill
        {
            Name = "جوشکاری با فرایند قوس الکتریکی دستی SMAW (E6) (کاردانش)"
        });
        skills.Add(new Skill
        {
            Name = "جوشکاری با فرایند قوس الکتریکی دستی SMAW (E8) (کاردانش)"
        });
        skills.Add(new Skill
        {
            Name = "جوشکاری با فرایند قوس الکتریکی دستی SMAW (E9) (کاردانش)"
        });
        return skills;
    }

    private static List<FamiliarityMethod> GetFamiliarityMethodConfiguration()
    {
        var familiarityMethods = new List<FamiliarityMethod>();
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "ariagostar.net"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "ariavash.ir"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "related to ariavash"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "weldskill_instagram"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "SMS"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "divar"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "118"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "مراجعه حضوری"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "فنی و حرفه ای مرکز 5"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "علی اسدی مطلق"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "عبدالله برزوئیان"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "مهدی جلیلی"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "سعید نظرپور"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "آیین دانش"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "مهرمادر"
        });
        familiarityMethods.Add(new FamiliarityMethod
        {
            Name = "توضیحات"
        });
        return familiarityMethods;
    }

    private static List<FailureReason> GetFailureReasonsConfiguration()
    {
        var failures = new List<FailureReason>();
        failures.Add(new FailureReason
        {
            Name = "جذب توسط رقبا"
        });
        failures.Add(new FailureReason
        {
            Name = "در حال پیگیری"

        });
        failures.Add(new FailureReason
        {
            Name = "عدم ارائه خدمات آموزشی"

        });
        failures.Add(new FailureReason
        {
            Name = "عدم برقراری ارتباط"

        });
        failures.Add(new FailureReason
        {
            Name = "عدم رضایت از تجهیزات و یا فضای آموزشی"

        });
        failures.Add(new FailureReason
        {
            Name = "عدم رضایت از ساعت آموزش"

        });
        failures.Add(new FailureReason
        {
            Name = "عدم وجود خوابگاه"

        });
        failures.Add(new FailureReason
        {
            Name = "مسافت زیاد"

        });
        failures.Add(new FailureReason
        {
            Name = "هزینه دوره"

        });
        return failures;
    }


}