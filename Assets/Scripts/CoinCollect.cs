using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public GameObject player;
    public Collider2D playerCollider;
    public int coins = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        coins++;
        Debug.Log("Coin collected.");
        Destroy(gameObject);
    }
}
