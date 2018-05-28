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
    PlayerStats stats;


    public void OnPointerClick(PointerEventData eventData)
    {
        
        //Hvis man kan købe -
        if(points.score >= shownitem.Koster)
        {
            inventory.list.Add(shownitem);
            points.score -= shownitem.Koster;
            if (shownitem.attackstats != null)
            {
                stats.Swords = shownitem.attackstats;
            }
        }
        
    }

    // Use this for initialization
    void Start () {
        itemsprite = GetComponent<Image>();
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<Points>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        itemsprite.sprite = shownitem.sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    

}
