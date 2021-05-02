using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    bool alive = true;

	public float speed = 5;
	public Rigidbody rb;
	public float horizontalMultiplier = 2;
	
	private Animator anim;

	float horizontalInput;

    // Update is called once per frame

    private void FixedUpdate ()
    {
        if(!alive) return;

    	Vector3 forwardMove =transform.forward * speed * Time.fixedDeltaTime;
    	Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
    	rb.MovePosition(rb.position + forwardMove + horizontalMove);
    	
    	anim = GetComponent<Animator>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        anim.SetInteger("transition", 0);

        //Se player cair do chão
        if(transform.position.y < -5){
            Die();
        }
    }

    public void Die()
    {
        alive = false;
        //Restart the game
        Invoke("Restart", 2); //Chamar função Restart depois de 2 segundos
    }

    void Restart(){
        //Delay entre atingir um ponto de morte e reiniciar o jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
