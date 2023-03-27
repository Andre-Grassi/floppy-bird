using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTubeScript : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1f;

    GameObject tube1;
    GameObject tube2;

    // Start is called before the first frame update
    void Start()
    {
        tube1 = transform.Find("Tube1").gameObject;
        tube2 = transform.Find("Tube2").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // Move tubes to the left
        transform.Translate(new Vector2(-(moveSpeed * Time.deltaTime), 0));
    }
}
