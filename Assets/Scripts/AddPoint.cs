using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // NECESSARY TO MANIPULATE TEXTMESHPRO

public class AddPoint : MonoBehaviour
{
    [SerializeField]
    GameObject pointsText;

    TextMeshProUGUI addPointsTextComponent;
    int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the TextMeshPro component
        addPointsTextComponent = pointsText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Need to add a debounce to prevent player getting more than one point here!!!

        // Checks whether the collision happened with the player
        if (other.gameObject.CompareTag("Player"))
        {
            /*
            Assign the current points to the points variable
            (I need to do this because if not then the script
            for each tube will have different points being assigned)
            */
            points = int.Parse(addPointsTextComponent.text);

            // Adds 1 point
            points++;

            // Update the text to the new points
            addPointsTextComponent.text = points.ToString();
        }
    }
}
