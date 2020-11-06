using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyAttack : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;
   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.Mouse1))
       {
           Attack();
       }
   }

   void Attack()
   {
       animator.SetTrigger("Charge Attack");

       Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayer);
       foreach (Collider enemy in hitEnemies)
       {
           enemy.GetComponent<EnemyBehavior>().TakeDamage(10);
       }
   }
   private void OnDrawGizmosSelected()
   {
       if(attackPoint == null)
           return;
       Gizmos.DrawWireSphere(attackPoint.position, attackRange);
   }
}
