using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
