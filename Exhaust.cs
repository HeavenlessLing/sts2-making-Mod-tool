using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models.Cards;
 
// test部分换成你mod的命名空间
namespace test
{
    public static class AddExhaust
    {
        public static void Apply(ref IEnumerable<CardKeyword> __result)
        {
            var keywords = __result.ToList();
            keywords.Add(CardKeyword.Exhaust);
            __result = keywords;
        }
    }
    // 为卡牌添加消耗示例
    // 比如为 "Infection" 卡牌加消耗
    /*
    [HarmonyPatch(typeof(Infection), "CanonicalKeywords", MethodType.Getter)]
    public static class Infection_Exhaust_Patch
    {
        static void Postfix(ref IEnumerable<CardKeyword> __result) => ExhaustHelper.Apply(ref __result);
    }
    */
}
