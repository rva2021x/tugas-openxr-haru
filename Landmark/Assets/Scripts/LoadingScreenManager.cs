using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreenManager : MonoBehaviour
{
	[Header("Loading Visuals")]
	public Image loadingIcon;
	public Image loadingDoneIcon;
	public Text loadingText;
	public Image progressBar;
	public Image fadeOverlay;

	[Header("Timing Settings")]
	public float waitingOnLoadEnd = 0.25f;
	public float fadeDuration = 0.25f;

	[Header("Loading Settings")]
	public LoadSceneMode loadSceneMode = LoadSceneMode.Single;
	public ThreadPriority loadThreadPriority;

	[Header("Other")]
	public AudioListener audioListener;
	AsyncOperation operation;
	Scene currentScene;

	public static int sceneToLoad = -1;
	static int loadingSceneIndex = 2;

	public static void LoadScene(int levelNum)
	{
		Application.backgroundLoadingPriority = ThreadPriority.High;
		sceneToLoad = levelNum;
		SceneManager.LoadScene(loadingSceneIndex);
	}

    private void Start()
    {
		if (sceneToLoad < 0) return;

		fadeOverlay.gameObject.SetActive(true);
		currentScene = SceneManager.GetActiveScene();
		StartCoroutine(LoadAsync(sceneToLoad));
    }

	private IEnumerator LoadAsync(int levelNum)
	{
		ShowLoadingVisuals();
		yield return null;

		FadeIn();
		StartOperation(levelNum);
		float lastProgress = 0f;

		while (DoneLoading() == false)
		{
			yield return null;

			if (Mathf.Approximately(operation.progress, lastProgress) == false)
			{
				progressBar.fillAmount = operation.progress;
				lastProgress = operation.progress;
			}
		}

		if (loadSceneMode == LoadSceneMode.Additive) audioListener.enabled = false;

		ShowCompletionVisuals();
		yield return new WaitForSeconds(waitingOnLoadEnd);
		FadeOut();
		yield return new WaitForSeconds(fadeDuration);

		if (loadSceneMode == LoadSceneMode.Additive)
		{
			SceneManager.UnloadSceneAsync(currentScene.name);
		}
		else
		{
			operation.allowSceneActivation = true;
		}
	}

	private void StartOperation(int levelNum)
	{
		Application.backgroundLoadingPriority = loadThreadPriority;
		operation = SceneManager.LoadSceneAsync(levelNum, loadSceneMode);

		if (loadSceneMode == LoadSceneMode.Single) operation.allowSceneActivation = false;
	}

	private bool DoneLoading()
	{
		return (loadSceneMode == LoadSceneMode.Additive && operation.isDone) || (loadSceneMode == LoadSceneMode.Single && operation.progress >= 0.9f);
	}

	private void FadeIn()
	{
		fadeOverlay.CrossFadeAlpha(0, fadeDuration, true);
	}

	private void FadeOut()
	{
		fadeOverlay.CrossFadeAlpha(1, fadeDuration, true);
	}

	private void ShowLoadingVisuals()
	{
		loadingIcon.gameObject.SetActive(true);
		loadingDoneIcon.gameObject.SetActive(false);
		progressBar.fillAmount = 0f;
		loadingText.text = "LOADING...";
	}

	private void ShowCompletionVisuals()
	{
		loadingIcon.gameObject.SetActive(false);
		loadingDoneIcon.gameObject.SetActive(true);
		progressBar.fillAmount = 1f;
		loadingText.text = "LOADING DONE";
	}
}
