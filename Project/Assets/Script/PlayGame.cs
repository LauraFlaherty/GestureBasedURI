using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    // Start is called before the first frame update
    void PlayAction()
    {
       SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }


}
