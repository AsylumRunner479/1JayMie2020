using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public FloatReference maxHealth, curHealth,  speed, attackCooldown;

    private void Update()
    {
        Debug.Log(maxHealth);
        Debug.Log(speed);
        Debug.Log(attackCooldown);
        Debug.Log(curHealth);

    }
}
