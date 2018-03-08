using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    private float mCurrentHealth;
    private float mMaxHealth;


    public virtual void TakeDamage(int amount)
    {

        mCurrentHealth -= amount;
        if (mCurrentHealth <= 0)
        {

            Die();
        }


    }

    protected void Die()
    {
        Destroy(gameObject);
    }

}