using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] GameObject asteroid;
    [SerializeField] int circleSize = 10;
    [SerializeField] Transform playerTransform;
    //[SerializeField] GameObject disableZone;

    void Start()
    {
        StartCoroutine(CreateAsteroid());
    }

    IEnumerator CreateAsteroid()
    {
        while (true)
        {
            GameObject prefab = Instantiate
                (
                asteroid,
                Random.insideUnitCircle.normalized * circleSize + (Vector2)playerTransform.position,
                Quaternion.identity
                );

            yield return new WaitForSeconds(3f);
        }
    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (disableZone != null) 
    //    {
    //        Destroy(asteroid);
    //    }
    //}
}
