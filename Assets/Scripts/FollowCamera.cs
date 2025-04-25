using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float offset;
    public float followTime = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition = new Vector3(transform.position.x, target.position.y + offset, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newposition, followTime);

    }
    /*public Transform player;
    private float offsetY;
    public float minOffset;
    public float maxOffset;

    private void Start()
    {
       
    }

    private void LateUpdate()
    {
        offsetY =  player.position.y - transform.position.y;
        if (player != null)
        {
            if (offsetY >= maxOffset) 
            {
                float newY = transform.position.y + maxOffset;
                transform.position = new Vector3(transform.position.x, newY, transform.position.z);
            }
            if (offsetY <= minOffset)
            {
                float newY = transform.position.y - minOffset;
                transform.position = new Vector3(transform.position.x, newY, transform.position.z);
            }
            float newY = player.position.y + offsetY;
            float newX = player.position.y - offsetY;
            if (newY > transform.position.y)
                transform.position = new Vector3(transform.position.x, newY, transform.position.z);
            if (newX < transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, newY, transform.position.z);
            }
        }
    }*/
}
