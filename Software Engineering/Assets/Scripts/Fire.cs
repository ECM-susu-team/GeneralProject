using UnityEngine;

public class Fire : MonoBehaviour {
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            rb.AddForce(Vector2.up * 15000);
        }
    }
}
