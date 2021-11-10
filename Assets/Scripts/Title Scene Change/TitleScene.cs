using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{

    
    void Start()
    {
        StartCoroutine(OtherScene());
    }

    IEnumerator OtherScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Title");
    }
}
