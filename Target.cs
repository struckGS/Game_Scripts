using UnityEngine;

public class Target : MonoBehaviour
{
	public ParticleSystem dieEffect;
	public float health = 20f;
	public BoxCollider bc;
	public Rigidbody rb;
	public ParticleSystem hurt;

	public void TakeDamage(float amount)
	{
		Vector3 knockback = -transform.forward * 700;
		rb.AddForce(knockback);
		hurt.Play();
		health -= amount;
		if (health <= 0f)
		{
			dieEffect.Play();
			//Component.Destroy(rb);
			Component.Destroy(bc);
			Invoke("Die", 2f);
		}
		Invoke("stop", 0.5f);
	}
	
	void Die()
	{
		
		Destroy(gameObject);
				
	}
	private void stop()
	{
		hurt.Stop();
	}
}
