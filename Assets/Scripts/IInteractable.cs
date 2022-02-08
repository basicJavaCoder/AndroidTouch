using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    GameObject gameObject { get; }

    void tapped();

    void moveTo(Vector3 destination);

    void scale(float percentageChange);

    void rotateObject(Vector3 v);

    void objectSelected();

    void objectDeselected();
}