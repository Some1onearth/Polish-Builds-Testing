using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public static GameHandler gamehandler;
    public int score = 0;
    public bool isGameOver = false;
    [SerializeField] Player playerPrefab;
    [SerializeField] Asteroid asteroidPrefab;
    [SerializeField] Bullet bulletPrefab;

    void Start()
    {
        if (gamehandler == null)
        {
            gamehandler = this;
        }
        else
        {
            Destroy(this);
            Debug.LogWarning("Second GameHandler");
        }
    }
    public Player GetPlayer()
    {
        return Instantiate<Player>(playerPrefab);
    }
    public Asteroid GetAsteroid()
    {
        return Instantiate<Asteroid>(asteroidPrefab);
    }    
    public Bullet GetBullet()
    {
        return Instantiate<Bullet>(bulletPrefab);
    }

    public void GameOver()
    {
        isGameOver = true;
    }
    public void AsteroidDestroyed()
    {
        score += 1;
    }
}
