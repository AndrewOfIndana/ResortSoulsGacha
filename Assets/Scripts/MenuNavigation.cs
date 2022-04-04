using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuNavigation : MonoBehaviour
{
    public bool isMenuOpen;
    public GameObject defaultScreen;
    public GameObject dialogueScreen;
    public GameObject inventoryScreen;
    public GameObject miniGamesScreen;

    void Start()
    {
        isMenuOpen = false;
        defaultScreen.SetActive(true);
        //dialogueScreen.SetActive(false);
        inventoryScreen.SetActive(false);
        miniGamesScreen.SetActive(false);
    }

    public void OpenDialogue()
    {
        isMenuOpen = true;
        //defaultScreen.SetActive(false);
        //dialogueScreen.SetActive(true);
        Debug.Log("OpenDialogue");
    }
    public void OpenInventory()
    {
        isMenuOpen = true;
        defaultScreen.SetActive(false);
        inventoryScreen.SetActive(true);
        Debug.Log("OpenInventory");
    }
    public void OpenShop()
    {
        Debug.Log("Opening Shop");
    }
    public void OpenMinigames()
    {
        isMenuOpen = true;
        defaultScreen.SetActive(false);
        miniGamesScreen.SetActive(true);
    }

    public void Close()
    {
        isMenuOpen = false;
        defaultScreen.SetActive(true);
        //dialogueScreen.SetActive(false);
        inventoryScreen.SetActive(false);
        miniGamesScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("WOrk");
        }
    }
}
