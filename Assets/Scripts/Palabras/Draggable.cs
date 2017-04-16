using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour , IBeginDragHandler , IDragHandler , IEndDragHandler {

    Transform ParentToRetornTo;
    Transform placeHolderParent;

    public enum Type { BASE, DROPZONE, DROPPABLE };
    public Type itemType = Type.BASE;

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");

        //placeholder = new GameObject();
        //placeholder.transform.SetParent(this.transform.parent);
        //LayoutElement le = placeholder.AddComponent<LayoutElement>();
        //le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        //le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        //le.flexibleHeight = 0;
        //le.flexibleWidth = 0;

        //placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());

        ParentToRetornTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        // Debug.Log("OnDrag");

        this.transform.position = eventData.position;

        int newSpot = ParentToRetornTo.childCount;
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
        this.transform.SetParent(ParentToRetornTo);
        //this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }

    public Transform getParentToReturn()
    {
        return ParentToRetornTo;
    }

    public void setParentToReturn(Transform p)
    {
        ParentToRetornTo = p;
    }

    public Transform getPlaceHolderParent()
    {
        return placeHolderParent;
    }

    public void setPlaceHolderParent(Transform p)
    {
        placeHolderParent = p;
    }
}
