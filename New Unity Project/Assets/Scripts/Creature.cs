using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Creature", menuName = "Card/Type/Creature")]
public class Creature : CardType
{
    public override void OnSetType(CardDisplay visuals)
    {
        base.OnSetType(visuals);
        visuals.healthText.enabled = true;
        visuals.attackText.enabled = true;

    }
}
