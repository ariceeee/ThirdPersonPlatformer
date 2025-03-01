using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private int numCoins = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            numCoins++;
            Debug.Log("Player collected a coin! Total coins: " + numCoins);
            Destroy(other.gameObject);
        }
    }

}
