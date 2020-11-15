using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;
    public float attackRange = 10;
    public LayerMask enemyLayer;
    public float force = 30f;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = new Vector3(force, 0,0);
        rBody.AddRelativeForce(forceDirection);
        Collider[] hitEnemies = Physics.OverlapSphere(rBody.position, attackRange, enemyLayer);
        foreach (Collider enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyBehavior>().TakeDamage(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
     // Destroys the cloned prefabs after 2 seconds 
        Destroy(gameObject, 2f);
    }
}
