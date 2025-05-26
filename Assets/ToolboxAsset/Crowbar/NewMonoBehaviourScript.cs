using UnityEngine;

public class ClickAttack : MonoBehaviour
{
    public Collider attackCollider; // 무기 콜라이더 (isTrigger 켜기)
    public float attackDuration = 0.3f;

    private bool isAttacking = false;

    void Start()
    {
        if (attackCollider != null)
            attackCollider.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            StartCoroutine(DoAttack());
        }
    }

    System.Collections.IEnumerator DoAttack()
    {
        isAttacking = true;
        if (attackCollider != null)
            attackCollider.enabled = true;

        Debug.Log("Attacking!");

        yield return new WaitForSeconds(attackDuration);

        if (attackCollider != null)
            attackCollider.enabled = false;

        isAttacking = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Hit enemy: " + other.name);
            // 적 체력 감소 처리 가능
        }
    }
}

