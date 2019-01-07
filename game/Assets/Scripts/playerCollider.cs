using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class playerCollider : MonoBehaviour {

    public int lives = 7;
    public TextMeshProUGUI livestxt;
    // Use this for initialization
    void Start()
    {
        livestxt.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        livestxt.text = lives.ToString();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives -= 1;
        if (lives == 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }


}

