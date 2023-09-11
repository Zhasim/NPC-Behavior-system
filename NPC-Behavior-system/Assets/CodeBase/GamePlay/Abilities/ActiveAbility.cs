using System.Collections.Generic;
using CodeBase.StaticData.Abilities;

namespace CodeBase.GamePlay.Abilities
{
    public class ActiveAbility
    {
        public string CasterId;
        public List<string> TargetIds;
    
        public AbilityTypeId Ability;
        public AbilityType Type;
        public float DelayLeft;

    }
}