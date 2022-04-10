using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Player;

    private readonly float step = 2f;
    private readonly float negativeStep = -1;
    private readonly float maxScaling = 4;

    private void Update()
    {
        this.Player.transform.localPosition += this.getPosition();
        this.Player.transform.localScale += this.GetScale();

        this.Player.transform.Rotate(0f, 0f, -1.3f);
    }

    private Vector3 getPosition()
    {
        return this.step * Vector3.right * Time.deltaTime;
    }

    private Vector3 GetScale()
    {
        float koof = this.Player.transform.localScale.x >= this.maxScaling
            ? this.negativeStep
            : Math.Abs(this.negativeStep);

        float scaling = koof * Time.deltaTime;

        return new Vector3(
            scaling,
            scaling,
            scaling
        );
    }
}
