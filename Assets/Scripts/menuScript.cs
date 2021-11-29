using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    int sceneIndex;
    [SerializeField] GameObject rotateButton;
    [SerializeField] GameObject ScenePrefab;
    private bool rotating;
    Vector3 rotationVector;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {

    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void MegoPlayset()
    {
        Debug.Log("Loading mego");
        SceneManager.LoadScene(0);
    }

    public void LandOfGiants()
    {
        Debug.Log("Loading giants");
        SceneManager.LoadScene(1);
    }

    public void DancingOnCeiling()
    {
        Debug.Log("Loading dancing");
        SceneManager.LoadScene(2);
    }
    public void originalScene()
    {
        Debug.Log("Loading original");
        SceneManager.LoadScene(3);
    }

    public void rotateRoom90()
    {
        Debug.Log("Rotate Room");
        SceneManager.LoadScene(4);
    }
    public void rotateRoom180()
    {
        Debug.Log("Rotate Room");
        SceneManager.LoadScene(5);
    }
    public void rotateRoom270()
    {
        Debug.Log("Rotate Room");
        SceneManager.LoadScene(6);
    }


}