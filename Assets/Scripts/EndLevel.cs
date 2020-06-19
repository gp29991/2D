using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public SpriteRenderer check;
    public Sprite openDoorSprite;

    // Start is called before the first frame update
    void Start()
    {
        check = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && check.sprite == openDoorSprite)
        {
            SceneManager.LoadScene("LevelEnd");
        }
    }
}
