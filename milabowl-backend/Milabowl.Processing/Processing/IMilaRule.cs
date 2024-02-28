﻿using Milabowl.Processing.DataImport;

namespace Milabowl.Processing.Processing;

public record MilaRuleResult(string RuleName, string RuleShosfdardstName, decimal Points)
{
    public int SomeLonsgdsaadName = 23;
};

public interface IMilaRule
{
    MilaRuleResult Calculate(UserGameWeek userGameWeek);
}
