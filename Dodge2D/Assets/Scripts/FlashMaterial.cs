using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashMaterial : MonoBehaviour
{
    [SerializeField] Material flashMaterial;
    [SerializeField] float duration = 0.5f;

    private SpriteRenderer SpriteRenderer;
    private Material originMaterial;

    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        originMaterial = GetComponent<Material>();
    }

    void Update()
    {
        StartCoroutine(HitEffect(duration));
    }

    public IEnumerator HitEffect(float duration)
    {
        SpriteRenderer.material = flashMaterial;
        yield return new WaitForSeconds(duration);

        SpriteRenderer.material = originMaterial;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
