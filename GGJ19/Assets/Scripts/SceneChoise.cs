using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChoise
{
    public Choise Choise;
    public Scene Scene;
    public int SceneNumber;


    public SceneChoise(Scene _scene, Choise _choise,int num)
    {
        Choise = _choise;
        Scene = _scene;
        SceneNumber = num;
    }
}
