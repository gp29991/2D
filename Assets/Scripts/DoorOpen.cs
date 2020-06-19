using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public SpriteRenderer door;
    public Sprite doorOpen;
    public Sprite mySprite;
    public SpriteRenderer toggle;
    public Vector3 position;
    public bool moved = false;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            toggle.sprite = mySprite;
            door.sprite = doorOpen;
            if (!moved)
            {
                position = transform.localPosition;
                position.y -= 0.07f;
                position.x -= 0.09f;
                transform.localPosition = position;
                moved = true;
            }
        }
    }
}
