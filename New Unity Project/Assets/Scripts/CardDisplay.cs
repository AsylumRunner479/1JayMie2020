using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour 
{
    public Card card;
    [Header("Text Elements")]
    public Text nameText;
        public Text description, costText, attackText, healthText;
    [Header("Image Elements")]
    public Image attackBox,healthBox,icon, background, baseUI;
    public GameObject self;
    public GameObject Worldspace;
    // Start is called before the first frame update

    void Start()
    {
        nameText.text = card.name;
        description.text = card.description;
        costText.text = card.cost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        icon.sprite = card.icon;
        background.sprite = card.background;
        card.cardType.OnSetType(this);

        


    }
   
    // Update is called once per frame

}
