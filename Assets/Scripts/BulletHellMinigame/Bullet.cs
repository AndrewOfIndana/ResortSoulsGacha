using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float shootSpeed;

    void Start()
    {
        Rigidbody2D r2d = this.GetComponent<Rigidbody2D>();
        r2d.AddRelativeForce( new Vector2(shootSpeed, 0f));
    }

    public void SetSpeed(int difficulty)
    {
        shootSpeed = (75 + (float)(25 * difficulty));
    }

    public void OnTriggerStay2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SendMessage("Damage", SendMessageOptions.DontRequireReceiver);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.CompareTag("KillBounds"))
        {
            Destroy(this.gameObject);
        }
    }
}
