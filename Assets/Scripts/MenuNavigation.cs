using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuNavigation : MonoBehaviour
{
    private GameManager gameController;
    public bool isMenuOpen;
    public GameObject defaultScreen;
    public GameObject dialogueScreen;
    public GameObject inventoryScreen;
    public GameObject miniGamesScreen;
    public TextMeshProUGUI cloutTxt;

    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        isMenuOpen = false;
        defaultScreen.SetActive(true);
        //dialogueScreen.SetActive(false);
        inventoryScreen.SetActive(false);
        miniGamesScreen.SetActive(false);
        UpdateUI();
    }

    public void OpenDialogue()
    {
        isMenuOpen = true;
        //defaultScreen.SetActive(false);
        //dialogueScreen.SetActive(true);
    }
    public void OpenInventory()
    {
        isMenuOpen = true;
        defaultScreen.SetActive(false);
        inventoryScreen.SetActive(true);
    }
    public void OpenShop()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void OpenMinigames()
    {
        isMenuOpen = true;
        defaultScreen.SetActive(false);
        miniGamesScreen.SetActive(true);
    }
    public void OpenMinigameOne()
    {
        SceneManager.LoadScene("BulletHellMinigame");
    }
    public void Close()
    {
        isMenuOpen = false;
        defaultScreen.SetActive(true);
        //dialogueScreen.SetActive(false);
        inventoryScreen.SetActive(false);
        miniGamesScreen.SetActive(false);
    }

    void UpdateUI()
    {
        cloutTxt.text = "Clout: " + gameController.clout.ToString();
    }
}
