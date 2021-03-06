﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour
{
    public Pointer pointer;
    public SpriteRenderer circleRenderer;
    
    public Sprite openSprite;
    public Sprite closedSprite;

    private void Update()
    {
        pointer.OnPointerUpdate += UpdateSprite;
    }

    private void UpdateSprite(Vector3 position, bool hit)
    {
        transform.position = position;

        if (hit)
        {
            circleRenderer.sprite = closedSprite;
        }
        else
        {
            circleRenderer.sprite = openSprite;
        }
    }

    private void OnDestroy()
    {
        pointer.OnPointerUpdate -= UpdateSprite;
    }
}
