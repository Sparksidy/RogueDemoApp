using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {

    public Sprite dmgSprite;
    int hp = 4;

    private SpriteRenderer spriteRenderer;
    

	// Use this for initialization
	void Awake () {
        spriteRenderer = GetComponent<SpriteRenderer>();

	}

    public void DamageWall(int loss)
    {
        spriteRenderer.sprite = dmgSprite;
        hp -= loss;
        if (hp <= 0)
            gameObject.SetActive(false);
    }
}
