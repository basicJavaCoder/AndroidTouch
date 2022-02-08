using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeControl : MonoBehaviour, IInteractable
{
    Renderer objectRenderer;
    Color32 objectColour;


    void Start()
    {

        objectRenderer = GetComponent<Renderer>();
        objectColour = GetComponent<Renderer>().material.color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void tapped()
    {
        objectRenderer.material.SetColor("_Color", Color.yellow);
    }

    public void moveTo(Vector3 destination)
    {
        throw new System.NotImplementedException();
    }

    public void scale(float percentageChange)
    {
        throw new System.NotImplementedException();
    }

    public void rotateObject(Vector3 v)
    {
        throw new System.NotImplementedException();
    }

    public void objectSelected()
    {
        throw new System.NotImplementedException();
    }

    public void objectDeselected()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update


}