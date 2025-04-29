using UnityEngine;

public class Projectile2D : MonoBehaviour
{
    [SerializeField] private Transform shootpoint;
    [SerializeField] private GameObject target;
    [SerializeField] private Rigidbody2D bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 5f);
            
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log("hit" + hit.collider.name);
            }
        }
    }
}
