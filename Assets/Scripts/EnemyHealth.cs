using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        Debug.Log("I am taking damage");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Destroy (gameObject);
        }
    }
}
