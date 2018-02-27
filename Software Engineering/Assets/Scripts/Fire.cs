using UnityEngine;

public class Fire : MonoBehaviour {
    private Rigidbody2D rb;
    GameObject WarriorClass;
    Warrior wrr;
    private int curHP = 0;
    void Start()
    {
        WarriorClass = GameObject.Find("character");
        wrr = WarriorClass.GetComponent<Warrior>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            curHP = wrr.GetHealth();
            rb = other.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * 1000);
            curHP = curHP - 10;
            wrr.SetHealth(curHP);
        }
    }
}
