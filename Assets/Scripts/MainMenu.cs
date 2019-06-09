using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int contador = 1;
    public Button button;
    public void Salir() 
    {
        Application.Quit();
    }

   }
