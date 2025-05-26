using UnityEngine;

public class ClickAttack : MonoBehaviour
{
    public Collider attackCollider; // ���� �ݶ��̴� (isTrigger �ѱ�)
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
            // �� ü�� ���� ó�� ����
        }
    }
}

