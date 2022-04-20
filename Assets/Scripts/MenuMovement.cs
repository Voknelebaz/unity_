using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using DG.Tweening; 

public class MenuMovement : MonoBehaviour
{
    private bool menuOut; 
    Transform menuTransform;
    float glide = 160; 
    float glideTime = 1;
    float hide = 25;
    float hideTime = 0.2f; 
    float flipTime = 0.2f; 
    void Start()
    {
        menuOut = true;
        menuTransform = GameObject.FindWithTag("menu").GetComponent<Transform>();
    }

    public void ButtonPressed()
    {
        Sequence sequence = DOTween.Sequence(); 
       if(menuOut == true)
        {
            sequence.Append(menuTransform.DOMoveX(menuTransform.position.x - glide, glideTime)).Join(transform.DOMoveX(transform.position.x - glide, glideTime))
            .Append(menuTransform.DOMoveX(menuTransform.position.x - glide - hide, hideTime)).Append(transform.DOScale(-1, flipTime)); 
            menuOut = false; 
        }
        else
        {
              sequence.Append(menuTransform.DOMoveX(menuTransform.position.x + hide, hideTime))
             .Append(menuTransform.DOMoveX(menuTransform.position.x + hide + glide, glideTime))
             .Join(transform.DOMoveX(transform.position.x + glide, glideTime))
             .Append(transform.DOScaleX(1, flipTime)); 

            menuOut = true; 
        }

    }
}
