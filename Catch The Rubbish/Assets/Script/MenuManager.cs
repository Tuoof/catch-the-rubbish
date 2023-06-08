using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject startMenu;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartButton()
    {
        startMenu.SetActive(false);

        SceneManager.LoadScene("Level1");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
