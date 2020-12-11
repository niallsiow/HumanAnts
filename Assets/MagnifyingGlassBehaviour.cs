using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlassBehaviour : MonoBehaviour
{

    public GameObject ground;
    public float yPos;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 positionVectorAtStart;
        positionVectorAtStart = transform.position;
        positionVectorAtStart.y = yPos;
        transform.position = positionVectorAtStart;
    }

    // Update is called once per frame
    void Update()
    {
        // find cursor position
        Ray rayFromCameraToCursor = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, -yPos);
        groundPlane.Raycast(rayFromCameraToCursor, out float distanceFromCamera);
        Vector3 cursorPosition = rayFromCameraToCursor.GetPoint(distanceFromCamera);

        // move magnifying glass to cursor position
        transform.position = cursorPosition;
    }
}
