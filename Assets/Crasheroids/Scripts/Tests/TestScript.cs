using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    GameHandler _gameHandler;

    [SetUp]
    public void Setup()
    {
        GameObject gameHandler = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/GameHandler"));
        _gameHandler = gameHandler.GetComponent<GameHandler>();
    }

    [TearDown]
    public void TearDown()
    {
        Object.Destroy(_gameHandler.gameObject);
    }

    [UnityTest]
    public IEnumerator TestNull()
    {
        Player player = null;// = _gameHandler.GetPlayer();

        yield return new WaitForSeconds(1f);

        Assert.IsNull(player);
    }

    [UnityTest] //Unity specific test
    public IEnumerator PlayerMoveRight()
    {
        //create player
        Player player = _gameHandler.GetPlayer();

        //save position
        float initialXPos = player.transform.position.x;

        //make the player move right
        //player.MoveRight();
        player.PlayerMovement(1, 0);

        //wait for movement
        yield return new WaitForSeconds(1f);

        //test if the player has moved right
        Assert.Greater(player.transform.position.x, initialXPos);

        Object.Destroy(_gameHandler);
    }

    [UnityTest] //Unity specific test
    public IEnumerator PlayerMoveLeft()
    {
        //create player
        Player player = _gameHandler.GetPlayer();

        //save position
        float initialXPos = player.transform.position.x;

        //make the player move Left
        //player.MoveLeft();
        player.PlayerMovement(-1, 0);

        //wait for movement
        yield return new WaitForSeconds(1f);

        //test if the player has moved right
        Assert.Less(player.transform.position.x, initialXPos);

        Object.Destroy(_gameHandler);
    }

    [UnityTest] //Unity specific test
    public IEnumerator PlayerMoveDown()
    {
        //create player
        Player player = _gameHandler.GetPlayer();

        //save position
        float initialYPos = player.transform.position.y;

        //make the player move Left
        //player.MoveLeft();
        player.PlayerMovement(0, -1);

        //wait for movement
        yield return new WaitForSeconds(1f);

        //test if the player has moved right
        Assert.Less(player.transform.position.y, initialYPos);

        Object.Destroy(_gameHandler);
    } 
    
    [UnityTest] //Unity specific test
    public IEnumerator PlayerMoveUp()
    {
        //create player
        Player player = _gameHandler.GetPlayer();

        //save position
        float initialYPos = player.transform.position.y;

        //make the player move Left
        //player.MoveLeft();
        player.PlayerMovement(0, 1);

        //wait for movement
        yield return new WaitForSeconds(1f);

        //test if the player has moved right
        Assert.Greater(player.transform.position.y, initialYPos);

        Object.Destroy(_gameHandler);
    }
}
