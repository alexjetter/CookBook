using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Ingredient", order = 1)]
public class Ingredient : ScriptableObject
{
	//public string Name;
	public Recipe Recipe;
	public Texture Icon;
	public Color UIColor = new Color(0.6f, 0.8f, 1, 1);
}
