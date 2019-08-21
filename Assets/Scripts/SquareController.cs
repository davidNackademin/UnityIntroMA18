using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 centerPosition = new Vector3(0, 0, 0);

        // Transform squareTransform = GetComponent<Transform>();

        //squareTransform.position = centerPosition;

        gameObject.transform.position = centerPosition;
    }

    private void Update()
    {
        Vector3 position = gameObject.transform.position;

        position.x += 0.1f;

        gameObject.transform.position = position;
        
    }
}
