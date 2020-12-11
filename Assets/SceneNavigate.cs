using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigate : MonoBehaviour
{
    bool descriptionShowing = false;
    public GameObject descriptionImage;
    public string startScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9");
            controllDescription();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            controllDescription();
        }

        if (descriptionShowing)
        {
            // A button
            if (Input.GetKeyDown("joystick button 16"))
            {
                Debug.Log("button16");
                SceneManager.LoadScene(startScene);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A");
                SceneManager.LoadScene(startScene);
            }
        }
    }

    void controllDescription()
    {
        if (descriptionShowing)
        {
            descriptionShowing = false;
            descriptionImage.SetActive(false);
        }
        else
        {
            descriptionShowing = true;
            descriptionImage.SetActive(true);
        }
    }

    
}
