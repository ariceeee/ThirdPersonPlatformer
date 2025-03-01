using TMPro;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private int numCoins;
    [SerializeField] private TextMeshProUGUI coinText;

    void Start()
    {
        numCoins = 0;
        coinText.text = "Coins: " + numCoins;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            numCoins++;
            coinText.text = "Coins: " + numCoins;
            Destroy(other.gameObject);
        }
    }

}
