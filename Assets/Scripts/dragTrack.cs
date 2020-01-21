using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dragTrack : MonoBehaviour
{

    private Transform trackPlace;

    public BoxCollider2D track;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    bool moveAllowed = false;

    void Start()
    {

        initialPosition = transform.position;
        PhysicsMaterial2D mat = new PhysicsMaterial2D();
        GetComponent<BoxCollider2D>().sharedMaterial = mat;
        track = GetComponent<BoxCollider2D>();

    }


    // Update is called once per frame
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (Input.touchCount > 0)
                    {
                        
                        if (track == Physics2D.OverlapPoint(touchPos))
                        {
                            
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                            moveAllowed = true;
                        }
                    }


                    
                    break;

                case TouchPhase.Moved:
                    
                        if (track == Physics2D.OverlapPoint(touchPos) || moveAllowed)
                        {
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        }






                    
                    break;

                case TouchPhase.Ended:
                    
                    moveAllowed = false;
                    track = GetComponent<BoxCollider2D>();
                    break;
                    
            }
        }
    }

}