using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShowItem : MonoBehaviour, IPointerClickHandler {
    public Item shownitem;
    Image itemsprite;

    Points points;
    Inventory inventory;

    public void OnPointerClick(PointerEventData eventData)
    {
        
        //Hvis man kan købe -
        if(points.score >= shownitem.Koster)
        {
            inventory.list.Add(shownitem);
            points.score -= shownitem.Koster;
        }
    }

    // Use this for initialization
    void Start () {
        itemsprite = GetComponent<Image>();
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<Points>();

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        itemsprite.sprite = shownitem.sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    

}
