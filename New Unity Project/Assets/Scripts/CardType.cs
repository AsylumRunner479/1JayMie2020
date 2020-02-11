using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardType : ScriptableObject
{
    // Start is called before the first frame update
    public string typeName;
    public virtual void OnSetType(CardDisplay visuals)
    {

    }
}
