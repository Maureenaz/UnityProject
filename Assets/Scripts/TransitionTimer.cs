using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTimer : MonoBehaviour
{

    public float DelayLoading;
    public string SceneName;

    private float timeLapsed;
    // Update is called once per frame
    private void Update()
    {
        timeLapsed += Time.deltaTime;

        if (timeLapsed > DelayLoading)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
