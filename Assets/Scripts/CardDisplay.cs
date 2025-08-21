using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public Card card;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;

    public Text manaText;
    public Text attackText;
    public Text defenseText;

    void Start()
    {
        card.Print();

        nameText.text = card.name;
        descriptionText.text = card.description;

        artworkImage.sprite = card.artwork;

        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        defenseText.text = card.defense.ToString();
    }

}
