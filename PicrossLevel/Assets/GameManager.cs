using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject tile;
	//-6,-9
	public int xInicial, yInicial;
	private int xTilesDesejadas, yTilesDesejadas;
	private int[,] tipoTile;
	private int xTipoTileIterator, yTipoTileIterator;
	private Color myPink, myPurple, myLightPink;

	void Start () {

		myPink = new Color(0.92f,0.12f,0.39f);
		myLightPink = new Color(0.94f,0.38f,0.57f);
		myPurple = new Color(0.40f,0.23f,0.72f);
		xTilesDesejadas = yTilesDesejadas = 15;
		xTipoTileIterator = yTipoTileIterator = 0;
		tipoTile = new int[15, 15] { 
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
		{ 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, 
		{ 0, 1, 1, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0 }, 
		{ 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, 
		{ 0, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, 
		{ 0, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, 
		{ 0, 0, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, 
		{ 0, 0, 0, 1, 1, 2, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 
		{ 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 }, 
		{ 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, 
		{ 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, 
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
		};

		StartCoroutine (InstanciaTiles ());
	}

	IEnumerator InstanciaTiles () {

		for (float y = yInicial + yTilesDesejadas; yInicial < y; y--) {

			for (float x = xInicial; x < xInicial + xTilesDesejadas; x++) {

				//refatorar, credo!!
				if (tipoTile[yTipoTileIterator, xTipoTileIterator] == 0) {
					tile.GetComponent<SpriteRenderer>(). color = myPurple;
					Instantiate (tile, new Vector3 (x / 2, y / 2, 2), Quaternion.identity);
				} else if (tipoTile[yTipoTileIterator, xTipoTileIterator] == 1) {
					tile.GetComponent<SpriteRenderer>(). color = myPink;
					Instantiate (tile, new Vector3 (x / 2, y / 2, 2), Quaternion.identity);
				} else {
					tile.GetComponent<SpriteRenderer>(). color = myLightPink;
					Instantiate (tile, new Vector3 (x / 2, y / 2, 2), Quaternion.identity);
				}

				yield return new WaitForSeconds (0.01f);

				if (xTipoTileIterator < 14) {
					xTipoTileIterator++;
				} else {
					xTipoTileIterator = 0;
				}
			}

			if (yTipoTileIterator < 14) {
				yTipoTileIterator++;
			} else {
				yTipoTileIterator = 0;
			}
		}
	}
}
