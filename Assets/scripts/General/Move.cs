using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
     public float Speed;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0)){
            Vector2 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = Vector2.MoveTowards(transform.position, Target, Speed * Time.deltaTime);
        }

        //FaceMouse();
    }
    /*void FaceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2 
        (
            mousePosition.x = transform.position.x,
            mousePosition.y = transform.position.y
        );

        transform.up = direction;
    }*/
    
}
