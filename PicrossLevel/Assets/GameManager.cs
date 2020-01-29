using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject tile, tile2;
	//-6,-9
	public int xInicial, yInicial;
	private int xTilesDesejadas, yTilesDesejadas;
	private int[,] tipoTile;
	private int xTipoTileIterator, yTipoTileIterator;

	void Start(){

	xTilesDesejadas = yTilesDesejadas = 15;
	xTipoTileIterator = yTipoTileIterator = 0;
	tipoTile = new int[15, 15] {
	{ 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
	};

        StartCoroutine(InstanciaTiles());
    }

    IEnumerator InstanciaTiles(){	
		
		for (float y = yInicial + yTilesDesejadas; yInicial < y; y--){

			for (float x = xInicial; x < xInicial + xTilesDesejadas; x++){

				if (tipoTile[yTipoTileIterator , xTipoTileIterator] == 1){
    			Instantiate(tile, new Vector3(x/2, y/2, 0), Quaternion.identity);
				} else {
				Instantiate(tile2, new Vector3(x/2, y/2, 0), Quaternion.identity);
				}

				yield return new WaitForSeconds(0.01f);
				
					if(xTipoTileIterator < 14){
						xTipoTileIterator++;
					} else {
						xTipoTileIterator = 0;
					}
				}
				
				if(yTipoTileIterator < 14){
				yTipoTileIterator++;
			} else {
				yTipoTileIterator = 0;
			}
			}
		}
    }
