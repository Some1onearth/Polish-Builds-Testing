using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest] //Unity specific test
    public IEnumerator PlayerMoveRight()
    {
        GameObject gameHandler = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/GameHandler"));

        //create player
        Player player = gameHandler.GetComponent<GameHandler>().GetPlayer();

        //save position
        float initialXPos = player.transform.position.x;

        //make the player move right
        player.MoveRight();

        //wait for movement
        yield return new WaitForSeconds(1f);

        Assert.Greater(player.transform.position.x, initialXPos);
    }
}
