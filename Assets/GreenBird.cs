using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBird : MonoBehaviour
{

    private void OnMouseDrag()
    {
        transform.position = Input.mousePosition;
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }


}
