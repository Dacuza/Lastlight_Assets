using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour {



   public void NewGame()
        {
        SceneManager.LoadScene("Stage1");
        }
    public void Continue()
    {



    }
   public  void Exit()
    {

        Exit();

    }
}
