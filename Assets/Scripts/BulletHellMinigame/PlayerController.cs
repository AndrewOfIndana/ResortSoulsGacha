using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MinigameOneManager gameManager;
    private PlayerInput playerTouch;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("MinigameController").GetComponent<MinigameOneManager>();
        playerTouch = GameObject.Find("PlayerTouch").GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, playerTouch.transform.position) > 0.2f)
        {
            Vector3 dir = playerTouch.transform.position - transform.position;
            dir.z = 0f;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        }
    }

    public void Damage()
    {
        gameManager.SendMessage("GameOver", SendMessageOptions.DontRequireReceiver);
        this.gameObject.SetActive(false);
    }
}
