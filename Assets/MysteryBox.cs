using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    public Collider2D playerz;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Mystery Box detected! No abilities gained.");
        Destroy(gameObject);
    }
}
