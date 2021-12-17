using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCalc : MonoBehaviour {

	//public int a = 36;
	public GameObject ImageTarget1;
	public GameObject ImageTarget2;
	public GameObject ImageTarget3;
	public GameObject ImageTarget4;
	public GameObject ImageTarget5;
	public GameObject ImageTarget6;
	public GameObject ImageTarget7;
	public GameObject ImageTarget8;
	public GameObject ImageTarget9;
	public GameObject ImageTarget10;

	public Canvas Result;
	public GameObject WrongResult;

    private void Start()
    {
        
    }

    private void Update()
    {
		// 1
		float distance1 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget2.transform.position);
		float distance2 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget3.transform.position);
		float distance3 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget4.transform.position);
		float distance4 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget5.transform.position);
		float distance5 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget6.transform.position);
		float distance6 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget7.transform.position);
		float distance7 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget8.transform.position);
		float distance8 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget9.transform.position);
		float distance9 = Vector3.Distance(ImageTarget1.transform.position, ImageTarget10.transform.position);

		// 2
		float distance10 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget3.transform.position);
		float distance11 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget4.transform.position);
		float distance12 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget5.transform.position);
		float distance13 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget6.transform.position);
		float distance14 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget7.transform.position);
		float distance15 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget8.transform.position);
		float distance16 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget9.transform.position);
		float distance17 = Vector3.Distance(ImageTarget2.transform.position, ImageTarget10.transform.position);

		// 3
		float distance18 = Vector3.Distance(ImageTarget3.transform.position, ImageTarget4.transform.position);
		float distance19 = Vector3.Distance(ImageTarget3.transform.position, ImageTarget5.transform.position);
		float distance20 = Vector3.Distance(ImageTarget3.transform.position, ImageTarget6.transform.position);
		float distance21 = Vector3.Distance(ImageTarget3.transform.position, ImageTarget7.transform.position);
		float distance22 = Vector3.Distance(ImageTarget3.transform.position, ImageTarget8.transform.position);
		float distance23 = Vector3.Distance(ImageTarget3.transform.position, ImageTarget9.transform.position);
		float distance24 = Vector3.Distance(ImageTarget3.transform.position, ImageTarget10.transform.position);

		// 4
		float distance25 = Vector3.Distance(ImageTarget4.transform.position, ImageTarget5.transform.position);
		float distance26 = Vector3.Distance(ImageTarget4.transform.position, ImageTarget6.transform.position);
		float distance27 = Vector3.Distance(ImageTarget4.transform.position, ImageTarget7.transform.position);
		float distance28 = Vector3.Distance(ImageTarget4.transform.position, ImageTarget8.transform.position);
		float distance29 = Vector3.Distance(ImageTarget4.transform.position, ImageTarget9.transform.position);
		float distance30 = Vector3.Distance(ImageTarget4.transform.position, ImageTarget10.transform.position);

		// 5
		float distance31 = Vector3.Distance(ImageTarget5.transform.position, ImageTarget6.transform.position);
		float distance32 = Vector3.Distance(ImageTarget5.transform.position, ImageTarget7.transform.position);
		float distance33 = Vector3.Distance(ImageTarget5.transform.position, ImageTarget8.transform.position);
		float distance34 = Vector3.Distance(ImageTarget5.transform.position, ImageTarget9.transform.position);
		float distance35 = Vector3.Distance(ImageTarget5.transform.position, ImageTarget10.transform.position);

		// 6
		float distance36 = Vector3.Distance(ImageTarget6.transform.position, ImageTarget7.transform.position);
		float distance37 = Vector3.Distance(ImageTarget6.transform.position, ImageTarget8.transform.position);
		float distance38 = Vector3.Distance(ImageTarget6.transform.position, ImageTarget9.transform.position);
		float distance39 = Vector3.Distance(ImageTarget6.transform.position, ImageTarget10.transform.position);

		// 7
		float distance40 = Vector3.Distance(ImageTarget7.transform.position, ImageTarget8.transform.position);
		float distance41 = Vector3.Distance(ImageTarget7.transform.position, ImageTarget9.transform.position);
		float distance42 = Vector3.Distance(ImageTarget7.transform.position, ImageTarget10.transform.position);

		// 8
		float distance43 = Vector3.Distance(ImageTarget8.transform.position, ImageTarget9.transform.position);
		float distance44 = Vector3.Distance(ImageTarget8.transform.position, ImageTarget10.transform.position);

		// 9
		float distance45 = Vector3.Distance(ImageTarget9.transform.position, ImageTarget10.transform.position);

		if(10.0 < distance1 && distance1 < 40.0)
        {
			//Result.enabled = true;
			StartCoroutine(waktu());
			Debug.Log(distance1);
        }
		else if (10.0 < distance2 && distance2 < 40.0)
		{
			WrongResult.SetActive(true);
			Debug.Log("Distance 2: " + distance2);
		}
		else if (10.0 < distance3 && distance3 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance4 && distance4 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance5 && distance5 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance6 && distance6 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance7 && distance7 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance8 && distance8 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if(10.0 < distance9 && distance9 < 40.0)
        {
			WrongResult.SetActive(true);
			//WrongResult.SetActive(true);
			//Debug.Log(distance9);
		}
		else if (10.0 < distance10 && distance10 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance11 && distance11 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance12 && distance12 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance13 && distance13 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance14 && distance14 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance15 && distance15 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance16 && distance16 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance17 && distance17 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance18 && distance18 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance19 && distance19 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance20 && distance20 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance21 && distance21 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance22 && distance22 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance23 && distance23 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance24 && distance24 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance25 && distance25 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance26 && distance26 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance27 && distance27 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance28 && distance28 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance29 && distance29 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance30 && distance30 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance31 && distance31 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance32 && distance32 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance33 && distance33 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance34 && distance34 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance35 && distance35 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance36 && distance36 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance37 && distance37 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance38 && distance38 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance39 && distance39 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance40 && distance40 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance41 && distance41 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance42 && distance42 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance43 && distance43 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance44 && distance44 < 40.0)
		{
			WrongResult.SetActive(true);
		}
		else if (10.0 < distance45 && distance45 < 40.0)
		{
			WrongResult.SetActive(true);
		}
	}

	IEnumerator waktu()
	{
		yield return new WaitForSeconds(2);
		Result.enabled = true;
	}
}
