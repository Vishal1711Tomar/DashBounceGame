using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{ public static GameManager instance;
    public int coinCollected = 0;
    public int Score = 0;
    public bool isplayerDead = false;
    public Transform Player;
    public TMP_Text coinsCollected;
    public TMP_Text score;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { if (instance != null)
        {
            Destroy(gameObject);
        }
     instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {  
        coinsCollected.text = coinCollected.ToString();
        score.text = coinCollected.ToString();

    }

}
