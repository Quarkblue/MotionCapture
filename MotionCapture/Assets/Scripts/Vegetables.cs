using System.Collections;
using UnityEngine;

public class Vegetables : MonoBehaviour
{
    public int scoreValue = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CollectVegetable(scoreValue);
            Destroy(gameObject);
        }
    }
}
