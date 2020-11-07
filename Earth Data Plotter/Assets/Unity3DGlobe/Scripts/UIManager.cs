using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject MainCanvas;
    public Button Reset;

    // Start is called before the first frame update
    void Start()
    {
        Reset.onClick.AddListener(ResetScene);

    }

    void ResetScene()
    {

        SceneManager.LoadScene("WastePopulation");
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
