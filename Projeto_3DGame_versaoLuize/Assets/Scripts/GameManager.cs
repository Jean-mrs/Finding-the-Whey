using UnityEngine;
// Change the test on the screen when the score changes
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{

    int score;
    public static GameManager inst;

    public Text scoreText;

    public void IncrementScore(){
        score++;
        scoreText.text = "PONTUAÇÃO: " + score; // acessar a componente text desse objeto e atualiza-lo com o novo valor da varável score
    }

    private void Awake()
    {
        inst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
