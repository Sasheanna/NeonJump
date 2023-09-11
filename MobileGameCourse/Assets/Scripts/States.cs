using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour
{
    public string state;
    public MapSpawner map;
    public PlayerMovement move;
    public Score score;
    public SpriteRenderer sprite;
    public ParticleSystem ps;
    public AudioManager dieSound;
    public Menu menu;

    // Start is called before the first frame update
    void Start()
    {
        state = "Idle";
        move.ResetGravity(0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            Die();
    }

    public void Die()
    {
        state = "Dead";
        move.ResetGravity(0);
        score.End();
        sprite.enabled = false;
        ps.Play();
        dieSound.PlayDie();

        //goes to the IEnumerator Delay thing
        StartCoroutine(Delay());
    }

    public void Respawn()
    {
        menu.ChangeMenu(true);
        transform.position = new Vector3(-6, -1, 0);
    }

    public void StartGame()
    {
        state = "Alive";
        move.ResetGravity(3);
        map.ClearStorage();
        sprite.enabled = true;
        menu.ChangeMenu(false);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Respawn();
    }

}
