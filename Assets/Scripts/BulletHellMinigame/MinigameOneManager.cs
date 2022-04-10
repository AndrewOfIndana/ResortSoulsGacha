using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MinigameOneManager : MonoBehaviour
{
    public BulletSpawner[] spawner;
    public float timeAlive = 0f;
    public TextMeshProUGUI timeAliveTxt;
    public GameObject startingScreen;
    public GameObject gameOverScreen;
    public float chooseSpawnerRate = 5f;
    public int difficultyScale;
    public bool isGame = false;

    private float chooseSpawnerTime = 5f;

    void Start()
    {
        timeAliveTxt.text = timeAlive.ToString("0.00");
        Invoke("SetGame", 5f);
        startingScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }
    void SetGame()
    {
        difficultyScale = 1;
        isGame = true;
        startingScreen.SetActive(false);
        InvokeRepeating("IncreaseDifficulty", 20f, 20f);
    }
    void Update()
    {
        if(isGame) 
        {
            timeAlive += Time.deltaTime;
            timeAliveTxt.text = timeAlive.ToString("0.00");

            if (chooseSpawnerTime < 0f)
            {
                ChooseSpawner();
                chooseSpawnerTime = (chooseSpawnerRate-(.2f * difficultyScale));
            }
            chooseSpawnerTime -= Time.deltaTime;
        }
    }

    void IncreaseDifficulty() 
    {
        difficultyScale++;

        for(int i = 0; i < spawner.Length; i++)
        {
            spawner[i].SetDifficulty(difficultyScale);
        }
    }

    void ChooseSpawner() 
    {
        int randomSpawner = (int)(Random.Range(0, spawner.Length));
        spawner[randomSpawner].Activate(true);
        StartCoroutine(ForgetSpawner(randomSpawner, chooseSpawnerRate));
    }

    IEnumerator ForgetSpawner(int randomNum, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        spawner[randomNum].Activate(false);
    }

    public void GameOver() 
    {
        isGame = false;
        gameOverScreen.SetActive(true);

        //GameManager globalGameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        //globalGameManager.SendMessage("MiniGameOneResults",213);

    }
}
