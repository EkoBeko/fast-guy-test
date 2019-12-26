using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{

    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElaped;
    private void Update()
    {
        timeElaped += Time.deltaTime;
        if(timeElaped > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }






}
