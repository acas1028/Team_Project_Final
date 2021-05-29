using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleObject : MonoBehaviour
{
    Renderer circleColor;
    public int isLighting;

    void Awake()
    {
        _Reset();
        circleColor = this.GetComponent<Renderer>();
        Draw();
    }

    // Update is called once per frame
    void Update()
    {
        Draw();
    }

    private void Draw()
    {
        if (isLighting == 1)
            circleColor.material.color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
        else if (isLighting == 2)
            circleColor.material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
    }
    public void Change()
    {
        if (isLighting == 1)
            isLighting = 2;
        else
            isLighting = 1;
    }
    public int GetIsLighting()
    {
        return isLighting;
    }
    public void _Reset()
    {
        int temp = Random.Range(0, 2);

        if (temp == 0)
            isLighting = 1;
        else
            isLighting = 2;
    }
}
