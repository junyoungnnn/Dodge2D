using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashMaterial : MonoBehaviour
{
    [SerializeField] Material flashMaterial;
    [SerializeField] float duration = 0.5f;

    private SpriteRenderer spriteRenderer;
    private Material originMaterial;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originMaterial = spriteRenderer.material;
    }

    public IEnumerator HitEffect(float duration)
    {
        spriteRenderer.material = flashMaterial;
        yield return new WaitForSeconds(duration);

        spriteRenderer.material = originMaterial;
    }

}
