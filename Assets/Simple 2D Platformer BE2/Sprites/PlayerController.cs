using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("Score");
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        this.score.GetComponent<ScoreController>().gameScore -= 5;
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()

    {

    if (Input.GetKey(KeyCode.LeftArrow))
    {transform.localScale = new Vector3(-1, 1, 1);
     transform.Translate(-0.003f, 0, 0);
    }
     if (Input.GetKey(KeyCode.RightArrow))
    {transform.localScale = new Vector3(1, 1, 1);
     transform.Translate(0.003f, 0, 0);
    } 

    if (Input.GetKey(KeyCode.UpArrow))
    {transform.localScale = new Vector3(1, 1, 1);
     transform.Translate(0, 0.001f, 0);
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {transform.localScale = new Vector3(1, 1, 1);
     transform.Translate(0, -0.001f, 0);
    }  

        
    }
}
