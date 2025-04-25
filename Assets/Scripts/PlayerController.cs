using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movedirection = Vector2.zero;
    private bool isdragging = false;
    public float swipeSenstivity = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * movespeed, rb.linearVelocity.y);
        movedirection = Vector2.zero;
        if (Input.touchCount>0 )
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase== TouchPhase.Began )
            {
                isdragging = true;
            }
            else if((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && isdragging)
            {
                float dragx = touch.deltaPosition.x*swipeSenstivity;
                movedirection = new Vector2 (Mathf.Clamp(dragx,-1f,1f),0f);
            }
            else if(touch.phase==TouchPhase.Ended || touch.phase== TouchPhase.Canceled)
            {
              isdragging=false;
            }

        }
       

    }
    private void FixedUpdate()
    {
        if (isdragging) 
        {
            rb.linearVelocity = new Vector2(movedirection.x * movespeed, rb.linearVelocity.y);
        }
    }
}
