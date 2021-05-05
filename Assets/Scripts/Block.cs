using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockSparklesVFX;
    level level;

    private void Start()
    {
        level = FindObjectOfType<level>();
        level.CountBreakableBlocks();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (tag == "Breakable")
        {
            destroyBlock();
        }
    }

    private void destroyBlock()
    {

        FindObjectOfType<GameStatus>().addScore();
        playBlockDestroySFX();

        Destroy(gameObject);
        level.blockDestroyed();
        triggerSparklesVFX();
    }

    private void playBlockDestroySFX()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
    }

    private void triggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }
}
