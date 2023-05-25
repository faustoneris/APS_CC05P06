using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class Capivara : MonoBehaviourPunCallbacks
{

    private Rigidbody2D myBody;
    private int score = 0;
    public Text scoreText;


    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            if(Input.GetKeyDown(KeyCode.RightArrow))
            myBody.MovePosition(myBody.position + Vector2.right);

            if(Input.GetKeyDown(KeyCode.LeftArrow))
                myBody.MovePosition(myBody.position + Vector2.left);

            if(Input.GetKeyDown(KeyCode.UpArrow))
                myBody.MovePosition(myBody.position + Vector2.up);

            if(Input.GetKeyDown(KeyCode.DownArrow))
                myBody.MovePosition(myBody.position + Vector2.down);
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Tronco")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            score++;
            Debug.Log("Pontuação: " + score);
        }

        if (target.tag == "peixe")
        {
            score++;
            Debug.Log("Pontuação: " + score);
            scoreText.text = "Pontuação: " + score.ToString();
        }
    }
}
