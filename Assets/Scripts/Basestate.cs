using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Basestate//abstract means u cant say var = new basestate, only instantiate wich inherit from it
{
    public Basestate(GameObject gameobject)
    {
        this.gameObject = gameobject;
        this.transform = gameobject.transform;
    }
    protected GameObject gameObject;
    protected Transform transform;
    public abstract Type tick();
}
