using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Card/Type/Spell")]
public class Spell : CardType
{
  public override void OnSetType(CardDisplay visuals)
    {
        base.OnSetType(visuals);
        visuals.healthBox.gameObject.SetActive(false);
        visuals.attackBox.gameObject.SetActive(false);
       

    }
}
