using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour, IInteractable
{

    Renderer objectRenderer;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveTo(Vector3 destination)
    {
        throw new System.NotImplementedException();
    }

    public void objectDeselected()
    {
        throw new System.NotImplementedException();
    }

    public void objectSelected()
    {
        throw new System.NotImplementedException();
    }

    public void rotateObject(Vector3 v)
    {
        throw new System.NotImplementedException();
    }

    public void scale(float percentageChange)
    {
        throw new System.NotImplementedException();
    }

    public void tapped()
    {

        objectRenderer.material.SetColor("_Color", Color.yellow);

    }

    

}
