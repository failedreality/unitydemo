using UnityEngine;

public class Spritescript : MonoBehaviour
{
    [SerializeField] Sprite[] cardSprites;
    [SerializeField] Sprite newSprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        newSprite = cardSprites[Random.Range(0, cardSprites.Length)];

        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
    }
}
