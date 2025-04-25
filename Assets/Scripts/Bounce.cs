using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceForce = 8f;
    private Rigidbody2D rb;
    


    void Start()
    { rb = GetComponent<Rigidbody2D>();

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Platform"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounceForce);
        }
        if (collision.transform.CompareTag("Enemy"))
        {
            UIManager ui = FindAnyObjectByType<UIManager>();
            GameManager.instance.isplayerDead = true;
            ui.ShowGameOverUI();
            /*Destroy(gameObject);*/
        }
        if (collision.transform.CompareTag("Coin"))
        {
            GameManager.instance.coinCollected++;
            Destroy(collision.gameObject);
        }
    }

}
