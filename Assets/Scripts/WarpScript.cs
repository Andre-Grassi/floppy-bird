using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Tube")
        {
            // Get the parent Tube1 or Tube2
            Transform wholeTube = other.transform.parent.transform.parent;

            // "Re-spawn" the tube that has been surpassed
            wholeTube.transform.Translate(new Vector2(5, 0));

            // Randomly sets the height of the tube
            wholeTube.transform.position = new Vector2(
                wholeTube.transform.position.x,
                Random.Range(-1f, 4.75f)
            );
        }
    }
}
