using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public GameObject gameOverTxt;

    public Text timeTxt;
    float alive = 0.0f;

    public static gameManager I;

    public Animator anim;
    public GameObject balloon;

    void Awake()
    {
        I = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.8f);   
    }

    void makeSquare()
    {
        Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        timeTxt.text = alive.ToString("N2");
    }

    public void gameover()
    {
        anim.SetBool("isDie", true);
        gameOverTxt.SetActive(true);
        Invoke("dead", 0.5f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }
}
