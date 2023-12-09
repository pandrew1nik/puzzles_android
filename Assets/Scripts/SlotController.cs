using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotController : MonoBehaviour, IDropHandler
{
    public int id;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Dropped");

        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<PuzzleController>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                    this.gameObject.GetComponent<RectTransform>().anchoredPosition;
            }
            else
            {
                eventData.pointerDrag.GetComponent<PuzzleController>().ResetPosition();
            }
        }
    }
}
